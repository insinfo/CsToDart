using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using CsToDartTranspiler;
using KineApps.Common.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.MSBuild;

namespace A;

internal class D
{
	[CompilerGenerated]
	private string m_A;

	[CompilerGenerated]
	private ISet<string> m_A;

	[CompilerGenerated]
	private bool m_A;

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
	public bool B()
	{
		return this.m_A;
	}

	[SpecialName]
	[CompilerGenerated]
	public void A(bool P_0)
	{
		this.m_A = P_0;
	}
}
internal static class d
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct A : IAsyncStateMachine
	{
		public int A;

		public AsyncTaskMethodBuilder<D> A;

		public string A;

		private D m_A;

		private ISet<string> m_A;

		private ISet<string> a;

		private MSBuildWorkspace m_A;

		[B(new byte[] { 0, 1 })]
		private TaskAwaiter<Solution> m_A;

		[B(new byte[] { 0, 1 })]
		private TaskAwaiter<Project> m_A;

		private void A()
		{
			int num = this.A;
			D result2;
			try
			{
				if ((uint)num > 1u)
				{
					D obj = new D();
					obj.A((string)null);
					obj.A(new HashSet<string>());
					obj.A(true);
					this.m_A = obj;
					this.m_A = new HashSet<string>();
					a = null;
					this.m_A = MSBuildWorkspace.Create();
				}
				try
				{
					TaskAwaiter<Solution> awaiter;
					ProjectId projectId;
					Solution solution;
					if (num != 0)
					{
						TaskAwaiter<Project> awaiter2;
						if (num != 1)
						{
							if (this.A.EndsWith(".sln", StringComparison.InvariantCultureIgnoreCase))
							{
								awaiter = this.m_A.OpenSolutionAsync(this.A).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = (this.A = 0);
									this.m_A = awaiter;
									this.A.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									return;
								}
								goto IL_00d7;
							}
							awaiter2 = this.m_A.OpenProjectAsync(this.A).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (this.A = 1);
								this.m_A = awaiter2;
								this.A.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = this.m_A;
							this.m_A = default(TaskAwaiter<Project>);
							num = (this.A = -1);
						}
						Project result = awaiter2.GetResult();
						projectId = result.Id;
						solution = result.Solution;
						goto IL_0167;
					}
					awaiter = this.m_A;
					this.m_A = default(TaskAwaiter<Solution>);
					num = (this.A = -1);
					goto IL_00d7;
					IL_00d7:
					solution = awaiter.GetResult();
					projectId = null;
					goto IL_0167;
					IL_0167:
					IEnumerable<ProjectId> enumerable2;
					if (!(projectId == null))
					{
						IEnumerable<ProjectId> enumerable = new List<ProjectId> { projectId };
						enumerable2 = enumerable;
					}
					else
					{
						enumerable2 = solution.GetProjectDependencyGraph().GetTopologicallySortedProjects();
					}
					IEnumerator<ProjectId> enumerator = enumerable2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ProjectId current = enumerator.Current;
							Project project = solution.GetProject(current);
							ProjectData projectData = new C(project).A(false);
							Log.Message(LogLevel.Normal, "Project: " + project.FilePath + ", TargetFramework: " + (projectData.TargetFramework ?? "not specified"), "GetTargetFrameworkInfoAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\TargetFrameworkInfoProvider.cs", 64);
							ISet<string> targetFrameworks = projectData.TargetFrameworks;
							if (targetFrameworks != null && targetFrameworks.Count > 0)
							{
								Log.Message(LogLevel.Normal, "TargetFrameworks: " + string.Join(";", projectData.TargetFrameworks), "GetTargetFrameworkInfoAsync", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\SolutionInfoProvider\\TargetFrameworkInfoProvider.cs", 67);
							}
							if (string.IsNullOrWhiteSpace(projectData.TargetFramework))
							{
								this.m_A.A(false);
							}
							else
							{
								this.m_A.a().Add(projectData.TargetFramework);
							}
							ISet<string> targetFrameworks2 = projectData.TargetFrameworks;
							if (targetFrameworks2 != null && targetFrameworks2.Count > 0)
							{
								this.m_A.a().UnionWith(projectData.TargetFrameworks);
								this.m_A.IntersectWith(projectData.TargetFrameworks);
								a = projectData.TargetFrameworks;
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							enumerator?.Dispose();
						}
					}
				}
				finally
				{
					if (num < 0 && this.m_A != null)
					{
						((IDisposable)this.m_A).Dispose();
					}
				}
				this.m_A = null;
				if (this.m_A.Count() > 0)
				{
					this.m_A.A(this.m_A.First());
				}
				else
				{
					this.m_A.A(a?.FirstOrDefault());
				}
				result2 = this.m_A;
			}
			catch (Exception exception)
			{
				this.A = -2;
				this.m_A = null;
				this.m_A = null;
				a = null;
				this.A.SetException(exception);
				return;
			}
			this.A = -2;
			this.m_A = null;
			this.m_A = null;
			a = null;
			this.A.SetResult(result2);
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

	[AsyncStateMachine(typeof(A))]
	public static Task<D> A(string P_0)
	{
		A stateMachine = default(A);
		stateMachine.A = AsyncTaskMethodBuilder<D>.Create();
		stateMachine.A = P_0;
		stateMachine.A = -1;
		stateMachine.A.Start(ref stateMachine);
		return stateMachine.A.Task;
	}
}
