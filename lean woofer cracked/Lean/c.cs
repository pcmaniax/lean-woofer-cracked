using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
[CompilerGenerated]
[DebuggerDisplay("\\{ icon_url = {icon_url}, text = {text} }", Type = "<Anonymous Type>")]
internal sealed class c<g, h>
{
	// Token: 0x17000007 RID: 7
	// (get) Token: 0x06000010 RID: 16 RVA: 0x000020F1 File Offset: 0x000002F1
	public g icon_url
	{
		get
		{
			return this.a;
		}
	}

	// Token: 0x17000008 RID: 8
	// (get) Token: 0x06000011 RID: 17 RVA: 0x000020F9 File Offset: 0x000002F9
	public h text
	{
		get
		{
			return this.b;
		}
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002101 File Offset: 0x00000301
	[DebuggerHidden]
	public c(g a, h b)
	{
		this.a = a;
		this.b = b;
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002910 File Offset: 0x00000B10
	[DebuggerHidden]
	public override bool Equals(object a)
	{
		c<g, h> c = a as c<g, h>;
		return this == c || (c != null && EqualityComparer<g>.Default.Equals(this.a, c.a) && EqualityComparer<h>.Default.Equals(this.b, c.b));
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002117 File Offset: 0x00000317
	[DebuggerHidden]
	public override int GetHashCode()
	{
		return (-934571874 + EqualityComparer<g>.Default.GetHashCode(this.a)) * -1521134295 + EqualityComparer<h>.Default.GetHashCode(this.b);
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00002960 File Offset: 0x00000B60
	[DebuggerHidden]
	public override string ToString()
	{
		IFormatProvider provider = null;
		string format = "{{ icon_url = {0}, text = {1} }}";
		object[] array = new object[2];
		int num = 0;
		g g = this.a;
		array[num] = ((g != null) ? g.ToString() : null);
		int num2 = 1;
		h h = this.b;
		array[num2] = ((h != null) ? h.ToString() : null);
		return string.Format(provider, format, array);
	}

	// Token: 0x04000007 RID: 7
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly g a;

	// Token: 0x04000008 RID: 8
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly h b;
}
