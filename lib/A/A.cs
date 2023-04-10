using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace A;

[CompilerGenerated]
internal sealed class A<A, a>
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly A m_A;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly a m_A;

	[SpecialName]
	public A A()
	{
		return this.A;
	}

	[SpecialName]
	public a a()
	{
		return this.A;
	}

	[DebuggerHidden]
	public A(A P_0, a P_1)
	{
		this.A = P_0;
		this.A = P_1;
	}

	[DebuggerHidden]
	public override bool Equals(object value)
	{
		A<A, a> a2 = value as A<A, a>;
		if (this != a2)
		{
			if (a2 != null && EqualityComparer<A>.Default.Equals(this.A, a2.A))
			{
				return EqualityComparer<a>.Default.Equals(this.A, a2.A);
			}
			return false;
		}
		return true;
	}

	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (747490883 * -1521134295 + EqualityComparer<A>.Default.GetHashCode(this.A)) * -1521134295 + EqualityComparer<a>.Default.GetHashCode(this.A);
	}

	[DebuggerHidden]
	[return: B(1)]
	public override string ToString()
	{
		object[] array = new object[2];
		A val = this.A;
		array[0] = ((val != null) ? val.ToString() : null);
		a val2 = this.A;
		array[1] = ((val2 != null) ? val2.ToString() : null);
		return string.Format(null, "{{ exp = {0}, symbol = {1} }}", array);
	}
}
[CompilerGenerated]
[a]
internal sealed class a : Attribute
{
}
