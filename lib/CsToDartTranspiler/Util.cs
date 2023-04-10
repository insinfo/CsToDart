using System;
using System.Collections.Immutable;
using System.IO;
using System.Text;
using Microsoft.CodeAnalysis;

namespace CsToDartTranspiler;

public static class Util
{
	private static string[] m_A = new string[3] { "KineApps", "MyCar", "ViewModel" };

	private static readonly char[] m_A = new char[1] { '_' };

	public static string ToCamelCase(string name)
	{
		if (name == null)
		{
			return null;
		}
		if (name.Length > 1)
		{
			return char.ToLowerInvariant(name[0]) + name.Substring(1);
		}
		return char.ToLowerInvariant(name[0]).ToString();
	}

	public static string ToLowerCaseWithUnderscores(string name)
	{
		string[] a = Util.m_A;
		foreach (string text in a)
		{
			string newValue = text[0] + text.Substring(1).ToLowerInvariant();
			name = name.Replace(text, newValue);
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int j = 0; j < name.Length; j++)
		{
			char c = name[j];
			if (c == '-' || c == ' ')
			{
				stringBuilder.Append('_');
			}
			else if (j > 0 && char.IsUpper(c))
			{
				char c2 = stringBuilder[stringBuilder.Length - 1];
				if (c2 != '_' && c2 != '.' && c2 != '/' && c2 != '\\')
				{
					stringBuilder.Append('_');
				}
				stringBuilder.Append(char.ToLowerInvariant(c));
			}
			else
			{
				stringBuilder.Append(char.ToLowerInvariant(c));
			}
		}
		return stringBuilder.ToString();
	}

	public static string EnsureUnderscorePrefix(string s)
	{
		if (string.IsNullOrEmpty(s))
		{
			return s;
		}
		s = s.TrimStart(Util.m_A);
		return "_" + s;
	}

	public static string EnsureNoUnderscorePrefix(string s)
	{
		s = s?.TrimStart(Util.m_A);
		return s;
	}

	public static string GetFullMetadataName(ISymbol s, bool includeParameters)
	{
		if (s == null || A(s))
		{
			return string.Empty;
		}
		StringBuilder stringBuilder = new StringBuilder();
		if (includeParameters && s is IMethodSymbol methodSymbol)
		{
			ImmutableArray<IParameterSymbol>.Enumerator enumerator = methodSymbol.Parameters.GetEnumerator();
			while (enumerator.MoveNext())
			{
				IParameterSymbol current = enumerator.Current;
				stringBuilder.Append("_");
				stringBuilder.Append(current.Type.Name);
			}
		}
		StringBuilder stringBuilder2 = new StringBuilder(s.MetadataName);
		ISymbol symbol = s;
		s = s.ContainingSymbol;
		while (s != null && !A(s))
		{
			if (s is ITypeSymbol && symbol is ITypeSymbol)
			{
				stringBuilder2.Insert(0, '+');
			}
			else
			{
				stringBuilder2.Insert(0, '.');
			}
			stringBuilder2.Insert(0, s.OriginalDefinition.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat));
			s = s.ContainingSymbol;
		}
		if (includeParameters)
		{
			stringBuilder2.Append(stringBuilder);
		}
		return stringBuilder2.ToString();
	}

	public static string GetNamespaceAndClassName(ISymbol s, bool includeTypeParameters, out string typeSymbols)
	{
		string text = s.ContainingNamespace?.ToString() + "." + s.Name;
		typeSymbols = string.Empty;
		if (s is INamedTypeSymbol namedTypeSymbol)
		{
			ImmutableArray<ITypeParameterSymbol>.Enumerator enumerator = namedTypeSymbol.TypeParameters.GetEnumerator();
			while (enumerator.MoveNext())
			{
				ITypeParameterSymbol current = enumerator.Current;
				typeSymbols += current.ToString();
			}
		}
		return text + (includeTypeParameters ? typeSymbols : string.Empty);
	}

	private static bool A(ISymbol P_0)
	{
		INamespaceSymbol namespaceSymbol = null;
		if (P_0 is INamespaceSymbol namespaceSymbol2)
		{
			return namespaceSymbol2.IsGlobalNamespace;
		}
		return false;
	}

	public static string NormalizePath(string path)
	{
		if (string.IsNullOrEmpty(path))
		{
			return string.Empty;
		}
		return Path.GetFullPath(new Uri(path).LocalPath).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
	}

	public static string EnsureTrailingPathSeparator(string path)
	{
		return path.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar) + Path.DirectorySeparatorChar;
	}

	public static string RemoveLeadingPathSeparator(string path)
	{
		return path.TrimStart(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
	}

	public static string RemoveTrailingPathSeparator(string path)
	{
		return path.TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);
	}

	public static string GetRelativePath(string fromFolderPath = null, string toFolderPath = null, string fromFilePath = null, string toFilePath = null)
	{
		string text = NormalizePath(fromFolderPath ?? fromFilePath);
		string text2 = NormalizePath(toFolderPath ?? toFilePath);
		if (fromFolderPath != null)
		{
			text = EnsureTrailingPathSeparator(text);
		}
		if (toFolderPath != null)
		{
			text2 = EnsureTrailingPathSeparator(text2);
		}
		Uri uri = new Uri(text);
		Uri uri2 = new Uri(text2);
		return Uri.UnescapeDataString(uri.MakeRelativeUri(uri2).ToString()).Replace('/', Path.DirectorySeparatorChar);
	}
}
