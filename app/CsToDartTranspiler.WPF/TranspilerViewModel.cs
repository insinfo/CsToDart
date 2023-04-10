using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using KineApps.Common.Diagnostics;
using Microsoft.CodeAnalysis;

namespace CsToDartTranspiler.WPF;

internal class TranspilerViewModel : ILogListener, INotifyPropertyChanged, IProgress<int>
{
	private readonly DartTranspiler _transpiler;

	private bool _hasSolution;

	private string _solutionFilePath;

	private int _progress;

	private bool _isBusy;

	public bool HasSolution
	{
		get
		{
			return _hasSolution;
		}
		private set
		{
			if (value != _hasSolution)
			{
				_hasSolution = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HasSolution"));
			}
		}
	}

	public string SolutionFilePath
	{
		get
		{
			return _solutionFilePath;
		}
		private set
		{
			if (value != _solutionFilePath)
			{
				_solutionFilePath = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SolutionFilePath"));
			}
		}
	}

	public int Progress
	{
		get
		{
			return _progress;
		}
		set
		{
			if (value != _progress)
			{
				_progress = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Progress"));
			}
		}
	}

	public bool IsBusy
	{
		get
		{
			return _isBusy;
		}
		set
		{
			if (value != _isBusy)
			{
				_isBusy = value;
				this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("IsBusy"));
			}
		}
	}

	public IList<ProjectData> ProjectData { get; private set; }

	public bool ShouldAllowSettingTargetFramework { get; private set; }

	public ISet<string> TargetFrameworks { get; private set; }

	public string TargetFramework { get; set; }

	public ObservableCollection<string> LogMessages { get; } = new ObservableCollection<string>();


	public event PropertyChangedEventHandler PropertyChanged;

	public TranspilerViewModel()
	{
		_transpiler = new DartTranspiler(this);
	}

	public void Reset(bool resetLog)
	{
		ProjectData?.Clear();
		HasSolution = false;
		SolutionFilePath = null;
		if (resetLog)
		{
			LogMessages.Clear();
		}
	}

	public async Task OpenSolutionAsync(string solutionFilePath)
	{
		IsBusy = true;
		try
		{
			LogMessages.Clear();
			IList<ProjectData> projectData = null;
			await Task.Run(async delegate
			{
				await _transpiler.OpenSolutionAsync(solutionFilePath, TargetFramework);
				projectData = _transpiler.GetProjectData(this);
			});
			ProjectData = projectData;
			HasSolution = true;
			SolutionFilePath = solutionFilePath;
			ShouldAllowSettingTargetFramework = _transpiler.ShouldAllowSettingTargetFramework;
			TargetFrameworks = _transpiler.TargetFrameworks;
		}
		catch (Exception ex)
		{
			LogMessages.Add(ex.ToString());
			MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
			Reset(resetLog: false);
		}
		finally
		{
			IsBusy = false;
		}
	}

	public async Task TranspilerAsync(string outputFolder)
	{
		IsBusy = true;
		try
		{
			if (string.IsNullOrEmpty(outputFolder))
			{
				string directoryName = Path.GetDirectoryName(SolutionFilePath);
				outputFolder = Path.Combine(directoryName, "_CsToDartTranspiler_");
			}
			await Task.Run(async delegate
			{
				await _transpiler.TranspileAsync(outputFolder, this, LicenseInfoProvider.IsPro);
			});
		}
		catch (Exception ex)
		{
			LogMessages.Add(ex.ToString());
			MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Hand);
		}
		finally
		{
			IsBusy = false;
		}
	}

	public async Task<string> GetDocumentTextAync(DocumentId documentId)
	{
		try
		{
			return await _transpiler.GetDocumentTextAsync(documentId);
		}
		catch (Exception ex)
		{
			LogMessages.Add(ex.ToString());
			return "<" + ex.ToString() + ">";
		}
	}

	public string GetDartSourceCode(DocumentId documentId)
	{
		try
		{
			return _transpiler.GetDartSourceCode(documentId);
		}
		catch (Exception ex)
		{
			LogMessages.Add(ex.ToString());
			return "<" + ex.ToString() + ">";
		}
	}

	public void Log(LogLevel level, string message)
	{
		RunInUiThread(delegate
		{
			LogMessages.Add(message);
		});
	}

	public void Report(int value)
	{
		if (value != Progress)
		{
			RunInUiThread(delegate
			{
				Progress = value;
			});
		}
	}

	private static void RunInUiThread(Action action)
	{
		Application.Current?.Dispatcher.Invoke(action);
	}
}
