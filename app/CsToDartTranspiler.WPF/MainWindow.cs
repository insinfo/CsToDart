using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using KineApps.Controls;

namespace CsToDartTranspiler.WPF;

public partial class MainWindow : Window, IComponentConnector
{
	private TranspilerViewModel _transpilerViewModel = new TranspilerViewModel();

	private TranspilerViewModel TranspilerViewModel => _transpilerViewModel;

	private string AppTitle => "C# to Dart Transpiler" + (LicenseInfoProvider.IsPro ? " Pro" : string.Empty);

	public MainWindow()
	{
		InitializeComponent();
		CsFileContent.CurrentHighlighter = HighlighterManager.Instance.Highlighters["Cs"];
		DartFileContent.CurrentHighlighter = HighlighterManager.Instance.Highlighters["Dart"];
		base.DataContext = TranspilerViewModel;
		TranspilerViewModel.PropertyChanged += TranspilerViewModel_PropertyChanged;
		TranspilerViewModel.LogMessages.CollectionChanged += LogMessages_CollectionChanged;
		System.Windows.DataObject.AddCopyingHandler(CsFileContent, CancelCopyCommand);
		System.Windows.DataObject.AddCopyingHandler(DartFileContent, CancelCopyCommand);
		base.Loaded += MainWindow_Loaded;
	}

	private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
	{
		UpdateMenu();
		if (!LicenseInfoProvider.IsPro)
		{
			await LicenseInfoProvider.GetLicenseInfoAsync(new WindowInteropHelper(this).EnsureHandle());
		}
		if (!LicenseInfoProvider.IsPro)
		{
			CsFileContent.ContextMenu = null;
			DartFileContent.ContextMenu = null;
		}
		UpdateUiTrialStatus();
	}

	private async void FileOpenMenuItem_Click(object sender, RoutedEventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Filter = "Project Files (*.sln;*.csproj)|*.sln;*.csproj";
		switch (openFileDialog.ShowDialog())
		{
		case System.Windows.Forms.DialogResult.OK:
		{
			string fileName = openFileDialog.FileName;
			await LoadSolutionAsync(fileName);
			break;
		}
		}
	}

	private void FileCloseMenuItem_Click(object sender, RoutedEventArgs e)
	{
		_transpilerViewModel.Reset(resetLog: true);
		SolutionExplorerTreeView.Items.Clear();
	}

	private void FileExitMenuItem_Click(object sender, RoutedEventArgs e)
	{
		System.Windows.Application.Current.Shutdown();
	}

	private async void TargetFrameworkMenuItem_Click(object sender, RoutedEventArgs e)
	{
		foreach (MenuItem item in (IEnumerable)TranspileTargetFramework.Items)
		{
			item.IsChecked = false;
		}
		MenuItem obj = sender as MenuItem;
		obj.IsChecked = true;
		string text = obj.Header as string;
		if (text.ToLowerInvariant() == "default")
		{
			text = null;
		}
		if (text != _transpilerViewModel.TargetFramework)
		{
			_transpilerViewModel.TargetFramework = text;
			await LoadSolutionAsync(_transpilerViewModel.SolutionFilePath);
		}
	}

	private async void TranspileMenuItem_Click(object sender, RoutedEventArgs e)
	{
		StatusTextBlock.Text = "Transpiling....";
		await _transpilerViewModel.TranspilerAsync(null);
	}

	private async void PurchaseMenuItem_Click(object sender, RoutedEventArgs e)
	{
		await LicenseInfoProvider.PurchaseAsync(this);
		UpdateUiTrialStatus();
	}

	private void ReportIssueMenuItem_Click(object sender, RoutedEventArgs e)
	{
	}

	private void RateAndReviewMenuItem_Click(object sender, RoutedEventArgs e)
	{
		Process.Start(new ProcessStartInfo
		{
			FileName = string.Format("ms-windows-store:REVIEW?ProductId={0}", "9P5BNFRSMQ00"),
			UseShellExecute = true
		});
	}

	private void HelpPrivacyPolicyMenuItem_Click(object sender, RoutedEventArgs e)
	{
		Process.Start(new ProcessStartInfo
		{
			FileName = "https://www.iubenda.com/privacy-policy/34668582",
			UseShellExecute = true
		});
	}

	private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
	{
		string text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
		System.Windows.MessageBox.Show(this, "Version " + text + "\r\n\r\n(C) KINEAPPS 2018-2023\r\n\r\ninfo@kineapps.com", "C# to Dart Transpiler", MessageBoxButton.OK, MessageBoxImage.Asterisk);
	}

	private void UpdateMenu()
	{
		FileOpen.IsEnabled = !_transpilerViewModel.IsBusy;
		FileClose.IsEnabled = _transpilerViewModel.HasSolution && !_transpilerViewModel.IsBusy;
		TranspileTargetFramework.IsEnabled = _transpilerViewModel.HasSolution && !_transpilerViewModel.IsBusy;
		TranspileTranspile.IsEnabled = _transpilerViewModel.HasSolution && !_transpilerViewModel.IsBusy;
	}

