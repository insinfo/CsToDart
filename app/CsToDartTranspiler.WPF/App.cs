using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace CsToDartTranspiler.WPF;

public class App : Application
{
	public const string ApplicationName = "C# to Dart Transpiler";

	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "7.0.2.0")]
	public void InitializeComponent()
	{
		base.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
	}

	[STAThread]
	[DebuggerNonUserCode]
	[GeneratedCode("PresentationBuildTasks", "7.0.2.0")]
	public static void Main()
	{
		App app = new App();
		app.InitializeComponent();
		app.Run();
	}
}
