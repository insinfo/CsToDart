using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CsToDartTranspiler;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace KineApps.Common.Diagnostics;

public static class Log
{
	private const string m_A = "log.txt";

	private static volatile Stream m_A;

	[CompilerGenerated]
	private static ILogListener m_A;

	private const int m_A = 256;

	public static ILogListener LogListener
	{
		[CompilerGenerated]
		get
		{
			return Log.m_A;
		}
		[CompilerGenerated]
		set
		{
			Log.m_A = value;
		}
	}

	public static void StartFileLogging(string filePath)
	{
		try
		{
			File.Delete(filePath);
			Log.m_A = File.OpenWrite(filePath);
		}
		catch (Exception)
		{
		}
	}

	public static void StopFileLogging()
	{
		try
		{
			Log.m_A?.Flush();
			Log.m_A?.Dispose();
			Log.m_A = null;
		}
		catch (Exception)
		{
		}
	}

	public static void Message(LogLevel logLevel, string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		A(logLevel, "   ", message, memberName, filePath, lineNumber);
	}

	public static void Message(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		A(LogLevel.Debug, "   ", message, memberName, filePath, lineNumber);
	}

	public static void MessageIf(bool condition, string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		if (condition)
		{
			A(LogLevel.Debug, "   ", message, memberName, filePath, lineNumber);
		}
	}

	public static void Error(LogLevel logLevel, string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		A(logLevel, "[E]", message, memberName, filePath, lineNumber);
	}

	public static void Error(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		A(LogLevel.Debug, "[E]", message, memberName, filePath, lineNumber);
	}

	public static void ErrorIf(bool condition, string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		if (condition)
		{
			A(LogLevel.Debug, "[E]", message, memberName, filePath, lineNumber);
		}
	}

	public static void Warning(LogLevel logLevel, string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		A(logLevel, "[W]", message, memberName, filePath, lineNumber);
	}

	public static void Warning(string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		A(LogLevel.Debug, "[W]", message, memberName, filePath, lineNumber);
	}

	public static void WarningIf(bool condition, string message, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		if (condition)
		{
			A(LogLevel.Debug, "[W]", message, memberName, filePath, lineNumber);
		}
	}

	public static void Exception(Exception exception, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		Exception(LogLevel.Debug, exception, memberName, filePath, lineNumber);
	}

	public static void Exception(LogLevel logLevel, Exception exception, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		A(LogLevel.Normal, "[X]", exception.ToString(), memberName, filePath, lineNumber);
		while (exception.InnerException != null)
		{
			A(LogLevel.Normal, "[X]", exception.InnerException.ToString(), memberName, filePath, lineNumber);
			exception = exception.InnerException;
		}
	}

	private static void A(LogLevel P_0, string P_1, string P_2, string P_3, string P_4, int P_5)
	{
		string text = Environment.CurrentManagedThreadId.ToString();
		string text2 = P_4.Substring(P_4.LastIndexOf('\\') + 1);
		string text3 = text2.Substring(0, text2.IndexOf('.'));
		string text4 = string.Format("[{0}] {1} {2} {3}.{4} ({5}) \t\t\t\t\t {6}", text, DateTime.Now.ToString("HH:mm:ss.fff"), P_1, text3, P_3, P_5, P_2);
		if (P_0 == LogLevel.Debug)
		{
			return;
		}
		text4 = string.Format("{0} {1} {2}", DateTime.Now.ToString("HH:mm:ss.fff"), P_1, P_2);
		LogListener?.Log(P_0, text4);
		if (Log.m_A == null)
		{
			return;
		}
		try
		{
			Log.m_A.Seek(0L, SeekOrigin.End);
			byte[] bytes = Encoding.UTF8.GetBytes(text4);
			Log.m_A.Write(bytes, 0, bytes.Length);
			bytes = new byte[2] { 13, 10 };
			Log.m_A.Write(bytes, 0, bytes.Length);
			Log.m_A.Flush();
		}
		catch
		{
		}
	}

	public static void Node(CSharpSyntaxNode node, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		string text = node.ToString();
		if (node is NamespaceDeclarationSyntax)
		{
			text = A(text);
		}
		else if (text.Length > 256)
		{
			text = text.Substring(0, 256) + "\r\n.\r\n.\r\n.\r\n";
		}
		Message("C#: " + text, memberName, filePath, lineNumber);
	}

	private static string A(string P_0)
	{
		int num = P_0.IndexOf("\r");
		if (num > 0)
		{
			return P_0.Substring(0, num - 1);
		}
		return P_0;
	}

	public static void LogSeparatorLine()
	{
		Message("\r\n--------------------------------------------------------------------------------------------------------------------------------", "LogSeparatorLine", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\LogExtensions.cs", 42);
	}
}
