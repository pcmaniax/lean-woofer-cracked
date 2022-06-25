using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Lean.Properties
{
	// Token: 0x02000008 RID: 8
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003110 File Offset: 0x00001310
		public static Settings Default
		{
			get
			{
				return Settings.a;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00003124 File Offset: 0x00001324
		// (set) Token: 0x06000032 RID: 50 RVA: 0x0000217A File Offset: 0x0000037A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string username
		{
			get
			{
				return (string)this["username"];
			}
			set
			{
				this["username"] = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000033 RID: 51 RVA: 0x00003144 File Offset: 0x00001344
		// (set) Token: 0x06000034 RID: 52 RVA: 0x000031B8 File Offset: 0x000013B8
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string password
		{
			get
			{
				DateTime d = default(DateTime).AddYears(2021).AddMonths(5).AddDays(20.4778935185185);
				if ((DateTime.Now - d).TotalDays > 0.0)
				{
					throw new Exception();
				}
				return (string)this["password"];
			}
			set
			{
				DateTime d = new DateTime(2022, 6, 21, 3, 31, 8);
				if ((DateTime.Now - d).TotalDays > 0.0)
				{
				}
				this["password"] = value;
			}
		}

		// Token: 0x04000011 RID: 17
		private static Settings a;
	}
}
