using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using CsToDartTranspiler;
using KineApps.Common.Diagnostics;
using Microsoft.Build.Locator;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;
using Microsoft.CodeAnalysis.Text;

namespace A;

internal class C
{
	private class A
	{
		[CompilerGenerated]
		private string m_A;

		[CompilerGenerated]
		private ISet<string> m_A;

		[CompilerGenerated]
		private string m_a;

		[SpecialName]
		[CompilerGenerated]
		public string A()
		{
			return this.m_A;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(string P_0)
		{
			this.m_A = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public ISet<string> a()
		{
			return this.m_A;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(ISet<string> P_0)
		{
			this.m_A = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public string B()
		{
			return this.m_a;
		}

		[SpecialName]
		[CompilerGenerated]
		public void a(string P_0)
		{
			this.m_a = P_0;
		}
	}

	private readonly Project m_A;

	public C(Project P_0)
	{
		this.m_A = P_0;
	}

	public ProjectData A(bool P_0)
	{
		A a2 = A();
		ProjectData projectData = new ProjectData
		{
			ProjectId = this.m_A.Id,
			Name = this.m_A.Name,
			FilePath = this.m_A.FilePath,
			TargetFramework = a2.A(),
			TargetFrameworks = a2.a(),
			PackageTargetFallback = a2.B()
		};
		if (P_0)
		{
			string value = Util.NormalizePath(Path.GetDirectoryName(this.m_A.FilePath));
			{
				foreach (Document document in this.m_A.Documents)
				{
					if (!c.A(document.Name))
					{
						DocumentData item = new DocumentData
						{
							DocumentId = document.Id,
							Name = document.Name,
							FilePath = document.FilePath,
							Folders = document.Folders
						};
						if (!Util.NormalizePath(Path.GetDirectoryName(document.FilePath)).StartsWith(value, StringComparison.InvariantCultureIgnoreCase))
						{
							Log.Warning($"File '{document.FilePath}' is not under the project folder '{value}'.", "GetProjectData", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\ProjectInfoProvider.cs", 58);
						}
						projectData.Documents.Add(item);
					}
				}
				return projectData;
			}
		}
		return projectData;
	}

	private A A()
	{
		A a2 = new A();
		try
		{
			using XmlReader reader = XmlReader.Create(this.m_A.FilePath);
			XDocument xDocument = XDocument.Load(reader);
			a2.A(xDocument.Descendants("TargetFramework").FirstOrDefault()?.Value);
			foreach (XElement item in xDocument.Descendants("TargetFrameworks"))
			{
				if (!item.Value.StartsWith("$", StringComparison.InvariantCulture))
				{
					string value = item.Value;
					if (!string.IsNullOrWhiteSpace(value))
					{
						string[] collection = value.Split(new char[1] { ';' }, StringSplitOptions.RemoveEmptyEntries);
						a2.A(new HashSet<string>(collection));
					}
				}
			}
			a2.a(xDocument.Descendants("PackageTargetFallback").FirstOrDefault()?.Value);
			return a2;
		}
		catch (Exception exception)
		{
			Log.Exception(exception, "ParseCsprojData", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\ProjectInfoProvider.cs", 107);
			return a2;
		}
	}
}
internal class c
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct A : IAsyncStateMachine
	{
		public int A;

		public AsyncTaskMethodBuilder<string> A;

		public c A;

		public DocumentId A;

		[B(new byte[] { 0, 1 })]
		private TaskAwaiter<SourceText> m_A;

		private void A()
		{
			int num = this.A;
			c c2 = this.A;
			string result;
			try
			{
				TaskAwaiter<SourceText> awaiter;
				if (num == 0)
				{
					awaiter = this.m_A;
					this.m_A = default(TaskAwaiter<SourceText>);
					num = (this.A = -1);
					goto IL_008f;
				}
				if (c2.A() != null)
				{
					awaiter = c2.A().GetDocument(this.A).GetTextAsync()
						.GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (this.A = 0);
						this.m_A = awaiter;
						this.A.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_008f;
				}
				result = string.Empty;
				goto end_IL_000e;
				IL_008f:
				result = awaiter.GetResult().ToString();
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				this.A = -2;
				this.A.SetException(exception);
				return;
			}
			this.A = -2;
			this.A.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		[DebuggerHidden]
		private void A([B(1)] IAsyncStateMachine stateMachine)
		{
			this.A.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine([B(1)] IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct a : IAsyncStateMachine
	{
		public int A;

		public AsyncTaskMethodBuilder A;

		public c A;

		public string A;

		public string a;

		private TaskAwaiter<D> m_A;

		[B(new byte[] { 0, 1 })]
		private TaskAwaiter<Solution> m_A;

		[B(new byte[] { 0, 1 })]
		private TaskAwaiter<Project> m_A;

		private void A()
		{
			int num = this.A;
			c c2 = this.A;
			try
			{
				TaskAwaiter<D> awaiter3;
				TaskAwaiter<Solution> awaiter2;
				TaskAwaiter<Project> awaiter;
				D result;
				switch (num)
				{
				default:
					c.A(c2.m_A);
					awaiter3 = d.A(this.A).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (this.A = 0);
						this.m_A = awaiter3;
						this.A.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
						return;
					}
					goto IL_0084;
				case 0:
					awaiter3 = this.m_A;
					this.m_A = default(TaskAwaiter<D>);
					num = (this.A = -1);
					goto IL_0084;
				case 1:
					awaiter2 = this.m_A;
					this.m_A = default(TaskAwaiter<Solution>);
					num = (this.A = -1);
					goto IL_0185;
				case 2:
					{
						awaiter = this.m_A;
						this.m_A = default(TaskAwaiter<Project>);
						num = (this.A = -1);
						break;
					}
					IL_0185:
					awaiter2.GetResult();
					c2.m_A = null;
					goto end_IL_000e;
					IL_0084:
					result = awaiter3.GetResult();
					c2.A(result.a());
					c2.A(!result.B());
					if (a == null && !result.B())
					{
						a = result.A();
					}
					c2.m_A = a(a);
					c2.m_A = a;
					if (this.A.EndsWith(".sln", StringComparison.InvariantCultureIgnoreCase))
					{
						Log.Message(LogLevel.Normal, "Loading solution: " + this.A, "OpenSolutionAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\SolutionInfoProvider.cs", 113);
						awaiter2 = c2.m_A.OpenSolutionAsync(this.A).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (this.A = 1);
							this.m_A = awaiter2;
							this.A.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0185;
					}
					Log.Message(LogLevel.Normal, "Loading project: " + this.A, "OpenSolutionAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\SolutionInfoProvider.cs", 119);
					awaiter = c2.m_A.OpenProjectAsync(this.A).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (this.A = 2);
						this.m_A = awaiter;
						this.A.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					break;
				}
				Project result2 = awaiter.GetResult();
				c2.m_A = result2.Id;
				end_IL_000e:;
			}
			catch (Exception exception)
			{
				this.A = -2;
				this.A.SetException(exception);
				return;
			}
			this.A = -2;
			this.A.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		[DebuggerHidden]
		private void A([B(1)] IAsyncStateMachine stateMachine)
		{
			this.A.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine([B(1)] IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A(stateMachine);
		}
	}

	private MSBuildWorkspace m_A;

	private string m_A;

	private ProjectId m_A;

	private readonly IDictionary<DocumentId, string> m_A = new Dictionary<DocumentId, string>();

	[CompilerGenerated]
	private ISet<string> m_A;

	[CompilerGenerated]
	private bool m_A;

	public c()
	{
		if (MSBuildLocator.CanRegister)
		{
			MSBuildLocator.RegisterDefaults();
		}
	}

	[SpecialName]
	public Solution A()
	{
		return this.m_A?.CurrentSolution;
	}

	[SpecialName]
	public string a()
	{
		if (A()?.FilePath == null)
		{
			string text = A().Projects.FirstOrDefault()?.FilePath;
			if (text != null)
			{
				text = Path.GetDirectoryName(text);
				return Path.GetDirectoryName(text);
			}
			return null;
		}
		return Path.GetDirectoryName(A().FilePath);
	}

	[SpecialName]
	[CompilerGenerated]
	public ISet<string> B()
	{
		return this.m_A;
	}

	[SpecialName]
	[CompilerGenerated]
	private void A(ISet<string> P_0)
	{
		this.m_A = P_0;
	}

	[SpecialName]
	[CompilerGenerated]
	public bool b()
	{
		return this.m_A;
	}

	[SpecialName]
	[CompilerGenerated]
	private void A(bool P_0)
	{
		this.m_A = P_0;
	}

	[AsyncStateMachine(typeof(a))]
	public Task A(string P_0, string P_1)
	{
		a stateMachine = default(a);
		stateMachine.A = AsyncTaskMethodBuilder.Create();
		stateMachine.A = this;
		stateMachine.A = P_0;
		stateMachine.a = P_1;
		stateMachine.A = -1;
		stateMachine.A.Start(ref stateMachine);
		return stateMachine.A.Task;
	}

	public IList<ProjectData> A(IProgress<int> P_0)
	{
		IEnumerable<ProjectId> enumerable = C();
		List<ProjectData> list = new List<ProjectData>();
		int num = 0;
		int num2 = enumerable.Count();
		P_0?.Report(0);
		foreach (ProjectId item2 in enumerable)
		{
			Project project = A(item2);
			Log.Message(LogLevel.Normal, "Found project: " + project.FilePath, "GetProjectData", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\SolutionInfoProvider.cs", 138);
			Log.Message(LogLevel.Normal, "Files: " + project.Documents.Count(), "GetProjectData", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\SolutionInfoProvider.cs", 139);
			ProjectData item = new C(project).A(true);
			list.Add(item);
			num++;
			double num3 = (double)num / (double)num2 * 100.0;
			P_0?.Report((int)num3);
		}
		Log.Message(LogLevel.Normal, (num2 > 1 && this.m_A == null) ? "Solution successfully loaded" : "Project successfully loaded", "GetProjectData", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\SolutionInfoProvider.cs", 152);
		return list;
	}

	public IEnumerable<ProjectId> C()
	{
		if (!(this.m_A == null))
		{
			return new List<ProjectId> { this.m_A };
		}
		return A().GetProjectDependencyGraph().GetTopologicallySortedProjects();
	}

	[AsyncStateMachine(typeof(A))]
	public Task<string> A(DocumentId P_0)
	{
		A stateMachine = default(A);
		stateMachine.A = AsyncTaskMethodBuilder<string>.Create();
		stateMachine.A = this;
		stateMachine.A = P_0;
		stateMachine.A = -1;
		stateMachine.A.Start(ref stateMachine);
		return stateMachine.A.Task;
	}

	public Project A(ProjectId P_0)
	{
		Project project = A()?.GetProject(P_0);
		if (project == null)
		{
			return null;
		}
		ProjectData projectData = new C(project).A(false);
		bool flag = true;
		string text = this.m_A;
		if (text != null && text.ToLowerInvariant().Contains("netstandard2"))
		{
			Log.Message("target framework set to netstandard2", "GetProject", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\SolutionInfoProvider.cs", 192);
			flag = false;
		}
		else
		{
			string targetFramework = projectData.TargetFramework;
			if (targetFramework != null && targetFramework.ToLowerInvariant().Contains("netstandard2"))
			{
				Log.Message("netstandard2 project detected", "GetProject", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\SolutionInfoProvider.cs", 197);
				flag = false;
			}
			else if (projectData.PackageTargetFallback != null)
			{
				Log.Message("PackageTargetFallback detected", "GetProject", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\SolutionInfoProvider.cs", 202);
				flag = true;
			}
		}
		if (flag)
		{
			Log.Message(LogLevel.Normal, "Load mscorlib for " + project.Name, "GetProject", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\SolutionInfoProvider.cs", 208);
			MetadataReference metadataReference = MetadataReference.CreateFromFile(typeof(object).GetTypeInfo().Assembly.Location);
			return project.AddMetadataReference(metadataReference);
		}
		Log.Message(LogLevel.Normal, "Skip loading mscorlib for " + project.Name, "GetProject", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\SolutionInfoProvider.cs", 215);
		return project;
	}

	internal static bool A(string P_0)
	{
		P_0 = P_0.ToLowerInvariant();
		if (!P_0.Contains("assemblyinfo") && !P_0.Contains("assemblyattributes") && !P_0.EndsWith(".designer.cs", StringComparison.InvariantCultureIgnoreCase))
		{
			return !P_0.EndsWith(".cs", StringComparison.InvariantCultureIgnoreCase);
		}
		return true;
	}

	private static MSBuildWorkspace a(string P_0)
	{
		ImmutableDictionary<string, string> empty = ImmutableDictionary<string, string>.Empty;
		empty = empty.Add("CheckForSystemRuntimeDependency", "true");
		if (P_0 != null)
		{
			empty = empty.Add("TargetFramework", P_0);
			Log.Message(LogLevel.Normal, "Using TargetFramework=" + P_0, "CreateWorkspace", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\SolutionInfoProvider.cs", 244);
		}
		MSBuildWorkspace mSBuildWorkspace = MSBuildWorkspace.Create(empty);
		mSBuildWorkspace.LoadMetadataForReferencedProjects = true;
		mSBuildWorkspace.WorkspaceFailed += A;
		return mSBuildWorkspace;
	}

	private static void A(MSBuildWorkspace P_0)
	{
		if (P_0 != null)
		{
			if (P_0.CurrentSolution != null)
			{
				P_0.CloseSolution();
			}
			P_0.WorkspaceFailed -= A;
			P_0.Dispose();
			P_0 = null;
		}
	}

	private static void A(object P_0, WorkspaceDiagnosticEventArgs P_1)
	{
		Log.Error(P_1.Diagnostic.Message, "MSBuildWorkspace_WorkspaceFailed", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\SolutionInfoProvider.cs", 271);
	}
}
