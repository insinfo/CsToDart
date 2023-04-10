using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using A;
using KineApps.Common.Diagnostics;
using Microsoft.CodeAnalysis;

namespace CsToDartTranspiler;

public class DartTranspiler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct A : IAsyncStateMachine
	{
		public int A;

		public AsyncTaskMethodBuilder A;

		public DartTranspiler A;

		public string A;

		public string a;

		private TaskAwaiter m_A;

		private void A()
		{
			int num = this.A;
			DartTranspiler dartTranspiler = this.A;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = dartTranspiler.m_A.A(this.A, a).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (this.A = 0);
						this.m_A = awaiter;
						this.A.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = this.m_A;
					this.m_A = default(TaskAwaiter);
					num = (this.A = -1);
				}
				awaiter.GetResult();
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
		private void A([global::A.B(1)] IAsyncStateMachine stateMachine)
		{
			this.A.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine([global::A.B(1)] IAsyncStateMachine stateMachine)
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

		public AsyncTaskMethodBuilder<DartTranspilerPreprocessorData> A;

		public IProgress<int> A;

		public Solution A;

		public DartTranspiler A;

		private DartTranspilerPreprocessorData m_A;

		private int a;

		private int B;

		private IEnumerator<ProjectId> m_A;

		private ProjectId m_A;

		[global::A.B(new byte[] { 0, 1 })]
		private IEnumerator<Document> m_A;

		private Document m_A;

		private SemanticModel m_A;

		[global::A.B(new byte[] { 0, 2 })]
		private TaskAwaiter<SemanticModel> m_A;

		[global::A.B(new byte[] { 0, 2 })]
		private TaskAwaiter<SyntaxNode> m_A;

		private void A()
		{
			int num = this.A;
			DartTranspiler dartTranspiler = this.A;
			DartTranspilerPreprocessorData result3;
			try
			{
				if ((uint)num > 1u)
				{
					this.A?.Report(0);
					Log.Message(LogLevel.Normal, "Preprocessing solution: " + this.A.FilePath, "PreprocessAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 90);
					this.m_A = new DartTranspilerPreprocessorData();
					IEnumerable<ProjectId> enumerable = dartTranspiler.m_A.C();
					dartTranspiler.m_A = 0;
					a = 0;
					B = enumerable.Count();
					this.m_A = enumerable.GetEnumerator();
				}
				try
				{
					if ((uint)num <= 1u)
					{
						goto IL_016a;
					}
					goto IL_038b;
					IL_016a:
					try
					{
						TaskAwaiter<SyntaxNode> awaiter;
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_0312;
							}
							awaiter = this.m_A;
							this.m_A = default(TaskAwaiter<SyntaxNode>);
							num = (this.A = -1);
							goto IL_02a6;
						}
						TaskAwaiter<SemanticModel> awaiter2 = this.m_A;
						this.m_A = default(TaskAwaiter<SemanticModel>);
						num = (this.A = -1);
						goto IL_022f;
						IL_022f:
						SemanticModel result = awaiter2.GetResult();
						this.m_A = result;
						awaiter = this.m_A.GetSyntaxRootAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (this.A = 1);
							this.m_A = awaiter;
							this.A.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_02a6;
						IL_02a6:
						SyntaxNode result2 = awaiter.GetResult();
						DartTranspilerPreprocessor dartTranspilerPreprocessor = new DartTranspilerPreprocessor(this.m_A, this.m_A);
						dartTranspilerPreprocessor.Run(result2);
						if (dartTranspilerPreprocessor.HasPublicDeclarations)
						{
							this.m_A.FilesWithPublicDeclarations[this.m_A].Add(this.m_A.FilePath);
						}
						dartTranspiler.m_A++;
						this.m_A = null;
						this.m_A = null;
						goto IL_0312;
						IL_0312:
						while (this.m_A.MoveNext())
						{
							this.m_A = this.m_A.Current;
							Log.Message(LogLevel.Normal, "Preprocessing: " + this.m_A.FilePath, "PreprocessAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 118);
							if (c.A(this.m_A.Name))
							{
								continue;
							}
							awaiter2 = this.m_A.GetSemanticModelAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (this.A = 0);
								this.m_A = awaiter2;
								this.A.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_022f;
						}
					}
					finally
					{
						if (num < 0 && this.m_A != null)
						{
							this.m_A.Dispose();
						}
					}
					this.m_A = null;
					int num2 = a + 1;
					a = num2;
					double num3 = (double)a / (double)B * 100.0;
					this.A?.Report((int)num3);
					this.m_A = null;
					goto IL_038b;
					IL_038b:
					if (this.m_A.MoveNext())
					{
						this.m_A = this.m_A.Current;
						Project project = dartTranspiler.m_A.A(this.m_A);
						Log.Message(LogLevel.Normal, "Preprocessing project: " + project.FilePath, "PreprocessAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 105);
						Log.Message("Files: " + project.Documents.Count(), "PreprocessAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 106);
						string directoryName = Path.GetDirectoryName(project.FilePath);
						string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(project.FilePath);
						this.m_A.ProjectNamesByProjectFolderPath[directoryName] = fileNameWithoutExtension;
						this.m_A.FilesWithPublicDeclarations[this.m_A] = new HashSet<string>();
						this.m_A = project.Documents.GetEnumerator();
						goto IL_016a;
					}
				}
				finally
				{
					if (num < 0 && this.m_A != null)
					{
						this.m_A.Dispose();
					}
				}
				this.m_A = null;
				Log.Message(LogLevel.Normal, "Preprocessing completed", "PreprocessAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 146);
				result3 = this.m_A;
			}
			catch (Exception exception)
			{
				this.A = -2;
				this.m_A = null;
				this.A.SetException(exception);
				return;
			}
			this.A = -2;
			this.m_A = null;
			this.A.SetResult(result3);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		[DebuggerHidden]
		private void A([global::A.B(1)] IAsyncStateMachine stateMachine)
		{
			this.A.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine([global::A.B(1)] IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct B : IAsyncStateMachine
	{
		public int A;

		public AsyncTaskMethodBuilder A;

		public string A;

		public DartTranspiler A;

		public IProgress<int> A;

		public bool A;

		private string a;

		private TaskAwaiter<DartTranspilerPreprocessorData> m_A;

		private TaskAwaiter m_A;

		private void A()
		{
			int num = this.A;
			DartTranspiler dartTranspiler = this.A;
			try
			{
				if ((uint)num > 1u)
				{
					a = Path.Combine(this.A, "log.txt");
				}
				try
				{
					TaskAwaiter awaiter;
					TaskAwaiter<DartTranspilerPreprocessorData> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = this.m_A;
							this.m_A = default(TaskAwaiter);
							num = (this.A = -1);
							goto IL_015d;
						}
						Log.Message(LogLevel.Normal, "Transpile started", "TranspileAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 61);
						Log.Message(LogLevel.Normal, "Output folder: " + this.A, "TranspileAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 62);
						Log.StartFileLogging(a);
						dartTranspiler.m_A.Clear();
						awaiter2 = dartTranspiler.A(dartTranspiler.CurrentSolution, this.A).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (this.A = 0);
							this.m_A = awaiter2;
							this.A.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = this.m_A;
						this.m_A = default(TaskAwaiter<DartTranspilerPreprocessorData>);
						num = (this.A = -1);
					}
					DartTranspilerPreprocessorData result = awaiter2.GetResult();
					awaiter = dartTranspiler.A(dartTranspiler.CurrentSolution, this.A, result, this.A, this.A).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (this.A = 1);
						this.m_A = awaiter;
						this.A.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_015d;
					IL_015d:
					awaiter.GetResult();
					Log.Message(LogLevel.Normal, "Transpile completed", "TranspileAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 72);
				}
				catch (Exception exception)
				{
					Log.Exception(LogLevel.Normal, exception, "TranspileAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 76);
					throw;
				}
				finally
				{
					if (num < 0)
					{
						Log.StopFileLogging();
						Log.Message(LogLevel.Normal, "Log file saved to: " + a, "TranspileAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 82);
					}
				}
			}
			catch (Exception exception2)
			{
				this.A = -2;
				a = null;
				this.A.SetException(exception2);
				return;
			}
			this.A = -2;
			a = null;
			this.A.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A();
		}

		[DebuggerHidden]
		private void A([global::A.B(1)] IAsyncStateMachine stateMachine)
		{
			this.A.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine([global::A.B(1)] IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A(stateMachine);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct b : IAsyncStateMachine
	{
		public int A;

		public AsyncTaskMethodBuilder A;

		public IProgress<int> A;

		public Solution A;

		public string A;

		public DartTranspiler A;

		public DartTranspilerPreprocessorData A;

		public bool A;

		private int a;

		private IEnumerator<ProjectId> m_A;

		private ProjectId m_A;

		private Project m_A;

		private global::A.b m_A;

		[global::A.B(new byte[] { 0, 1 })]
		private IEnumerator<Document> m_A;

		private Document m_A;

		private SemanticModel m_A;

		[global::A.B(new byte[] { 0, 2 })]
		private TaskAwaiter<SemanticModel> m_A;

		[global::A.B(new byte[] { 0, 2 })]
		private TaskAwaiter<SyntaxNode> m_A;

		private void A()
		{
			int num = this.A;
			DartTranspiler dartTranspiler = this.A;
			try
			{
				if ((uint)num > 1u)
				{
					this.A?.Report(0);
					Log.Message(LogLevel.Normal, "Transpiling solution: " + this.A.FilePath, "TranspileAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 155);
					global::A.b.A(this.A);
					IEnumerable<ProjectId> enumerable = dartTranspiler.m_A.C();
					a = 0;
					this.m_A = enumerable.GetEnumerator();
				}
				try
				{
					if ((uint)num <= 1u)
					{
						goto IL_014b;
					}
					goto IL_042b;
					IL_014b:
					try
					{
						TaskAwaiter<SyntaxNode> awaiter;
						if (num != 0)
						{
							if (num != 1)
							{
								goto IL_033d;
							}
							awaiter = this.m_A;
							this.m_A = default(TaskAwaiter<SyntaxNode>);
							num = (this.A = -1);
							goto IL_028a;
						}
						TaskAwaiter<SemanticModel> awaiter2 = this.m_A;
						this.m_A = default(TaskAwaiter<SemanticModel>);
						num = (this.A = -1);
						goto IL_0213;
						IL_0213:
						SemanticModel result = awaiter2.GetResult();
						this.m_A = result;
						awaiter = this.m_A.GetSyntaxRootAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (this.A = 1);
							this.m_A = awaiter;
							this.A.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_028a;
						IL_028a:
						SyntaxNode result2 = awaiter.GetResult();
						string text = new DartTranspilerVisitor(this.m_A, this.A, this.m_A.A()).Run(result2);
						dartTranspiler.m_A[this.m_A.Id] = text;
						if (this.A)
						{
							this.m_A.A(this.m_A.FilePath, text);
						}
						int num2 = a + 1;
						a = num2;
						double num3 = (double)a / (double)dartTranspiler.m_A * 100.0;
						this.A?.Report((int)num3);
						this.m_A = null;
						this.m_A = null;
						goto IL_033d;
						IL_033d:
						while (this.m_A.MoveNext())
						{
							this.m_A = this.m_A.Current;
							Log.Message(LogLevel.Normal, "File: " + this.m_A.FilePath, "TranspileAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 174);
							if (c.A(this.m_A.Name))
							{
								continue;
							}
							awaiter2 = this.m_A.GetSemanticModelAsync().GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (this.A = 0);
								this.m_A = awaiter2;
								this.A.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_0213;
						}
					}
					finally
					{
						if (num < 0 && this.m_A != null)
						{
							this.m_A.Dispose();
						}
					}
					this.m_A = null;
					if (this.A)
					{
						ISet<string> set = new HashSet<string>();
						try
						{
							string text2 = E.A(this.m_A, this.m_A.FilePath);
							if (text2 != null)
							{
								set.Add(text2);
							}
						}
						catch (Exception exception)
						{
							Log.Exception(exception, "TranspileAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 218);
						}
						this.m_A.A().AddPathDependency(Path.Combine(dartTranspiler.m_A.a(), "kacommon"), "kacommon");
						this.m_A.a();
						this.m_A.A(this.A.FilesWithPublicDeclarations[this.m_A], set);
					}
					this.m_A = null;
					this.m_A = null;
					this.m_A = null;
					goto IL_042b;
					IL_042b:
					if (this.m_A.MoveNext())
					{
						this.m_A = this.m_A.Current;
						this.m_A = dartTranspiler.m_A.A(this.m_A);
						Log.Message(LogLevel.Normal, "Project: " + this.m_A.FilePath, "TranspileAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 167);
						Log.Message("Files: " + this.m_A.Documents.Count(), "TranspileAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspiler.cs", 168);
						this.m_A = new global::A.b(dartTranspiler.m_A.a(), this.A, this.m_A.FilePath);
						this.m_A = this.m_A.Documents.GetEnumerator();
						goto IL_014b;
					}
				}
				finally
				{
					if (num < 0 && this.m_A != null)
					{
						this.m_A.Dispose();
					}
				}
				this.m_A = null;
			}
			catch (Exception exception2)
			{
				this.A = -2;
				this.A.SetException(exception2);
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
		private void A([global::A.B(1)] IAsyncStateMachine stateMachine)
		{
			this.A.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine([global::A.B(1)] IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in A
			this.A(stateMachine);
		}
	}

	private readonly IDictionary<DocumentId, string> m_A = new Dictionary<DocumentId, string>();

	private readonly c m_A = new c();

	private int m_A;

	public Solution CurrentSolution => this.m_A?.A();

	public ISet<string> TargetFrameworks => this.m_A?.B();

	public bool ShouldAllowSettingTargetFramework => this.m_A?.b() ?? false;

	public DartTranspiler(ILogListener logListener)
	{
		Log.LogListener = logListener;
	}

	[AsyncStateMachine(typeof(A))]
	public Task OpenSolutionAsync(string filePath, string targetFramework)
	{
		A stateMachine = default(A);
		stateMachine.A = AsyncTaskMethodBuilder.Create();
		stateMachine.A = this;
		stateMachine.A = filePath;
		stateMachine.a = targetFramework;
		stateMachine.A = -1;
		stateMachine.A.Start(ref stateMachine);
		return stateMachine.A.Task;
	}

	public IList<ProjectData> GetProjectData(IProgress<int> progress)
	{
		return this.m_A.A(progress);
	}

	public Task<string> GetDocumentTextAsync(DocumentId documentId)
	{
		return this.m_A.A(documentId);
	}

	public string GetDartSourceCode(DocumentId csDocumentId)
	{
		if (this.m_A.ContainsKey(csDocumentId))
		{
			return this.m_A[csDocumentId];
		}
		return null;
	}

	[AsyncStateMachine(typeof(B))]
	public Task TranspileAsync(string outputFolder, IProgress<int> progress = null, bool writeDartFiles = true)
	{
		B stateMachine = default(B);
		stateMachine.A = AsyncTaskMethodBuilder.Create();
		stateMachine.A = this;
		stateMachine.A = outputFolder;
		stateMachine.A = progress;
		stateMachine.A = writeDartFiles;
		stateMachine.A = -1;
		stateMachine.A.Start(ref stateMachine);
		return stateMachine.A.Task;
	}

	[AsyncStateMachine(typeof(a))]
	private Task<DartTranspilerPreprocessorData> A(Solution P_0, IProgress<int> P_1)
	{
		a stateMachine = default(a);
		stateMachine.A = AsyncTaskMethodBuilder<DartTranspilerPreprocessorData>.Create();
		stateMachine.A = this;
		stateMachine.A = P_0;
		stateMachine.A = P_1;
		stateMachine.A = -1;
		stateMachine.A.Start(ref stateMachine);
		return stateMachine.A.Task;
	}

	[AsyncStateMachine(typeof(b))]
	private Task A(Solution P_0, string P_1, DartTranspilerPreprocessorData P_2, IProgress<int> P_3, bool P_4)
	{
		b stateMachine = default(b);
		stateMachine.A = AsyncTaskMethodBuilder.Create();
		stateMachine.A = this;
		stateMachine.A = P_0;
		stateMachine.A = P_1;
		stateMachine.A = P_2;
		stateMachine.A = P_3;
		stateMachine.A = P_4;
		stateMachine.A = -1;
		stateMachine.A.Start(ref stateMachine);
		return stateMachine.A.Task;
	}
}
