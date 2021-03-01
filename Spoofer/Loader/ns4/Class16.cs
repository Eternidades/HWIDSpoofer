using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace ns4
{
	// Token: 0x02000013 RID: 19
	internal class Class16
	{
		// Token: 0x0600009B RID: 155 RVA: 0x00006790 File Offset: 0x00004990
		public static string smethod_0(string string_0)
		{
			string @string = Encoding.Default.GetString(Convert.FromBase64String(Class6.APIENCRYPTKEY));
			SHA256 sha = SHA256.Create();
			byte[] byte_ = sha.ComputeHash(Encoding.ASCII.GetBytes(@string));
			byte[] bytes = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Class6.APIENCRYPTSALT)));
			return Class16.smethod_3(string_0, byte_, bytes);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00006800 File Offset: 0x00004A00
		public static string smethod_1(string string_0)
		{
			string @string = Encoding.Default.GetString(Convert.FromBase64String(Class6.APIENCRYPTKEY));
			SHA256 sha = SHA256.Create();
			byte[] byte_ = sha.ComputeHash(Encoding.ASCII.GetBytes(@string));
			byte[] bytes = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Class6.APIENCRYPTSALT)));
			string str = Class16.smethod_3(string_0, byte_, bytes);
			int int_ = int.Parse(Class10.string_0.Substring(0, 2));
			return str + Class12.smethod_2(int_);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00006890 File Offset: 0x00004A90
		public static string smethod_2(string string_0)
		{
			string @string = Encoding.Default.GetString(Convert.FromBase64String(Class6.APIENCRYPTKEY));
			SHA256 sha = SHA256.Create();
			byte[] byte_ = sha.ComputeHash(Encoding.ASCII.GetBytes(@string));
			byte[] bytes = Encoding.ASCII.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(Class6.APIENCRYPTSALT)));
			return Class16.smethod_4(string_0, byte_, bytes);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00006900 File Offset: 0x00004B00
		public static string smethod_3(string string_0, byte[] byte_0, byte[] byte_1)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = byte_0;
			aes.IV = byte_1;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			byte[] bytes = Encoding.ASCII.GetBytes(string_0);
			cryptoStream.Write(bytes, 0, bytes.Length);
			cryptoStream.FlushFinalBlock();
			byte[] array = memoryStream.ToArray();
			memoryStream.Close();
			cryptoStream.Close();
			return Convert.ToBase64String(array, 0, array.Length);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00006988 File Offset: 0x00004B88
		public static string smethod_4(string string_0, byte[] byte_0, byte[] byte_1)
		{
			Aes aes = Aes.Create();
			aes.Mode = CipherMode.CBC;
			aes.Key = byte_0;
			aes.IV = byte_1;
			MemoryStream memoryStream = new MemoryStream();
			ICryptoTransform transform = aes.CreateDecryptor();
			CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			string result = string.Empty;
			try
			{
				byte[] array = Convert.FromBase64String(string_0);
				cryptoStream.Write(array, 0, array.Length);
				cryptoStream.FlushFinalBlock();
				byte[] array2 = memoryStream.ToArray();
				result = Encoding.ASCII.GetString(array2, 0, array2.Length);
			}
			finally
			{
				memoryStream.Close();
				cryptoStream.Close();
			}
			return result;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00006A28 File Offset: 0x00004C28
		public static string smethod_5(string string_0)
		{
			string_0 = string_0.Replace('_', '/').Replace('-', '+');
			int num = string_0.Length % 4;
			int num2 = num;
			if (num2 != 2)
			{
				if (num2 == 3)
				{
					string_0 += "=";
				}
			}
			else
			{
				string_0 += "==";
			}
			return Encoding.UTF8.GetString(Convert.FromBase64String(string_0));
		}
	}
}
