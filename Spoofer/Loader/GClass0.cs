using System;

// Token: 0x02000017 RID: 23
public class GClass0
{
	// Token: 0x060000BA RID: 186 RVA: 0x00006CC4 File Offset: 0x00004EC4
	public static string smethod_0(string string_0)
	{
		int length = string_0.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = string_0[i];
			byte b = (byte)((int)c ^ length - i);
			byte b2 = (byte)((int)(c >> 8) ^ i);
			array[i] = (char)((int)b2 << 8 | (int)b);
		}
		return string.Intern(new string(array));
	}
}
