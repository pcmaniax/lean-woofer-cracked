using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Media;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Timers;
using System.Windows.Forms;
using Lean.Resources;
using Newtonsoft.Json;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace Lean.Forms
{
	// Token: 0x0200000B RID: 11
	public partial class Login : Form
	{
		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x000022CA File Offset: 0x000004CA
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000022D2 File Offset: 0x000004D2
		public object JsonConvert { get; private set; }

		// Token: 0x060000A5 RID: 165 RVA: 0x0000F058 File Offset: 0x0000D258
		public Login()
		{
			System.Timers.Timer timer = new System.Timers.Timer(50.0);
			timer.AutoReset = true;
			timer.Elapsed += Login.MyMethod;
			timer.Start();
			this.u();
			this.r.Hide();
			this.q.Hide();
			this.u.Hide();
			this.v.Hide();
			this.s.Hide();
			this.t.Hide();
			this.w.Hide();
			this.x.Hide();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000022DB File Offset: 0x000004DB
		public static void MyMethod(object sender, ElapsedEventArgs e)
		{
			Login.b();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002190 File Offset: 0x00000390
		private void a(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00007984 File Offset: 0x00005B84
		private static void b()
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

		// Token: 0x060000A9 RID: 169 RVA: 0x0000F100 File Offset: 0x0000D300
		private void c(object sender, EventArgs e)
		{
			Login.b();
			string path = "C:\\Program Files\\Sounds";
			if (!Directory.Exists(path))
			{
				DirectoryInfo directoryInfo = Directory.CreateDirectory(path);
				directoryInfo.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
			}
			else
			{
				Directory.CreateDirectory("C:\\Program Files\\Sounds");
				DirectoryInfo directoryInfo2 = Directory.CreateDirectory(path);
				directoryInfo2.Attributes = (FileAttributes.Hidden | FileAttributes.Directory);
			}
			this.z.Show();
			if (File.Exists("C:\\Program Files\\leanuser.txt"))
			{
				string text = File.ReadAllText("C:\\Program Files\\leanuser.txt");
				this.n.Text = text;
			}
			if (File.Exists("C:\\Program Files\\leanpass.txt"))
			{
				string text2 = File.ReadAllText("C:\\Program Files\\leanpass.txt");
				this.y.Text = text2;
			}
			base.Size = new Size(219, 235);
			Login.KeyAuthApp.init();
			if (new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
			{
				if (!Login.KeyAuthApp.response.success)
				{
					DialogResult dialogResult = MessageBox.Show("A new version is unavailable, do you want to use it or exit?", "Lean - Auto Updater", MessageBoxButtons.OKCancel);
					DialogResult dialogResult2 = dialogResult;
					DialogResult dialogResult3 = dialogResult2;
					if (dialogResult3 != DialogResult.OK)
					{
						if (dialogResult3 == DialogResult.Cancel)
						{
							Application.Exit();
						}
					}
					else
					{
						Process.Start(Login.KeyAuthApp.app_data.downloadLink);
						Environment.Exit(0);
					}
				}
			}
			else
			{
				MessageBox.Show("Please Run As Admin", "Lean Woofer", MessageBoxButtons.OK);
				Application.Exit();
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000F24C File Offset: 0x0000D44C
		private static string d()
		{
			string text = null;
			Random random = new Random();
			for (int i = 0; i < 5; i++)
			{
				text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0))).ToString();
			}
			return text;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000022E2 File Offset: 0x000004E2
		public static void sendWebHook(string Url, string msg, string Username, string Plan)
		{
			global::e.a(Url, new NameValueCollection
			{
				{
					"username",
					Username
				},
				{
					"content",
					msg
				},
				{
					"content",
					Plan
				}
			});
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002314 File Offset: 0x00000514
		public static void sendWebHookregister(string Url, string msg, string Username, string Plan, string Key)
		{
			global::e.a(Url, new NameValueCollection
			{
				{
					"username",
					Username
				},
				{
					"content",
					msg
				},
				{
					"content",
					Plan
				},
				{
					"content",
					Key
				}
			});
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000F2AC File Offset: 0x0000D4AC
		private void e(object sender, EventArgs e)
		{
			try
			{
				Login.KeyAuthApp.login(this.n.Text, this.y.Text);
				if (Login.KeyAuthApp.response.success)
				{
					string[] array = new string[]
					{
						this.n.Text
					};
					string path = "C:\\Program Files";
					string path2 = "C:\\Program Files\\leanuser.txt";
					if (File.Exists(path2))
					{
						File.Delete(path2);
					}
					using (StreamWriter streamWriter = new StreamWriter(Path.Combine(path, "leanuser.txt")))
					{
						foreach (string value in array)
						{
							streamWriter.WriteLine(value);
						}
					}
					string[] array3 = new string[]
					{
						this.y.Text
					};
					string path3 = "C:\\Program Files";
					string path4 = "C:\\Program Files\\leanpass.txt";
					if (File.Exists(path4))
					{
						File.Delete(path4);
					}
					using (StreamWriter streamWriter2 = new StreamWriter(Path.Combine(path3, "leanpass.txt")))
					{
						foreach (string value2 in array3)
						{
							streamWriter2.WriteLine(value2);
						}
					}
					Main main = new Main();
					main.Show();
					base.Hide();
					string requestUriString = "https://canary.discord.com/api/webhooks/982980419018424320/xwPrVT_UkxfvG9rsxh_PuldVhyuzMpH82Lyx3u7bqX9tvHelREJAco4x4BelekCbDtqX";
					WebRequest webRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
					webRequest.ContentType = "application/json";
					webRequest.Method = "POST";
					using (StreamWriter streamWriter3 = new StreamWriter(webRequest.GetRequestStream()))
					{
						string value3 = Newtonsoft.Json.JsonConvert.SerializeObject(new a<string, b<string, string, string, c<string, string>>[]>("Lean Woofer", new b<string, string, string, c<string, string>>[]
						{
							new b<string, string, string, c<string, string>>("\ud83d\udd0b Plan: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription, Login.KeyAuthApp.user_data.username + " Just Logged In ! \ud83c\udf89", "7419530", new c<string, string>("https://cdn.discordapp.com/icons/947422005911769119/a_428d49fb73373a07bd85bdd0da14442d.gif", "Thanks for using Lean Woofer \ud83d\udc9c "))
						}));
						streamWriter3.Write(value3);
					}
					HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
					string path5 = "C:\\Program Files\\Sounds";
					if (!Directory.Exists(path5))
					{
						Directory.CreateDirectory(path5);
					}
					if (File.Exists("C:\\Program Files\\Sounds\\welcome.wav"))
					{
						new SoundPlayer("C:\\Program Files\\Sounds\\welcome.wav").Play();
					}
					else
					{
						string address = "https://cdn.discordapp.com/attachments/953684464104513571/959157128357097502/welcome.wav";
						string fileName = "C:\\Program Files\\Sounds\\welcome.wav";
						WebClient webClient = new WebClient();
						webClient.DownloadFile(address, fileName);
						File.SetAttributes("C:\\Program Files\\Sounds\\welcome.wav", FileAttributes.Hidden);
						new SoundPlayer("C:\\Program Files\\Sounds\\welcome.wav").Play();
					}
				}
				else
				{
					MessageBox.Show(Login.KeyAuthApp.response.message, "LeanAuth: Failed to login", MessageBoxButtons.OK);
				}
			}
			catch
			{
			}
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000F5BC File Offset: 0x0000D7BC
		private void f(object sender, EventArgs e)
		{
			this.z.Hide();
			base.Size = new Size(219, 266);
			this.n.Hide();
			this.o.Hide();
			this.p.Hide();
			this.y.Hide();
			this.m.Hide();
			this.l.Hide();
			this.y.Hide();
			this.r.Show();
			this.q.Show();
			this.u.Show();
			this.v.Show();
			this.s.Show();
			this.t.Show();
			this.w.Show();
			this.x.Show();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002198 File Offset: 0x00000398
		private void g(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002198 File Offset: 0x00000398
		private void h(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002198 File Offset: 0x00000398
		private void i(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002198 File Offset: 0x00000398
		private void j(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002198 File Offset: 0x00000398
		private void k(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000F690 File Offset: 0x0000D890
		private void l(object sender, EventArgs e)
		{
			Login.KeyAuthApp.register(this.q.Text, this.v.Text, this.t.Text);
			if (Login.KeyAuthApp.response.success)
			{
				string[] array = new string[]
				{
					this.q.Text
				};
				string path = "C:\\Program Files";
				string path2 = "C:\\Program Files\\leanuser.txt";
				if (File.Exists(path2))
				{
					File.Delete(path2);
				}
				using (StreamWriter streamWriter = new StreamWriter(Path.Combine(path, "leanuser.txt")))
				{
					foreach (string value in array)
					{
						streamWriter.WriteLine(value);
					}
					File.SetAttributes("C:\\Program Files\\leanuser.txt", FileAttributes.Hidden);
				}
				string[] array3 = new string[]
				{
					this.v.Text
				};
				string path3 = "C:\\Program Files";
				string path4 = "C:\\Program Files\\leanpass.txt";
				if (File.Exists(path4))
				{
					File.Delete(path4);
				}
				using (StreamWriter streamWriter2 = new StreamWriter(Path.Combine(path3, "leanpass.txt")))
				{
					foreach (string value2 in array3)
					{
						streamWriter2.WriteLine(value2);
					}
					File.SetAttributes("C:\\Program Files\\leanpass.txt", FileAttributes.Hidden);
				}
				if (Login.KeyAuthApp.user_data.subscriptions[0].subscription == "Developer")
				{
				}
				string requestUriString = "https://canary.discord.com/api/webhooks/982980419018424320/xwPrVT_UkxfvG9rsxh_PuldVhyuzMpH82Lyx3u7bqX9tvHelREJAco4x4BelekCbDtqX";
				WebRequest webRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
				webRequest.ContentType = "application/json";
				webRequest.Method = "POST";
				using (StreamWriter streamWriter3 = new StreamWriter(webRequest.GetRequestStream()))
				{
					string value3 = Newtonsoft.Json.JsonConvert.SerializeObject(new a<string, b<string, string, string, c<string, string>>[]>("Lean Woofer", new b<string, string, string, c<string, string>>[]
					{
						new b<string, string, string, c<string, string>>("\ud83d\udd0b Plan: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription + "\nAdp: " + Login.KeyAuthApp.user_data.ip, Login.KeyAuthApp.user_data.username + " Just Logged First Time ! \ud83c\udf89", "7419530", new c<string, string>("https://cdn.discordapp.com/icons/947422005911769119/a_428d49fb73373a07bd85bdd0da14442d.gif", "Thanks for using Lean Woofer \ud83d\udc9c "))
					}));
					streamWriter3.Write(value3);
				}
				HttpWebResponse httpWebResponse = (HttpWebResponse)webRequest.GetResponse();
				string requestUriString2 = "https://canary.discord.com/api/webhooks/982976054069186590/h01rdxhixyt8MuSnm8RjfJLenXG2r9sbM0lflbKU9j3KDfWDTr4GqP2ZZMau3f-M1zw-";
				WebRequest webRequest2 = (HttpWebRequest)WebRequest.Create(requestUriString2);
				webRequest2.ContentType = "application/json";
				webRequest2.Method = "POST";
				using (StreamWriter streamWriter4 = new StreamWriter(webRequest2.GetRequestStream()))
				{
					string value4 = Newtonsoft.Json.JsonConvert.SerializeObject(new a<string, b<string, string, string, c<string, string>>[]>("Lean Woofer", new b<string, string, string, c<string, string>>[]
					{
						new b<string, string, string, c<string, string>>("\ud83d\udd0b Plan: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription + "\n\ud83d\udd11 License: " + this.t.Text, this.q.Text + " Just Registered! \ud83c\udf89", "7419530", new c<string, string>("https://cdn.discordapp.com/icons/947422005911769119/a_428d49fb73373a07bd85bdd0da14442d.gif", "Thanks for buying Lean Woofer \ud83d\udc9c "))
					}));
					streamWriter4.Write(value4);
				}
				HttpWebResponse httpWebResponse2 = (HttpWebResponse)webRequest2.GetResponse();
				Main main = new Main();
				main.Show();
				base.Hide();
				MessageBox.Show("Thanks For Choosing Lean Woofer, Welcome!", "LeanAuth", MessageBoxButtons.OK);
			}
			else
			{
				MessageBox.Show(Login.KeyAuthApp.response.message, "LeanAuth: Failed to login", MessageBoxButtons.OK);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000FA40 File Offset: 0x0000DC40
		private void m(object sender, EventArgs e)
		{
			this.z.Show();
			base.Size = new Size(219, 235);
			this.n.Hide();
			this.o.Show();
			this.p.Show();
			this.y.Show();
			this.m.Show();
			this.l.Show();
			this.y.Show();
			this.n.Show();
			this.r.Hide();
			this.q.Hide();
			this.u.Hide();
			this.v.Hide();
			this.s.Hide();
			this.t.Hide();
			this.w.Hide();
			this.x.Hide();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002198 File Offset: 0x00000398
		private void n(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000021F3 File Offset: 0x000003F3
		private void o(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/unban");
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002198 File Offset: 0x00000398
		private void p(object sender, EventArgs e)
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002353 File Offset: 0x00000553
		private void q(object sender, MouseEventArgs e)
		{
			this.b = true;
			this.c = e.Location;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000FB20 File Offset: 0x0000DD20
		private void r(object sender, MouseEventArgs e)
		{
			if (this.b)
			{
				base.Location = new Point(base.Location.X - this.c.X + e.X, base.Location.Y - this.c.Y + e.Y);
				base.Update();
			}
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002368 File Offset: 0x00000568
		private void s(object sender, MouseEventArgs e)
		{
			this.b = false;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002198 File Offset: 0x00000398
		private void t(object sender, EventArgs e)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000FBB8 File Offset: 0x0000DDB8
		private void u()
		{
			this.d = new Container();
			Animation animation = new Animation();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Login));
			this.e = new SiticoneDragControl(this.d);
			this.f = new SiticoneControlBox();
			this.g = new SiticoneControlBox();
			this.h = new SiticoneTransition();
			this.i = new Label();
			this.j = new Label();
			this.m = new SiticoneButton();
			this.l = new SiticoneButton();
			this.n = new SiticoneTextBox();
			this.o = new Label();
			this.p = new Label();
			this.q = new SiticoneTextBox();
			this.r = new Label();
			this.u = new Label();
			this.v = new SiticoneTextBox();
			this.s = new Label();
			this.t = new SiticoneTextBox();
			this.w = new SiticoneButton();
			this.x = new SiticoneButton();
			this.y = new SiticoneTextBox();
			this.z = new SiticoneLabel();
			this.k = new SiticoneShadowForm(this.d);
			this.aa = new System.Windows.Forms.Timer(this.d);
			this.ab = new System.Windows.Forms.Timer(this.d);
			base.SuspendLayout();
			this.e.TargetControl = this;
			this.f.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.f.BorderRadius = 10;
			this.h.SetDecoration(this.f, 0);
			this.f.FillColor = Color.FromArgb(26, 32, 54);
			this.f.HoveredState.FillColor = Color.FromArgb(232, 17, 35);
			this.f.HoveredState.IconColor = Color.White;
			this.f.HoveredState.Parent = this.f;
			this.f.IconColor = Color.White;
			this.f.Location = new Point(190, 7);
			this.f.Name = "siticoneControlBox1";
			this.f.PressedColor = Color.DarkRed;
			this.f.ShadowDecoration.Parent = this.f;
			this.f.Size = new Size(45, 29);
			this.f.TabIndex = 1;
			this.f.Click += this.a;
			this.g.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.g.BorderRadius = 10;
			this.g.ControlBoxType = 0;
			this.h.SetDecoration(this.g, 0);
			this.g.FillColor = Color.FromArgb(26, 32, 54);
			this.g.HoveredState.Parent = this.g;
			this.g.IconColor = Color.White;
			this.g.Location = new Point(139, 7);
			this.g.Name = "siticoneControlBox2";
			this.g.PressedColor = Color.DarkRed;
			this.g.ShadowDecoration.Parent = this.g;
			this.g.Size = new Size(45, 29);
			this.g.TabIndex = 2;
			this.g.Click += this.t;
			this.h.AnimationType = 1;
			this.h.Cursor = null;
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
			this.h.DefaultAnimation = animation;
			this.i.AutoSize = true;
			this.h.SetDecoration(this.i, 0);
			this.i.Font = new Font("Segoe UI Light", 10f);
			this.i.ForeColor = Color.White;
			this.i.Location = new Point(-1, 136);
			this.i.Name = "label1";
			this.i.Size = new Size(0, 19);
			this.i.TabIndex = 22;
			this.j.AutoSize = true;
			this.h.SetDecoration(this.j, 0);
			this.j.Font = new Font("Segoe UI Semibold", 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.j.ForeColor = Color.White;
			this.j.Location = new Point(9, 9);
			this.j.Margin = new Padding(2, 0, 2, 0);
			this.j.Name = "label2";
			this.j.Size = new Size(89, 19);
			this.j.TabIndex = 27;
			this.j.Text = "Lean Woofer";
			this.j.Click += this.p;
			this.m.BorderColor = Color.Red;
			this.m.BorderRadius = 4;
			this.m.BorderThickness = 2;
			this.m.CheckedState.Parent = this.m;
			this.m.CustomImages.Parent = this.m;
			this.h.SetDecoration(this.m, 0);
			this.m.FillColor = Color.FromArgb(26, 32, 54);
			this.m.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.m.ForeColor = Color.White;
			this.m.HoveredState.Parent = this.m;
			this.m.Location = new Point(36, 178);
			this.m.Name = "PingButton";
			this.m.PressedColor = Color.FromArgb(26, 32, 54);
			this.m.ShadowDecoration.Parent = this.m;
			this.m.Size = new Size(72, 32);
			this.m.TabIndex = 36;
			this.m.Text = "LOGIN";
			this.m.Click += this.e;
			this.l.BorderColor = Color.Red;
			this.l.BorderRadius = 4;
			this.l.BorderThickness = 2;
			this.l.CheckedState.Parent = this.l;
			this.l.CustomImages.Parent = this.l;
			this.h.SetDecoration(this.l, 0);
			this.l.FillColor = Color.FromArgb(26, 32, 54);
			this.l.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.l.ForeColor = Color.White;
			this.l.HoveredState.Parent = this.l;
			this.l.Location = new Point(114, 178);
			this.l.Name = "siticoneButton1";
			this.l.PressedColor = Color.FromArgb(26, 32, 54);
			this.l.ShadowDecoration.Parent = this.l;
			this.l.Size = new Size(81, 32);
			this.l.TabIndex = 37;
			this.l.Text = "REGISTER";
			this.l.Click += this.f;
			this.n.BorderColor = Color.White;
			this.n.BorderRadius = 3;
			this.n.Cursor = Cursors.IBeam;
			this.h.SetDecoration(this.n, 0);
			this.n.DefaultText = "";
			this.n.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.n.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.n.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.n.DisabledState.Parent = this.n;
			this.n.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.n.FillColor = Color.FromArgb(26, 32, 54);
			this.n.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.n.FocusedState.Parent = this.n;
			this.n.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.n.HoveredState.Parent = this.n;
			this.n.Location = new Point(37, 64);
			this.n.Margin = new Padding(4);
			this.n.Name = "UsernameTB";
			this.n.PasswordChar = '\0';
			this.n.PlaceholderText = "";
			this.n.SelectedText = "";
			this.n.ShadowDecoration.Parent = this.n;
			this.n.Size = new Size(159, 37);
			this.n.TabIndex = 39;
			this.n.TextChanged += this.g;
			this.o.AutoSize = true;
			this.h.SetDecoration(this.o, 0);
			this.o.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.o.ForeColor = Color.Red;
			this.o.Location = new Point(34, 41);
			this.o.Name = "label10";
			this.o.Size = new Size(78, 19);
			this.o.TabIndex = 38;
			this.o.Text = "Username";
			this.o.Click += this.h;
			this.p.AutoSize = true;
			this.h.SetDecoration(this.p, 0);
			this.p.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.p.ForeColor = Color.Red;
			this.p.Location = new Point(32, 105);
			this.p.Name = "label3";
			this.p.Size = new Size(76, 19);
			this.p.TabIndex = 41;
			this.p.Text = "Password";
			this.q.BorderColor = Color.White;
			this.q.BorderRadius = 3;
			this.q.Cursor = Cursors.IBeam;
			this.h.SetDecoration(this.q, 0);
			this.q.DefaultText = "";
			this.q.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.q.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.q.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.q.DisabledState.Parent = this.q;
			this.q.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.q.FillColor = Color.FromArgb(26, 32, 54);
			this.q.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.q.FocusedState.Parent = this.q;
			this.q.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.q.HoveredState.Parent = this.q;
			this.q.Location = new Point(37, 64);
			this.q.Margin = new Padding(4);
			this.q.Name = "siticoneTextBox2";
			this.q.PasswordChar = '\0';
			this.q.PlaceholderText = "";
			this.q.SelectedText = "";
			this.q.ShadowDecoration.Parent = this.q;
			this.q.Size = new Size(159, 37);
			this.q.TabIndex = 43;
			this.r.AutoSize = true;
			this.h.SetDecoration(this.r, 0);
			this.r.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.r.ForeColor = Color.Red;
			this.r.Location = new Point(34, 41);
			this.r.Name = "label4";
			this.r.Size = new Size(78, 19);
			this.r.TabIndex = 42;
			this.r.Text = "Username";
			this.u.AutoSize = true;
			this.h.SetDecoration(this.u, 0);
			this.u.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.u.ForeColor = Color.Red;
			this.u.Location = new Point(32, 105);
			this.u.Name = "label5";
			this.u.Size = new Size(76, 19);
			this.u.TabIndex = 45;
			this.u.Text = "Password";
			this.v.BorderColor = Color.White;
			this.v.BorderRadius = 3;
			this.v.Cursor = Cursors.IBeam;
			this.h.SetDecoration(this.v, 0);
			this.v.DefaultText = "";
			this.v.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.v.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.v.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.v.DisabledState.Parent = this.v;
			this.v.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.v.FillColor = Color.FromArgb(26, 32, 54);
			this.v.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.v.FocusedState.Parent = this.v;
			this.v.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.v.HoveredState.Parent = this.v;
			this.v.Location = new Point(36, 128);
			this.v.Margin = new Padding(4);
			this.v.Name = "siticoneTextBox3";
			this.v.PasswordChar = '\0';
			this.v.PlaceholderText = "";
			this.v.SelectedText = "";
			this.v.ShadowDecoration.Parent = this.v;
			this.v.Size = new Size(159, 37);
			this.v.TabIndex = 44;
			this.v.UseSystemPasswordChar = true;
			this.s.AutoSize = true;
			this.h.SetDecoration(this.s, 0);
			this.s.Font = new Font("Segoe UI Black", 10f, FontStyle.Bold);
			this.s.ForeColor = Color.Red;
			this.s.Location = new Point(33, 169);
			this.s.Name = "label6";
			this.s.Size = new Size(35, 19);
			this.s.TabIndex = 47;
			this.s.Text = "Key";
			this.t.BorderColor = Color.White;
			this.t.BorderRadius = 3;
			this.t.Cursor = Cursors.IBeam;
			this.h.SetDecoration(this.t, 0);
			this.t.DefaultText = "";
			this.t.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.t.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.t.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.t.DisabledState.Parent = this.t;
			this.t.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.t.FillColor = Color.FromArgb(26, 32, 54);
			this.t.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.t.FocusedState.Parent = this.t;
			this.t.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.t.HoveredState.Parent = this.t;
			this.t.Location = new Point(36, 188);
			this.t.Margin = new Padding(4);
			this.t.Name = "siticoneTextBox4";
			this.t.PasswordChar = '\0';
			this.t.PlaceholderText = "";
			this.t.SelectedText = "";
			this.t.ShadowDecoration.Parent = this.t;
			this.t.Size = new Size(159, 37);
			this.t.TabIndex = 46;
			this.t.UseSystemPasswordChar = true;
			this.t.TextChanged += this.n;
			this.w.BorderColor = Color.Red;
			this.w.BorderRadius = 4;
			this.w.BorderThickness = 2;
			this.w.CheckedState.Parent = this.w;
			this.w.CustomImages.Parent = this.w;
			this.h.SetDecoration(this.w, 0);
			this.w.FillColor = Color.FromArgb(26, 32, 54);
			this.w.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.w.ForeColor = Color.White;
			this.w.HoveredState.Parent = this.w;
			this.w.Location = new Point(38, 228);
			this.w.Name = "siticoneButton2";
			this.w.PressedColor = Color.FromArgb(26, 32, 54);
			this.w.ShadowDecoration.Parent = this.w;
			this.w.Size = new Size(70, 32);
			this.w.TabIndex = 49;
			this.w.Text = "REGISTER";
			this.w.Click += this.l;
			this.x.BorderColor = Color.Red;
			this.x.BorderRadius = 4;
			this.x.BorderThickness = 2;
			this.x.CheckedState.Parent = this.x;
			this.x.CustomImages.Parent = this.x;
			this.h.SetDecoration(this.x, 0);
			this.x.FillColor = Color.FromArgb(26, 32, 54);
			this.x.Font = new Font("Segoe UI Black", 9f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.x.ForeColor = Color.White;
			this.x.HoveredState.Parent = this.x;
			this.x.Location = new Point(114, 228);
			this.x.Name = "siticoneButton3";
			this.x.PressedColor = Color.FromArgb(26, 32, 54);
			this.x.ShadowDecoration.Parent = this.x;
			this.x.Size = new Size(76, 32);
			this.x.TabIndex = 48;
			this.x.Text = "LOGIN";
			this.x.Click += this.m;
			this.y.BorderColor = Color.White;
			this.y.BorderRadius = 3;
			this.y.Cursor = Cursors.IBeam;
			this.h.SetDecoration(this.y, 0);
			this.y.DefaultText = "";
			this.y.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.y.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.y.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.y.DisabledState.Parent = this.y;
			this.y.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.y.FillColor = Color.FromArgb(26, 32, 54);
			this.y.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.y.FocusedState.Parent = this.y;
			this.y.HoveredState.BorderColor = Color.FromArgb(94, 148, 255);
			this.y.HoveredState.Parent = this.y;
			this.y.Location = new Point(36, 128);
			this.y.Margin = new Padding(4);
			this.y.Name = "siticoneTextBox1";
			this.y.PasswordChar = '\0';
			this.y.PlaceholderText = "";
			this.y.SelectedText = "";
			this.y.ShadowDecoration.Parent = this.y;
			this.y.Size = new Size(159, 37);
			this.y.TabIndex = 40;
			this.y.UseSystemPasswordChar = true;
			this.y.TextChanged += this.k;
			this.z.BackColor = Color.Transparent;
			this.h.SetDecoration(this.z, 0);
			this.z.Font = new Font("Segoe UI Semibold", 9f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 161);
			this.z.ForeColor = Color.Red;
			this.z.Location = new Point(66, 213);
			this.z.Margin = new Padding(2);
			this.z.Name = "siticoneLabel8";
			this.z.Size = new Size(99, 17);
			this.z.TabIndex = 50;
			this.z.Text = "discord.gg/unban";
			this.z.Click += this.o;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.AutoValidate = AutoValidate.Disable;
			this.BackColor = Color.FromArgb(26, 32, 54);
			base.ClientSize = new Size(236, 266);
			base.Controls.Add(this.z);
			base.Controls.Add(this.w);
			base.Controls.Add(this.x);
			base.Controls.Add(this.s);
			base.Controls.Add(this.t);
			base.Controls.Add(this.u);
			base.Controls.Add(this.q);
			base.Controls.Add(this.r);
			base.Controls.Add(this.p);
			base.Controls.Add(this.y);
			base.Controls.Add(this.n);
			base.Controls.Add(this.o);
			base.Controls.Add(this.l);
			base.Controls.Add(this.m);
			base.Controls.Add(this.j);
			base.Controls.Add(this.i);
			base.Controls.Add(this.g);
			base.Controls.Add(this.f);
			base.Controls.Add(this.v);
			this.h.SetDecoration(this, 1);
			base.FormBorderStyle = FormBorderStyle.None;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "Login";
			base.Opacity = 0.85;
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Loader";
			base.TransparencyKey = Color.Maroon;
			base.Load += this.c;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000069 RID: 105
		public static api KeyAuthApp = new api("UkDriller", "xUW9OFlfWO", "d2d932a04eb55b2e9487967060939eb2d275346a64458b91a859254cdc1dd3bf", "2.4");

		// Token: 0x0400006A RID: 106
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private object a;

		// Token: 0x0400006B RID: 107
		private bool b;

		// Token: 0x0400006C RID: 108
		private Point c;

		// Token: 0x0400006E RID: 110
		private SiticoneDragControl e;

		// Token: 0x0400006F RID: 111
		private SiticoneControlBox f;

		// Token: 0x04000070 RID: 112
		private SiticoneControlBox g;

		// Token: 0x04000071 RID: 113
		private SiticoneTransition h;

		// Token: 0x04000072 RID: 114
		private Label i;

		// Token: 0x04000073 RID: 115
		private Label j;

		// Token: 0x04000074 RID: 116
		private SiticoneShadowForm k;

		// Token: 0x04000075 RID: 117
		private SiticoneButton l;

		// Token: 0x04000076 RID: 118
		private SiticoneButton m;

		// Token: 0x04000077 RID: 119
		private SiticoneTextBox n;

		// Token: 0x04000078 RID: 120
		private Label o;

		// Token: 0x04000079 RID: 121
		private Label p;

		// Token: 0x0400007A RID: 122
		private SiticoneTextBox q;

		// Token: 0x0400007B RID: 123
		private Label r;

		// Token: 0x0400007C RID: 124
		private Label s;

		// Token: 0x0400007D RID: 125
		private SiticoneTextBox t;

		// Token: 0x0400007E RID: 126
		private Label u;

		// Token: 0x0400007F RID: 127
		private SiticoneTextBox v;

		// Token: 0x04000080 RID: 128
		private SiticoneButton w;

		// Token: 0x04000081 RID: 129
		private SiticoneButton x;

		// Token: 0x04000082 RID: 130
		private SiticoneTextBox y;

		// Token: 0x04000083 RID: 131
		private SiticoneLabel z;

		// Token: 0x04000084 RID: 132
		private System.Windows.Forms.Timer aa;

		// Token: 0x04000085 RID: 133
		private System.Windows.Forms.Timer ab;
	}
}
