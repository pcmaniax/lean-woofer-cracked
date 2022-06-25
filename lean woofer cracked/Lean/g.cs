using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

// Token: 0x0200001F RID: 31
[CompilerGenerated]
internal static class g
{
	// Token: 0x06000155 RID: 341 RVA: 0x0000266C File Offset: 0x0000086C
	private static string a(CultureInfo a)
	{
		if (a == null)
		{
			return "";
		}
		return a.Name;
	}

	// Token: 0x06000156 RID: 342 RVA: 0x000134C4 File Offset: 0x000116C4
	private static Assembly b(AssemblyName a)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		foreach (Assembly assembly in assemblies)
		{
			AssemblyName name = assembly.GetName();
			if (string.Equals(name.Name, a.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(global::g.a(name.CultureInfo), global::g.a(a.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
			{
				return assembly;
			}
		}
		return null;
	}

	// Token: 0x06000157 RID: 343 RVA: 0x00013534 File Offset: 0x00011734
	private static void c(Stream a, Stream b)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = a.Read(array, 0, array.Length)) != 0)
		{
			b.Write(array, 0, count);
		}
	}

	// Token: 0x06000158 RID: 344 RVA: 0x00013568 File Offset: 0x00011768
	private static Stream d(string a)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (a.EndsWith(".compressed"))
		{
			Stream result;
			using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(a))
			{
				using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
				{
					MemoryStream memoryStream = new MemoryStream();
					global::g.c(deflateStream, memoryStream);
					memoryStream.Position = 0L;
					result = memoryStream;
				}
			}
			return result;
		}
		return executingAssembly.GetManifestResourceStream(a);
	}

	// Token: 0x06000159 RID: 345 RVA: 0x000135F4 File Offset: 0x000117F4
	private static Stream e(Dictionary<string, string> a, string b)
	{
		string text;
		if (a.TryGetValue(b, out text))
		{
			return global::g.d(text);
		}
		return null;
	}

	// Token: 0x0600015A RID: 346 RVA: 0x00013614 File Offset: 0x00011814
	private static byte[] f(Stream a)
	{
		byte[] array = new byte[a.Length];
		a.Read(array, 0, array.Length);
		return array;
	}

	// Token: 0x0600015B RID: 347 RVA: 0x0001363C File Offset: 0x0001183C
	private static Assembly g(Dictionary<string, string> a, Dictionary<string, string> b, AssemblyName c)
	{
		string str = c.Name.ToLowerInvariant();
		if (c.CultureInfo != null && !string.IsNullOrEmpty(c.CultureInfo.Name))
		{
			str = c.CultureInfo.Name + "." + str;
		}
		byte[] rawAssembly;
		using (Stream stream = global::g.e(a, str))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = global::g.f(stream);
		}
		using (Stream stream2 = global::g.e(b, str))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = global::g.f(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	// Token: 0x0600015C RID: 348 RVA: 0x000136FC File Offset: 0x000118FC
	public static Assembly h(object a, ResolveEventArgs b)
	{
		object obj = global::g.a;
		lock (obj)
		{
			if (global::g.b.ContainsKey(b.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(b.Name);
		Assembly assembly = global::g.b(assemblyName);
		if (assembly != null)
		{
			return assembly;
		}
		assembly = global::g.g(global::g.c, global::g.d, assemblyName);
		if (assembly == null)
		{
			object obj2 = global::g.a;
			lock (obj2)
			{
				global::g.b[b.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	// Token: 0x0600015D RID: 349 RVA: 0x000137D4 File Offset: 0x000119D4
	// Note: this type is marked as 'beforefieldinit'.
	static g()
	{
		global::g.c.Add("circularprogressbar", "costura.circularprogressbar.dll.compressed");
		global::g.c.Add("costura", "costura.costura.dll.compressed");
		global::g.d.Add("costura", "costura.costura.pdb.compressed");
		global::g.c.Add("metroframework.design", "costura.metroframework.design.dll.compressed");
		global::g.c.Add("metroframework", "costura.metroframework.dll.compressed");
		global::g.c.Add("metroframework.fonts", "costura.metroframework.fonts.dll.compressed");
		global::g.c.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
		global::g.c.Add("proxyclient", "costura.proxyclient.dll.compressed");
		global::g.c.Add("siticone.ui", "costura.siticone.ui.dll.compressed");
		global::g.c.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
		global::g.c.Add("winformanimation", "costura.winformanimation.dll.compressed");
	}

	// Token: 0x0600015E RID: 350 RVA: 0x000138E8 File Offset: 0x00011AE8
	public static void i()
	{
		if (Interlocked.Exchange(ref global::g.e, 1) == 1)
		{
			return;
		}
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.AssemblyResolve += global::g.h;
	}

	// Token: 0x040000CE RID: 206
	private static object a = new object();

	// Token: 0x040000CF RID: 207
	private static Dictionary<string, bool> b = new Dictionary<string, bool>();

	// Token: 0x040000D0 RID: 208
	private static Dictionary<string, string> c = new Dictionary<string, string>();

	// Token: 0x040000D1 RID: 209
	private static Dictionary<string, string> d = new Dictionary<string, string>();

	// Token: 0x040000D2 RID: 210
	private static int e;
}
