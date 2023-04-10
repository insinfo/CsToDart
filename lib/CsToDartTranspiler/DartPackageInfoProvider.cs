using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using KineApps.Common.Diagnostics;

namespace CsToDartTranspiler;

public class DartPackageInfoProvider
{
	private readonly string m_A;

	private readonly string a;

	private readonly string B;

	private readonly string b;

	[CompilerGenerated]
	private readonly IDictionary<string, string> m_A = new SortedDictionary<string, string>();

	[CompilerGenerated]
	private readonly ISet<string> m_A = new HashSet<string>();

	public string CsProjectFilePath => B;

	public IDictionary<string, string> PathDependencies
	{
		[CompilerGenerated]
		get
		{
			return this.m_A;
		}
	}

	public ISet<string> Dependencies
	{
		[CompilerGenerated]
		get
		{
			return this.m_A;
		}
	}

	public DartPackageInfoProvider(string solutionFolderPath, string outputDir, string csProjectFilePath)
	{
		this.m_A = solutionFolderPath;
		a = outputDir;
		B = csProjectFilePath;
		b = Path.GetDirectoryName(csProjectFilePath);
	}

	public void AddPathDependency(string referencedCsProjectFolderPath, string referencedCsProjectName)
	{
		string dartLibraryNameFromCsProjectName = GetDartLibraryNameFromCsProjectName(referencedCsProjectName);
		if (!PathDependencies.ContainsKey(dartLibraryNameFromCsProjectName))
		{
			string relativePath = Util.GetRelativePath(b, referencedCsProjectFolderPath);
			relativePath = Util.RemoveTrailingPathSeparator(relativePath.Replace("\\" + referencedCsProjectName + "\\", "/" + dartLibraryNameFromCsProjectName + "/").Replace('\\', '/'));
			PathDependencies.Add(dartLibraryNameFromCsProjectName, relativePath);
		}
	}

	public string GetDartLibraryName()
	{
		return GetDartLibraryNameFromCsProjectName(Path.GetFileNameWithoutExtension(B));
	}

	public static string GetDartLibraryNameFromCsProjectName(string csProjectName)
	{
		return Util.ToLowerCaseWithUnderscores(csProjectName);
	}

	public string GetDartProjectFolderPath()
	{
		return A(this.m_A, a, b);
	}

	public string GetDartProjectLibFolderPath()
	{
		return A(this.m_A, a, b, true);
	}

	public string GetDartProjectLibSrcFolderPath()
	{
		return A(this.m_A, a, b, false, true);
	}

	public string GetDartProjectSourceFileFolderPath(string csProjectFilePath)
	{
		return A(this.m_A, a, b, false, true);
	}

	public string GetPubspecFilePath()
	{
		string text = Path.Combine(A(this.m_A, a, b), "pubspec.yaml");
		Directory.CreateDirectory(Path.GetDirectoryName(text));
		return text;
	}

	public string GetMainLibraryFilePath()
	{
		string dartProjectLibFolderPath = GetDartProjectLibFolderPath();
		string dartLibraryName = GetDartLibraryName();
		string text = Path.Combine(dartProjectLibFolderPath, dartLibraryName + ".dart");
		Directory.CreateDirectory(Path.GetDirectoryName(text));
		return text;
	}

	public string GetDartSourceFilePath(string csFilePath)
	{
		string directoryName = Path.GetDirectoryName(csFilePath);
		string path = A(this.m_A, a, directoryName, false, true);
		if (!directoryName.StartsWith(b, StringComparison.InvariantCultureIgnoreCase))
		{
			Log.Warning($"File '{csFilePath}' is not under the project folder '{b}'.", "GetDartSourceFilePath", "D:\\work\\CsToDartTranspiler\\CsToDartTranspiler\\DartPackageInfoProvider.cs", 107);
		}
		string path2 = Path.ChangeExtension(Util.ToLowerCaseWithUnderscores(Path.GetFileName(csFilePath)), ".dart");
		return Path.Combine(path, path2);
	}

	public string GetArbFilePath(string xlfFilePath)
	{
		string directoryName = Path.GetDirectoryName(xlfFilePath);
		string path = A(this.m_A, a, directoryName, true).Replace("multilingual_resources", "i18n");
		string path2 = Path.ChangeExtension(Path.GetFileName(xlfFilePath).ToLowerInvariant().Replace("-", "_"), ".arb");
		return Path.Combine(path, path2);
	}

	public string GetDartRelativeSourceFilePath(string csFilePath)
	{
		string dartSourceFilePath = GetDartSourceFilePath(csFilePath);
		string dartProjectLibFolderPath = GetDartProjectLibFolderPath();
		return dartSourceFilePath.Substring(dartProjectLibFolderPath.Length + 1).Replace('\\', '/');
	}

	private static string A(string P_0, string P_1, string P_2, bool P_3 = false, bool P_4 = false)
	{
		string text = Util.NormalizePath(P_0);
		P_2 = Util.NormalizePath(P_2);
		if (P_2.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) == 0)
		{
			int length = text.Length;
			string path = P_2.Substring(length);
			path = Util.RemoveLeadingPathSeparator(path);
			if (P_3 || P_4)
			{
				List<string> list = new List<string>(path.Split(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar));
				list.Insert(1, "lib");
				if (P_4)
				{
					list.Insert(2, "src");
				}
				path = string.Join(Path.DirectorySeparatorChar.ToString(), list.ToArray());
			}
			P_1 = Util.NormalizePath(P_1);
			P_1 = Util.EnsureTrailingPathSeparator(P_1);
			path = Util.ToLowerCaseWithUnderscores(path);
			return P_1 + path;
		}
		throw new Exception("All files must be under the solution file directory (" + P_0 + "). Failed: " + P_2);
	}
}
