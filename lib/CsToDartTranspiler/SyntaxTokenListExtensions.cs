using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.CodeAnalysis;

namespace CsToDartTranspiler;

public static class SyntaxTokenListExtensions
{
	[CompilerGenerated]
	private sealed class A
	{
		public string A;

		internal bool A(SyntaxToken P_0)
		{
			return P_0.Text == this.A;
		}
	}

	public static bool Contains(this SyntaxTokenList mods, string mod)
	{
		return mods.Any((SyntaxToken P_0) => P_0.Text == mod);
	}
}
