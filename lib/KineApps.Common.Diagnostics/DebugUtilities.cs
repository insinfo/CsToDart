using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace KineApps.Common.Diagnostics;

public static class DebugUtilities
{
	[Conditional("DEBUG")]
	public static void Assert(bool condition, string message = null, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		if (!condition)
		{
			Log.Error((message == null) ? "Fatal error" : message, memberName, filePath, lineNumber);
			if (Debugger.IsAttached)
			{
				Debugger.Break();
			}
		}
	}

	[Conditional("DEBUG")]
	public static void Fail(string message = null, [CallerMemberName] string memberName = "", [CallerFilePath] string filePath = "", [CallerLineNumber] int lineNumber = 0)
	{
		Log.Error((message == null) ? "Fatal error" : message, memberName, filePath, lineNumber);
		if (Debugger.IsAttached)
		{
			Debugger.Break();
		}
	}
}
