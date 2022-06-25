using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Lean.Resources
{
	// Token: 0x0200001D RID: 29
	public class json_wrapper
	{
		// Token: 0x06000150 RID: 336 RVA: 0x00002640 File Offset: 0x00000840
		public static bool is_serializable(Type to_check)
		{
			return to_check.IsSerializable || to_check.IsDefined(typeof(DataContractAttribute), true);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000133B4 File Offset: 0x000115B4
		public json_wrapper(object obj_to_work_with)
		{
			this.b = obj_to_work_with;
			Type type = this.b.GetType();
			this.a = new DataContractJsonSerializer(type);
			if (!json_wrapper.is_serializable(type))
			{
				throw new Exception(string.Format("the object {0} isn't a serializable", this.b));
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00013408 File Offset: 0x00011608
		public object string_to_object(string json)
		{
			byte[] bytes = Encoding.Default.GetBytes(json);
			object result;
			using (MemoryStream memoryStream = new MemoryStream(bytes))
			{
				result = this.a.ReadObject(memoryStream);
			}
			return result;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000265E File Offset: 0x0000085E
		public T string_to_generic<T>(string json)
		{
			return (T)((object)this.string_to_object(json));
		}

		// Token: 0x040000CC RID: 204
		private DataContractJsonSerializer a;

		// Token: 0x040000CD RID: 205
		private object b;
	}
}
