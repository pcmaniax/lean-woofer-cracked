using System;
using System.Collections.Specialized;
using System.Net;

// Token: 0x02000012 RID: 18
internal class e
{
	// Token: 0x060000D2 RID: 210 RVA: 0x000117C8 File Offset: 0x0000F9C8
	public static byte[] a(string a, NameValueCollection b)
	{
		byte[] result;
		using (WebClient webClient = new WebClient())
		{
			result = webClient.UploadValues(a, b);
		}
		return result;
	}
}
