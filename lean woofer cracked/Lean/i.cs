using System;
using System.IO;
using System.Reflection;

// Token: 0x02000021 RID: 33
internal sealed class i
{
	// Token: 0x0600015F RID: 351 RVA: 0x0001391C File Offset: 0x00011B1C
	public static string a(string a, int b)
	{
		DateTime d = default(DateTime).AddYears(2021).AddMonths(5).AddDays(20.0268865740741);
		if ((d - DateTime.Now).TotalDays < 0.0)
		{
		}
		return i.b.b.c(a, b);
	}

	// Token: 0x06000160 RID: 352 RVA: 0x00013984 File Offset: 0x00011B84
	public static string b()
	{
		char[] array = "\u001a#\u00193\u0004".ToCharArray();
		int num = array.Length;
		while (--num >= 0)
		{
			array[num] ^= 'W';
		}
		return new string(array);
	}

	// Token: 0x02000022 RID: 34
	// (Invoke) Token: 0x06000163 RID: 355
	private delegate string a();

	// Token: 0x02000023 RID: 35
	private sealed class b
	{
		// Token: 0x06000167 RID: 359 RVA: 0x000139D8 File Offset: 0x00011BD8
		private b()
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(i.b.a());
			if (manifestResourceStream != null)
			{
				this.c = new byte[16];
				manifestResourceStream.Read(this.c, 0, this.c.Length);
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00013A44 File Offset: 0x00011C44
		public string c(string a, int b)
		{
			int num = a.Length;
			char[] array = a.ToCharArray();
			while (--num >= 0)
			{
				array[num] = (char)((int)array[num] ^ ((int)this.c[b & 15] | b));
			}
			return new string(array);
		}

		// Token: 0x040000D5 RID: 213
		private static readonly i.a a = new i.a(i.b);

		// Token: 0x040000D6 RID: 214
		public static readonly i.b b = new i.b();

		// Token: 0x040000D7 RID: 215
		private byte[] c;
	}
}
