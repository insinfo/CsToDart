using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using CsToDartTranspiler;
using KineApps.Common.Diagnostics;

namespace A;

[CompilerGenerated]
[a]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
internal sealed class B : Attribute
{
	public readonly byte[] A;

	public B(byte P_0)
	{
		A = new byte[1] { P_0 };
	}

	public B(byte[] P_0)
	{
		A = P_0;
	}
}
internal class b
{
	private readonly DartPackageInfoProvider m_A;

	public b(string P_0, string P_1, string P_2)
	{
		this.m_A = new DartPackageInfoProvider(P_0, P_1, P_2);
	}

	[SpecialName]
	public DartPackageInfoProvider A()
	{
		return this.m_A;
	}

	public void A(string P_0, string P_1)
	{
		string dartSourceFilePath = this.m_A.GetDartSourceFilePath(P_0);
		Directory.CreateDirectory(Path.GetDirectoryName(dartSourceFilePath));
		Log.Message(LogLevel.Normal, "Writing " + dartSourceFilePath, "WriteDartSourceFile", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartFileWriter.cs", 26);
		File.WriteAllText(dartSourceFilePath, P_1);
	}

	public string a(string P_0, string P_1)
	{
		string arbFilePath = this.m_A.GetArbFilePath(P_0);
		Directory.CreateDirectory(Path.GetDirectoryName(arbFilePath));
		Log.Message(LogLevel.Normal, "Writing " + arbFilePath, "WriteArbFile", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartFileWriter.cs", 35);
		File.WriteAllText(arbFilePath, P_1);
		return arbFilePath;
	}

	public string B(string P_0, string P_1)
	{
		string text = Path.Combine(this.m_A.GetDartProjectFolderPath(), P_0);
		Directory.CreateDirectory(Path.GetDirectoryName(text));
		Log.Message(LogLevel.Normal, "Writing " + text, "WriteTextFile", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartFileWriter.cs", 55);
		File.WriteAllText(text, P_1);
		return text;
	}

	public void a()
	{
		string text = "  ";
		string text2 = text + text;
		string pubspecFilePath = this.m_A.GetPubspecFilePath();
		string dartLibraryName = this.m_A.GetDartLibraryName();
		Log.Message(LogLevel.Normal, "Writing pubspec.yaml: " + pubspecFilePath, "WritePubspecFile", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartFileWriter.cs", 70);
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = stringBuilder;
		StringBuilder stringBuilder3 = stringBuilder2;
		StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(6, 1, stringBuilder2);
		handler.AppendLiteral("name: ");
		handler.AppendFormatted(dartLibraryName);
		stringBuilder3.AppendLine(ref handler);
		stringBuilder.AppendLine("description:");
		stringBuilder.AppendLine("version: 0.0.1");
		stringBuilder.AppendLine("author:");
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("dependencies:");
		foreach (string dependency in this.m_A.Dependencies)
		{
			stringBuilder.Append(text + dependency + ":");
			switch (dependency)
			{
			case "flutter":
			case "flutter_localizations":
				stringBuilder.AppendLine();
				stringBuilder.AppendLine(text2 + "sdk: flutter");
				stringBuilder.AppendLine();
				break;
			case "intl_translation":
				stringBuilder.AppendLine(" ^0.17.0");
				stringBuilder.AppendLine();
				break;
			}
		}
		foreach (KeyValuePair<string, string> pathDependency in this.m_A.PathDependencies)
		{
			stringBuilder.AppendLine(text + pathDependency.Key + ":");
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(6, 2, stringBuilder2);
			handler.AppendFormatted(text2);
			handler.AppendLiteral("path: ");
			handler.AppendFormatted(pathDependency.Value);
			stringBuilder4.AppendLine(ref handler);
			stringBuilder.AppendLine();
		}
		File.WriteAllText(pubspecFilePath, stringBuilder.ToString());
	}

	public void A(ISet<string> P_0, ISet<string> P_1)
	{
		string mainLibraryFilePath = this.m_A.GetMainLibraryFilePath();
		string dartLibraryName = this.m_A.GetDartLibraryName();
		string dartProjectLibFolderPath = this.m_A.GetDartProjectLibFolderPath();
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = stringBuilder;
		StringBuilder stringBuilder3 = stringBuilder2;
		StringBuilder.AppendInterpolatedStringHandler handler = new StringBuilder.AppendInterpolatedStringHandler(9, 1, stringBuilder2);
		handler.AppendLiteral("library ");
		handler.AppendFormatted(dartLibraryName);
		handler.AppendLiteral(";");
		stringBuilder3.AppendLine(ref handler);
		stringBuilder.AppendLine();
		foreach (string item in P_0)
		{
			string dartSourceFilePath = this.m_A.GetDartSourceFilePath(item);
			string value = Util.GetRelativePath(dartProjectLibFolderPath, null, null, dartSourceFilePath).Replace('\\', '/');
			stringBuilder2 = stringBuilder;
			StringBuilder stringBuilder4 = stringBuilder2;
			handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
			handler.AppendLiteral("export '");
			handler.AppendFormatted(value);
			handler.AppendLiteral("';");
			stringBuilder4.AppendLine(ref handler);
		}
		if (P_1 != null)
		{
			foreach (string item2 in P_1)
			{
				stringBuilder2 = stringBuilder;
				StringBuilder stringBuilder5 = stringBuilder2;
				handler = new StringBuilder.AppendInterpolatedStringHandler(10, 1, stringBuilder2);
				handler.AppendLiteral("export '");
				handler.AppendFormatted(item2);
				handler.AppendLiteral("';");
				stringBuilder5.AppendLine(ref handler);
			}
		}
		Log.Message(LogLevel.Normal, "Writing main library file:" + mainLibraryFilePath, "WriteMainLibraryFile", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartFileWriter.cs", 134);
		File.WriteAllText(mainLibraryFilePath, stringBuilder.ToString());
	}

	public static void A(string P_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
		foreach (string text in manifestResourceNames)
		{
			string path = b(P_0, text);
			string path2 = a(text);
			string path3 = Path.Combine(path, path2);
			using Stream stream = executingAssembly.GetManifestResourceStream(text);
			using StreamReader streamReader = new StreamReader(stream);
			string contents = streamReader.ReadToEnd();
			File.WriteAllText(path3, contents);
		}
	}

	private static string b(string P_0, string P_1)
	{
		P_1 = P_1.Replace("CsToDartTranspiler.Dart.", string.Empty);
		int num = P_1.LastIndexOf(".");
		num--;
		while (P_1[num] != '.' && num > 0)
		{
			num--;
		}
		if (num == 0)
		{
			return P_0;
		}
		string path = P_1.Substring(0, num).Replace('.', '\\');
		string text = Path.Combine(P_0, path);
		Directory.CreateDirectory(text);
		return text;
	}

	private static string a(string P_0)
	{
		int num = P_0.LastIndexOf(".");
		num = P_0.LastIndexOf(".", num - 1) + 1;
		return P_0.Substring(num);
	}
}
