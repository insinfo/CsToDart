using KineApps.Common.Diagnostics;

namespace CsToDartTranspiler;

public interface ILogListener
{
	void Log(LogLevel level, string message);
}
