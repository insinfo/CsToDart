using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;

namespace CsToDartTranspiler;

public class ProjectData
{
	[CompilerGenerated]
	private ProjectId A;

	[CompilerGenerated]
	private string A;

	[CompilerGenerated]
	private string a;

	[CompilerGenerated]
	private readonly IList<DocumentData> A = new List<DocumentData>();

	[CompilerGenerated]
	private ISet<string> A;

	[CompilerGenerated]
	private string B;

	[CompilerGenerated]
	private string b;

	public ProjectId ProjectId
	{
		[CompilerGenerated]
		get
		{
			return this.A;
		}
		[CompilerGenerated]
		set
		{
			this.A = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return this.A;
		}
		[CompilerGenerated]
		set
		{
			this.A = value;
		}
	}

	public string FilePath
	{
		[CompilerGenerated]
		get
		{
			return a;
		}
		[CompilerGenerated]
		set
		{
			a = value;
		}
	}

	public IList<DocumentData> Documents
	{
		[CompilerGenerated]
		get
		{
			return this.A;
		}
	}

	public ISet<string> TargetFrameworks
	{
		[CompilerGenerated]
		get
		{
			return A;
		}
		[CompilerGenerated]
		set
		{
			A = value;
		}
	}

	public string TargetFramework
	{
		[CompilerGenerated]
		get
		{
			return B;
		}
		[CompilerGenerated]
		set
		{
			B = value;
		}
	}

	public string PackageTargetFallback
	{
		[CompilerGenerated]
		get
		{
			return b;
		}
		[CompilerGenerated]
		set
		{
			b = value;
		}
	}
}
