using System;
using System.Windows.Forms;
using Lean.Forms;

// Token: 0x0200001E RID: 30
internal static class f
{
	// Token: 0x06000154 RID: 340 RVA: 0x00013454 File Offset: 0x00011654
	[STAThread]
	private static void Main()
	{
		DateTime d = default(DateTime).AddYears(2021).AddMonths(5).AddDays(20.1525578703704);
		if ((DateTime.Now - d).TotalDays <= 0.0)
		{
		}
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new Login());
	}
}
