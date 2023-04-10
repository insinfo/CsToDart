using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;

namespace CsToDartTranspiler;

public class DocumentData
{
	[CompilerGenerated]
	private DocumentId A;

	[CompilerGenerated]
	private IReadOnlyList<string> A;

	[CompilerGenerated]
	private string A;

	[CompilerGenerated]
	private string a;

	public DocumentId DocumentId
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

	public IReadOnlyList<string> Folders
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
			return A;
		}
		[CompilerGenerated]
		set
		{
			A = value;
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
}