	private void UpdateTargetFrameworksMenuItem()
	{
		TranspileTargetFramework.Items.Clear();
		if (_transpilerViewModel.ShouldAllowSettingTargetFramework)
		{
			MenuItem menuItem = new MenuItem
			{
				Header = "Default",
				IsCheckable = true,
				IsChecked = (_transpilerViewModel.TargetFramework == null)
			};
			menuItem.Click += TargetFrameworkMenuItem_Click;
			TranspileTargetFramework.Items.Add(menuItem);
			foreach (string targetFramework in _transpilerViewModel.TargetFrameworks)
			{
				MenuItem menuItem2 = new MenuItem
				{
					IsCheckable = true,
					Header = targetFramework,
					IsChecked = (_transpilerViewModel.TargetFramework == targetFramework)
				};
				menuItem2.Click += TargetFrameworkMenuItem_Click;
				TranspileTargetFramework.Items.Add(menuItem2);
			}
		}
		TranspileTargetFramework.Visibility = ((!_transpilerViewModel.ShouldAllowSettingTargetFramework || _transpilerViewModel.TargetFrameworks.Count <= 0) ? Visibility.Collapsed : Visibility.Visible);
	}

	private async Task LoadSolutionAsync(string filePath)
	{
		StatusTextBlock.Text = "Loading....";
		SolutionExplorerTreeView.Items.Clear();
		await _transpilerViewModel.OpenSolutionAsync(filePath);
		UpdateTargetFrameworksMenuItem();
		if (_transpilerViewModel.ProjectData == null)
		{
			return;
		}
		foreach (ProjectData projectDatum in _transpilerViewModel.ProjectData)
		{
			TreeViewItem treeViewItem = new TreeViewItem
			{
				Header = projectDatum.Name,
				Tag = projectDatum,
				ToolTip = projectDatum.FilePath
			};
			SolutionExplorerTreeView.Items.Add(treeViewItem);
			Dictionary<string, TreeViewItem> dictionary = new Dictionary<string, TreeViewItem>();
			foreach (DocumentData document in projectDatum.Documents)
			{
				TreeViewItem treeViewItem2 = treeViewItem;
				if (document.Folders != null)
				{
					List<string> list = new List<string>();
					foreach (string folder in document.Folders)
					{
						list.Add(folder);
						string key = string.Join("/", list);
						if (dictionary.ContainsKey(key))
						{
							treeViewItem2 = dictionary[key];
							continue;
						}
						TreeViewItem treeViewItem3 = new TreeViewItem
						{
							Header = folder
						};
						treeViewItem2.Items.Add(treeViewItem3);
						treeViewItem2 = (dictionary[key] = treeViewItem3);
					}
				}
				TreeViewItem newItem = new TreeViewItem
				{
					Header = document.Name,
					Tag = document,
					ToolTip = document.FilePath
				};
				treeViewItem2.Items.Add(newItem);
			}
		}
	}

	private async void SolutionExplorerTreeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
	{
		object obj = (e.NewValue as TreeViewItem)?.Tag;
		if (obj is DocumentData documentData)
		{
			string text = await _transpilerViewModel.GetDocumentTextAync(documentData.DocumentId);
			CsFileContent.Text = text ?? string.Empty;
			string dartSourceCode = _transpilerViewModel.GetDartSourceCode(documentData.DocumentId);
			DartFileContent.Text = dartSourceCode ?? string.Empty;
		}
		else
		{
			CsFileContent.Text = string.Empty;
			DartFileContent.Text = string.Empty;
		}
		CsFileContent.ScrollToHome();
		DartFileContent.ScrollToHome();
	}

	private void TranspilerViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
	{
		if (e.PropertyName == "IsBusy")
		{
			if (_transpilerViewModel.IsBusy)
			{
				ProgressBar.Visibility = Visibility.Visible;
			}
			else
			{
				ProgressBar.Visibility = Visibility.Collapsed;
				StatusTextBlock.Text = "Ready";
			}
			UpdateMenu();
		}
		else if (e.PropertyName == "Progress")
		{
			ProgressBar.Value = _transpilerViewModel.Progress;
		}
		else
		{
			UpdateWindowTitle();
			UpdateMenu();
		}
	}

	private void UpdateUiTrialStatus()
	{
		bool isPro = LicenseInfoProvider.IsPro;
		UpdateWindowTitle();
		HelpPurchase.Visibility = (isPro ? Visibility.Collapsed : Visibility.Visible);
	}

	private void UpdateWindowTitle()
	{
		if (_transpilerViewModel.HasSolution)
		{
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(_transpilerViewModel.SolutionFilePath);
			base.Title = fileNameWithoutExtension + " - " + AppTitle;
		}
		else
		{
			base.Title = AppTitle;
		}
	}

	private void LogMessages_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
	{
		if (VisualTreeHelper.GetChildrenCount(LogOutput) > 0)
		{
			((ScrollViewer)VisualTreeHelper.GetChild((Border)VisualTreeHelper.GetChild(LogOutput, 0), 0)).ScrollToBottom();
		}
	}

	private void CancelCopyCommand(object sender, DataObjectEventArgs e)
	{
		if (!LicenseInfoProvider.IsPro)
		{
			e.CancelCommand();
		}
	}
}
