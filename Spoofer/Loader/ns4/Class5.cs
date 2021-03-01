using System;
using System.Collections.Generic;

namespace ns4
{
	// Token: 0x02000008 RID: 8
	internal class Class5
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00004B04 File Offset: 0x00002D04
		public static string smethod_0(string string_1)
		{
			string result;
			try
			{
				if (Class8.ID != null || Class8.HWID != null || Class8.IP != null || !Class6.bool_0)
				{
					result = Class5.dictionary_0[string_1];
				}
				else
				{
					Class6.bool_0 = true;
					result = "User is not logged in, possible breach detected!";
				}
			}
			catch
			{
				result = "N/A";
			}
			return result;
		}

		// Token: 0x0400000F RID: 15
		public static string string_0 = null;

		// Token: 0x04000010 RID: 16
		public static Dictionary<string, string> dictionary_0 = new Dictionary<string, string>();
	}
}
