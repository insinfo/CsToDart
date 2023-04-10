using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using A;
using KineApps.Common.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CsToDartTranspiler;

public class DartTranspilerVisitor : CSharpSyntaxWalker
{
	private enum A
	{
		A,
		a,
		B
	}

	private class a
	{
		[CompilerGenerated]
		private int m_A = -1;

		[CompilerGenerated]
		private A m_A;

		[SpecialName]
		[CompilerGenerated]
		public int A()
		{
			return this.m_A;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(int P_0)
		{
			this.m_A = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public A a()
		{
			return this.m_A;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(A P_0)
		{
			this.m_A = P_0;
		}
	}

	private class B
	{
		[CompilerGenerated]
		private readonly List<string> m_A = new List<string>();

		[CompilerGenerated]
		private readonly List<string> m_a = new List<string>();

		[SpecialName]
		[CompilerGenerated]
		public List<string> A()
		{
			return this.m_A;
		}

		[SpecialName]
		[CompilerGenerated]
		public List<string> a()
		{
			return this.m_a;
		}
	}

	private class b
	{
		[CompilerGenerated]
		private bool m_A;

		[CompilerGenerated]
		private int m_A;

		[SpecialName]
		[CompilerGenerated]
		public bool A()
		{
			return this.m_A;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(bool P_0)
		{
			this.m_A = P_0;
		}

		[SpecialName]
		[CompilerGenerated]
		public int a()
		{
			return this.m_A;
		}

		[SpecialName]
		[CompilerGenerated]
		public void A(int P_0)
		{
			this.m_A = P_0;
		}
	}

	private class C
	{
		public IDictionary<string, VariableDeclaratorSyntax> A;

		public IDictionary<string, PropertyDeclarationSyntax> A;

		public bool A;

		[SpecialName]
		public bool A()
		{
			if (!this.A)
			{
				IDictionary<string, VariableDeclaratorSyntax> a = this.A;
				if (a == null || a.Count <= 0)
				{
					IDictionary<string, PropertyDeclarationSyntax> a2 = this.A;
					if (a2 == null)
					{
						return false;
					}
					return a2.Count > 0;
				}
				return true;
			}
			return false;
		}
	}

	private class c
	{
		[CompilerGenerated]
		private readonly ISet<string> m_A = new HashSet<string>();

		[SpecialName]
		[CompilerGenerated]
		public ISet<string> A()
		{
			return this.m_A;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class D
	{
		public static readonly D A = new D();

		public static Func<A<AssignmentExpressionSyntax, ISymbol>, bool> A;

		public static Func<A<AssignmentExpressionSyntax, ISymbol>, ISymbol> A;

		public static Func<A<AssignmentExpressionSyntax, ISymbol>, AssignmentExpressionSyntax> A;

		public static Func<IGrouping<ISymbol, AssignmentExpressionSyntax>, ISymbol> A;

		public static Func<IGrouping<ISymbol, AssignmentExpressionSyntax>, AssignmentExpressionSyntax[]> A;

		public static Func<ArgumentSyntax, bool> A;

		public static Func<SyntaxToken, bool> A;

		[global::A.B(new byte[] { 0, 0, 1, 0 })]
		public static Func<INamedTypeSymbol, IEnumerable<IMethodSymbol>> A;

		[global::A.B(new byte[] { 0, 0, 1, 0 })]
		public static Func<INamedTypeSymbol, IEnumerable<IPropertySymbol>> A;

		public static Func<string, int> A;

		public static Func<AttributeSyntax, bool> A;

		public static Func<AttributeListSyntax, bool> A;

		public static Func<AccessorDeclarationSyntax, bool> A;

		public static Func<AccessorDeclarationSyntax, bool> a;

		public static Func<AccessorDeclarationSyntax, bool> B;

		public static Func<AccessorDeclarationSyntax, bool> b;

		public static Func<ExpressionSyntax, bool> A;

		public static Func<AssignmentExpressionSyntax, bool> A;

		public static Func<VariableDeclaratorSyntax, bool> A;

		public static Func<VariableDeclaratorSyntax, string> A;

		public static Func<ExpressionSyntax, bool> a;

		public static Func<AssignmentExpressionSyntax, bool> a;

		public static Func<PropertyDeclarationSyntax, bool> A;

		public static Func<PropertyDeclarationSyntax, string> A;

		public static Func<ArgumentSyntax, bool> a;

		public static Func<ISymbol, bool> A;

		public static Func<ObjectCreationExpressionSyntax, bool> A;

		public static Func<InitializerExpressionSyntax, bool> A;

		public static Func<ExpressionSyntax, bool> B;

		public static Func<ArgumentSyntax, bool> B;

		internal bool A(A<AssignmentExpressionSyntax, ISymbol> P_0)
		{
			return P_0.a() != null;
		}

		internal ISymbol a(A<AssignmentExpressionSyntax, ISymbol> P_0)
		{
			return P_0.a();
		}

		internal AssignmentExpressionSyntax B(A<AssignmentExpressionSyntax, ISymbol> P_0)
		{
			return P_0.A();
		}

		internal ISymbol A(IGrouping<ISymbol, AssignmentExpressionSyntax> P_0)
		{
			return P_0.Key;
		}

		internal AssignmentExpressionSyntax[] a(IGrouping<ISymbol, AssignmentExpressionSyntax> P_0)
		{
			return P_0.ToArray();
		}

		internal bool A(ArgumentSyntax P_0)
		{
			return P_0.RefKindKeyword.Kind() != SyntaxKind.None;
		}

		internal bool A(SyntaxToken P_0)
		{
			if (!(P_0.Text == "readonly"))
			{
				return P_0.Text == "const";
			}
			return true;
		}

		[return: global::A.B(new byte[] { 1, 0 })]
		internal IEnumerable<IMethodSymbol> A(INamedTypeSymbol P_0)
		{
			return P_0.GetMembers().OfType<IMethodSymbol>();
		}

		[return: global::A.B(new byte[] { 1, 0 })]
		internal IEnumerable<IPropertySymbol> a(INamedTypeSymbol P_0)
		{
			return P_0.GetMembers().OfType<IPropertySymbol>();
		}

		internal int A(string P_0)
		{
			return P_0.Length;
		}

		internal bool A(AttributeListSyntax P_0)
		{
			return P_0.Attributes.Any((AttributeSyntax P_0) => P_0.Name.ToString() == "Flags");
		}

		internal bool A(AttributeSyntax P_0)
		{
			return P_0.Name.ToString() == "Flags";
		}

		internal bool A(AccessorDeclarationSyntax P_0)
		{
			return P_0.Keyword.Text == "get";
		}

		internal bool a(AccessorDeclarationSyntax P_0)
		{
			return P_0.Keyword.Text == "set";
		}

		internal bool B(AccessorDeclarationSyntax P_0)
		{
			return P_0.Keyword.Text == "get";
		}

		internal bool b(AccessorDeclarationSyntax P_0)
		{
			return P_0.Keyword.Text == "set";
		}

		internal bool A(VariableDeclaratorSyntax P_0)
		{
			d CS_0024_003C_003E8__locals0 = new d();
			if (P_0.Ancestors().OfType<FieldDeclarationSyntax>().Any())
			{
				ExpressionSyntax expressionSyntax = P_0.Initializer?.Value;
				CS_0024_003C_003E8__locals0.A = expressionSyntax as ObjectCreationExpressionSyntax;
				if (CS_0024_003C_003E8__locals0.A != null)
				{
					InitializerExpressionSyntax? initializer = CS_0024_003C_003E8__locals0.A.Initializer;
					if (initializer == null || initializer.Kind() != SyntaxKind.ObjectInitializerExpression || CS_0024_003C_003E8__locals0.A.Type.Kind() == SyntaxKind.GenericName)
					{
						return CS_0024_003C_003E8__locals0.A.DescendantNodes().OfType<InitializerExpressionSyntax>().Any((InitializerExpressionSyntax P_0) => P_0.Expressions.Any((ExpressionSyntax P_0) => P_0 is ObjectCreationExpressionSyntax objectCreationExpressionSyntax2 && objectCreationExpressionSyntax2.Initializer != null) || CS_0024_003C_003E8__locals0.A.DescendantNodes().OfType<AssignmentExpressionSyntax>().Any((AssignmentExpressionSyntax P_0) => P_0.Right is ObjectCreationExpressionSyntax objectCreationExpressionSyntax && objectCreationExpressionSyntax.Initializer != null));
					}
					return true;
				}
			}
			return false;
		}

		internal bool A(ExpressionSyntax P_0)
		{
			if (P_0 is ObjectCreationExpressionSyntax objectCreationExpressionSyntax)
			{
				return objectCreationExpressionSyntax.Initializer != null;
			}
			return false;
		}

		internal bool A(AssignmentExpressionSyntax P_0)
		{
			if (P_0.Right is ObjectCreationExpressionSyntax objectCreationExpressionSyntax)
			{
				return objectCreationExpressionSyntax.Initializer != null;
			}
			return false;
		}

		internal string a(VariableDeclaratorSyntax P_0)
		{
			return P_0.Identifier.Text;
		}

		internal bool A(PropertyDeclarationSyntax P_0)
		{
			E CS_0024_003C_003E8__locals0 = new E();
			ExpressionSyntax expressionSyntax = P_0.Initializer?.Value;
			CS_0024_003C_003E8__locals0.A = expressionSyntax as ObjectCreationExpressionSyntax;
			if (CS_0024_003C_003E8__locals0.A != null)
			{
				InitializerExpressionSyntax? initializer = CS_0024_003C_003E8__locals0.A.Initializer;
				if (initializer == null || initializer.Kind() != SyntaxKind.ObjectInitializerExpression || CS_0024_003C_003E8__locals0.A.Type.Kind() == SyntaxKind.GenericName)
				{
					return CS_0024_003C_003E8__locals0.A.DescendantNodes().OfType<InitializerExpressionSyntax>().Any((InitializerExpressionSyntax P_0) => P_0.Expressions.Any((ExpressionSyntax P_0) => P_0 is ObjectCreationExpressionSyntax objectCreationExpressionSyntax2 && objectCreationExpressionSyntax2.Initializer != null) || CS_0024_003C_003E8__locals0.A.DescendantNodes().OfType<AssignmentExpressionSyntax>().Any((AssignmentExpressionSyntax P_0) => P_0.Right is ObjectCreationExpressionSyntax objectCreationExpressionSyntax && objectCreationExpressionSyntax.Initializer != null));
				}
				return true;
			}
			return false;
		}

		internal bool a(ExpressionSyntax P_0)
		{
			if (P_0 is ObjectCreationExpressionSyntax objectCreationExpressionSyntax)
			{
				return objectCreationExpressionSyntax.Initializer != null;
			}
			return false;
		}

		internal bool a(AssignmentExpressionSyntax P_0)
		{
			if (P_0.Right is ObjectCreationExpressionSyntax objectCreationExpressionSyntax)
			{
				return objectCreationExpressionSyntax.Initializer != null;
			}
			return false;
		}

		internal string a(PropertyDeclarationSyntax P_0)
		{
			return P_0.Identifier.Text;
		}

		internal bool a(ArgumentSyntax P_0)
		{
			return P_0.RefKindKeyword.Kind() != SyntaxKind.None;
		}

		internal bool A(ISymbol P_0)
		{
			if (P_0.Kind != SymbolKind.Parameter && P_0.Kind != SymbolKind.Local)
			{
				if (P_0 is IMethodSymbol methodSymbol)
				{
					return methodSymbol.MethodKind == MethodKind.LocalFunction;
				}
				return false;
			}
			return true;
		}

		internal bool A(ObjectCreationExpressionSyntax P_0)
		{
			return P_0.Initializer != null;
		}

		internal bool A(InitializerExpressionSyntax P_0)
		{
			return P_0.Kind() == SyntaxKind.ObjectInitializerExpression;
		}

		internal bool B(ExpressionSyntax P_0)
		{
			return P_0.Kind() == SyntaxKind.ComplexElementInitializerExpression;
		}

		internal bool B(ArgumentSyntax P_0)
		{
			return P_0.RefKindKeyword.Kind() != SyntaxKind.None;
		}
	}

	[CompilerGenerated]
	private sealed class d
	{
		public ObjectCreationExpressionSyntax A;

		internal bool A(InitializerExpressionSyntax P_0)
		{
			if (!P_0.Expressions.Any((ExpressionSyntax P_0) => P_0 is ObjectCreationExpressionSyntax objectCreationExpressionSyntax2 && objectCreationExpressionSyntax2.Initializer != null))
			{
				return this.A.DescendantNodes().OfType<AssignmentExpressionSyntax>().Any((AssignmentExpressionSyntax P_0) => P_0.Right is ObjectCreationExpressionSyntax objectCreationExpressionSyntax && objectCreationExpressionSyntax.Initializer != null);
			}
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class E
	{
		public ObjectCreationExpressionSyntax A;

		internal bool A(InitializerExpressionSyntax P_0)
		{
			if (!P_0.Expressions.Any((ExpressionSyntax P_0) => P_0 is ObjectCreationExpressionSyntax objectCreationExpressionSyntax2 && objectCreationExpressionSyntax2.Initializer != null))
			{
				return this.A.DescendantNodes().OfType<AssignmentExpressionSyntax>().Any((AssignmentExpressionSyntax P_0) => P_0.Right is ObjectCreationExpressionSyntax objectCreationExpressionSyntax && objectCreationExpressionSyntax.Initializer != null);
			}
			return true;
		}
	}

	[CompilerGenerated]
	private sealed class e
	{
		public string A;

		internal bool A(TypeParameterConstraintClauseSyntax P_0)
		{
			return P_0.Name.Identifier.Text == this.A;
		}
	}

	[CompilerGenerated]
	private sealed class F
	{
		public int A;

		internal bool A(IMethodSymbol P_0)
		{
			return P_0.Parameters.Count() == this.A;
		}
	}

	[CompilerGenerated]
	private sealed class f
	{
		public IMethodSymbol A;

		internal bool A(IMethodSymbol P_0)
		{
			return this.A.Equals(this.A.ContainingType.FindImplementationForInterfaceMember(P_0));
		}
	}

	[CompilerGenerated]
	private sealed class G
	{
		public IPropertySymbol A;

		internal bool A(IPropertySymbol P_0)
		{
			return this.A.Equals(this.A.ContainingType.FindImplementationForInterfaceMember(P_0));
		}
	}

	[CompilerGenerated]
	private sealed class g
	{
		public string A;

		internal bool A(string P_0)
		{
			string a = this.A;
			if (a == null)
			{
				return false;
			}
			return a.IndexOf(P_0, StringComparison.InvariantCultureIgnoreCase) == 0;
		}
	}

	private readonly SemanticModel m_A;

	private readonly DartTranspilerPreprocessorData m_A;

	private readonly DartPackageInfoProvider m_A;

	private Dictionary<ISymbol, AssignmentExpressionSyntax[]> m_A;

	private SyntaxTriviaList m_A;

	private readonly Dictionary<string, Action<InvocationExpressionSyntax, MemberAccessExpressionSyntax>> m_A = new Dictionary<string, Action<InvocationExpressionSyntax, MemberAccessExpressionSyntax>>();

	private const int m_A = 300;

	private readonly StringBuilder m_A = new StringBuilder();

	private readonly IList<StringBuilder> m_A = new List<StringBuilder>();

	private Stack<int> m_A = new Stack<int>(new int[1]);

	private StringBuilder m_a = new StringBuilder();

	private bool m_A;

	private Stack<a> m_A = new Stack<a>(new a[1]
	{
		new a()
	});

	private Stack<int> m_a = new Stack<int>();

	private static readonly Dictionary<string, Regex> m_A = new Dictionary<string, Regex>
	{
		{
			"summaryStart",
			new Regex("<summary>", RegexOptions.IgnoreCase)
		},
		{
			"summaryEnd",
			new Regex("</summary>", RegexOptions.IgnoreCase)
		},
		{
			"returnsStart",
			new Regex("<returns>", RegexOptions.IgnoreCase)
		},
		{
			"returnsEnd",
			new Regex("</returns>", RegexOptions.IgnoreCase)
		},
		{
			"paramStart",
			new Regex("<param\\s+name=\"", RegexOptions.IgnoreCase)
		},
		{
			"paramEnd",
			new Regex("</param>", RegexOptions.IgnoreCase)
		},
		{
			"remarksStart",
			new Regex("<remarks>", RegexOptions.IgnoreCase)
		},
		{
			"remarksEnd",
			new Regex("</remarks>", RegexOptions.IgnoreCase)
		},
		{
			"seealso",
			new Regex("<seealso\\s+cref=\"(.*?)\"s*/>", RegexOptions.IgnoreCase)
		},
		{
			"see",
			new Regex("<see\\s+cref=\"(.*?)\"s*/>", RegexOptions.IgnoreCase)
		},
		{
			"exception",
			new Regex("<exception\\s+cref=\"", RegexOptions.IgnoreCase)
		},
		{
			"apostropheAndEndElement",
			new Regex("\"\\s*/>", RegexOptions.IgnoreCase)
		},
		{
			"endElement",
			new Regex("\\s*/>", RegexOptions.IgnoreCase)
		},
		{
			"docComment",
			new Regex("///(s*)(.*)", RegexOptions.IgnoreCase)
		}
	};

	private readonly Dictionary<string, Action<ExpressionSyntax>> m_A = new Dictionary<string, Action<ExpressionSyntax>>();

	private Stack<B> m_A = new Stack<B>();

	private string m_A;

	private string m_a;

	private readonly Stack<Dictionary<string, int>> m_A = new Stack<Dictionary<string, int>>();

	private KeyValuePair<string, string>? m_A;

	private Stack<b> m_A = new Stack<b>();

	private readonly Stack<C> m_A = new Stack<C>();

	private readonly c m_A = new c();

	private static bool m_a;

	private string m_B;

	public DartTranspilerVisitor(SemanticModel model, DartTranspilerPreprocessorData preprocessorData, DartPackageInfoProvider dartPackageInfoProvider)
	{
		Log.Message("IN", ".ctor", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.cs", 24);
		this.m_A = model;
		this.m_A = preprocessorData;
		this.m_A = dartPackageInfoProvider;
		Log.Message("OUT", ".ctor", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.cs", 30);
	}

	public string Run(SyntaxNode root)
	{
		SetupMethodTranslators();
		SetupPropertyTranslators();
		this.m_A = (from P_0 in root.DescendantNodes().OfType<AssignmentExpressionSyntax>()
			select new A<AssignmentExpressionSyntax, ISymbol>(P_0, B(P_0.Left)) into P_0
			where P_0.a() != null
			group P_0.A() by P_0.a()).ToDictionary((IGrouping<ISymbol, AssignmentExpressionSyntax> P_0) => P_0.Key, (IGrouping<ISymbol, AssignmentExpressionSyntax> P_0) => P_0.ToArray());
		Visit(root);
		a();
		return this.m_A.ToString();
	}

	public override void Visit(SyntaxNode node)
	{
		if (node == null)
		{
			Debugger.Break();
			return;
		}
		SyntaxTriviaList leadingTrivia = node.GetLeadingTrivia();
		if (leadingTrivia != this.m_A)
		{
			this.m_A = leadingTrivia;
			A(node);
		}
		if (node is StatementSyntax && !(node is BlockSyntax))
		{
			A();
		}
		if (node is StatementSyntax)
		{
			G();
		}
		base.Visit(node);
		SyntaxTriviaList trailingTrivia = node.GetTrailingTrivia();
		if (trailingTrivia != this.m_A)
		{
			this.m_A = trailingTrivia;
			a(node);
		}
	}

	public override void VisitIdentifierName(IdentifierNameSyntax node)
	{
		Log.Node(node, "VisitIdentifierName", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.cs", 95);
		ISymbol symbol = B(node);
		string text = A(symbol);
		if (string.IsNullOrEmpty(text))
		{
			text = node.Identifier.ToString();
			Log.Warning("Unknown identifier: " + text, "VisitIdentifierName", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.cs", 103);
		}
		if (this.m_A?.Key == text)
		{
			a(this.m_A?.Value);
		}
		else if (node.Parent is NameColonSyntax)
		{
			a(text);
			a(": ");
		}
		else
		{
			bool flag = false;
			if ((from P_0 in node.Ancestors().OfType<ArgumentSyntax>()
				where P_0.RefKindKeyword.Kind() != SyntaxKind.None
				select P_0).Any())
			{
				flag = true;
			}
			if (flag)
			{
				if (!node.Ancestors().OfType<DeclarationExpressionSyntax>().Any())
				{
					a(TranslateReferenceVariableName(text));
				}
			}
			else
			{
				a(text);
				B obj = J();
				if (obj != null && obj.a().Contains(text))
				{
					a(".value");
				}
			}
		}
		Log.Message("OUT", "VisitIdentifierName", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.cs", 151);
	}

	private void A()
	{
		B b = J();
		if (b == null || b.A().Count <= 0)
		{
			return;
		}
		foreach (string item in b.A())
		{
			A(item);
			C();
		}
		b.A().Clear();
	}

	private void a()
	{
		string text = this.m_A.SyntaxTree?.FilePath;
		string text2 = D(text);
		if (text2 == null)
		{
			return;
		}
		HashSet<string> hashSet = new HashSet<string>();
		foreach (string item in this.m_A.A())
		{
			if (item == text)
			{
				continue;
			}
			string text3 = D(item);
			if (text3 != null)
			{
				string text4 = this.m_A.ProjectNamesByProjectFolderPath[text3];
				string dartLibraryNameFromCsProjectName = DartPackageInfoProvider.GetDartLibraryNameFromCsProjectName(text4);
				if (text3 == text2)
				{
					string dartRelativeSourceFilePath = this.m_A.GetDartRelativeSourceFilePath(item);
					hashSet.Add($"import 'package:{dartLibraryNameFromCsProjectName}/{dartRelativeSourceFilePath}'");
				}
				else
				{
					hashSet.Add($"import 'package:{dartLibraryNameFromCsProjectName}/{dartLibraryNameFromCsProjectName}.dart'");
					this.m_A.AddPathDependency(text3, text4);
				}
			}
		}
		if (hashSet.Count <= 0)
		{
			return;
		}
		List<string> list = new List<string>(hashSet);
		list.Sort();
		A(DartTranspilerVisitor.A.B);
		foreach (string item2 in list)
		{
			a(item2);
			C();
		}
		g();
	}

	private string A(TypeSyntax P_0)
	{
		ITypeSymbol typeSymbol = b(P_0);
		return A(typeSymbol);
	}

	private string A(ITypeSymbol P_0)
	{
		string name = P_0.Name;
		uint num = global::A.F.A(name);
		if (num <= 1615808600)
		{
			if (num <= 765439473)
			{
				if (num <= 679076413)
				{
					if (num != 425125395)
					{
						if (num == 679076413 && name == "Char")
						{
							goto IL_02c0;
						}
					}
					else if (name == "DateTimeOffset")
					{
						goto IL_02c6;
					}
				}
				else
				{
					switch (num)
					{
					case 765439473u:
						if (!(name == "Int16"))
						{
							break;
						}
						return "0";
					case 697196164u:
						if (!(name == "Int64"))
						{
							break;
						}
						return "0";
					}
				}
			}
			else if (num <= 1324880019)
			{
				switch (num)
				{
				case 1323747186u:
					if (!(name == "UInt16"))
					{
						break;
					}
					return "0";
				case 1324880019u:
					if (!(name == "UInt64"))
					{
						break;
					}
					return "0";
				}
			}
			else if (num != 1447003228)
			{
				if (num == 1615808600 && name == "String")
				{
					goto IL_02c0;
				}
			}
			else if (name == "Nullable")
			{
				return null;
			}
		}
		else if (num <= 2711245919u)
		{
			if (num <= 2417551388u)
			{
				switch (num)
				{
				case 2417551388u:
					if (!(name == "TimeSpan"))
					{
						break;
					}
					return "Duration.zero";
				case 2386971688u:
					if (!(name == "Double"))
					{
						break;
					}
					return "0.0";
				}
			}
			else if (num != 2615964816u)
			{
				if (num == 2711245919u && name == "Int32")
				{
					return "0";
				}
			}
			else if (name == "DateTime")
			{
				goto IL_02c6;
			}
		}
		else
		{
			switch (num)
			{
			case 3409549631u:
				if (!(name == "Byte"))
				{
					break;
				}
				return "0";
			case 3538687084u:
				if (!(name == "UInt32"))
				{
					break;
				}
				return "0";
			case 2779444460u:
				if (!(name == "Decimal"))
				{
					break;
				}
				return "0.0";
			case 4051133705u:
				if (!(name == "Single"))
				{
					break;
				}
				return "0.0";
			case 3969205087u:
				if (!(name == "Boolean"))
				{
					break;
				}
				return "false";
			}
		}
		switch (P_0.TypeKind)
		{
		case TypeKind.Array:
			return "[]";
		case TypeKind.Enum:
		{
			INamedTypeSymbol namedTypeSymbol = (INamedTypeSymbol)P_0;
			return namedTypeSymbol.Name + "." + namedTypeSymbol.MemberNames.First();
		}
		case TypeKind.Struct:
		{
			string text = A((ISymbol)P_0);
			return "new " + text + "()";
		}
		case TypeKind.TypeParameter:
			return "null";
		default:
			return null;
		}
		IL_02c0:
		return "null";
		IL_02c6:
		return "DateTime(0)";
	}

	private void A(string P_0, Action<InvocationExpressionSyntax, MemberAccessExpressionSyntax> P_1)
	{
		this.m_A.Add(P_0, P_1);
	}

	public void SetupMethodTranslators()
	{
		A("Debug.Assert", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("assert");
			Visit(P_0.ArgumentList);
		});
		A("Console.WriteLine", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("print");
			Visit(P_0.ArgumentList);
		});
		A("Console.Write", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("print");
			Visit(P_0.ArgumentList);
		});
		A("Console.ReadLine", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("readln");
			Visit(P_0.ArgumentList);
		});
		A("TimeSpan.FromSeconds", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("Duration.ofSeconds");
			Visit(P_0.ArgumentList);
		});
		A("TimeSpan.FromMilliseconds", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("Duration.ofMillis");
			Visit(P_0.ArgumentList);
		});
		A("Assert.Equal", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("assertEquals");
			Visit(P_0.ArgumentList);
		});
		A("Assert.NotEqual", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("assertNotEquals");
			Visit(P_0.ArgumentList);
		});
		A("Assert.Same", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("assertSame");
			Visit(P_0.ArgumentList);
		});
		A("Assert.True", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("assertTrue");
			Visit(P_0.ArgumentList);
		});
		A("Assert.False", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("assertFalse");
			Visit(P_0.ArgumentList);
		});
		A("Assert.Contains", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("assertTrue (");
			ArgumentSyntax node7 = P_0.ArgumentList.Arguments.First();
			ArgumentSyntax node8 = P_0.ArgumentList.Arguments.Last();
			Visit(node8);
			a(".contains(");
			Visit(node7);
			a("))");
		});
		A("Assert.DoesNotContain", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("assertFalse (");
			ArgumentSyntax node5 = P_0.ArgumentList.Arguments.First();
			ArgumentSyntax node6 = P_0.ArgumentList.Arguments.Last();
			Visit(node6);
			a(".contains(");
			Visit(node5);
			a("))");
		});
		A("Assert.ThrowsAsync", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			TypeSyntax typeSyntax = (P_1.Name as GenericNameSyntax).TypeArgumentList.Arguments.First();
			string text3 = a(typeSyntax);
			a("assertFailsWith<" + text3 + ">");
			Visit(P_0.ArgumentList);
		});
		A("Assert.IsType", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			if (P_0.ArgumentList.Arguments.Count() == 1)
			{
				a("assertTrue (");
				GenericNameSyntax genericNameSyntax = P_1.Name as GenericNameSyntax;
				string text = a(genericNameSyntax.TypeArgumentList.Arguments.First());
				ArgumentSyntax node3 = P_0.ArgumentList.Arguments.Last();
				Visit(node3);
				a(" is " + text + ")");
			}
			if (P_0.ArgumentList.Arguments.Count == 2)
			{
				a("assertTrue (");
				TypeOfExpressionSyntax typeOfExpressionSyntax = P_0.ArgumentList.Arguments.First().Expression as TypeOfExpressionSyntax;
				string text2 = a(typeOfExpressionSyntax.Type);
				ArgumentSyntax node4 = P_0.ArgumentList.Arguments.Last();
				Visit(node4);
				a(" is " + text2 + ")");
			}
		});
		A("Assert.Null", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("assertNull");
			Visit(P_0.ArgumentList);
		});
		A("Assert.NotNull", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("assertNotNull");
			Visit(P_0.ArgumentList);
		});
		A("EventWaitHandle.Set", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			Visit(P_1.Expression);
			a(".countDown()");
		});
		A("Enumerable.Where", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			Visit(P_1.Expression);
			a(".");
			a("filter");
			Visit(P_0.ArgumentList);
		});
		A("Enumerable.Select", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			Visit(P_1.Expression);
			a(".");
			a("map");
			Visit(P_0.ArgumentList);
		});
		A("Enumerable.ToList", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			Visit(P_1.Expression);
			a(".");
			a("toList");
			Visit(P_0.ArgumentList);
		});
		A("Enumerable.ToArray", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			Visit(P_1.Expression);
			a(".");
			a("toTypedArray");
			Visit(P_0.ArgumentList);
		});
		A("Enumerable.Concat", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			ArgumentSyntax node2 = P_0.ArgumentList.Arguments.First();
			a("(");
			Visit(P_1.Expression);
			a(" + ");
			Visit(node2);
			a(")");
		});
		A("Enumerable.Range", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			ArgumentSyntax argumentSyntax = P_0.ArgumentList.Arguments.First();
			ArgumentSyntax node = P_0.ArgumentList.Arguments.Last();
			if (argumentSyntax.Expression is LiteralExpressionSyntax literalExpressionSyntax && literalExpressionSyntax.Token.ValueText == "0")
			{
				a("(");
				Visit(argumentSyntax);
				a(" upto ");
				Visit(node);
				a(")");
			}
			else
			{
				a("(");
				Visit(argumentSyntax);
				a(" upto ");
				Visit(argumentSyntax);
				a("+");
				Visit(node);
				a(")");
			}
		});
		A("Task.FromResult", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			a("Future.value");
			Visit(P_0.ArgumentList);
		});
		A("String.Empty", (Action<InvocationExpressionSyntax, MemberAccessExpressionSyntax>)delegate
		{
			a("\"\"");
		});
		A("ConfigureAwait", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			Visit(P_1.Expression);
		});
		A("Task.ConfigureAwait", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			Visit(P_1.Expression);
		});
		A("Object.GetType", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			Visit(P_1.Expression);
			a(".");
			a("runtimeType");
		});
		A("Object.GetHashCode", delegate(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
		{
			Visit(P_1.Expression);
			a(".");
			a("hashCode");
		});
	}

	private void A(string P_0)
	{
		a(d() + P_0);
	}

	private void B()
	{
		a(d());
	}

	private void a(string P_0)
	{
		StringBuilder stringBuilder = (this.m_A ? this.m_A.Last() : this.m_A);
		a a = this.m_A.Peek();
		switch (a.a())
		{
		case DartTranspilerVisitor.A.A:
			stringBuilder.Append(P_0);
			this.m_a.Append(P_0);
			break;
		case DartTranspilerVisitor.A.a:
		case DartTranspilerVisitor.A.B:
			if (a.A() >= 0 && a.A() < stringBuilder.Length - 1)
			{
				stringBuilder.Insert(a.A(), P_0);
				b(P_0);
			}
			else
			{
				stringBuilder.Append(P_0);
				this.m_a.Append(P_0);
			}
			break;
		}
		if (a.A() > -1)
		{
			int num = a.A();
			foreach (a item in this.m_A)
			{
				if (num <= item.A())
				{
					item.A(item.A() + P_0.Length);
				}
			}
		}
		Console.Write(P_0);
	}

	private void A(bool P_0 = false)
	{
		a("\r\n");
		if (P_0)
		{
			a("\r\n");
		}
		E();
	}

	private void b()
	{
		a(";");
		E();
		Log.LogSeparatorLine();
	}

	private void C()
	{
		a(";\n");
		E();
		Log.LogSeparatorLine();
	}

	private void B(string P_0)
	{
		a(d() + P_0);
		A(false);
	}

	private void c()
	{
		int num = this.m_A.Pop();
		this.m_A.Push(num + 1);
	}

	private void D()
	{
		int num = this.m_A.Pop();
		this.m_A.Push(num - 1);
	}

	private string d()
	{
		return new string(' ', this.m_A.Peek() * 2);
	}

	private void A(bool P_0, string P_1, SyntaxNode P_2, bool P_3 = true)
	{
		if (!P_0)
		{
			return;
		}
		if (P_3)
		{
			A(DartTranspilerVisitor.A.a);
		}
		Log.Warning(LogLevel.Normal, P_1 ?? "Syntax not supported", "WriteTodoIf", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.OutputWriter.cs", 127);
		A(false);
		B("// TODO: " + (P_1 ?? "Syntax not supported"));
		if (P_2 != null)
		{
			B("/*");
			string text = P_2.ToString();
			if (text.Length > 300)
			{
				text = text.Substring(0, 300) + "\n.......................";
			}
			B(text);
			B("*/");
			Log.Warning(LogLevel.Normal, text, "WriteTodoIf", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.OutputWriter.cs", 141);
		}
		if (P_3)
		{
			g();
		}
	}

	private void E()
	{
		Log.Message("Dart: " + this.m_a.ToString(), "LogDartLine", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.OutputWriter.cs", 153);
		this.m_a.Clear();
	}

	private void b(string P_0)
	{
		Log.Message("Dart: " + P_0.ToString(), "LogDartLine", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.OutputWriter.cs", 158);
	}

	private void e()
	{
		StringBuilder item = new StringBuilder();
		this.m_A.Add(item);
		this.m_A.Push(new a());
		this.m_a.Push(0);
		this.m_A.Push(0);
		this.m_A = true;
	}

	private void F()
	{
		this.m_a.Pop();
		this.m_A.Pop();
		this.m_A.Pop();
		this.m_A = false;
	}

	private void f()
	{
		foreach (StringBuilder item in this.m_A)
		{
			this.m_A.Append(item.ToString());
		}
		this.m_A.Clear();
		this.m_A = false;
	}

	private void G()
	{
		if (this.m_a.Count > 0)
		{
			this.m_a.Pop();
		}
		int item = H();
		this.m_a.Push(item);
	}

	private void A(A P_0)
	{
		a obj = new a();
		obj.A(P_0);
		a a = obj;
		this.m_A.Push(a);
		switch (P_0)
		{
		case DartTranspilerVisitor.A.A:
			a.A(-1);
			break;
		case DartTranspilerVisitor.A.a:
			a.A(i());
			break;
		case DartTranspilerVisitor.A.B:
			a.A(0);
			if (h())
			{
				A(false);
			}
			break;
		}
	}

	private void g()
	{
		this.m_A.Pop();
	}

	private int H()
	{
		StringBuilder stringBuilder = (this.m_A ? this.m_A.Last() : this.m_A);
		a a = this.m_A.Peek();
		A a2 = a.a();
		if ((uint)(a2 - 1) <= 1u)
		{
			if (a.A() >= 0 && a.A() < stringBuilder.Length - 1)
			{
				return a.A();
			}
			return stringBuilder.Length;
		}
		return stringBuilder.Length;
	}

	private bool h()
	{
		StringBuilder stringBuilder = (this.m_A ? this.m_A.Last() : this.m_A);
		a a = this.m_A.Peek();
		bool flag = false;
		while (a.A() + 1 < stringBuilder.Length && stringBuilder[a.A()] == '/' && stringBuilder[a.A() + 1] == '/')
		{
			I();
			flag = true;
		}
		bool flag2 = false;
		if (!flag && a.A() + 1 < stringBuilder.Length && stringBuilder[a.A()] == '/' && stringBuilder[a.A() + 1] == '*')
		{
			a.A(a.A() + 2);
			while (a.A() < stringBuilder.Length && (stringBuilder[a.A() - 2] != '*' || stringBuilder[a.A() - 1] != '/'))
			{
				int num = a.A() + 1;
				a.A(num);
			}
			I();
			flag2 = true;
		}
		return flag || flag2;
	}

	private void I()
	{
		StringBuilder stringBuilder = (this.m_A ? this.m_A.Last() : this.m_A);
		a a = this.m_A.Peek();
		while (a.A() < stringBuilder.Length && stringBuilder[a.A()] != '\r' && stringBuilder[a.A()] != '\n')
		{
			int num = a.A() + 1;
			a.A(num);
		}
		if (a.A() != stringBuilder.Length)
		{
			char c = stringBuilder[a.A()];
			int num = a.A() + 1;
			a.A(num);
			if (a.A() < stringBuilder.Length && c == '\r' && stringBuilder[a.A()] == '\n')
			{
				num = a.A() + 1;
				a.A(num);
			}
		}
	}

	private int i()
	{
		if (this.m_A.Count > 0 && this.m_A.Peek().A())
		{
			return this.m_A.Peek().a();
		}
		if (this.m_a.Count <= 0)
		{
			return 0;
		}
		return this.m_a.Peek();
	}

	private void A(SyntaxNode P_0)
	{
		SyntaxKind syntaxKind = P_0.Kind();
		if (syntaxKind != SyntaxKind.SetAccessorDeclaration && syntaxKind != SyntaxKind.GetAccessorDeclaration && P_0.HasLeadingTrivia)
		{
			SyntaxTriviaList leadingTrivia = P_0.GetLeadingTrivia();
			A(leadingTrivia, false, false);
		}
	}

	private void a(SyntaxNode P_0)
	{
		SyntaxKind syntaxKind = P_0.Kind();
		if (syntaxKind != SyntaxKind.SetAccessorDeclaration && syntaxKind != SyntaxKind.GetAccessorDeclaration && P_0.HasTrailingTrivia)
		{
			SyntaxTriviaList trailingTrivia = P_0.GetTrailingTrivia();
			A(trailingTrivia, true, false);
		}
	}

	private void A(SyntaxTriviaList P_0, bool P_1, bool P_2)
	{
		bool flag = P_1 || P_0.Count == 1;
		SyntaxTriviaList.Enumerator enumerator = P_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			SyntaxTrivia current = enumerator.Current;
			switch (current.Kind())
			{
			case SyntaxKind.SingleLineCommentTrivia:
			case SyntaxKind.MultiLineCommentTrivia:
			case SyntaxKind.SingleLineDocumentationCommentTrivia:
			case SyntaxKind.MultiLineDocumentationCommentTrivia:
			{
				string[] array = current.ToFullString().Split(new string[1] { "\r\n" }, StringSplitOptions.None);
				if (array.Length == 0)
				{
					break;
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					string text2 = text.Trim();
					if (text2 == "//" || text2 == "///")
					{
						B(text2);
					}
					else
					{
						text2 = C(text).Trim();
						if (string.IsNullOrEmpty(text) || text2 == "//" || text2 == "///")
						{
							continue;
						}
						B(text2);
					}
					flag = true;
				}
				break;
			}
			case SyntaxKind.EndOfLineTrivia:
				if (!P_2)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						A(false);
					}
				}
				break;
			}
		}
	}

	private static string C(string P_0)
	{
		foreach (KeyValuePair<string, Regex> item in DartTranspilerVisitor.m_A)
		{
			string key = item.Key;
			Regex value = item.Value;
			switch (key)
			{
			case "returnsStart":
				P_0 = value.Replace(P_0, "Returns: ");
				break;
			case "paramStart":
				P_0 = value.Replace(P_0, "[");
				P_0 = Regex.Replace(P_0, "\"\\s*>", "] ", RegexOptions.IgnoreCase);
				break;
			case "remarksStart":
				P_0 = value.Replace(P_0, "Remarks: ");
				break;
			case "seealso":
			{
				Match match2 = value.Match(P_0);
				if (match2.Success)
				{
					string value2 = match2.Groups[1].Value;
					P_0 = value.Replace(P_0, "See also: [" + value2 + "]");
				}
				break;
			}
			case "see":
			{
				MatchCollection matchCollection = value.Matches(P_0);
				for (int i = 0; i < matchCollection.Count; i++)
				{
					Match match3 = matchCollection[i];
					if (match3.Success)
					{
						string value3 = match3.Groups[1].Value;
						P_0 = value.Replace(P_0, "[" + value3 + "]", 1);
					}
				}
				break;
			}
			case "exception":
				P_0 = value.Replace(P_0, "Exception: ");
				break;
			case "docComment":
			{
				Match match = value.Match(P_0);
				if (match.Success)
				{
					string text = match.Groups[2].Value.Trim();
					P_0 = ((!string.IsNullOrWhiteSpace(text)) ? ("/// " + text) : "///");
				}
				break;
			}
			default:
				P_0 = value.Replace(P_0, string.Empty);
				break;
			}
		}
		return P_0;
	}

	private void A(string P_0, Action<ExpressionSyntax> P_1)
	{
		this.m_A.Add(P_0, P_1);
	}

	public void SetupPropertyTranslators()
	{
		A("string.Empty", (Action<ExpressionSyntax>)delegate
		{
			a("\"\"");
		});
	}

	private B J()
	{
		if (this.m_A.Count <= 0)
		{
			return null;
		}
		return this.m_A.Peek();
	}

	private string c(string P_0)
	{
		Dictionary<string, int> dictionary = this.m_A.Peek();
		if (dictionary.ContainsKey(P_0))
		{
			int num = dictionary[P_0];
			return P_0 + (dictionary[P_0] = num + 1).ToString(CultureInfo.InvariantCulture);
		}
		dictionary[P_0] = 0;
		return P_0;
	}

	private string a(TypeSyntax P_0)
	{
		if (P_0.IsVar)
		{
			return "var";
		}
		bool flag = false;
		if (P_0 is NullableTypeSyntax nullableTypeSyntax)
		{
			flag = true;
			P_0 = nullableTypeSyntax.ElementType;
		}
		ITypeSymbol typeSymbol = b(P_0);
		if (typeSymbol != null)
		{
			return A((ISymbol)typeSymbol) + (flag ? "?" : string.Empty);
		}
		return P_0.ToString();
	}

	private string A(ISymbol P_0)
	{
		return A(P_0, true);
	}

	private string A(ISymbol P_0, bool P_1)
	{
		if (P_0 == null)
		{
			return null;
		}
		if (P_0.Kind == SymbolKind.ArrayType)
		{
			IArrayTypeSymbol arrayTypeSymbol = (IArrayTypeSymbol)P_0;
			string text = A((ISymbol)arrayTypeSymbol.ElementType);
			return "List<" + text + ">";
		}
		if (P_0.Kind == SymbolKind.TypeParameter)
		{
			return P_0.Name;
		}
		string text2 = string.Empty;
		if (P_1)
		{
			string[] array = null;
			if (P_0 is INamedTypeSymbol namedTypeSymbol && namedTypeSymbol.IsGenericType)
			{
				array = namedTypeSymbol.TypeArguments.Select(A).ToArray();
			}
			if (P_0 is IMethodSymbol methodSymbol && methodSymbol.IsGenericMethod)
			{
				array = methodSymbol.TypeArguments.Select(A).ToArray();
			}
			if (array != null)
			{
				string text3 = string.Join(", ", array);
				text2 = "<" + text3 + ">";
			}
		}
		string text4 = B(P_0);
		if (!string.IsNullOrEmpty(text4))
		{
			return text4 + text2;
		}
		string text5;
		if (P_0 != null && P_0.Kind == SymbolKind.Method)
		{
			string fullMetadataName = Util.GetFullMetadataName(P_0, includeParameters: true);
			text5 = ((!this.m_A.RenamedMethodNames.ContainsKey(fullMetadataName)) ? Util.ToCamelCase(P_0.Name) : Util.ToCamelCase(this.m_A.RenamedMethodNames[fullMetadataName]));
		}
		else if ((P_0 != null && P_0.Kind == SymbolKind.Property) || (P_0 != null && P_0.Kind == SymbolKind.Event) || (P_0 != null && P_0.Kind == SymbolKind.Field))
		{
			text5 = Util.ToCamelCase(P_0.Name);
		}
		else
		{
			text5 = P_0.Name;
			if (string.IsNullOrEmpty(text5))
			{
				return null;
			}
		}
		string s = text5 + text2;
		if (a(P_0))
		{
			return Util.EnsureUnderscorePrefix(s);
		}
		return Util.EnsureNoUnderscorePrefix(s);
	}

	private static bool a(ISymbol P_0)
	{
		bool result = false;
		if (P_0 is IMethodSymbol methodSymbol && methodSymbol.MethodKind == MethodKind.LocalFunction)
		{
			result = false;
		}
		else
		{
			switch (P_0?.DeclaredAccessibility)
			{
			case Accessibility.Private:
				result = true;
				break;
			case Accessibility.NotApplicable:
				if (P_0.Kind != SymbolKind.Local && P_0.Kind != SymbolKind.Parameter && P_0.Kind != SymbolKind.ErrorType)
				{
					result = true;
				}
				break;
			default:
				result = false;
				break;
			}
		}
		return result;
	}

	private static string B(ISymbol P_0)
	{
		string text = P_0?.Name;
		switch (global::A.F.A(text))
		{
		case 3370340735u:
			if (!(text == "Void"))
			{
				break;
			}
			return "void";
		case 3409549631u:
			if (!(text == "Byte"))
			{
				break;
			}
			return "int";
		case 765439473u:
			if (!(text == "Int16"))
			{
				break;
			}
			return "int";
		case 1323747186u:
			if (!(text == "UInt16"))
			{
				break;
			}
			return "int";
		case 2711245919u:
			if (!(text == "Int32"))
			{
				break;
			}
			return "int";
		case 3538687084u:
			if (!(text == "UInt32"))
			{
				break;
			}
			return "int";
		case 697196164u:
			if (!(text == "Int64"))
			{
				break;
			}
			return "int";
		case 1324880019u:
			if (!(text == "UInt64"))
			{
				break;
			}
			return "int";
		case 2779444460u:
			if (!(text == "Decimal"))
			{
				break;
			}
			return "double";
		case 2386971688u:
			if (!(text == "Double"))
			{
				break;
			}
			return "double";
		case 4051133705u:
			if (!(text == "Single"))
			{
				break;
			}
			return "double";
		case 3969205087u:
			if (!(text == "Boolean"))
			{
				break;
			}
			return "bool";
		case 1615808600u:
			if (!(text == "String"))
			{
				break;
			}
			return "String";
		case 679076413u:
			if (!(text == "Char"))
			{
				break;
			}
			return "String";
		case 3851314394u:
			if (!(text == "Object"))
			{
				break;
			}
			return "Object";
		case 2997815336u:
			if (!(text == "IDictionary"))
			{
				break;
			}
			return "Map";
		case 1221312622u:
			if (!(text == "IReadOnlyDictionary"))
			{
				break;
			}
			return "Map";
		case 1266202965u:
			if (!(text == "Dictionary"))
			{
				break;
			}
			return "Map";
		case 3628503142u:
			if (!(text == "IReadOnlyList"))
			{
				break;
			}
			return "List";
		case 1831964446u:
			if (!(text == "IEnumerable"))
			{
				break;
			}
			return "Iterable";
		case 3747075108u:
			if (!(text == "ObservableCollection"))
			{
				break;
			}
			return "List";
		case 2615964816u:
			if (!(text == "DateTime"))
			{
				break;
			}
			return "DateTime";
		case 425125395u:
			if (!(text == "DateTimeOffset"))
			{
				break;
			}
			return "DateTime";
		case 2417551388u:
			if (!(text == "TimeSpan"))
			{
				break;
			}
			return "Duration";
		case 3751101983u:
			if (!(text == "ArgumentException"))
			{
				break;
			}
			return "ArgumentError";
		case 1995390348u:
			if (!(text == "Task"))
			{
				break;
			}
			return "Future";
		case 3682473599u:
			if (!(text == "TaskCompletionSource"))
			{
				break;
			}
			return "Completer";
		case 175614239u:
			if (!(text == "Action"))
			{
				break;
			}
			return "Function";
		case 518053841u:
			if (!(text == "Tuple"))
			{
				break;
			}
			if (P_0 is INamedTypeSymbol namedTypeSymbol)
			{
				return text + namedTypeSymbol.TypeArguments.Count();
			}
			return text;
		case 1208581836u:
			if (!(text == "IComparable"))
			{
				break;
			}
			return "Comparable";
		case 3543877906u:
			if (!(text == "IFile"))
			{
				break;
			}
			return "File";
		case 2890788112u:
			if (!(text == "IFolder"))
			{
				break;
			}
			return "Directory";
		}
		return null;
	}

	private static string A(BaseTypeDeclarationSyntax P_0)
	{
		string text = P_0.Identifier.Text;
		if (A(P_0.Modifiers, P_0))
		{
			return Util.EnsureUnderscorePrefix(text);
		}
		return Util.EnsureNoUnderscorePrefix(text);
	}

	private static string A(VariableDeclaratorSyntax P_0)
	{
		string text = P_0.Identifier.Text;
		FieldDeclarationSyntax fieldDeclarationSyntax = P_0.Ancestors().OfType<FieldDeclarationSyntax>().FirstOrDefault();
		if (fieldDeclarationSyntax != null)
		{
			text = ((!A(fieldDeclarationSyntax.Modifiers, P_0)) ? Util.EnsureNoUnderscorePrefix(text) : Util.EnsureUnderscorePrefix(text));
		}
		return text;
	}

	private static string A(PropertyDeclarationSyntax P_0)
	{
		string s = Util.ToCamelCase(P_0.Identifier.Text);
		if (A(P_0.Modifiers, P_0))
		{
			return Util.EnsureUnderscorePrefix(s);
		}
		return Util.EnsureNoUnderscorePrefix(s);
	}

	private static bool A(SyntaxTokenList P_0, SyntaxNode P_1)
	{
		if (P_0.Contains("private"))
		{
			return true;
		}
		if (!P_0.Contains("private") && !P_0.Contains("protected") && !P_0.Contains("internal") && !P_0.Contains("public"))
		{
			if (P_1.Ancestors().OfType<ClassDeclarationSyntax>().Any())
			{
				return true;
			}
			if (P_1.Ancestors().OfType<StructDeclarationSyntax>().Any())
			{
				return true;
			}
		}
		return false;
	}

	private ISymbol B(SyntaxNode P_0)
	{
		SymbolInfo symbolInfo = this.m_A.GetSymbolInfo(P_0);
		ISymbol symbol = symbolInfo.Symbol;
		if (symbol == null)
		{
			TypeInfo typeInfo = this.m_A.GetTypeInfo(P_0);
			symbol = typeInfo.Type ?? typeInfo.ConvertedType;
			if (symbol == null && !symbolInfo.CandidateSymbols.IsEmpty)
			{
				if (P_0 is InvocationExpressionSyntax invocationExpressionSyntax)
				{
					int A = invocationExpressionSyntax.ArgumentList?.Arguments.Count ?? 0;
					symbol = symbolInfo.CandidateSymbols.OfType<IMethodSymbol>().FirstOrDefault((IMethodSymbol P_0) => P_0.Parameters.Count() == A);
				}
				if (symbol == null)
				{
					symbol = symbolInfo.CandidateSymbols.FirstOrDefault();
				}
			}
		}
		if (symbol != null)
		{
			b(symbol);
		}
		return symbol;
	}

	private ITypeSymbol b(SyntaxNode P_0)
	{
		TypeInfo typeInfo = this.m_A.GetTypeInfo(P_0);
		if (typeInfo.Type != null)
		{
			b(typeInfo.Type);
			return typeInfo.Type;
		}
		ISymbol symbol = this.m_A.GetSymbolInfo(P_0).Symbol;
		if (symbol != null)
		{
			b(symbol);
			return symbol as ITypeSymbol;
		}
		Log.Warning(LogLevel.Normal, "Could not find ITypeSymbol, node: " + P_0.ToString(), "GetTypeSymbol", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.SymbolProvider.cs", 68);
		return null;
	}

	private void b(ISymbol P_0)
	{
		if (P_0 is ITypeSymbol)
		{
			ImmutableArray<Location>.Enumerator enumerator = P_0.Locations.GetEnumerator();
			while (enumerator.MoveNext())
			{
				Location current = enumerator.Current;
				if (current.Kind == LocationKind.SourceFile)
				{
					string text = current.SourceTree?.FilePath;
					if (text != null)
					{
						this.m_A.A().Add(text);
					}
				}
			}
		}
		else
		{
			Log.Message("Ignored: " + P_0.Kind, "UpdateReferencedSourceFiles", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.SymbolProvider.cs", 91);
		}
	}

	public static string TranslateReferenceVariableName(string variableName)
	{
		return variableName + "Ref";
	}

	private static bool A(FieldDeclarationSyntax P_0)
	{
		return P_0.Modifiers.Any((SyntaxToken P_0) => P_0.Text == "readonly" || P_0.Text == "const");
	}

	private bool A(MethodDeclarationSyntax P_0)
	{
		IMethodSymbol A = this.m_A.GetDeclaredSymbol(P_0);
		return A.ContainingType.AllInterfaces.SelectMany([return: global::A.B(new byte[] { 1, 0 })] (INamedTypeSymbol P_0) => P_0.GetMembers().OfType<IMethodSymbol>()).Any((IMethodSymbol P_0) => A.Equals(A.ContainingType.FindImplementationForInterfaceMember(P_0)));
	}

	private bool a(PropertyDeclarationSyntax P_0)
	{
		IPropertySymbol A = this.m_A.GetDeclaredSymbol(P_0);
		return A.ContainingType.AllInterfaces.SelectMany([return: global::A.B(new byte[] { 1, 0 })] (INamedTypeSymbol P_0) => P_0.GetMembers().OfType<IPropertySymbol>()).Any((IPropertySymbol P_0) => A.Equals(A.ContainingType.FindImplementationForInterfaceMember(P_0)));
	}

	private void A<A>(IEnumerable<A> P_0, Action<A> P_1, string P_2 = ", ")
	{
		bool flag = true;
		foreach (A item in P_0)
		{
			if (flag)
			{
				flag = false;
			}
			else
			{
				a(P_2);
			}
			P_1(item);
		}
	}

	private string D(string P_0)
	{
		return (from P_0 in this.m_A.ProjectNamesByProjectFolderPath.Keys.Where(delegate(string P_0)
			{
				string text = P_0;
				return text != null && text.IndexOf(P_0, StringComparison.InvariantCultureIgnoreCase) == 0;
			})
			orderby P_0.Length descending
			select P_0).FirstOrDefault();
	}

	public override void VisitNamespaceDeclaration(NamespaceDeclarationSyntax node)
	{
		Log.Node(node, "VisitNamespaceDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 17);
		SyntaxList<MemberDeclarationSyntax>.Enumerator enumerator = node.Members.GetEnumerator();
		while (enumerator.MoveNext())
		{
			MemberDeclarationSyntax current = enumerator.Current;
			Visit(current);
		}
		Log.Message("OUT", "VisitNamespaceDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 24);
	}

	public override void VisitUsingDirective(UsingDirectiveSyntax node)
	{
	}

	public override void VisitNameEquals(NameEqualsSyntax node)
	{
		base.VisitNameEquals(node);
	}

	public override void VisitAliasQualifiedName(AliasQualifiedNameSyntax node)
	{
		base.VisitAliasQualifiedName(node);
	}

	public override void VisitStructDeclaration(StructDeclarationSyntax node)
	{
		Log.Node(node, "VisitStructDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 44);
		A(node);
		Log.Message("OUT", "VisitStructDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 48);
	}

	public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
	{
		Log.Node(node, "VisitInterfaceDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 53);
		A(node);
		Log.Message("OUT", "VisitInterfaceDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 57);
	}

	public override void VisitExplicitInterfaceSpecifier(ExplicitInterfaceSpecifierSyntax node)
	{
		base.VisitExplicitInterfaceSpecifier(node);
	}

	public override void VisitClassDeclaration(ClassDeclarationSyntax node)
	{
		Log.Node(node, "VisitClassDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 67);
		A(node);
		Log.Message("OUT", "VisitClassDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 71);
	}

	public override void VisitBaseList(BaseListSyntax node)
	{
		base.VisitBaseList(node);
	}

	public override void VisitSimpleBaseType(SimpleBaseTypeSyntax node)
	{
		base.VisitSimpleBaseType(node);
	}

	public override void VisitClassOrStructConstraint(ClassOrStructConstraintSyntax node)
	{
		base.VisitClassOrStructConstraint(node);
	}

	public override void VisitConstructorDeclaration(ConstructorDeclarationSyntax node)
	{
		Log.Message(LogLevel.Normal, "Constructor: " + node.Identifier.Text, "VisitConstructorDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 91);
		Log.Node(node, "VisitConstructorDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 93);
		this.m_A.Push(new B());
		this.m_A.Push(new Dictionary<string, int>());
		string text = ((!(node.Parent is TypeDeclarationSyntax typeDeclarationSyntax)) ? node.Identifier.Text : A((BaseTypeDeclarationSyntax)typeDeclarationSyntax));
		A(text);
		VisitParameterList(node.ParameterList);
		if (node.Body != null)
		{
			Visit(node.Body);
		}
		else
		{
			Visit(node.ExpressionBody);
			A(false);
		}
		this.m_A.Pop();
		this.m_A.Pop();
		Log.Message("OUT", "VisitConstructorDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 132);
	}

	public override void VisitConstructorInitializer(ConstructorInitializerSyntax node)
	{
		Log.Node(node, "VisitConstructorInitializer", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 136);
		base.VisitConstructorInitializer(node);
	}

	public override void VisitConstructorConstraint(ConstructorConstraintSyntax node)
	{
		base.VisitConstructorConstraint(node);
	}

	public override void VisitDestructorDeclaration(DestructorDeclarationSyntax node)
	{
		Log.Message(LogLevel.Normal, "Destructor: " + node.Identifier.Text, "VisitDestructorDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 147);
		Log.Node(node, "VisitDestructorDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 149);
		this.m_A.Push(new B());
		this.m_A.Push(new Dictionary<string, int>());
		A("void ");
		string text = "destroy" + node.Identifier;
		a(text);
		base.VisitDestructorDeclaration(node);
		this.m_A.Pop();
		this.m_A.Pop();
	}

	public override void VisitEnumDeclaration(EnumDeclarationSyntax node)
	{
		Log.Message(LogLevel.Normal, "Enum: " + node.Identifier.Text, "VisitEnumDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 171);
		Log.Node(node, "VisitEnumDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 173);
		if (node.Parent is ClassDeclarationSyntax)
		{
			e();
		}
		if (node.BaseList != null)
		{
			Log.Warning(LogLevel.Normal, "Underlying enum type cannot be declared, enum:", node.Identifier.Text, "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 182);
		}
		A(node);
		if (node.Parent is ClassDeclarationSyntax)
		{
			F();
		}
		Log.Message("OUT", "VisitEnumDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 193);
	}

	private void A(EnumDeclarationSyntax P_0)
	{
		A(false);
		string text = A((BaseTypeDeclarationSyntax)P_0);
		B("class " + text + " {");
		c();
		B("final int value;");
		B("final String name;");
		B("const " + text + "._(this.value, this.name);");
		A(false);
		int result = 0;
		List<string> list = new List<string>();
		SeparatedSyntaxList<EnumMemberDeclarationSyntax>.Enumerator enumerator = P_0.Members.GetEnumerator();
		while (enumerator.MoveNext())
		{
			EnumMemberDeclarationSyntax current = enumerator.Current;
			if (current.HasLeadingTrivia)
			{
				A(current.GetLeadingTrivia(), false, true);
			}
			string text2 = Util.ToCamelCase(current.Identifier.Text);
			list.Add(text2);
			if (current.EqualsValue != null)
			{
				A($"static const {text2} = const {text}._(");
				Visit(current.EqualsValue.Value);
				int.TryParse(current.EqualsValue.Value.ToString(), out result);
				a(", '" + text2 + "');");
				A(false);
			}
			else
			{
				B($"static const {text2} = const {text}._({result}, '{text2}');");
			}
			result++;
		}
		A(false);
		B("static const List<" + text + "> values = [");
		c();
		foreach (string item in list)
		{
			B(item + ",");
		}
		D();
		B("];");
		if (P_0.AttributeLists.Any((AttributeListSyntax P_0) => P_0.Attributes.Any((AttributeSyntax P_0) => P_0.Name.ToString() == "Flags")))
		{
			A(false);
			B($"{text} operator |({text} other) => {text}._(value | other.value, name + ' | ' + other.name);");
			B($"{text} operator &({text} other) => {text}._(value & other.value, name + ' & ' + other.name);");
		}
		A(false);
		B("@override");
		B("String toString() => '" + text + "' + '.' + name;");
		A(false);
		D();
		B("}");
	}

	public override void VisitFieldDeclaration(FieldDeclarationSyntax node)
	{
		Log.Node(node, "VisitFieldDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 272);
		SeparatedSyntaxList<VariableDeclaratorSyntax>.Enumerator enumerator = node.Declaration.Variables.GetEnumerator();
		while (enumerator.MoveNext())
		{
			VariableDeclaratorSyntax current = enumerator.Current;
			A(current, false);
		}
		Log.Message("OUT", "VisitFieldDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 279);
	}

	private void A(VariableDeclaratorSyntax P_0, bool P_1)
	{
		FieldDeclarationSyntax fieldDeclarationSyntax = P_0.Ancestors().OfType<FieldDeclarationSyntax>().First();
		B();
		string text = P_0.Identifier.Text;
		bool flag = this.m_A.Peek().A.ContainsKey(text);
		string text2 = a(fieldDeclarationSyntax.Declaration.Type);
		C(P_0);
		bool flag2 = A(fieldDeclarationSyntax);
		if (!P_1)
		{
			a(fieldDeclarationSyntax.Modifiers);
		}
		string text3 = A(P_0);
		string text4 = A(fieldDeclarationSyntax.Declaration.Type);
		bool flag3 = P_0.Initializer == null && !flag2;
		if (P_0.Initializer != null)
		{
			if (!P_1)
			{
				if (flag2)
				{
					a("final ");
				}
				a(text2 + " " + text3);
				if (!flag)
				{
					a(" = ");
					Visit(P_0.Initializer.Value);
				}
			}
			else
			{
				a(text3 + " = ");
				Visit(P_0.Initializer.Value);
			}
		}
		else if (text4 != null && text4 != "null")
		{
			if (flag2)
			{
				a("final ");
			}
			a($"{text2} {text3} = {text4}");
		}
		else if (flag3)
		{
			a(text2 + "? " + text3);
		}
		else
		{
			a(text2 + " " + text3);
		}
		C();
	}

	public override void VisitPropertyDeclaration(PropertyDeclarationSyntax node)
	{
		Log.Message(LogLevel.Normal, "Property: " + node.Identifier.Text, "VisitPropertyDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 350);
		Log.Node(node, "VisitPropertyDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 352);
		this.m_A.Push(new B());
		try
		{
			string text = node.Identifier.Text;
			bool flag = this.m_A.Peek().A.ContainsKey(text);
			string text2 = A(node);
			string text3 = a(node.Type);
			Action action = delegate
			{
				a(string.Empty);
			};
			if (a(node))
			{
				action = delegate
				{
					a("@override");
					A(false);
					B();
				};
			}
			if (node.AccessorList != null)
			{
				AccessorDeclarationSyntax accessorDeclarationSyntax = node.AccessorList.Accessors.FirstOrDefault((AccessorDeclarationSyntax P_0) => P_0.Keyword.Text == "get");
				AccessorDeclarationSyntax accessorDeclarationSyntax2 = node.AccessorList.Accessors.FirstOrDefault((AccessorDeclarationSyntax P_0) => P_0.Keyword.Text == "set");
				if (accessorDeclarationSyntax != null)
				{
					if (accessorDeclarationSyntax.HasLeadingTrivia)
					{
						A(accessorDeclarationSyntax.GetLeadingTrivia(), false, true);
					}
					B();
					action();
					a(node.Modifiers);
					if (accessorDeclarationSyntax.Body == null && accessorDeclarationSyntax.ExpressionBody == null)
					{
						a(text3 + " " + text2);
						if (node.Initializer == null)
						{
							string text4 = A(node.Type);
							if (!string.IsNullOrEmpty(text4))
							{
								a(" = " + text4);
							}
						}
						else if (!flag)
						{
							Visit(node.Initializer);
						}
						C();
						return;
					}
					a(text3 + " get " + text2);
					Visit(accessorDeclarationSyntax);
					A(false);
					if (accessorDeclarationSyntax.HasTrailingTrivia)
					{
						A(accessorDeclarationSyntax.GetTrailingTrivia(), true, false);
					}
				}
				if (accessorDeclarationSyntax2 != null)
				{
					this.m_A.Push(new B());
					try
					{
						if (accessorDeclarationSyntax2.HasLeadingTrivia)
						{
							A(accessorDeclarationSyntax2.GetLeadingTrivia(), false, true);
						}
						B();
						action();
						a(node.Modifiers);
						if (accessorDeclarationSyntax2.Body == null && accessorDeclarationSyntax2.ExpressionBody == null)
						{
							a(text3 + " " + text2);
							C();
							return;
						}
						a($"set {text2}({text3} value)");
						Visit(accessorDeclarationSyntax2);
						A(false);
						if (accessorDeclarationSyntax2.HasTrailingTrivia)
						{
							A(accessorDeclarationSyntax2.GetTrailingTrivia(), true, false);
						}
					}
					finally
					{
						this.m_A.Pop();
					}
				}
			}
			else
			{
				B();
				action();
				a(node.Modifiers);
				a(text3 + " get " + text2);
			}
			if (node.Initializer != null)
			{
				a(" = ");
				Visit(node.Initializer.Value);
				C();
			}
			if (node.ExpressionBody != null)
			{
				VisitArrowExpressionClause(node.ExpressionBody);
			}
		}
		finally
		{
			this.m_A.Pop();
		}
		Log.Message("OUT", "VisitPropertyDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 482);
	}

	public override void VisitAccessorList(AccessorListSyntax node)
	{
		base.VisitAccessorList(node);
	}

	public override void VisitEventFieldDeclaration(EventFieldDeclarationSyntax node)
	{
		Log.Node(node, "VisitEventFieldDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 493);
		SeparatedSyntaxList<VariableDeclaratorSyntax>.Enumerator enumerator = node.Declaration.Variables.GetEnumerator();
		while (enumerator.MoveNext())
		{
			VariableDeclaratorSyntax current = enumerator.Current;
			string value;
			if (node.Declaration.Type is GenericNameSyntax genericNameSyntax)
			{
				TypeSyntax typeSyntax = genericNameSyntax.TypeArgumentList.Arguments[0];
				value = a(typeSyntax);
			}
			else
			{
				value = "Object";
			}
			B();
			a(node.Modifiers);
			bool flag = A(node.Modifiers, node);
			if (node.Parent is InterfaceDeclarationSyntax)
			{
				flag = false;
			}
			string s = Util.ToCamelCase(current.Identifier.Text);
			s = ((!flag) ? Util.EnsureNoUnderscorePrefix(s) : Util.EnsureUnderscorePrefix(s));
			a($"Event<{value}> {s} = new Event<{value}>()");
			C();
		}
		Log.Message("OUT", "VisitEventFieldDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 536);
	}

	public override void VisitEventDeclaration(EventDeclarationSyntax node)
	{
		Log.Node(node, "VisitEventDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 541);
		A(true, null, node, false);
		Log.Message("OUT", "VisitEventDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 545);
	}

	public override void VisitDelegateDeclaration(DelegateDeclarationSyntax node)
	{
		Log.Message(LogLevel.Normal, "Delegate: " + node.Identifier.Text, "VisitDelegateDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 550);
		Log.Node(node, "VisitDelegateDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 552);
		string text = node.Identifier.Text;
		string text2 = a(node.ReturnType);
		text = ((!A(node.Modifiers, node)) ? Util.EnsureNoUnderscorePrefix(text) : Util.EnsureUnderscorePrefix(text));
		if (node.Parent is ClassDeclarationSyntax)
		{
			e();
		}
		a("typedef " + text2 + " " + text);
		Visit(node.ParameterList);
		C();
		if (node.Parent is ClassDeclarationSyntax)
		{
			F();
		}
		Log.Message("OUT", "VisitDelegateDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 582);
	}

	public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
	{
		Log.Message(LogLevel.Normal, "Method: " + node.Identifier.Text, "VisitMethodDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 588);
		Log.Node(node, "VisitMethodDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 590);
		this.m_A.Push(new B());
		this.m_A.Push(new Dictionary<string, int>());
		B();
		bool flag = node.Identifier.Text == "GetHashCode";
		if (A(node) || flag)
		{
			a("@override");
			A(false);
			B();
		}
		if (flag)
		{
			a("int get hashCode");
		}
		else
		{
			a(node.Modifiers);
			string text = a(node.ReturnType);
			IMethodSymbol declaredSymbol = this.m_A.GetDeclaredSymbol(node);
			string text2 = A(declaredSymbol, false);
			if (string.IsNullOrEmpty(text2))
			{
				text2 = "<UnknownMethod>";
				Log.Warning(LogLevel.Normal, "Unknown identifier: " + node.ToString(), "VisitMethodDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 628);
			}
			a(text + " " + text2);
			if (node.TypeParameterList != null)
			{
				Visit(node.TypeParameterList);
			}
			Visit(node.ParameterList);
			if (node.Modifiers.Contains("async"))
			{
				a(" async");
			}
		}
		if (node.Body != null)
		{
			Visit(node.Body);
			Log.LogSeparatorLine();
		}
		else if (node.ExpressionBody != null)
		{
			Visit(node.ExpressionBody);
			A(false);
			Log.LogSeparatorLine();
		}
		else
		{
			C();
		}
		this.m_A.Pop();
		this.m_A.Pop();
		Log.Message("OUT", "VisitMethodDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 670);
	}

	public override void VisitVariableDeclaration(VariableDeclarationSyntax node)
	{
		Log.Node(node, "VisitVariableDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 675);
		bool flag = node.Parent is ForStatementSyntax;
		string text = a(node.Type);
		if (flag)
		{
			a(text + " ");
		}
		else
		{
			A(text + " ");
		}
		bool flag2 = true;
		SeparatedSyntaxList<VariableDeclaratorSyntax>.Enumerator enumerator = node.Variables.GetEnumerator();
		while (enumerator.MoveNext())
		{
			VariableDeclaratorSyntax current = enumerator.Current;
			if (!flag2)
			{
				a(", ");
			}
			flag2 = false;
			a($"{current.Identifier}");
			if (current.Initializer != null)
			{
				Visit(current.Initializer);
				continue;
			}
			string text2 = A(node.Type);
			if (text2 != null && text2 != "null")
			{
				a(" = " + text2);
			}
		}
		if (flag)
		{
			a("; ");
		}
		else
		{
			C();
		}
		Log.Message("OUT", "VisitVariableDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 723);
	}

	public override void VisitVariableDeclarator(VariableDeclaratorSyntax node)
	{
		base.VisitVariableDeclarator(node);
	}

	public override void VisitConversionOperatorDeclaration(ConversionOperatorDeclarationSyntax node)
	{
		Log.Node(node, "VisitConversionOperatorDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 736);
		A(true, null, node, false);
		Log.Message("OUT", "VisitConversionOperatorDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 740);
	}

	public override void VisitOperatorDeclaration(OperatorDeclarationSyntax node)
	{
		Log.Message(LogLevel.Normal, "Operator: " + node.OperatorToken.Text, "VisitOperatorDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 745);
		Log.Node(node, "VisitOperatorDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 747);
		string key = node.ParameterList.Parameters.FirstOrDefault()?.Identifier.Text;
		this.m_A = new KeyValuePair<string, string>(key, "this");
		string text = a(node.ReturnType);
		string text2 = node.OperatorToken.Text;
		A(text + " operator " + text2);
		Visit(node.ParameterList);
		if (node.Body != null)
		{
			Visit(node.Body);
		}
		if (node.ExpressionBody != null)
		{
			Visit(node.ExpressionBody);
		}
		this.m_A = null;
		Log.Message("OUT", "VisitOperatorDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 770);
	}

	public override void VisitAccessorDeclaration(AccessorDeclarationSyntax node)
	{
		base.VisitAccessorDeclaration(node);
	}

	public override void VisitIndexerDeclaration(IndexerDeclarationSyntax node)
	{
		string text = a(node.Type);
		if (node.ExpressionBody != null)
		{
			A(text + " operator []");
			Visit(node.ParameterList);
			Visit(node.ExpressionBody);
			A(false);
		}
		if (node.AccessorList == null)
		{
			return;
		}
		AccessorDeclarationSyntax accessorDeclarationSyntax = node.AccessorList.Accessors.FirstOrDefault((AccessorDeclarationSyntax P_0) => P_0.Keyword.Text == "get");
		AccessorDeclarationSyntax accessorDeclarationSyntax2 = node.AccessorList.Accessors.FirstOrDefault((AccessorDeclarationSyntax P_0) => P_0.Keyword.Text == "set");
		if (accessorDeclarationSyntax != null)
		{
			A(text + " operator []");
			Visit(node.ParameterList);
			if (accessorDeclarationSyntax.Body != null)
			{
				Visit(accessorDeclarationSyntax.Body);
			}
			if (accessorDeclarationSyntax.ExpressionBody != null)
			{
				Visit(accessorDeclarationSyntax.ExpressionBody);
			}
			A(false);
		}
		if (accessorDeclarationSyntax2 != null)
		{
			A("operator []=");
			this.m_B = text + " value";
			Visit(node.ParameterList);
			if (accessorDeclarationSyntax2.Body != null)
			{
				Visit(accessorDeclarationSyntax2.Body);
			}
			if (accessorDeclarationSyntax2.ExpressionBody != null)
			{
				Visit(accessorDeclarationSyntax2.ExpressionBody);
			}
			A(false);
		}
	}

	public override void VisitAnonymousObjectMemberDeclarator(AnonymousObjectMemberDeclaratorSyntax node)
	{
	}

	public override void VisitTypeConstraint(TypeConstraintSyntax node)
	{
		base.VisitTypeConstraint(node);
	}

	public override void VisitAttribute(AttributeSyntax node)
	{
	}

	public override void VisitAttributeArgument(AttributeArgumentSyntax node)
	{
	}

	public override void VisitAttributeList(AttributeListSyntax node)
	{
	}

	public override void VisitAttributeTargetSpecifier(AttributeTargetSpecifierSyntax node)
	{
	}

	public override void VisitAttributeArgumentList(AttributeArgumentListSyntax node)
	{
	}

	public override void VisitExternAliasDirective(ExternAliasDirectiveSyntax node)
	{
		base.VisitExternAliasDirective(node);
	}

	public override void VisitIncompleteMember(IncompleteMemberSyntax node)
	{
		base.VisitIncompleteMember(node);
	}

	private void A(TypeDeclarationSyntax P_0)
	{
		string text = A((BaseTypeDeclarationSyntax)P_0);
		Log.Message(LogLevel.Normal, "Class: " + text, "WriteClass", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 885);
		C c = new C();
		this.m_A.Push(c);
		A(P_0, c);
		this.m_A.Push(new Dictionary<string, int>());
		if (P_0.Parent is ClassDeclarationSyntax)
		{
			e();
		}
		if (P_0.Kind() == SyntaxKind.InterfaceDeclaration)
		{
			a("abstract ");
		}
		else
		{
			A(P_0.Modifiers);
		}
		a("class " + text);
		if (P_0.TypeParameterList != null)
		{
			Visit(P_0.TypeParameterList);
		}
		if (P_0.BaseList != null)
		{
			SeparatedSyntaxList<BaseTypeSyntax> types = P_0.BaseList.Types;
			BaseTypeSyntax baseTypeSyntax = null;
			List<BaseTypeSyntax> list = new List<BaseTypeSyntax>();
			SeparatedSyntaxList<BaseTypeSyntax>.Enumerator enumerator = types.GetEnumerator();
			while (enumerator.MoveNext())
			{
				BaseTypeSyntax current = enumerator.Current;
				ITypeSymbol typeSymbol = b(current.Type);
				string text2 = a(current.Type);
				if ((typeSymbol != null && typeSymbol.IsAbstract) || (text2.StartsWith("I", StringComparison.InvariantCulture) && text2.Length > 2 && char.ToUpperInvariant(text2[1]) == text2[1] && char.ToLowerInvariant(text2[2]) == text2[2]))
				{
					list.Add(current);
					continue;
				}
				Log.Warning(LogLevel.Normal, "class " + text + ": there can be only one base class", "WriteClass", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitDeclaration.cs", 940);
				if (baseTypeSyntax != null)
				{
					list.Add(current);
				}
				else
				{
					baseTypeSyntax = current;
				}
			}
			if (baseTypeSyntax != null)
			{
				a(" extends ");
				Visit(baseTypeSyntax.Type);
			}
			if (list.Count > 0)
			{
				a(" implements ");
				bool flag = true;
				foreach (BaseTypeSyntax item in list)
				{
					if (!flag)
					{
						a(", ");
					}
					else
					{
						flag = false;
					}
					Visit(item.Type);
				}
			}
		}
		a(" {");
		A(false);
		this.c();
		if (c.A.Count > 0 || c.A.Count > 0)
		{
			if (!P_0.DescendantNodes().OfType<ConstructorDeclarationSyntax>().Any())
			{
				A(text + "() {");
				A(false);
				this.c();
				A("_initializeFields();");
				A(false);
				D();
				A("}");
				A(true);
			}
			j();
		}
		foreach (MemberDeclarationSyntax item2 in P_0.Members.ToList())
		{
			Visit(item2);
		}
		D();
		B("}");
		this.m_A.Pop();
		this.m_A.Pop();
		if (P_0.Parent is ClassDeclarationSyntax)
		{
			F();
		}
		else
		{
			f();
		}
	}

	private static void A(TypeDeclarationSyntax P_0, C P_1)
	{
		P_1.A = P_0.DescendantNodes().OfType<VariableDeclaratorSyntax>().Where(delegate(VariableDeclaratorSyntax P_0)
		{
			if (P_0.Ancestors().OfType<FieldDeclarationSyntax>().Any())
			{
				ExpressionSyntax expressionSyntax2 = P_0.Initializer?.Value;
				ObjectCreationExpressionSyntax A2 = expressionSyntax2 as ObjectCreationExpressionSyntax;
				if (A2 != null)
				{
					InitializerExpressionSyntax? initializer2 = A2.Initializer;
					if (initializer2 == null || initializer2.Kind() != SyntaxKind.ObjectInitializerExpression || A2.Type.Kind() == SyntaxKind.GenericName)
					{
						return A2.DescendantNodes().OfType<InitializerExpressionSyntax>().Any((InitializerExpressionSyntax P_0) => P_0.Expressions.Any((ExpressionSyntax P_0) => P_0 is ObjectCreationExpressionSyntax objectCreationExpressionSyntax4 && objectCreationExpressionSyntax4.Initializer != null) || A2.DescendantNodes().OfType<AssignmentExpressionSyntax>().Any((AssignmentExpressionSyntax P_0) => P_0.Right is ObjectCreationExpressionSyntax objectCreationExpressionSyntax3 && objectCreationExpressionSyntax3.Initializer != null));
					}
					return true;
				}
			}
			return false;
		})
			.ToDictionary((VariableDeclaratorSyntax P_0) => P_0.Identifier.Text);
		P_1.A = P_0.DescendantNodes().OfType<PropertyDeclarationSyntax>().Where(delegate(PropertyDeclarationSyntax P_0)
		{
			ExpressionSyntax expressionSyntax = P_0.Initializer?.Value;
			ObjectCreationExpressionSyntax A = expressionSyntax as ObjectCreationExpressionSyntax;
			if (A != null)
			{
				InitializerExpressionSyntax? initializer = A.Initializer;
				if (initializer == null || initializer.Kind() != SyntaxKind.ObjectInitializerExpression || A.Type.Kind() == SyntaxKind.GenericName)
				{
					return A.DescendantNodes().OfType<InitializerExpressionSyntax>().Any((InitializerExpressionSyntax P_0) => P_0.Expressions.Any((ExpressionSyntax P_0) => P_0 is ObjectCreationExpressionSyntax objectCreationExpressionSyntax2 && objectCreationExpressionSyntax2.Initializer != null) || A.DescendantNodes().OfType<AssignmentExpressionSyntax>().Any((AssignmentExpressionSyntax P_0) => P_0.Right is ObjectCreationExpressionSyntax objectCreationExpressionSyntax && objectCreationExpressionSyntax.Initializer != null));
				}
				return true;
			}
			return false;
		})
			.ToDictionary((PropertyDeclarationSyntax P_0) => P_0.Identifier.Text);
	}

	private void A(SyntaxTokenList P_0)
	{
		B();
		if (P_0.Contains("abstract"))
		{
			a("abstract ");
		}
	}

	private void a(SyntaxTokenList P_0)
	{
		if (P_0.Contains("static"))
		{
			a("static ");
		}
	}

	private void j()
	{
		A("void _initializeFields() {");
		A(false);
		this.c();
		C c = this.m_A.Peek();
		foreach (KeyValuePair<string, VariableDeclaratorSyntax> item in c.A)
		{
			string text = A(item.Value);
			bool num = item.Value.Ancestors().OfType<FieldDeclarationSyntax>().FirstOrDefault()?.Modifiers.Contains("static") ?? false;
			A(false);
			A("// initialize " + text);
			A(false);
			if (num)
			{
				B("if (" + text + " == null) {");
				G();
				this.c();
			}
			else
			{
				G();
			}
			A(item.Value, true);
			if (num)
			{
				D();
				B("}");
			}
		}
		foreach (KeyValuePair<string, PropertyDeclarationSyntax> item2 in c.A)
		{
			string text2 = A(item2.Value);
			bool num2 = item2.Value.Modifiers.Contains("static");
			A(false);
			A("// initialize " + text2);
			A(false);
			if (num2)
			{
				B("if (" + text2 + " == null) {");
				G();
				this.c();
			}
			else
			{
				G();
			}
			A(text2);
			Visit(item2.Value.Initializer);
			C();
			if (num2)
			{
				D();
				B("}");
			}
		}
		D();
		A("}");
		A(true);
	}

	private bool C(SyntaxNode P_0)
	{
		ISymbol declaredSymbol = this.m_A.GetDeclaredSymbol(P_0);
		return this.m_A.ContainsKey(declaredSymbol);
	}

	public override void VisitExpressionStatement(ExpressionStatementSyntax node)
	{
		Log.Node(node, "VisitExpressionStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 16);
		B();
		bool flag = false;
		if (node.Expression is AssignmentExpressionSyntax assignmentExpressionSyntax)
		{
			SyntaxKind syntaxKind = assignmentExpressionSyntax.Kind();
			if (syntaxKind == SyntaxKind.AddAssignmentExpression || syntaxKind == SyntaxKind.SubtractAssignmentExpression)
			{
				ITypeSymbol typeSymbol = b(assignmentExpressionSyntax.Left);
				ISymbol symbol = B(assignmentExpressionSyntax.Right);
				if (typeSymbol?.Name == "EventHandler" || (symbol != null && symbol.Kind == SymbolKind.Method))
				{
					if (syntaxKind == SyntaxKind.AddAssignmentExpression)
					{
						Visit(assignmentExpressionSyntax.Left);
						a(".addListener(this, ");
						Visit(assignmentExpressionSyntax.Right);
						a(")");
					}
					else
					{
						Visit(assignmentExpressionSyntax.Left);
						a(".removeListener(this)");
					}
					flag = true;
				}
			}
		}
		else if (node.Expression is ObjectCreationExpressionSyntax)
		{
			string text = c("temp");
			a("var " + text + " = ");
			this.m_A = text;
			this.m_a = text;
			base.VisitExpressionStatement(node);
			this.m_a = null;
			flag = true;
		}
		if (!flag)
		{
			base.VisitExpressionStatement(node);
		}
		C();
		Log.Message("OUT", "VisitExpressionStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 74);
	}

	public override void VisitInvocationExpression(InvocationExpressionSyntax node)
	{
		Log.Node(node, "VisitInvocationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 80);
		List<ArgumentSyntax> list = node.ArgumentList.Arguments.Where((ArgumentSyntax P_0) => P_0.RefKindKeyword.Kind() != SyntaxKind.None).ToList();
		if (list.Any())
		{
			A(DartTranspilerVisitor.A.a);
			foreach (ArgumentSyntax item2 in list)
			{
				string text = ((!(item2.Expression is DeclarationExpressionSyntax declarationExpressionSyntax)) ? item2.Expression.ToString() : declarationExpressionSyntax.Designation.ToString());
				string text2 = c(TranslateReferenceVariableName(text));
				B obj = J();
				if (obj != null && obj.a().Contains(text))
				{
					text += ".value";
				}
				if (item2.Expression is DeclarationExpressionSyntax declarationExpressionSyntax2)
				{
					string text3 = A(declarationExpressionSyntax2.Type);
					if (text3 == null)
					{
						A("var " + text);
					}
					else
					{
						A("var " + text + " = " + text3);
					}
					C();
				}
				A($"var {text2} = RefParam({text})");
				b();
				A(false);
				string item = text + " = " + text2 + ".value";
				obj?.A().Add(item);
			}
			g();
		}
		ExpressionSyntax expression = node.Expression;
		if (!(expression is MemberAccessExpressionSyntax memberAccessExpressionSyntax))
		{
			if (!(expression is IdentifierNameSyntax))
			{
				if (!(expression is MemberBindingExpressionSyntax memberBindingExpressionSyntax))
				{
					if (!(expression is GenericNameSyntax node2))
					{
						if (expression is InvocationExpressionSyntax node3)
						{
							VisitInvocationExpression(node3);
							if (node.ArgumentList != null)
							{
								Visit(node.ArgumentList);
							}
						}
						else
						{
							A(true, null, node);
						}
					}
					else
					{
						VisitGenericName(node2);
						if (node.ArgumentList != null)
						{
							Visit(node.ArgumentList);
						}
					}
				}
				else
				{
					if (memberBindingExpressionSyntax.Name.Identifier.Text == "Invoke")
					{
						a("emit");
					}
					else
					{
						Visit(node.Expression);
					}
					if (node.ArgumentList != null)
					{
						Visit(node.ArgumentList);
					}
				}
			}
			else
			{
				bool num = b(node.Expression)?.Name == "EventHandler";
				Visit(node.Expression);
				if (num)
				{
					a(".emit");
				}
				if (node.ArgumentList != null)
				{
					Visit(node.ArgumentList);
				}
			}
			return;
		}
		string obj2 = B(node)?.ContainingType?.Name ?? memberAccessExpressionSyntax.Expression.ToString();
		string text4 = memberAccessExpressionSyntax.Name.Identifier.Text;
		string key = obj2 + "." + text4;
		if (this.m_A.TryGetValue(key, out var value))
		{
			value(node, memberAccessExpressionSyntax);
			return;
		}
		if (this.m_A.TryGetValue(text4, out var value2))
		{
			value2(node, memberAccessExpressionSyntax);
			return;
		}
		A(memberAccessExpressionSyntax);
		if (node.ArgumentList != null)
		{
			Visit(node.ArgumentList);
		}
	}

	public override void VisitMemberAccessExpression(MemberAccessExpressionSyntax node)
	{
		Log.Node(node, "VisitMemberAccessExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 231);
		ISymbol symbol = B(node);
		if (symbol != null && symbol.Kind == SymbolKind.Method)
		{
			A(node);
		}
		else
		{
			string text = node.Name.Identifier.Text;
			string text2 = (symbol?.ContainingType?.Name ?? node.Expression.ToString()) + "." + text;
			if (this.m_A.TryGetValue(text2, out var value))
			{
				value(node);
			}
			else
			{
				A(node.Expression);
				string text3 = A(symbol);
				if (string.IsNullOrEmpty(text3))
				{
					text3 = text;
					Log.Warning("Unknown identifier: " + text2, "VisitMemberAccessExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 261);
				}
				a(text3);
			}
		}
		Log.Message("OUT", "VisitMemberAccessExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 267);
	}

	private void A(MemberAccessExpressionSyntax P_0)
	{
		if (P_0.Expression is PredefinedTypeSyntax predefinedTypeSyntax)
		{
			string text = a(predefinedTypeSyntax);
			a(text);
			a(".");
		}
		else
		{
			A(P_0.Expression);
		}
		if (P_0.Name is GenericNameSyntax node)
		{
			VisitGenericName(node);
		}
		else
		{
			A(P_0.Name);
		}
	}

	private void A(SimpleNameSyntax P_0)
	{
		Log.Node(P_0, "VisitSimpleName", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 295);
		ISymbol symbol = B(P_0);
		string text = A(symbol, true);
		if (string.IsNullOrEmpty(text))
		{
			text = Util.ToCamelCase(P_0.Identifier.Text);
			string text2 = symbol?.ContainingType?.Name + "." + text;
			Log.Warning("Unknown identifier: " + text2, "VisitSimpleName", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 306);
		}
		a(text);
		Log.Message("OUT", "VisitSimpleName", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 310);
	}

	public override void VisitGenericName(GenericNameSyntax node)
	{
		Log.Node(node, "VisitGenericName", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 315);
		ISymbol symbol = B(node);
		string text = A(symbol, true);
		if (string.IsNullOrEmpty(text))
		{
			text = node.Identifier.Text;
			string text2 = symbol?.ContainingType?.Name + "." + text;
			Log.Warning("Unknown identifier: " + text2, "VisitGenericName", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 326);
			a(text);
			Visit(node.TypeArgumentList);
		}
		else
		{
			a(text);
		}
		Log.Message("OUT", "VisitGenericName", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 336);
	}

	public override void VisitElementAccessExpression(ElementAccessExpressionSyntax node)
	{
		base.VisitElementAccessExpression(node);
	}

	private void A(ExpressionSyntax P_0)
	{
		if (P_0 is ThisExpressionSyntax)
		{
			if (P_0.Parent is MemberAccessExpressionSyntax memberAccessExpressionSyntax)
			{
				ISymbol symbol = B(memberAccessExpressionSyntax);
				string text = A(symbol, true);
				{
					foreach (ISymbol item in from P_0 in this.m_A.LookupSymbols(P_0.SpanStart)
						where P_0.Kind == SymbolKind.Parameter || P_0.Kind == SymbolKind.Local || (P_0 is IMethodSymbol methodSymbol && methodSymbol.MethodKind == MethodKind.LocalFunction)
						select P_0)
					{
						if (A(item, true) == text)
						{
							a("this");
							a(".");
							break;
						}
					}
					return;
				}
			}
			a("this");
			a(".");
		}
		else
		{
			Visit(P_0);
			a(".");
		}
	}

	public override void VisitThisExpression(ThisExpressionSyntax node)
	{
		Log.Node(node, "VisitThisExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 385);
		a("this");
		Log.Message("OUT", "VisitThisExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 389);
	}

	public override void VisitBaseExpression(BaseExpressionSyntax node)
	{
		Log.Node(node, "VisitBaseExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 394);
		a("super");
		Log.Message("OUT", "VisitBaseExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 398);
	}

	public override void VisitMemberBindingExpression(MemberBindingExpressionSyntax node)
	{
		base.VisitMemberBindingExpression(node);
	}

	public override void VisitElementBindingExpression(ElementBindingExpressionSyntax node)
	{
		base.VisitElementBindingExpression(node);
	}

	public override void VisitDeclarationExpression(DeclarationExpressionSyntax node)
	{
		Log.Node(node, "VisitDeclarationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 424);
		base.VisitDeclarationExpression(node);
		Log.Message("OUT", "VisitDeclarationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 428);
	}

	public override void VisitSimpleLambdaExpression(SimpleLambdaExpressionSyntax node)
	{
		Log.Node(node, "VisitSimpleLambdaExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 435);
		A(node, null, node.Parameter);
		Log.Message("OUT", "VisitSimpleLambdaExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 439);
	}

	public override void VisitParenthesizedLambdaExpression(ParenthesizedLambdaExpressionSyntax node)
	{
		Log.Node(node, "VisitParenthesizedLambdaExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 444);
		A(node, node.ParameterList);
		Log.Message("OUT", "VisitParenthesizedLambdaExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 448);
	}

	public override void VisitAnonymousMethodExpression(AnonymousMethodExpressionSyntax node)
	{
		Log.Node(node, "VisitAnonymousMethodExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 453);
		A(node, node.ParameterList);
		Log.Message("OUT", "VisitAnonymousMethodExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 457);
	}

	private void A(AnonymousFunctionExpressionSyntax P_0, ParameterListSyntax P_1, ParameterSyntax P_2 = null)
	{
		if (P_1 != null)
		{
			Visit(P_1);
		}
		else if (P_2 != null)
		{
			a("(");
			Visit(P_2);
			a(")");
		}
		if (P_0.AsyncKeyword.Kind() == SyntaxKind.AsyncKeyword)
		{
			a(" async");
		}
		if (P_0.Body is BlockSyntax blockSyntax)
		{
			a(" {");
			A(false);
			c();
			SyntaxList<StatementSyntax>.Enumerator enumerator = blockSyntax.Statements.GetEnumerator();
			while (enumerator.MoveNext())
			{
				StatementSyntax current = enumerator.Current;
				Visit(current);
			}
			D();
			A(" }");
		}
		else
		{
			a(" => ");
			Visit(P_0.Body);
		}
	}

	public override void VisitArrowExpressionClause(ArrowExpressionClauseSyntax node)
	{
		Log.Node(node, "VisitArrowExpressionClause", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 501);
		bool num = node.Parent is ConstructorDeclarationSyntax;
		bool flag = false;
		bool flag2 = false;
		if (num)
		{
			if (this.m_A.Peek().A())
			{
				a(" { _initializeFields(); ");
				this.m_A.Peek().A = true;
			}
			else
			{
				a(" { ");
			}
		}
		else
		{
			flag = node.DescendantNodesAndSelf().OfType<ObjectCreationExpressionSyntax>().Any((ObjectCreationExpressionSyntax P_0) => P_0.Initializer != null);
			flag2 = node.DescendantNodesAndSelf().OfType<ConditionalExpressionSyntax>().Any();
			if (flag || flag2)
			{
				a(" { ");
				A(false);
				G();
				c();
				A("return ");
			}
			else
			{
				a(" => ");
			}
		}
		A(node.Expression, "result");
		if (!flag)
		{
			b();
		}
		if (num)
		{
			a(" } ");
		}
		else if (flag || flag2)
		{
			C();
			D();
			A("}");
			A(false);
		}
		else
		{
			A(false);
		}
		Log.Message("OUT", "VisitArrowExpressionClause", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 562);
	}

	public override void VisitAssignmentExpression(AssignmentExpressionSyntax node)
	{
		Log.Node(node, "VisitAssignmentExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 569);
		Visit(node.Left);
		a($" {node.OperatorToken} ");
		Visit(node.Right);
		Log.Message("OUT", "VisitAssignmentExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 575);
	}

	public override void VisitEqualsValueClause(EqualsValueClauseSyntax node)
	{
		Log.Node(node, "VisitEqualsValueClause", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 580);
		a(" " + node.EqualsToken.Text + " ");
		Visit(node.Value);
		Log.Message("OUT", "VisitEqualsValueClause", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 586);
	}

	public override void VisitBinaryExpression(BinaryExpressionSyntax node)
	{
		Log.Node(node, "VisitBinaryExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 591);
		Visit(node.Left);
		a(" ");
		a(node.OperatorToken.Text);
		a(" ");
		Visit(node.Right);
		Log.Message("OUT", "VisitBinaryExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 599);
	}

	public override void VisitPrefixUnaryExpression(PrefixUnaryExpressionSyntax node)
	{
		Log.Node(node, "VisitPrefixUnaryExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 604);
		a(node.OperatorToken.Text);
		Visit(node.Operand);
		Log.Message("OUT", "VisitPrefixUnaryExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 609);
	}

	public override void VisitPostfixUnaryExpression(PostfixUnaryExpressionSyntax node)
	{
		Log.Node(node, "VisitPostfixUnaryExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 614);
		Visit(node.Operand);
		a(node.OperatorToken.Text);
		Log.Message("OUT", "VisitPostfixUnaryExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 619);
	}

	public override void VisitLiteralExpression(LiteralExpressionSyntax node)
	{
		Log.Node(node, "VisitLiteralExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 625);
		if (node.Token.Kind() == SyntaxKind.NumericLiteralToken)
		{
			a(node.Token.ValueText);
			if (A((ISymbol)this.m_A.GetTypeInfo(node).ConvertedType) == "double" && !node.Token.ValueText.Contains("."))
			{
				a(".0");
			}
		}
		else
		{
			string text = node.ToString();
			if (text.StartsWith("@", StringComparison.InvariantCulture))
			{
				a(text.Substring(1));
			}
			else
			{
				a(text);
			}
		}
		Log.Message("OUT", "VisitLiteralExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 654);
	}

	public override void VisitConditionalExpression(ConditionalExpressionSyntax node)
	{
		Log.Node(node, "VisitConditionalExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 659);
		Visit(node.Condition);
		a(" ? ");
		A(node.WhenTrue, "trueResult");
		a(" : ");
		A(node.WhenFalse, "falseResult");
		Log.Message("OUT", "VisitConditionalExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 671);
	}

	public override void VisitConditionalAccessExpression(ConditionalAccessExpressionSyntax node)
	{
		Log.Node(node, "VisitConditionalAccessExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 676);
		Visit(node.Expression);
		a("?.");
		Visit(node.WhenNotNull);
		Log.Message("OUT", "VisitConditionalAccessExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 682);
	}

	public override void VisitCastExpression(CastExpressionSyntax node)
	{
		Log.Node(node, "VisitCastExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 687);
		A(node.Expression, null);
		a(" as ");
		string text = a(node.Type);
		a(text);
		Log.Message("OUT", "VisitCastExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 694);
	}

	public override void VisitSizeOfExpression(SizeOfExpressionSyntax node)
	{
		Log.Node(node, "VisitSizeOfExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 699);
		a(node.ToString());
		Log.Message("OUT", "VisitSizeOfExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 704);
	}

	public override void VisitParenthesizedExpression(ParenthesizedExpressionSyntax node)
	{
		Log.Node(node, "VisitParenthesizedExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 709);
		a("(");
		A(node.Expression, null);
		a(")");
		Log.Message("OUT", "VisitParenthesizedExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 715);
	}

	public override void VisitTupleExpression(TupleExpressionSyntax node)
	{
		Log.Node(node, "VisitTupleExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 723);
		string text = "Tuple" + node.Arguments.Count;
		a(text + ".fromList([");
		bool flag = true;
		SeparatedSyntaxList<ArgumentSyntax>.Enumerator enumerator = node.Arguments.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ArgumentSyntax current = enumerator.Current;
			if (!flag)
			{
				a(", ");
			}
			flag = false;
			Visit(current.Expression);
		}
		a("])");
		A(!DartTranspilerVisitor.m_a, "Install https://github.com/dart-lang/tuple", null);
		DartTranspilerVisitor.m_a = true;
		Log.Message("OUT", "VisitTupleExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 749);
	}

	public override void VisitOmittedArraySizeExpression(OmittedArraySizeExpressionSyntax node)
	{
		base.VisitOmittedArraySizeExpression(node);
	}

	public override void VisitDefaultExpression(DefaultExpressionSyntax node)
	{
		Log.Node(node, "VisitDefaultExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 760);
		string text = A(node.Type) ?? "null";
		a(text);
		Log.Message("OUT", "VisitDefaultExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 767);
	}

	public override void VisitTypeOfExpression(TypeOfExpressionSyntax node)
	{
		Log.Node(node, "VisitTypeOfExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 772);
		string text = a(node.Type);
		a(text);
		a(".runtimeType");
		Log.Message("OUT", "VisitTypeOfExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 778);
	}

	public override void VisitIsPatternExpression(IsPatternExpressionSyntax node)
	{
		Log.Node(node, "VisitIsPatternExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 784);
		Visit(node.Expression);
		if (node.Pattern is ConstantPatternSyntax)
		{
			a(" == ");
		}
		else
		{
			a(" is ");
		}
		Visit(node.Pattern);
		Log.Message("OUT", "VisitIsPatternExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 799);
	}

	public override void VisitConstantPattern(ConstantPatternSyntax node)
	{
		Log.Node(node, "VisitConstantPattern", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 805);
		base.VisitConstantPattern(node);
		Log.Message("OUT", "VisitConstantPattern", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 809);
	}

	public override void VisitDeclarationPattern(DeclarationPatternSyntax node)
	{
		Log.Node(node, "VisitDeclarationPattern", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 814);
		if (node.Parent is IsPatternExpressionSyntax isPatternExpressionSyntax)
		{
			A(DartTranspilerVisitor.A.a);
			string text = isPatternExpressionSyntax.Expression.ToString();
			string text2 = a(node.Type);
			A(text2);
			a(" ");
			Visit(node.Designation);
			a(" = " + text + " as " + text2);
			C();
			G();
			g();
			a(text2);
		}
		else
		{
			A(true, "Syntax not supported", node);
		}
		Log.Message("OUT", "VisitDeclarationPattern", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 838);
	}

	public override void VisitThrowExpression(ThrowExpressionSyntax node)
	{
		Log.Node(node, "VisitThrowExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 843);
		a("throw ");
		A(node.Expression, "ex");
		Log.Message("OUT", "VisitThrowExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 848);
	}

	public override void VisitAwaitExpression(AwaitExpressionSyntax node)
	{
		Log.Node(node, "VisitAwaitExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 853);
		a("await ");
		Visit(node.Expression);
		Log.Message("OUT", "VisitAwaitExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 858);
	}

	public override void VisitObjectCreationExpression(ObjectCreationExpressionSyntax node)
	{
		Log.Node(node, "VisitObjectCreationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 864);
		ITypeSymbol typeSymbol = b(node);
		if (typeSymbol != null && typeSymbol.TypeKind == TypeKind.Delegate)
		{
			if (node.ArgumentList.Arguments.Count != 1)
			{
				a("null");
				A(true, "Failed translating delegate", node.Parent);
			}
			else
			{
				Visit(node.ArgumentList.Arguments[0]);
			}
		}
		else
		{
			string text = A((ISymbol)typeSymbol);
			if (node.Initializer == null || (!text.StartsWith("List<", StringComparison.InvariantCulture) && !text.StartsWith("Map<", StringComparison.InvariantCulture)))
			{
				a(text);
				if (node.ArgumentList != null)
				{
					Visit(node.ArgumentList);
				}
			}
			if (node.Initializer != null)
			{
				Visit(node.Initializer);
			}
		}
		Log.Message("OUT", "VisitObjectCreationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 903);
	}

	public override void VisitAnonymousObjectCreationExpression(AnonymousObjectCreationExpressionSyntax node)
	{
		Log.Node(node, "VisitAnonymousObjectCreationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 908);
		a("null");
		A(true, "Anonymous types are not supported", node);
		base.VisitAnonymousObjectCreationExpression(node);
		Log.Message("OUT", "VisitAnonymousObjectCreationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 915);
	}

	public override void VisitArrayCreationExpression(ArrayCreationExpressionSyntax node)
	{
		Log.Node(node, "VisitArrayCreationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 920);
		string text = a(node.Type);
		a(text + "()");
		Log.Message("OUT", "VisitArrayCreationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 925);
	}

	public override void VisitImplicitArrayCreationExpression(ImplicitArrayCreationExpressionSyntax node)
	{
		Log.Node(node, "VisitImplicitArrayCreationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 930);
		base.VisitImplicitArrayCreationExpression(node);
		Log.Message("OUT", "VisitImplicitArrayCreationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 935);
	}

	public override void VisitStackAllocArrayCreationExpression(StackAllocArrayCreationExpressionSyntax node)
	{
		A(true, null, node);
		base.VisitStackAllocArrayCreationExpression(node);
	}

	public override void VisitInitializerExpression(InitializerExpressionSyntax node)
	{
		Log.Node(node, "VisitInitializerExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 946);
		switch (node.Kind())
		{
		case SyntaxKind.ObjectInitializerExpression:
		{
			string text;
			if (this.m_A != null)
			{
				text = this.m_A;
				this.m_A = null;
			}
			else
			{
				_ = node.Parent;
				VariableDeclaratorSyntax variableDeclaratorSyntax = node.Ancestors().OfType<VariableDeclaratorSyntax>().FirstOrDefault();
				if (variableDeclaratorSyntax != null)
				{
					text = A(variableDeclaratorSyntax);
				}
				else
				{
					PropertyDeclarationSyntax propertyDeclarationSyntax = node.Ancestors().OfType<PropertyDeclarationSyntax>().FirstOrDefault();
					if (propertyDeclarationSyntax != null)
					{
						text = A(propertyDeclarationSyntax);
					}
					else
					{
						AssignmentExpressionSyntax assignmentExpressionSyntax = node.Ancestors().OfType<AssignmentExpressionSyntax>().FirstOrDefault();
						if (assignmentExpressionSyntax != null)
						{
							ISymbol symbol = B(assignmentExpressionSyntax.Left);
							text = ((symbol == null) ? assignmentExpressionSyntax.Left.ToString() : A(symbol));
							foreach (InitializerExpressionSyntax item in from P_0 in assignmentExpressionSyntax.Ancestors().OfType<InitializerExpressionSyntax>()
								where P_0.Kind() == SyntaxKind.ObjectInitializerExpression
								select P_0)
							{
								AssignmentExpressionSyntax assignmentExpressionSyntax2 = item.Parent.Ancestors().OfType<AssignmentExpressionSyntax>().FirstOrDefault();
								if (assignmentExpressionSyntax2 != null)
								{
									ISymbol symbol2 = B(assignmentExpressionSyntax2.Left);
									if (symbol2 != null)
									{
										text = A(symbol2) + "." + text;
									}
								}
								else if (this.m_a != null)
								{
									text = this.m_a + "." + text;
									break;
								}
							}
						}
						else
						{
							text = "?????";
						}
					}
				}
			}
			bool flag2 = false;
			SeparatedSyntaxList<ExpressionSyntax>.Enumerator enumerator = node.Expressions.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ExpressionSyntax current2 = enumerator.Current;
				if (current2 is AssignmentExpressionSyntax assignmentExpressionSyntax3 && assignmentExpressionSyntax3.Left is ImplicitElementAccessSyntax implicitElementAccessSyntax)
				{
					if (!flag2)
					{
						flag2 = true;
						a("{");
						A(false);
						c();
					}
					else
					{
						a(",");
						A(false);
					}
					A(implicitElementAccessSyntax.ArgumentList.Arguments[0].ToString());
					a(": ");
					D();
					A(assignmentExpressionSyntax3.Right, null);
					c();
				}
				else
				{
					C();
					A(text + ".");
					Visit(current2);
				}
			}
			if (flag2)
			{
				A(false);
				D();
				A("}");
			}
			break;
		}
		case SyntaxKind.CollectionInitializerExpression:
		case SyntaxKind.ArrayInitializerExpression:
		{
			bool flag3 = node.Expressions.Any((ExpressionSyntax P_0) => P_0.Kind() == SyntaxKind.ComplexElementInitializerExpression);
			a(flag3 ? "{" : "[");
			bool flag4 = true;
			SeparatedSyntaxList<ExpressionSyntax>.Enumerator enumerator = node.Expressions.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ExpressionSyntax current3 = enumerator.Current;
				if (!flag4)
				{
					a(", ");
				}
				flag4 = false;
				A(current3, null);
			}
			a(flag3 ? "}" : "]");
			break;
		}
		case SyntaxKind.ComplexElementInitializerExpression:
		{
			bool flag = node.Expressions.Count > 1;
			SeparatedSyntaxList<ExpressionSyntax>.Enumerator enumerator = node.Expressions.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ExpressionSyntax current = enumerator.Current;
				if (flag)
				{
					Visit(current);
					a(": ");
				}
				else
				{
					A(current, null);
				}
				flag = false;
			}
			break;
		}
		}
		Log.Message("OUT", "VisitInitializerExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 1094);
	}

	private void A(ExpressionSyntax P_0, string P_1 = null)
	{
		if (P_0 is ObjectCreationExpressionSyntax objectCreationExpressionSyntax && objectCreationExpressionSyntax.Initializer != null)
		{
			A(DartTranspilerVisitor.A.a);
			string text = c(P_1 ?? "item");
			A("var " + text + " = ");
			this.m_A = text;
			this.m_a = text;
			Visit(objectCreationExpressionSyntax);
			this.m_a = null;
			C();
			G();
			g();
			a(text);
		}
		else
		{
			Visit(P_0);
		}
	}

	public override void VisitRefExpression(RefExpressionSyntax node)
	{
		base.VisitRefExpression(node);
	}

	public override void VisitMakeRefExpression(MakeRefExpressionSyntax node)
	{
		base.VisitMakeRefExpression(node);
	}

	public override void VisitRefTypeExpression(RefTypeExpressionSyntax node)
	{
		base.VisitRefTypeExpression(node);
	}

	public override void VisitRefValueExpression(RefValueExpressionSyntax node)
	{
		base.VisitRefValueExpression(node);
	}

	public override void VisitInterpolatedStringExpression(InterpolatedStringExpressionSyntax node)
	{
		Log.Node(node, "VisitInterpolatedStringExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 1155);
		a("\"");
		SyntaxList<InterpolatedStringContentSyntax>.Enumerator enumerator = node.Contents.GetEnumerator();
		while (enumerator.MoveNext())
		{
			InterpolatedStringContentSyntax current = enumerator.Current;
			Visit(current);
		}
		a("\"");
		Log.Message("OUT", "VisitInterpolatedStringExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 1164);
	}

	public override void VisitInterpolation(InterpolationSyntax node)
	{
		Log.Node(node, "VisitInterpolation", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 1169);
		A(node.FormatClause != null || node.AlignmentClause != null, null, node);
		a("${");
		A(node.Expression, null);
		a("}");
		Log.Message("OUT", "VisitInterpolation", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 1177);
	}

	public override void VisitInterpolatedStringText(InterpolatedStringTextSyntax node)
	{
		Log.Node(node, "VisitInterpolatedStringText", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 1182);
		a(node.TextToken.Text);
		Log.Message("OUT", "VisitInterpolatedStringText", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitExpression.cs", 1186);
	}

	public override void VisitInterpolationAlignmentClause(InterpolationAlignmentClauseSyntax node)
	{
		base.VisitInterpolationAlignmentClause(node);
	}

	public override void VisitInterpolationFormatClause(InterpolationFormatClauseSyntax node)
	{
		base.VisitInterpolationFormatClause(node);
	}

	public override void VisitImplicitElementAccess(ImplicitElementAccessSyntax node)
	{
		base.VisitImplicitElementAccess(node);
	}

	public override void VisitArrayRankSpecifier(ArrayRankSpecifierSyntax node)
	{
		base.VisitArrayRankSpecifier(node);
	}

	public override void VisitCheckedExpression(CheckedExpressionSyntax node)
	{
		base.VisitCheckedExpression(node);
	}

	public override void VisitQueryExpression(QueryExpressionSyntax node)
	{
		base.VisitQueryExpression(node);
	}

	public override void VisitQueryBody(QueryBodySyntax node)
	{
		base.VisitQueryBody(node);
	}

	public override void VisitFromClause(FromClauseSyntax node)
	{
		base.VisitFromClause(node);
	}

	public override void VisitLetClause(LetClauseSyntax node)
	{
		base.VisitLetClause(node);
	}

	public override void VisitJoinClause(JoinClauseSyntax node)
	{
		base.VisitJoinClause(node);
	}

	public override void VisitJoinIntoClause(JoinIntoClauseSyntax node)
	{
		base.VisitJoinIntoClause(node);
	}

	public override void VisitWhereClause(WhereClauseSyntax node)
	{
		base.VisitWhereClause(node);
	}

	public override void VisitOrderByClause(OrderByClauseSyntax node)
	{
		base.VisitOrderByClause(node);
	}

	public override void VisitOrdering(OrderingSyntax node)
	{
		base.VisitOrdering(node);
	}

	public override void VisitSelectClause(SelectClauseSyntax node)
	{
		base.VisitSelectClause(node);
	}

	public override void VisitGroupClause(GroupClauseSyntax node)
	{
		base.VisitGroupClause(node);
	}

	public override void VisitQueryContinuation(QueryContinuationSyntax node)
	{
		base.VisitQueryContinuation(node);
	}

	public override void VisitParameterList(ParameterListSyntax node)
	{
		Log.Node(node, "VisitParameterList", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 16);
		bool flag = false;
		if (node.Parent is MethodDeclarationSyntax declarationSyntax)
		{
			string fullMetadataName = Util.GetFullMetadataName(this.m_A.GetDeclaredSymbol(declarationSyntax), includeParameters: true);
			if (this.m_A.MethodsCalledUsingNamedParameters.Contains(fullMetadataName))
			{
				flag = true;
			}
		}
		a("(");
		if (flag)
		{
			a("{");
		}
		bool flag2 = true;
		bool flag3 = false;
		bool flag4 = node.Parent is OperatorDeclarationSyntax;
		SeparatedSyntaxList<ParameterSyntax>.Enumerator enumerator = node.Parameters.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ParameterSyntax current = enumerator.Current;
			if (!flag2 && !flag4)
			{
				a(", ");
			}
			else if (flag2)
			{
				flag2 = false;
				if (flag4)
				{
					continue;
				}
			}
			if (!flag && current.Default != null && !flag3)
			{
				flag3 = true;
				a("[");
			}
			Visit(current);
		}
		if (!flag && flag3)
		{
			a("]");
		}
		else if (flag)
		{
			a("}");
		}
		a(")");
		Log.Message("OUT", "VisitParameterList", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 76);
	}

	public override void VisitBracketedParameterList(BracketedParameterListSyntax node)
	{
		Log.Node(node, "VisitBracketedParameterList", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 83);
		a("(");
		bool flag = true;
		SeparatedSyntaxList<ParameterSyntax>.Enumerator enumerator = node.Parameters.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ParameterSyntax current = enumerator.Current;
			if (!flag)
			{
				a(", ");
			}
			flag = false;
			Visit(current);
		}
		if (this.m_B != null)
		{
			a(", ");
			a(this.m_B);
			this.m_B = null;
		}
		a(")");
		Log.Message("OUT", "VisitBracketedParameterList", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 108);
	}

	public override void VisitParameter(ParameterSyntax node)
	{
		Log.Node(node, "VisitParameter", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 112);
		bool num = node.Modifiers.Contains("ref") || node.Modifiers.Contains("out");
		B b = J();
		if (num)
		{
			string value = a(node.Type);
			a($"RefParam<{value}> {node.Identifier}");
			b?.a().Add(node.Identifier.Text);
		}
		else
		{
			if (node.Type == null)
			{
				a(node.Identifier.ToString());
			}
			else
			{
				string value2 = a(node.Type);
				a($"{value2} {node.Identifier}");
			}
			if (node.Default != null)
			{
				Visit(node.Default);
			}
		}
		Log.Message("OUT", "VisitParameter", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 142);
	}

	public override void VisitArgumentList(ArgumentListSyntax node)
	{
		Log.Node(node, "VisitArgumentList", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 148);
		bool flag = false;
		string text = null;
		if (node.Parent is InvocationExpressionSyntax invocationExpressionSyntax)
		{
			text = Util.GetFullMetadataName(B(invocationExpressionSyntax), includeParameters: true);
			if (this.m_A.MethodsCalledUsingNamedParameters.Contains(text))
			{
				flag = true;
			}
		}
		a("(");
		bool flag2 = true;
		int num = 0;
		List<string> list = null;
		if (flag && text != null && this.m_A.ParameterNames.ContainsKey(text))
		{
			list = this.m_A.ParameterNames[text];
		}
		SeparatedSyntaxList<ArgumentSyntax>.Enumerator enumerator = node.Arguments.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ArgumentSyntax current = enumerator.Current;
			if (!flag2)
			{
				a(", ");
			}
			else
			{
				flag2 = false;
			}
			if (current.NameColon == null && list != null)
			{
				string text2 = list[num];
				a(text2 + ": ");
			}
			if (current.Expression is ObjectCreationExpressionSyntax objectCreationExpressionSyntax && objectCreationExpressionSyntax.Initializer != null)
			{
				A(DartTranspilerVisitor.A.a);
				string text3 = Util.ToCamelCase(objectCreationExpressionSyntax.Type?.ToString());
				if (string.IsNullOrEmpty(text3))
				{
					text3 = "arg";
				}
				string text4 = text3 + num;
				A("var " + text4 + " = ");
				this.m_A = text4;
				this.m_a = text4;
				Visit(current.Expression);
				this.m_a = null;
				C();
				G();
				g();
				a(text4);
			}
			else
			{
				Visit(current);
			}
			num++;
		}
		a(")");
		Log.Message("OUT", "VisitArgumentList", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 228);
	}

	public override void VisitBracketedArgumentList(BracketedArgumentListSyntax node)
	{
		Log.Node(node, "VisitBracketedArgumentList", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 233);
		a("[");
		bool flag = true;
		SeparatedSyntaxList<ArgumentSyntax>.Enumerator enumerator = node.Arguments.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ArgumentSyntax current = enumerator.Current;
			if (!flag)
			{
				a(", ");
			}
			else
			{
				flag = false;
			}
			Visit(current);
		}
		a("]");
		Log.Message("OUT", "VisitBracketedArgumentList", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 253);
	}

	public override void VisitArgument(ArgumentSyntax node)
	{
		base.VisitArgument(node);
	}

	public override void VisitNameColon(NameColonSyntax node)
	{
		base.VisitNameColon(node);
	}

	public override void VisitTypeParameterList(TypeParameterListSyntax node)
	{
		a("<");
		bool flag = true;
		SeparatedSyntaxList<TypeParameterSyntax>.Enumerator enumerator = node.Parameters.GetEnumerator();
		while (enumerator.MoveNext())
		{
			TypeParameterSyntax current = enumerator.Current;
			if (!flag)
			{
				a(", ");
			}
			flag = false;
			string A = current.Identifier.Text;
			a(A);
			if (!(node.Parent is TypeDeclarationSyntax typeDeclarationSyntax))
			{
				continue;
			}
			TypeParameterConstraintClauseSyntax typeParameterConstraintClauseSyntax = typeDeclarationSyntax.ConstraintClauses.FirstOrDefault((TypeParameterConstraintClauseSyntax P_0) => P_0.Name.Identifier.Text == A);
			if (typeParameterConstraintClauseSyntax == null)
			{
				continue;
			}
			bool flag2 = false;
			SeparatedSyntaxList<TypeParameterConstraintSyntax>.Enumerator enumerator2 = typeParameterConstraintClauseSyntax.Constraints.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				TypeParameterConstraintSyntax current2 = enumerator2.Current;
				if (current2 is TypeConstraintSyntax typeConstraintSyntax)
				{
					if (flag2)
					{
						a(", ");
					}
					else
					{
						a(" extends ");
					}
					flag2 = true;
					Visit(typeConstraintSyntax.Type);
				}
				else
				{
					Log.Warning(LogLevel.Normal, "Not supported constraint: " + current2.ToString(), "VisitTypeParameterList", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 308);
				}
			}
		}
		a(">");
	}

	public override void VisitTypeParameter(TypeParameterSyntax node)
	{
		base.VisitTypeParameter(node);
	}

	public override void VisitTypeParameterConstraintClause(TypeParameterConstraintClauseSyntax node)
	{
		base.VisitTypeParameterConstraintClause(node);
	}

	public override void VisitTypeArgumentList(TypeArgumentListSyntax node)
	{
		Log.Node(node, "VisitTypeArgumentList", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 329);
		a("<");
		bool flag = true;
		SeparatedSyntaxList<TypeSyntax>.Enumerator enumerator = node.Arguments.GetEnumerator();
		while (enumerator.MoveNext())
		{
			TypeSyntax current = enumerator.Current;
			if (!flag)
			{
				a(", ");
			}
			flag = false;
			string text = current.ToString();
			a(text);
		}
		a(">");
		Log.Message("OUT", "VisitTypeArgumentList", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 347);
	}

	public override void VisitOmittedTypeArgument(OmittedTypeArgumentSyntax node)
	{
		base.VisitOmittedTypeArgument(node);
	}

	public override void VisitSingleVariableDesignation(SingleVariableDesignationSyntax node)
	{
		Log.Node(node, "VisitSingleVariableDesignation", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 358);
		string text = node.Identifier.Text;
		if (node.Parent is DeclarationExpressionSyntax)
		{
			a(TranslateReferenceVariableName(text));
		}
		else
		{
			a(text);
		}
		Log.Message("OUT", "VisitSingleVariableDesignation", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 371);
	}

	public override void VisitParenthesizedVariableDesignation(ParenthesizedVariableDesignationSyntax node)
	{
		Log.Node(node, "VisitParenthesizedVariableDesignation", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 376);
		a("(");
		A(node.Variables, delegate(VariableDesignationSyntax P_0)
		{
			if (P_0 is SingleVariableDesignationSyntax singleVariableDesignationSyntax)
			{
				a(singleVariableDesignationSyntax.Identifier.Text);
			}
			if (P_0 is DiscardDesignationSyntax)
			{
				a("_");
			}
		});
		a(")");
		Log.Message("OUT", "VisitParenthesizedVariableDesignation", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 392);
	}

	public override void VisitDiscardDesignation(DiscardDesignationSyntax node)
	{
		Log.Node(node, "VisitDiscardDesignation", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 397);
		a("_");
		Log.Message("OUT", "VisitDiscardDesignation", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitParameters.cs", 401);
	}

	public override void VisitGlobalStatement(GlobalStatementSyntax node)
	{
		base.VisitGlobalStatement(node);
	}

	public override void VisitBlock(BlockSyntax node)
	{
		Log.Node(node, "VisitBlock", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 22);
		this.m_A.Push(new Dictionary<string, int>());
		a(" {");
		A(false);
		this.c();
		C c = this.m_A.Peek();
		if (node.Parent is ConstructorDeclarationSyntax && c.A())
		{
			A("_initializeFields();");
			A(false);
			this.m_A.Peek().A = true;
		}
		if (node.Statements.Count == 0)
		{
			A();
		}
		base.VisitBlock(node);
		D();
		B("}");
		this.m_A.Pop();
		Log.Message("OUT", "VisitBlock", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 52);
	}

	public override void VisitLocalFunctionStatement(LocalFunctionStatementSyntax node)
	{
		Log.Node(node, "VisitLocalFunctionStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 58);
		this.m_A.Push(new B());
		string text = Util.ToCamelCase(node.Identifier.Text);
		string text2 = a(node.ReturnType);
		A(text2 + " " + text);
		Visit(node.ParameterList);
		if (node.Body != null)
		{
			Visit(node.Body);
		}
		else
		{
			Visit(node.ExpressionBody);
			A(false);
		}
		this.m_A.Pop();
		Log.Message("OUT", "VisitLocalFunctionStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 80);
	}

	public override void VisitReturnStatement(ReturnStatementSyntax node)
	{
		Log.Node(node, "VisitReturnStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 86);
		if ((node.Expression is ObjectCreationExpressionSyntax objectCreationExpressionSyntax && objectCreationExpressionSyntax.Initializer != null) || (node.Expression is InvocationExpressionSyntax invocationExpressionSyntax && (from P_0 in invocationExpressionSyntax.DescendantNodes().OfType<ArgumentSyntax>()
			where P_0.RefKindKeyword.Kind() != SyntaxKind.None
			select P_0).Any()))
		{
			string text = c("result");
			A("var " + text + " = ");
			this.m_A = text;
			this.m_a = text;
			Visit(node.Expression);
			this.m_a = null;
			C();
			A();
			A("return " + text);
			C();
		}
		else
		{
			A("return");
			if (node.Expression != null)
			{
				a(" ");
				Visit(node.Expression);
			}
			C();
		}
		Log.Message("OUT", "VisitReturnStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 121);
	}

	public override void VisitYieldStatement(YieldStatementSyntax node)
	{
		Log.Node(node, "VisitYieldStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 126);
		if (node.Kind() == SyntaxKind.YieldBreakStatement)
		{
			A("return");
			C();
		}
		if (node.Kind() == SyntaxKind.YieldReturnStatement)
		{
			A("yield (");
			A(node.Expression, "result");
			a(")");
			C();
		}
		Log.Message("OUT", "VisitYieldStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 141);
	}

	public override void VisitIfStatement(IfStatementSyntax node)
	{
		Log.Node(node, "VisitIfStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 147);
		b b;
		if (!(node.Parent is ElseClauseSyntax))
		{
			b obj = new b();
			obj.A(H());
			b = obj;
			this.m_A.Push(b);
			B();
		}
		else
		{
			b = this.m_A.Peek();
		}
		a("if (");
		b.A(true);
		Visit(node.Condition);
		b.A(false);
		a(")");
		A(node.Statement);
		if (node.Else == null)
		{
			A(false);
		}
		else if (node.Else.Statement is IfStatementSyntax node2)
		{
			A("else ");
			VisitIfStatement(node2);
		}
		else
		{
			A("else");
			a(node.Else.Statement);
		}
		if (!(node.Parent is ElseClauseSyntax))
		{
			this.m_A.Pop();
		}
		Log.Message("OUT", "VisitIfStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 191);
	}

	public override void VisitForStatement(ForStatementSyntax node)
	{
		Log.Node(node, "VisitForStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 197);
		A("for (");
		if (node.Declaration != null)
		{
			Visit(node.Declaration);
		}
		else
		{
			a("; ");
		}
		if (node.Condition != null)
		{
			Visit(node.Condition);
		}
		a("; ");
		bool flag = true;
		SeparatedSyntaxList<ExpressionSyntax>.Enumerator enumerator = node.Incrementors.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ExpressionSyntax current = enumerator.Current;
			if (!flag)
			{
				a(", ");
			}
			Visit(current);
			flag = false;
		}
		a(")");
		a(node.Statement);
		Log.Message("OUT", "VisitForStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 234);
	}

	public override void VisitForEachStatement(ForEachStatementSyntax node)
	{
		Log.Node(node, "VisitForEachStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 239);
		A("for (");
		string text = a(node.Type);
		a(text);
		a(" ");
		a(node.Identifier.ToString());
		a(" in ");
		Visit(node.Expression);
		a(")");
		a(node.Statement);
		Log.Message("OUT", "VisitForEachStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 251);
	}

	public override void VisitForEachVariableStatement(ForEachVariableStatementSyntax node)
	{
		base.VisitForEachVariableStatement(node);
	}

	public override void VisitDoStatement(DoStatementSyntax node)
	{
		Log.Node(node, "VisitDoStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 262);
		b obj = new b();
		obj.A(H());
		b b = obj;
		this.m_A.Push(b);
		BlockSyntax node2 = node.Statement as BlockSyntax;
		A("do ");
		VisitBlock(node2);
		if (node.Condition != null)
		{
			A("while (");
			b.A(true);
			Visit(node.Condition);
			b.A(false);
			a(")");
		}
		C();
		this.m_A.Pop();
		Log.Message("OUT", "VisitDoStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 285);
	}

	public override void VisitWhileStatement(WhileStatementSyntax node)
	{
		Log.Node(node, "VisitWhileStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 290);
		A("while (");
		Visit(node.Condition);
		a(")");
		a(node.Statement);
		Log.Message("OUT", "VisitWhileStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 297);
	}

	public override void VisitSwitchSection(SwitchSectionSyntax node)
	{
		Log.Node(node, "VisitSwitchSection", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 303);
		try
		{
			SwitchLabelSyntax switchLabelSyntax = node.Labels.First();
			SyntaxList<StatementSyntax>.Enumerator enumerator;
			if (!(switchLabelSyntax is CasePatternSwitchLabelSyntax))
			{
				if (!(switchLabelSyntax is DefaultSwitchLabelSyntax))
				{
					if (switchLabelSyntax is CaseSwitchLabelSyntax)
					{
						A("case ");
						A(node.Labels, delegate(SwitchLabelSyntax P_0)
						{
							if (P_0 is CaseSwitchLabelSyntax caseSwitchLabelSyntax)
							{
								Visit(caseSwitchLabelSyntax.Value);
							}
						});
						a(": {");
						A(false);
						c();
						enumerator = A(node.Statements).GetEnumerator();
						while (enumerator.MoveNext())
						{
							StatementSyntax current = enumerator.Current;
							Visit(current);
						}
						D();
						B("}");
					}
					else
					{
						a("Unknown case");
					}
				}
				else
				{
					B("default: {");
					c();
					enumerator = A(node.Statements).GetEnumerator();
					while (enumerator.MoveNext())
					{
						StatementSyntax current2 = enumerator.Current;
						Visit(current2);
					}
					D();
					B("}");
				}
				return;
			}
			A("case ");
			A(node.Labels, delegate(SwitchLabelSyntax P_0)
			{
				DeclarationPatternSyntax declarationPatternSyntax = (P_0 as CasePatternSwitchLabelSyntax).Pattern as DeclarationPatternSyntax;
				string text = a(declarationPatternSyntax.Type);
				a(text);
			});
			a(": {");
			A(false);
			c();
			SyntaxList<SwitchLabelSyntax>.Enumerator enumerator2 = node.Labels.GetEnumerator();
			while (enumerator2.MoveNext())
			{
				if ((((CasePatternSwitchLabelSyntax)enumerator2.Current).Pattern as DeclarationPatternSyntax).Designation is SingleVariableDesignationSyntax singleVariableDesignationSyntax)
				{
					B("val " + singleVariableDesignationSyntax.Identifier.Text + " = tmp");
				}
			}
			enumerator = A(node.Statements).GetEnumerator();
			while (enumerator.MoveNext())
			{
				StatementSyntax current3 = enumerator.Current;
				Visit(current3);
			}
			D();
			B("}");
		}
		finally
		{
			Log.Message("OUT", "VisitSwitchSection", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 385);
		}
	}

	public override void VisitCaseSwitchLabel(CaseSwitchLabelSyntax node)
	{
		base.VisitCaseSwitchLabel(node);
	}

	public override void VisitDefaultSwitchLabel(DefaultSwitchLabelSyntax node)
	{
		base.VisitDefaultSwitchLabel(node);
	}

	public override void VisitSwitchStatement(SwitchStatementSyntax node)
	{
		Log.Node(node, "VisitSwitchStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 401);
		B($"switch ({node.Expression}) {{");
		c();
		SyntaxList<SwitchSectionSyntax>.Enumerator enumerator = node.Sections.GetEnumerator();
		while (enumerator.MoveNext())
		{
			SwitchSectionSyntax current = enumerator.Current;
			Visit(current);
		}
		D();
		B("}");
		Log.Message("OUT", "VisitSwitchStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 412);
	}

	public override void VisitBreakStatement(BreakStatementSyntax node)
	{
		Log.Node(node, "VisitBreakStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 417);
		if (!c(node))
		{
			B("break");
		}
		Log.Message("OUT", "VisitBreakStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 425);
	}

	private static bool c(SyntaxNode P_0)
	{
		while (P_0.Parent != null)
		{
			if (!(P_0 is SwitchStatementSyntax))
			{
				if (P_0 is DoStatementSyntax || P_0 is ForEachStatementSyntax || P_0 is ForStatementSyntax)
				{
					return false;
				}
				P_0 = P_0.Parent;
				continue;
			}
			return true;
		}
		return false;
	}

	public override void VisitContinueStatement(ContinueStatementSyntax node)
	{
		Log.Node(node, "VisitContinueStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 449);
		B("continue");
		Log.Message("OUT", "VisitContinueStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 453);
	}

	public override void VisitCasePatternSwitchLabel(CasePatternSwitchLabelSyntax node)
	{
		base.VisitCasePatternSwitchLabel(node);
	}

	public override void VisitTryStatement(TryStatementSyntax node)
	{
		Log.Node(node, "VisitTryStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 465);
		A("try");
		Visit(node.Block);
		SyntaxList<CatchClauseSyntax>.Enumerator enumerator = node.Catches.GetEnumerator();
		while (enumerator.MoveNext())
		{
			CatchClauseSyntax current = enumerator.Current;
			if (current.Declaration != null)
			{
				string text = current.Declaration.Identifier.Text;
				string value = a(current.Declaration.Type);
				A($"on {value} catch ({text})");
				Visit(current.Block);
			}
			else
			{
				A("catch (e)");
				Visit(current.Block);
			}
		}
		if (node.Finally != null)
		{
			A("finally");
			Visit(node.Finally.Block);
		}
		Log.Message("OUT", "VisitTryStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 495);
	}

	public override void VisitFinallyClause(FinallyClauseSyntax node)
	{
		base.VisitFinallyClause(node);
	}

	public override void VisitCatchDeclaration(CatchDeclarationSyntax node)
	{
		base.VisitCatchDeclaration(node);
	}

	public override void VisitCatchClause(CatchClauseSyntax node)
	{
		base.VisitCatchClause(node);
	}

	public override void VisitCatchFilterClause(CatchFilterClauseSyntax node)
	{
		base.VisitCatchFilterClause(node);
	}

	public override void VisitThrowStatement(ThrowStatementSyntax node)
	{
		Log.Node(node, "VisitThrowStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 520);
		if (node.Expression == null)
		{
			A("rethrow");
		}
		else
		{
			A("throw ");
			A(node.Expression, "ex");
		}
		C();
		Log.Message("OUT", "VisitThrowStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 533);
	}

	public override void VisitWhenClause(WhenClauseSyntax node)
	{
		base.VisitWhenClause(node);
	}

	public override void VisitUsingStatement(UsingStatementSyntax node)
	{
		Log.Node(node, "VisitUsingStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 543);
		if (node.Declaration != null)
		{
			Visit(node.Declaration);
		}
		string text = null;
		if (node.Expression != null)
		{
			text = c("instance");
			A("var " + text + " = ");
			A(node.Expression, null);
			C();
		}
		A("try ");
		if (node.Statement != null)
		{
			Visit(node.Statement);
		}
		A("finally {");
		A(false);
		c();
		if (node.Declaration != null)
		{
			SeparatedSyntaxList<VariableDeclaratorSyntax>.Enumerator enumerator = node.Declaration.Variables.GetEnumerator();
			while (enumerator.MoveNext())
			{
				string text2 = enumerator.Current.Identifier.Text;
				A(text2 + ".dispose()");
				C();
			}
		}
		if (text != null)
		{
			A(text + ".dispose()");
			C();
		}
		D();
		A("}");
		A(false);
		Log.Message("OUT", "VisitUsingStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 588);
	}

	public override void VisitLockStatement(LockStatementSyntax node)
	{
		Log.Node(node, "VisitLockStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 594);
		B();
		a("synchronized(");
		Visit(node.Expression);
		a(",{");
		A(node.Statement);
		a(")");
		A(false);
		Log.Message("OUT", "VisitLockStatement", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitStatement.cs", 605);
	}

	public override void VisitGotoStatement(GotoStatementSyntax node)
	{
		base.VisitGotoStatement(node);
	}

	public override void VisitLabeledStatement(LabeledStatementSyntax node)
	{
		base.VisitLabeledStatement(node);
	}

	public override void VisitLocalDeclarationStatement(LocalDeclarationStatementSyntax node)
	{
		base.VisitLocalDeclarationStatement(node);
	}

	public override void VisitEmptyStatement(EmptyStatementSyntax node)
	{
	}

	public override void VisitFixedStatement(FixedStatementSyntax node)
	{
	}

	public override void VisitCheckedStatement(CheckedStatementSyntax node)
	{
	}

	public override void VisitUnsafeStatement(UnsafeStatementSyntax node)
	{
	}

	private static SyntaxList<StatementSyntax> A(SyntaxList<StatementSyntax> P_0)
	{
		if (P_0.Count == 1 && P_0.First() is BlockSyntax blockSyntax)
		{
			return blockSyntax.Statements;
		}
		return P_0;
	}

	private void A(StatementSyntax P_0)
	{
		if (P_0 is BlockSyntax node)
		{
			VisitBlock(node);
		}
		else
		{
			B(P_0);
		}
	}

	private void a(StatementSyntax P_0)
	{
		if (P_0 is BlockSyntax)
		{
			Visit(P_0);
		}
		else
		{
			B(P_0);
		}
	}

	private void B(StatementSyntax P_0)
	{
		a(" {");
		A(false);
		c();
		Visit(P_0);
		D();
		A("}");
		A(false);
	}

	public override void VisitTrivia(SyntaxTrivia trivia)
	{
		if (!trivia.IsKind(SyntaxKind.SingleLineCommentTrivia))
		{
			trivia.IsKind(SyntaxKind.MultiLineCommentTrivia);
		}
		base.VisitTrivia(trivia);
	}

	public override void VisitSkippedTokensTrivia(SkippedTokensTriviaSyntax node)
	{
		base.VisitSkippedTokensTrivia(node);
	}

	public override void VisitDocumentationCommentTrivia(DocumentationCommentTriviaSyntax node)
	{
		base.VisitDocumentationCommentTrivia(node);
	}

	public override void VisitLeadingTrivia(SyntaxToken token)
	{
		base.VisitLeadingTrivia(token);
	}

	public override void VisitTrailingTrivia(SyntaxToken token)
	{
		base.VisitTrailingTrivia(token);
	}

	public override void VisitPredefinedType(PredefinedTypeSyntax node)
	{
		Log.Node(node, "VisitPredefinedType", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerVisitor.VisitType.cs", 12);
		if (!node.Ancestors().OfType<ArgumentSyntax>().Any())
		{
			string text = a(node);
			a(text);
		}
	}

	public override void VisitPointerType(PointerTypeSyntax node)
	{
		base.VisitPointerType(node);
	}

	public override void VisitNullableType(NullableTypeSyntax node)
	{
		base.VisitNullableType(node);
	}

	public override void VisitTupleType(TupleTypeSyntax node)
	{
		base.VisitTupleType(node);
	}

	public override void VisitTupleElement(TupleElementSyntax node)
	{
		base.VisitTupleElement(node);
	}

	public override void VisitRefType(RefTypeSyntax node)
	{
		base.VisitRefType(node);
	}

	[CompilerGenerated]
	private A<AssignmentExpressionSyntax, ISymbol> A(AssignmentExpressionSyntax P_0)
	{
		return new A<AssignmentExpressionSyntax, ISymbol>(P_0, B(P_0.Left));
	}

	[CompilerGenerated]
	private void A(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("assert");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void a(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("print");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void B(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("print");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void b(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("readln");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void C(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("Duration.ofSeconds");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void c(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("Duration.ofMillis");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void D(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("assertEquals");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void d(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("assertNotEquals");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void E(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("assertSame");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void e(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("assertTrue");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void F(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("assertFalse");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void f(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("assertTrue (");
		ArgumentSyntax node = P_0.ArgumentList.Arguments.First();
		ArgumentSyntax node2 = P_0.ArgumentList.Arguments.Last();
		Visit(node2);
		a(".contains(");
		Visit(node);
		a("))");
	}

	[CompilerGenerated]
	private void G(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("assertFalse (");
		ArgumentSyntax node = P_0.ArgumentList.Arguments.First();
		ArgumentSyntax node2 = P_0.ArgumentList.Arguments.Last();
		Visit(node2);
		a(".contains(");
		Visit(node);
		a("))");
	}

	[CompilerGenerated]
	private void g(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		TypeSyntax typeSyntax = (P_1.Name as GenericNameSyntax).TypeArgumentList.Arguments.First();
		string text = a(typeSyntax);
		a("assertFailsWith<" + text + ">");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void H(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		if (P_0.ArgumentList.Arguments.Count() == 1)
		{
			a("assertTrue (");
			GenericNameSyntax genericNameSyntax = P_1.Name as GenericNameSyntax;
			string text = a(genericNameSyntax.TypeArgumentList.Arguments.First());
			ArgumentSyntax node = P_0.ArgumentList.Arguments.Last();
			Visit(node);
			a(" is " + text + ")");
		}
		if (P_0.ArgumentList.Arguments.Count == 2)
		{
			a("assertTrue (");
			TypeOfExpressionSyntax typeOfExpressionSyntax = P_0.ArgumentList.Arguments.First().Expression as TypeOfExpressionSyntax;
			string text2 = a(typeOfExpressionSyntax.Type);
			ArgumentSyntax node2 = P_0.ArgumentList.Arguments.Last();
			Visit(node2);
			a(" is " + text2 + ")");
		}
	}

	[CompilerGenerated]
	private void h(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("assertNull");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void I(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("assertNotNull");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void i(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		Visit(P_1.Expression);
		a(".countDown()");
	}

	[CompilerGenerated]
	private void J(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		Visit(P_1.Expression);
		a(".");
		a("filter");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void j(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		Visit(P_1.Expression);
		a(".");
		a("map");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void K(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		Visit(P_1.Expression);
		a(".");
		a("toList");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void k(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		Visit(P_1.Expression);
		a(".");
		a("toTypedArray");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void L(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		ArgumentSyntax node = P_0.ArgumentList.Arguments.First();
		a("(");
		Visit(P_1.Expression);
		a(" + ");
		Visit(node);
		a(")");
	}

	[CompilerGenerated]
	private void l(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		ArgumentSyntax argumentSyntax = P_0.ArgumentList.Arguments.First();
		ArgumentSyntax node = P_0.ArgumentList.Arguments.Last();
		if (argumentSyntax.Expression is LiteralExpressionSyntax literalExpressionSyntax && literalExpressionSyntax.Token.ValueText == "0")
		{
			a("(");
			Visit(argumentSyntax);
			a(" upto ");
			Visit(node);
			a(")");
		}
		else
		{
			a("(");
			Visit(argumentSyntax);
			a(" upto ");
			Visit(argumentSyntax);
			a("+");
			Visit(node);
			a(")");
		}
	}

	[CompilerGenerated]
	private void M(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("Future.value");
		Visit(P_0.ArgumentList);
	}

	[CompilerGenerated]
	private void m(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		a("\"\"");
	}

	[CompilerGenerated]
	private void N(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		Visit(P_1.Expression);
	}

	[CompilerGenerated]
	private void n(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		Visit(P_1.Expression);
	}

	[CompilerGenerated]
	private void O(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		Visit(P_1.Expression);
		a(".");
		a("runtimeType");
	}

	[CompilerGenerated]
	private void o(InvocationExpressionSyntax P_0, MemberAccessExpressionSyntax P_1)
	{
		Visit(P_1.Expression);
		a(".");
		a("hashCode");
	}

	[CompilerGenerated]
	private void a(ExpressionSyntax P_0)
	{
		a("\"\"");
	}

	[CompilerGenerated]
	private void K()
	{
		a(string.Empty);
	}

	[CompilerGenerated]
	private void k()
	{
		a("@override");
		A(false);
		B();
	}

	[CompilerGenerated]
	private void A(VariableDesignationSyntax P_0)
	{
		if (P_0 is SingleVariableDesignationSyntax singleVariableDesignationSyntax)
		{
			a(singleVariableDesignationSyntax.Identifier.Text);
		}
		if (P_0 is DiscardDesignationSyntax)
		{
			a("_");
		}
	}

	[CompilerGenerated]
	private void A(SwitchLabelSyntax P_0)
	{
		DeclarationPatternSyntax declarationPatternSyntax = (P_0 as CasePatternSwitchLabelSyntax).Pattern as DeclarationPatternSyntax;
		string text = a(declarationPatternSyntax.Type);
		a(text);
	}

	[CompilerGenerated]
	private void a(SwitchLabelSyntax P_0)
	{
		if (P_0 is CaseSwitchLabelSyntax caseSwitchLabelSyntax)
		{
			Visit(caseSwitchLabelSyntax.Value);
		}
	}
}
