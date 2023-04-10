using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using KineApps.Common.Diagnostics;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace CsToDartTranspiler;

public class DartTranspilerPreprocessor : CSharpSyntaxWalker
{
	private readonly SemanticModel m_A;

	private readonly DartTranspilerPreprocessorData m_A;

	[CompilerGenerated]
	private bool m_A;

	private string m_A;

	public bool HasPublicDeclarations
	{
		[CompilerGenerated]
		get
		{
			return this.m_A;
		}
		[CompilerGenerated]
		private set
		{
			this.m_A = value;
		}
	}

	public DartTranspilerPreprocessor(SemanticModel model, DartTranspilerPreprocessorData dartTranspilerPreprocessorData)
	{
		Log.Message("IN", ".ctor", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerPreprocessor.cs", 18);
		this.m_A = model;
		this.m_A = dartTranspilerPreprocessorData;
		Log.Message("OUT", ".ctor", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerPreprocessor.cs", 23);
	}

	public void Run(SyntaxNode root)
	{
		Visit(root);
	}

	public override void VisitClassDeclaration(ClassDeclarationSyntax node)
	{
		if (node.Modifiers.Contains("public"))
		{
			HasPublicDeclarations = true;
		}
		INamedTypeSymbol declaredSymbol = this.m_A.GetDeclaredSymbol(node);
		A(declaredSymbol);
		base.VisitClassDeclaration(node);
	}

	public override void VisitStructDeclaration(StructDeclarationSyntax node)
	{
		if (node.Modifiers.Contains("public"))
		{
			HasPublicDeclarations = true;
		}
		INamedTypeSymbol declaredSymbol = this.m_A.GetDeclaredSymbol(node);
		A(declaredSymbol);
		base.VisitStructDeclaration(node);
	}

	public override void VisitInterfaceDeclaration(InterfaceDeclarationSyntax node)
	{
		if (node.Modifiers.Contains("public"))
		{
			HasPublicDeclarations = true;
		}
		INamedTypeSymbol declaredSymbol = this.m_A.GetDeclaredSymbol(node);
		A(declaredSymbol);
		base.VisitInterfaceDeclaration(node);
	}

	private void A(ISymbol P_0)
	{
		string typeSymbols;
		string namespaceAndClassName = Util.GetNamespaceAndClassName(P_0, includeTypeParameters: false, out typeSymbols);
		if (this.m_A.AllDeclaredClasses.Contains(namespaceAndClassName))
		{
			string text = namespaceAndClassName + typeSymbols;
			string text2 = P_0.Name + typeSymbols;
			this.m_A.RenamedClassNames[text] = text2;
			Log.Message("Found already declared class name: " + text + " => " + text2, "HandleDeclaredClass", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerPreprocessor.cs", 83);
		}
		else
		{
			this.m_A.AllDeclaredClasses.Add(namespaceAndClassName);
			Log.Message("Found class:" + namespaceAndClassName, "HandleDeclaredClass", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerPreprocessor.cs", 88);
		}
	}

	public override void VisitMethodDeclaration(MethodDeclarationSyntax node)
	{
		Log.Node(node, "VisitMethodDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerPreprocessor.cs", 94);
		IMethodSymbol? declaredSymbol = this.m_A.GetDeclaredSymbol(node);
		string fullMetadataName = Util.GetFullMetadataName(declaredSymbol, includeParameters: false);
		string fullMetadataName2 = Util.GetFullMetadataName(declaredSymbol, includeParameters: true);
		if (this.m_A.AllDeclaredMethods.Contains(fullMetadataName))
		{
			int num = 0;
			string text;
			do
			{
				num++;
				text = node.Identifier.Text + num;
			}
			while (this.m_A.RenamedMethodNames.Values.Contains(text));
			this.m_A.RenamedMethodNames[fullMetadataName2] = text;
			Log.Message("Found overloaded method: " + fullMetadataName2 + " => " + text, "VisitMethodDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerPreprocessor.cs", 111);
		}
		else
		{
			this.m_A.AllDeclaredMethods.Add(fullMetadataName);
			Log.Message("Found method:" + fullMetadataName, "VisitMethodDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerPreprocessor.cs", 116);
		}
		List<string> list = new List<string>();
		this.m_A.ParameterNames[fullMetadataName2] = list;
		SeparatedSyntaxList<ParameterSyntax>.Enumerator enumerator = node.ParameterList.Parameters.GetEnumerator();
		while (enumerator.MoveNext())
		{
			ParameterSyntax current = enumerator.Current;
			list.Add(current.Identifier.Text);
		}
		base.VisitMethodDeclaration(node);
		Log.Message("OUT", "VisitMethodDeclaration", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerPreprocessor.cs", 128);
	}

	public override void VisitInvocationExpression(InvocationExpressionSyntax node)
	{
		Log.Node(node, "VisitInvocationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerPreprocessor.cs", 134);
		SymbolInfo symbolInfo = this.m_A.GetSymbolInfo(node);
		ISymbol s = symbolInfo.Symbol ?? symbolInfo.CandidateSymbols.FirstOrDefault();
		this.m_A = Util.GetFullMetadataName(s, includeParameters: true);
		base.VisitInvocationExpression(node);
		this.m_A = null;
		Log.Message("OUT", "VisitInvocationExpression", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerPreprocessor.cs", 144);
	}

	public override void VisitArgument(ArgumentSyntax node)
	{
		Log.Node(node, "VisitArgument", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerPreprocessor.cs", 149);
		if (node.NameColon != null && node.Parent is ArgumentListSyntax argumentListSyntax && argumentListSyntax.Parent is InvocationExpressionSyntax && !string.IsNullOrWhiteSpace(this.m_A))
		{
			this.m_A.MethodsCalledUsingNamedParameters.Add(this.m_A);
		}
		base.VisitArgument(node);
		Log.Message("OUT", "VisitArgument", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartTranspilerPreprocessor.cs", 164);
	}
}
