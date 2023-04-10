using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;

namespace CsToDartTranspiler;

public class DartTranspilerPreprocessorData
{
	[CompilerGenerated]
	private readonly IDictionary<string, string> A = new Dictionary<string, string>();

	[CompilerGenerated]
	private readonly IDictionary<ProjectId, ISet<string>> A = new Dictionary<ProjectId, ISet<string>>();

	[CompilerGenerated]
	private readonly ISet<string> A = new HashSet<string>();

	[CompilerGenerated]
	private readonly IDictionary<string, string> a = new Dictionary<string, string>();

	[CompilerGenerated]
	private readonly ISet<string> a = new HashSet<string>();

	[CompilerGenerated]
	private readonly IDictionary<string, List<string>> A = new Dictionary<string, List<string>>();

	[CompilerGenerated]
	private readonly IDictionary<string, string> B = new Dictionary<string, string>();

	[CompilerGenerated]
	private readonly ISet<string> B = new HashSet<string>();

	public IDictionary<string, string> ProjectNamesByProjectFolderPath
	{
		[CompilerGenerated]
		get
		{
			return this.A;
		}
	}

	public IDictionary<ProjectId, ISet<string>> FilesWithPublicDeclarations
	{
		[CompilerGenerated]
		get
		{
			return this.A;
		}
	}

	public ISet<string> AllDeclaredClasses
	{
		[CompilerGenerated]
		get
		{
			return this.A;
		}
	}

	public IDictionary<string, string> RenamedClassNames
	{
		[CompilerGenerated]
		get
		{
			return this.a;
		}
	}

	public ISet<string> AllDeclaredMethods
	{
		[CompilerGenerated]
		get
		{
			return a;
		}
	}

	public IDictionary<string, List<string>> ParameterNames
	{
		[CompilerGenerated]
		get
		{
			return A;
		}
	}

	public IDictionary<string, string> RenamedMethodNames
	{
		[CompilerGenerated]
		get
		{
			return this.B;
		}
	}

	public ISet<string> MethodsCalledUsingNamedParameters
	{
		[CompilerGenerated]
		get
		{
			return B;
		}
	}
}
