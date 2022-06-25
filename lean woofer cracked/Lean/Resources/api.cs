using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace Lean.Resources
{
	// Token: 0x02000013 RID: 19
	public class api
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x00011804 File Offset: 0x0000FA04
		public api(string name, string ownerid, string secret, string version)
		{
			if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(ownerid) || string.IsNullOrWhiteSpace(secret) || string.IsNullOrWhiteSpace(version))
			{
				api.error("Security error, please reinstall the software!");
				Environment.Exit(0);
			}
			this.name = name;
			this.ownerid = ownerid;
			this.secret = secret;
			this.version = version;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0001189C File Offset: 0x0000FA9C
		public void init()
		{
			this.b = encryption.sha256(encryption.iv_key());
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("init"));
			nameValueCollection["ver"] = encryption.encrypt(this.version, this.secret, text);
			nameValueCollection["hash"] = api.checksum(Process.GetCurrentProcess().MainModule.FileName);
			nameValueCollection["enckey"] = encryption.encrypt(this.b, this.secret, text);
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			if (text2 == "KeyAuth_Invalid")
			{
				api.error("Error accessing Auth Servers, please wait!");
				Environment.Exit(0);
			}
			text2 = encryption.decrypt(text2, this.secret, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			if (response_structure.success)
			{
				this.b(response_structure.appinfo);
				this.a = response_structure.sessionid;
				this.c = true;
			}
			else if (response_structure.message == "invalidver")
			{
				this.app_data.downloadLink = response_structure.download;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00011A20 File Offset: 0x0000FC20
		public static bool IsDebugRelease
		{
			get
			{
				DateTime d = new DateTime(2022, 6, 21, 7, 39, 41);
				if ((DateTime.Now - d).TotalDays > 0.0)
				{
				}
				return true;
			}
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00011A60 File Offset: 0x0000FC60
		public void Checkinit()
		{
			DateTime d = new DateTime(2022, 6, 20);
			if ((d - DateTime.Now).TotalDays < 0.0)
			{
				throw new InvalidOperationException();
			}
			if (!this.c)
			{
				if (api.IsDebugRelease)
				{
					api.error("Security error, please reinstall the software! (2)");
				}
				else
				{
					api.error("Security error, please reinstall the software! (2)");
				}
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00011AC8 File Offset: 0x0000FCC8
		public void register(string username, string pass, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("register"));
			nameValueCollection["username"] = encryption.encrypt(username, this.b, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.b, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.b, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			if (response_structure.success)
			{
				this.c(response_structure.info);
			}
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00011C28 File Offset: 0x0000FE28
		public void login(string username, string pass)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("login"));
			nameValueCollection["username"] = encryption.encrypt(username, this.b, text);
			nameValueCollection["pass"] = encryption.encrypt(pass, this.b, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			if (response_structure.success)
			{
				this.c(response_structure.info);
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00011D70 File Offset: 0x0000FF70
		public void upgrade(string username, string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("upgrade"));
			nameValueCollection["username"] = encryption.encrypt(username, this.b, text);
			nameValueCollection["key"] = encryption.encrypt(key, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			response_structure.success = false;
			this.d(response_structure);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00011E94 File Offset: 0x00010094
		public void license(string key)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("license"));
			nameValueCollection["key"] = encryption.encrypt(key, this.b, text);
			nameValueCollection["hwid"] = encryption.encrypt(value, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			if (response_structure.success)
			{
				this.c(response_structure.info);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00011FC4 File Offset: 0x000101C4
		public void check()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("check"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0001209C File Offset: 0x0001029C
		public void setvar(string var, string data)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("setvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.b, text);
			nameValueCollection["data"] = encryption.encrypt(data, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000121A4 File Offset: 0x000103A4
		public string getvar(string var)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("getvar"));
			nameValueCollection["var"] = encryption.encrypt(var, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000122AC File Offset: 0x000104AC
		public void ban()
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("ban"));
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00012384 File Offset: 0x00010584
		public string var(string varid)
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("var"));
			nameValueCollection["varid"] = encryption.encrypt(varid, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.message;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x000124A0 File Offset: 0x000106A0
		public List<api.msg> chatget(string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatget"));
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			List<api.msg> result;
			if (response_structure.success)
			{
				result = response_structure.messages;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000125A8 File Offset: 0x000107A8
		public bool chatsend(string msg, string channelname)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("chatsend"));
			nameValueCollection["message"] = encryption.encrypt(msg, this.b, text);
			nameValueCollection["channel"] = encryption.encrypt(channelname, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			return response_structure.success;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000126C4 File Offset: 0x000108C4
		public bool checkblack()
		{
			this.Checkinit();
			string value = WindowsIdentity.GetCurrent().User.Value;
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("checkblacklist"));
			nameValueCollection["hwid"] = encryption.encrypt(value, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			return response_structure.success;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000127DC File Offset: 0x000109DC
		public string webhook(string webid, string param, string body = "", string conttype = "")
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("webhook"));
			nameValueCollection["webid"] = encryption.encrypt(webid, this.b, text);
			nameValueCollection["params"] = encryption.encrypt(param, this.b, text);
			nameValueCollection["body"] = encryption.encrypt(body, this.b, text);
			nameValueCollection["conttype"] = encryption.encrypt(conttype, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			string result;
			if (response_structure.success)
			{
				result = response_structure.response;
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0001292C File Offset: 0x00010B2C
		public byte[] download(string fileid)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("file"));
			nameValueCollection["fileid"] = encryption.encrypt(fileid, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			string text2 = api.a(nameValueCollection2);
			text2 = encryption.decrypt(text2, this.b, text);
			api.response_structure response_structure = this.d.string_to_generic<api.response_structure>(text2);
			this.d(response_structure);
			byte[] result;
			if (response_structure.success)
			{
				result = encryption.str_to_byte_arr(response_structure.contents);
			}
			else
			{
				result = null;
			}
			return result;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00012A38 File Offset: 0x00010C38
		public void log(string message)
		{
			this.Checkinit();
			string text = encryption.sha256(encryption.iv_key());
			NameValueCollection nameValueCollection = new NameValueCollection();
			nameValueCollection["type"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes("log"));
			nameValueCollection["pcuser"] = encryption.encrypt(Environment.UserName, this.b, text);
			nameValueCollection["message"] = encryption.encrypt(message, this.b, text);
			nameValueCollection["sessionid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.a));
			nameValueCollection["name"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.name));
			nameValueCollection["ownerid"] = encryption.byte_arr_to_str(Encoding.Default.GetBytes(this.ownerid));
			nameValueCollection["init_iv"] = text;
			NameValueCollection nameValueCollection2 = nameValueCollection;
			api.a(nameValueCollection2);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00012B24 File Offset: 0x00010D24
		public static string checksum(string filename)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(filename))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002398 File Offset: 0x00000598
		public static void error(string message)
		{
			MessageBox.Show(message, "Lean Protection", MessageBoxButtons.OK);
			Environment.Exit(0);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00012B9C File Offset: 0x00010D9C
		private static string a(NameValueCollection a)
		{
			string result;
			try
			{
				using (WebClient webClient = new WebClient())
				{
					byte[] bytes = webClient.UploadValues("https://keyauth.win/api/1.0/", a);
					result = Encoding.Default.GetString(bytes);
				}
			}
			catch (WebException ex)
			{
				HttpWebResponse httpWebResponse = (HttpWebResponse)ex.Response;
				HttpStatusCode statusCode = httpWebResponse.StatusCode;
				HttpStatusCode httpStatusCode = statusCode;
				if (httpStatusCode != (HttpStatusCode)429)
				{
					api.error("Connection failure, Try again!");
					Environment.Exit(0);
					result = "";
				}
				else
				{
					api.error("You are connecting too fast to Woofer, please wait!");
					Environment.Exit(0);
					result = "";
				}
			}
			return result;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00012C48 File Offset: 0x00010E48
		private void b(api.app_data_structure a)
		{
			this.app_data.numUsers = a.numUsers;
			this.app_data.numOnlineUsers = a.numOnlineUsers;
			this.app_data.numKeys = a.numKeys;
			this.app_data.version = a.version;
			this.app_data.customerPanelLink = a.customerPanelLink;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00012CAC File Offset: 0x00010EAC
		private void c(api.user_data_structure a)
		{
			this.user_data.username = a.username;
			this.user_data.ip = a.ip;
			this.user_data.hwid = a.hwid;
			this.user_data.createdate = a.createdate;
			this.user_data.lastlogin = a.lastlogin;
			this.user_data.subscriptions = a.subscriptions;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00012D20 File Offset: 0x00010F20
		public string expirydaysleft()
		{
			this.Checkinit();
			DateTime d = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			TimeSpan timeSpan = d - DateTime.Now;
			return Convert.ToString(timeSpan.Days.ToString() + " Days " + timeSpan.Hours.ToString() + " Hours Left");
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000023AD File Offset: 0x000005AD
		private void d(api.response_structure a)
		{
			this.response.success = a.success;
			this.response.message = a.message;
		}

		// Token: 0x04000098 RID: 152
		public string name;

		// Token: 0x04000099 RID: 153
		public string ownerid;

		// Token: 0x0400009A RID: 154
		public string secret;

		// Token: 0x0400009B RID: 155
		public string version;

		// Token: 0x0400009C RID: 156
		private string a;

		// Token: 0x0400009D RID: 157
		private string b;

		// Token: 0x0400009E RID: 158
		private bool c;

		// Token: 0x0400009F RID: 159
		public api.app_data_class app_data = new api.app_data_class();

		// Token: 0x040000A0 RID: 160
		public api.user_data_class user_data = new api.user_data_class();

		// Token: 0x040000A1 RID: 161
		public api.response_class response = new api.response_class();

		// Token: 0x040000A2 RID: 162
		private json_wrapper d = new json_wrapper(new api.response_structure());

		// Token: 0x02000014 RID: 20
		[DataContract]
		private class response_structure
		{
			// Token: 0x1700001C RID: 28
			// (get) Token: 0x060000EE RID: 238 RVA: 0x000023D1 File Offset: 0x000005D1
			// (set) Token: 0x060000EF RID: 239 RVA: 0x000023D9 File Offset: 0x000005D9
			[DataMember]
			public bool success { get; set; }

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x060000F0 RID: 240 RVA: 0x000023E2 File Offset: 0x000005E2
			// (set) Token: 0x060000F1 RID: 241 RVA: 0x000023EA File Offset: 0x000005EA
			[DataMember]
			public string sessionid { get; set; }

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x060000F2 RID: 242 RVA: 0x000023F3 File Offset: 0x000005F3
			// (set) Token: 0x060000F3 RID: 243 RVA: 0x000023FB File Offset: 0x000005FB
			[DataMember]
			public string contents { get; set; }

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002404 File Offset: 0x00000604
			// (set) Token: 0x060000F5 RID: 245 RVA: 0x0000240C File Offset: 0x0000060C
			[DataMember]
			public string response { get; set; }

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002415 File Offset: 0x00000615
			// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000241D File Offset: 0x0000061D
			[DataMember]
			public string message { get; set; }

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002426 File Offset: 0x00000626
			// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000242E File Offset: 0x0000062E
			[DataMember]
			public string download { get; set; }

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x060000FA RID: 250 RVA: 0x00002437 File Offset: 0x00000637
			// (set) Token: 0x060000FB RID: 251 RVA: 0x0000243F File Offset: 0x0000063F
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.user_data_structure info { get; set; }

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x060000FC RID: 252 RVA: 0x00002448 File Offset: 0x00000648
			// (set) Token: 0x060000FD RID: 253 RVA: 0x00002450 File Offset: 0x00000650
			[DataMember(IsRequired = false, EmitDefaultValue = false)]
			public api.app_data_structure appinfo { get; set; }

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x060000FE RID: 254 RVA: 0x00002459 File Offset: 0x00000659
			// (set) Token: 0x060000FF RID: 255 RVA: 0x00002461 File Offset: 0x00000661
			[DataMember]
			public List<api.msg> messages { get; set; }

			// Token: 0x040000A3 RID: 163
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool a;

			// Token: 0x040000A4 RID: 164
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000A5 RID: 165
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x040000A6 RID: 166
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			// Token: 0x040000A7 RID: 167
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			// Token: 0x040000A8 RID: 168
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string f;

			// Token: 0x040000A9 RID: 169
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private api.user_data_structure g;

			// Token: 0x040000AA RID: 170
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private api.app_data_structure h;

			// Token: 0x040000AB RID: 171
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<api.msg> i;
		}

		// Token: 0x02000015 RID: 21
		public class msg
		{
			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000101 RID: 257 RVA: 0x0000246A File Offset: 0x0000066A
			// (set) Token: 0x06000102 RID: 258 RVA: 0x00002472 File Offset: 0x00000672
			public string message { get; set; }

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000103 RID: 259 RVA: 0x00012D88 File Offset: 0x00010F88
			// (set) Token: 0x06000104 RID: 260 RVA: 0x00012DC8 File Offset: 0x00010FC8
			public string author
			{
				[CompilerGenerated]
				get
				{
					DateTime d = new DateTime(2022, 6, 20);
					if ((d - DateTime.Now).TotalDays < 0.0)
					{
					}
					return this.b;
				}
				[CompilerGenerated]
				set
				{
					DateTime d = new DateTime(2022, 6, 21);
					if ((d - DateTime.Now).TotalDays < 0.0)
					{
					}
					this.b = value;
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000105 RID: 261 RVA: 0x0000247B File Offset: 0x0000067B
			// (set) Token: 0x06000106 RID: 262 RVA: 0x00002483 File Offset: 0x00000683
			public string timestamp { get; set; }

			// Token: 0x040000AC RID: 172
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000AD RID: 173
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000AE RID: 174
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;
		}

		// Token: 0x02000016 RID: 22
		[DataContract]
		private class user_data_structure
		{
			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000108 RID: 264 RVA: 0x0000248C File Offset: 0x0000068C
			// (set) Token: 0x06000109 RID: 265 RVA: 0x00002494 File Offset: 0x00000694
			[DataMember]
			public string username { get; set; }

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x0600010A RID: 266 RVA: 0x0000249D File Offset: 0x0000069D
			// (set) Token: 0x0600010B RID: 267 RVA: 0x000024A5 File Offset: 0x000006A5
			[DataMember]
			public string ip { get; set; }

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x0600010C RID: 268 RVA: 0x00012E0C File Offset: 0x0001100C
			// (set) Token: 0x0600010D RID: 269 RVA: 0x00012E50 File Offset: 0x00011050
			[DataMember]
			public string hwid
			{
				[CompilerGenerated]
				get
				{
					DateTime t = new DateTime(2022, 6, 20, 19, 29, 18);
					if (DateTime.Now > t)
					{
						throw new ArgumentOutOfRangeException();
					}
					return this.c;
				}
				[CompilerGenerated]
				set
				{
					DateTime t = new DateTime(2022, 6, 21, 2, 32, 35);
					if (DateTime.Now > t)
					{
					}
					this.c = value;
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x0600010E RID: 270 RVA: 0x000024AE File Offset: 0x000006AE
			// (set) Token: 0x0600010F RID: 271 RVA: 0x000024B6 File Offset: 0x000006B6
			[DataMember]
			public string createdate { get; set; }

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x06000110 RID: 272 RVA: 0x000024BF File Offset: 0x000006BF
			// (set) Token: 0x06000111 RID: 273 RVA: 0x000024C7 File Offset: 0x000006C7
			[DataMember]
			public string lastlogin { get; set; }

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x06000112 RID: 274 RVA: 0x000024D0 File Offset: 0x000006D0
			// (set) Token: 0x06000113 RID: 275 RVA: 0x000024D8 File Offset: 0x000006D8
			[DataMember]
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x040000AF RID: 175
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000B0 RID: 176
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000B1 RID: 177
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x040000B2 RID: 178
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			// Token: 0x040000B3 RID: 179
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			// Token: 0x040000B4 RID: 180
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<api.Data> f;
		}

		// Token: 0x02000017 RID: 23
		[DataContract]
		private class app_data_structure
		{
			// Token: 0x1700002E RID: 46
			// (get) Token: 0x06000115 RID: 277 RVA: 0x000024E1 File Offset: 0x000006E1
			// (set) Token: 0x06000116 RID: 278 RVA: 0x000024E9 File Offset: 0x000006E9
			[DataMember]
			public string numUsers { get; set; }

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x06000117 RID: 279 RVA: 0x000024F2 File Offset: 0x000006F2
			// (set) Token: 0x06000118 RID: 280 RVA: 0x00012E8C File Offset: 0x0001108C
			[DataMember]
			public string numOnlineUsers
			{
				[CompilerGenerated]
				get
				{
					return this.b;
				}
				[CompilerGenerated]
				set
				{
					DateTime t = new DateTime(2022, 6, 21, 13, 48, 49);
					if (t < DateTime.Now)
					{
					}
					this.b = value;
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x06000119 RID: 281 RVA: 0x00012EC8 File Offset: 0x000110C8
			// (set) Token: 0x0600011A RID: 282 RVA: 0x000024FA File Offset: 0x000006FA
			[DataMember]
			public string numKeys
			{
				[CompilerGenerated]
				get
				{
					DateTime t = new DateTime(2022, 6, 21, 12, 1, 0);
					if (t < DateTime.Now)
					{
						throw new InvalidOperationException();
					}
					return this.c;
				}
				[CompilerGenerated]
				set
				{
					this.c = value;
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600011B RID: 283 RVA: 0x00002503 File Offset: 0x00000703
			// (set) Token: 0x0600011C RID: 284 RVA: 0x0000250B File Offset: 0x0000070B
			[DataMember]
			public string version { get; set; }

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x0600011D RID: 285 RVA: 0x00002514 File Offset: 0x00000714
			// (set) Token: 0x0600011E RID: 286 RVA: 0x0000251C File Offset: 0x0000071C
			[DataMember]
			public string customerPanelLink { get; set; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x0600011F RID: 287 RVA: 0x00002525 File Offset: 0x00000725
			// (set) Token: 0x06000120 RID: 288 RVA: 0x0000252D File Offset: 0x0000072D
			[DataMember]
			public string downloadLink { get; set; }

			// Token: 0x040000B5 RID: 181
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000B6 RID: 182
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000B7 RID: 183
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x040000B8 RID: 184
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			// Token: 0x040000B9 RID: 185
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			// Token: 0x040000BA RID: 186
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string f;
		}

		// Token: 0x02000018 RID: 24
		public class app_data_class
		{
			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000122 RID: 290 RVA: 0x00002536 File Offset: 0x00000736
			// (set) Token: 0x06000123 RID: 291 RVA: 0x0000253E File Offset: 0x0000073E
			public string numUsers { get; set; }

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000124 RID: 292 RVA: 0x00012F08 File Offset: 0x00011108
			// (set) Token: 0x06000125 RID: 293 RVA: 0x00012F4C File Offset: 0x0001114C
			public string numOnlineUsers
			{
				[CompilerGenerated]
				get
				{
					DateTime t = new DateTime(2022, 6, 21, 12, 35, 53);
					if (DateTime.Now > t)
					{
						throw new ArgumentOutOfRangeException();
					}
					return this.b;
				}
				[CompilerGenerated]
				set
				{
					DateTime d = new DateTime(2022, 6, 21);
					if ((DateTime.Now - d).TotalDays > 0.0)
					{
					}
					this.b = value;
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000126 RID: 294 RVA: 0x00002547 File Offset: 0x00000747
			// (set) Token: 0x06000127 RID: 295 RVA: 0x0000254F File Offset: 0x0000074F
			public string numKeys { get; set; }

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000128 RID: 296 RVA: 0x00002558 File Offset: 0x00000758
			// (set) Token: 0x06000129 RID: 297 RVA: 0x00002560 File Offset: 0x00000760
			public string version { get; set; }

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x0600012A RID: 298 RVA: 0x00002569 File Offset: 0x00000769
			// (set) Token: 0x0600012B RID: 299 RVA: 0x00002571 File Offset: 0x00000771
			public string customerPanelLink { get; set; }

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x0600012C RID: 300 RVA: 0x0000257A File Offset: 0x0000077A
			// (set) Token: 0x0600012D RID: 301 RVA: 0x00002582 File Offset: 0x00000782
			public string downloadLink { get; set; }

			// Token: 0x040000BB RID: 187
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000BC RID: 188
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000BD RID: 189
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x040000BE RID: 190
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			// Token: 0x040000BF RID: 191
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			// Token: 0x040000C0 RID: 192
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string f;
		}

		// Token: 0x02000019 RID: 25
		public class user_data_class
		{
			// Token: 0x1700003A RID: 58
			// (get) Token: 0x0600012F RID: 303 RVA: 0x0000258B File Offset: 0x0000078B
			// (set) Token: 0x06000130 RID: 304 RVA: 0x00002593 File Offset: 0x00000793
			public string username { get; set; }

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000131 RID: 305 RVA: 0x0000259C File Offset: 0x0000079C
			// (set) Token: 0x06000132 RID: 306 RVA: 0x000025A4 File Offset: 0x000007A4
			public string ip { get; set; }

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x06000133 RID: 307 RVA: 0x00012F90 File Offset: 0x00011190
			// (set) Token: 0x06000134 RID: 308 RVA: 0x00012FD0 File Offset: 0x000111D0
			public string hwid
			{
				[CompilerGenerated]
				get
				{
					DateTime d = new DateTime(2022, 6, 21);
					if ((d - DateTime.Now).TotalDays < 0.0)
					{
					}
					return this.c;
				}
				[CompilerGenerated]
				set
				{
					DateTime d = new DateTime(2022, 6, 21);
					if ((DateTime.Now - d).TotalDays > 0.0)
					{
					}
					this.c = value;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x06000135 RID: 309 RVA: 0x000025AD File Offset: 0x000007AD
			// (set) Token: 0x06000136 RID: 310 RVA: 0x000025B5 File Offset: 0x000007B5
			public string createdate { get; set; }

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x06000137 RID: 311 RVA: 0x000025BE File Offset: 0x000007BE
			// (set) Token: 0x06000138 RID: 312 RVA: 0x000025C6 File Offset: 0x000007C6
			public string lastlogin { get; set; }

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x06000139 RID: 313 RVA: 0x000025CF File Offset: 0x000007CF
			// (set) Token: 0x0600013A RID: 314 RVA: 0x000025D7 File Offset: 0x000007D7
			public List<api.Data> subscriptions { get; set; }

			// Token: 0x040000C1 RID: 193
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000C2 RID: 194
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000C3 RID: 195
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;

			// Token: 0x040000C4 RID: 196
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string d;

			// Token: 0x040000C5 RID: 197
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string e;

			// Token: 0x040000C6 RID: 198
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private List<api.Data> f;
		}

		// Token: 0x0200001A RID: 26
		public class Data
		{
			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600013C RID: 316 RVA: 0x000025E0 File Offset: 0x000007E0
			// (set) Token: 0x0600013D RID: 317 RVA: 0x000025E8 File Offset: 0x000007E8
			public string subscription { get; set; }

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x0600013E RID: 318 RVA: 0x000025F1 File Offset: 0x000007F1
			// (set) Token: 0x0600013F RID: 319 RVA: 0x000025F9 File Offset: 0x000007F9
			public string expiry { get; set; }

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000140 RID: 320 RVA: 0x00002602 File Offset: 0x00000802
			// (set) Token: 0x06000141 RID: 321 RVA: 0x0000260A File Offset: 0x0000080A
			public string timeleft { get; set; }

			// Token: 0x040000C7 RID: 199
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string a;

			// Token: 0x040000C8 RID: 200
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;

			// Token: 0x040000C9 RID: 201
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string c;
		}

		// Token: 0x0200001B RID: 27
		public class response_class
		{
			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000143 RID: 323 RVA: 0x00002613 File Offset: 0x00000813
			// (set) Token: 0x06000144 RID: 324 RVA: 0x00013014 File Offset: 0x00011214
			public bool success
			{
				[CompilerGenerated]
				get
				{
					return this.a;
				}
				[CompilerGenerated]
				set
				{
					DateTime d = new DateTime(2022, 6, 21);
					if ((DateTime.Now - d).TotalDays > 0.0)
					{
					}
					this.a = value;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000145 RID: 325 RVA: 0x00013058 File Offset: 0x00011258
			// (set) Token: 0x06000146 RID: 326 RVA: 0x0000261B File Offset: 0x0000081B
			public string message
			{
				[CompilerGenerated]
				get
				{
					DateTime d = new DateTime(2022, 6, 21, 12, 59, 39);
					if ((d - DateTime.Now).TotalDays < 0.0)
					{
						throw new Exception();
					}
					return this.b;
				}
				[CompilerGenerated]
				set
				{
					this.b = value;
				}
			}

			// Token: 0x040000CA RID: 202
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private bool a;

			// Token: 0x040000CB RID: 203
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string b;
		}
	}
}
