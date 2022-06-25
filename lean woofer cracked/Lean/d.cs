using System;
using System.Linq;
using Microsoft.Win32;

// Token: 0x02000005 RID: 5
internal class d
{
	// Token: 0x06000016 RID: 22 RVA: 0x000029D0 File Offset: 0x00000BD0
	public static string a(int a)
	{
		return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", a).Select(new Func<string, char>(global::d.<>c.<>9.a)).ToArray<char>());
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00002A18 File Offset: 0x00000C18
	public void b()
	{
		DateTime d = new DateTime(2022, 6, 21);
		if ((DateTime.Now - d).TotalDays > 0.0)
		{
			throw new InvalidOperationException();
		}
		this.a = global::d.a(20);
		for (int i = 0; i < this.c.Length; i++)
		{
			this.c(i);
		}
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00002A84 File Offset: 0x00000C84
	private void c(int a)
	{
		DateTime t = default(DateTime).AddYears(2021).AddMonths(5).AddDays(20.5582060185185);
		if (t < DateTime.Now)
		{
			throw new ArgumentException();
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(this.c[a], true);
		if (registryKey != null)
		{
			int num = 0;
			while (num < this.d.GetLength(1) && !(this.d[a, num] == "nop"))
			{
				registryKey.SetValue(this.d[a, num], this.a);
				this.a = global::d.a(20);
				num++;
			}
			registryKey.Close();
		}
	}

	// Token: 0x06000019 RID: 25 RVA: 0x00002B58 File Offset: 0x00000D58
	public string[] d()
	{
		return this.c;
	}

	// Token: 0x0600001A RID: 26 RVA: 0x00002B70 File Offset: 0x00000D70
	public string[,] e()
	{
		return this.d;
	}

	// Token: 0x0600001B RID: 27 RVA: 0x00002B88 File Offset: 0x00000D88
	public d()
	{
		string[,] array = new string[7, 7];
		array[0, 0] = "SystemProductName";
		array[0, 1] = "Identifier";
		array[0, 2] = "Previous Update Revision";
		array[0, 3] = "ProcessorNameString";
		array[0, 4] = "VendorIdentifier";
		array[0, 5] = "Platform Specific Field1";
		array[0, 6] = "Component Information";
		array[1, 0] = "SerialNumber";
		array[1, 1] = "Identifier";
		array[1, 2] = "SystemManufacturer";
		array[1, 3] = "nop";
		array[1, 4] = "nop";
		array[1, 5] = "nop";
		array[1, 6] = "nop";
		array[2, 0] = "ComputerHardwareId";
		array[2, 1] = "ComputerHardwareIds";
		array[2, 2] = "BIOSVendor";
		array[2, 3] = "ProductId";
		array[2, 4] = "ProcessorNameString";
		array[2, 5] = "BIOSReleaseDate";
		array[2, 6] = "nop";
		array[3, 0] = "ProductId";
		array[3, 1] = "InstallDate";
		array[3, 2] = "InstallTime";
		array[3, 3] = "nop";
		array[3, 4] = "nop";
		array[3, 5] = "nop";
		array[3, 6] = "nop";
		array[4, 0] = "SusClientId";
		array[4, 1] = "nop";
		array[4, 2] = "nop";
		array[4, 3] = "nop";
		array[4, 4] = "nop";
		array[4, 5] = "nop";
		array[4, 6] = "nop";
		array[5, 0] = "NetCfgInstanceId";
		array[5, 1] = "NetLuidIndex";
		array[5, 2] = "nop";
		array[5, 3] = "nop";
		array[5, 4] = "nop";
		array[5, 5] = "nop";
		array[5, 6] = "nop";
		array[6, 0] = "NetworkAddress";
		array[6, 1] = "NetCfgInstanceId";
		array[6, 2] = "NetworkInterfaceInstallTimestamp";
		array[6, 3] = "nop";
		array[6, 4] = "nop";
		array[6, 5] = "nop";
		array[6, 6] = "nop";
		this.d = array;
		base..ctor();
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002E6C File Offset: 0x0000106C
	// Note: this type is marked as 'beforefieldinit'.
	static d()
	{
		DateTime t = new DateTime(2022, 6, 20, 22, 12, 15);
		if (DateTime.Now > t)
		{
		}
		global::d.b = new Random();
	}

	// Token: 0x04000009 RID: 9
	private string a;

	// Token: 0x0400000A RID: 10
	private static Random b;

	// Token: 0x0400000B RID: 11
	private string[] c = new string[]
	{
		"Hardware\\Description\\System\\CentralProcessor\\0",
		"HARDWARE\\DEVICEMAP\\Scsi\\Scsi Port 0\\Scsi Bus 0\\Target Id 0\\Logical Unit Id 0",
		"SYSTEM\\CurrentControlSet\\Control\\SystemInformation",
		"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion",
		"SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\WindowsUpdate",
		"SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0001",
		"SYSTEM\\CurrentControlSet\\Control\\Class\\{4d36e972-e325-11ce-bfc1-08002be10318}\\0012"
	};

	// Token: 0x0400000C RID: 12
	private string[,] d;
}
