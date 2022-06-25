using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Lean.Properties
{
	// Token: 0x02000007 RID: 7
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00002152 File Offset: 0x00000352
		internal Resources()
		{
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002EAC File Offset: 0x000010AC
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (Resources.a == null)
				{
					ResourceManager resourceManager = new ResourceManager("Lean.Properties.Resources", typeof(Resources).Assembly);
					Resources.a = resourceManager;
				}
				return Resources.a;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002EEC File Offset: 0x000010EC
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002172 File Offset: 0x00000372
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.b;
			}
			set
			{
				Resources.b = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00002F00 File Offset: 0x00001100
		internal static Bitmap a_4bc3eaf172e88b1615d0dc7e9adb9ca8
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("a_4bc3eaf172e88b1615d0dc7e9adb9ca8", Resources.b);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002F2C File Offset: 0x0000112C
		internal static Bitmap download
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("download", Resources.b);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002F58 File Offset: 0x00001158
		internal static Bitmap game
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("game", Resources.b);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002F84 File Offset: 0x00001184
		internal static Bitmap hennessy_woofer
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("hennessy-woofer", Resources.b);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000028 RID: 40 RVA: 0x00002FB0 File Offset: 0x000011B0
		internal static Bitmap IGclout
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("IGclout", Resources.b);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002FDC File Offset: 0x000011DC
		internal static Bitmap kindpng_3933927
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("kindpng_3933927", Resources.b);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600002A RID: 42 RVA: 0x00003008 File Offset: 0x00001208
		internal static Bitmap lean_woofer
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("lean-woofer", Resources.b);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00003034 File Offset: 0x00001234
		internal static Bitmap pngaaa_com_3790696
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("pngaaa.com-3790696", Resources.b);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600002C RID: 44 RVA: 0x00003060 File Offset: 0x00001260
		internal static Bitmap PngItem_2354504
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("PngItem_2354504", Resources.b);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000308C File Offset: 0x0000128C
		internal static Bitmap spoof
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("spoof", Resources.b);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000030B8 File Offset: 0x000012B8
		internal static Bitmap spoof1
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("spoof1", Resources.b);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000030E4 File Offset: 0x000012E4
		internal static Bitmap valorant
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("valorant", Resources.b);
				return (Bitmap)@object;
			}
		}

		// Token: 0x0400000F RID: 15
		private static ResourceManager a;

		// Token: 0x04000010 RID: 16
		private static CultureInfo b;
	}
}
