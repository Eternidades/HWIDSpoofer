using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;

namespace ns4
{
	// Token: 0x0200000F RID: 15
	internal class Class12
	{
		// Token: 0x0600008A RID: 138 RVA: 0x0000638C File Offset: 0x0000458C
		public static string smethod_0(string string_1)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				byte[] bytes = Encoding.UTF8.GetBytes(string_1);
				byte[] value = md.ComputeHash(bytes);
				result = BitConverter.ToString(value).Replace("-", "");
			}
			return result;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x000063E8 File Offset: 0x000045E8
		private static string smethod_1(int int_0)
		{
			Class12.Class13 @class = new Class12.Class13();
			@class.random_0 = new Random();
			return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz", int_0).Select(new Func<string, char>(@class.method_0)).ToArray<char>());
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00006430 File Offset: 0x00004630
		public static string smethod_2(int int_0)
		{
			Class12.Class14 @class = new Class12.Class14();
			@class.random_0 = new Random();
			return new string(Enumerable.Repeat<string>("gd8JQ57nxXzLLMPrLylVhxoGnWGCFjO4knKTfRE6mVvdjug2NF/4aptAsZcdIGbAPmcx0O+ftU/KvMIjcfUnH3j+IMdhAW5OpoX3MrjQdf5AAP97tTB5g1wdDSAqKpq9gw06t3VaqMWZHKtPSuAXy0kkZRsc+DicpcY8E9+vWMHXa3jMdbPx4YES0p66GzhqLd/heA2zMvX8iWv4wK7S3QKIW/a9dD4ALZJpmcr9OOE=", int_0).Select(new Func<string, char>(@class.method_0)).ToArray<char>());
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006478 File Offset: 0x00004678
		public static void smethod_3()
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			if (Class6.bool_1)
			{
				MessageBox.Show("A session has already been started, please end the previous one!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				using (StreamReader streamReader = new StreamReader(pathRoot + "Windows\\System32\\drivers\\etc\\hosts"))
				{
					string text = streamReader.ReadToEnd();
					if (text.Contains("api.auth.gg"))
					{
						Class6.bool_0 = true;
						MessageBox.Show("DNS redirecting has been detected!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
						Process.GetCurrentProcess().Kill();
					}
				}
				Class17 @class = new Class17();
				@class.method_0();
				Class6.Token = Guid.NewGuid().ToString();
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, new RemoteCertificateValidationCallback(Class12.smethod_5));
				Class6.APIENCRYPTKEY = Convert.ToBase64String(Encoding.Default.GetBytes("qw5y88Ewkw5cS2Qfqe1n5Lc4o0MjYjaa"));
				Class6.APIENCRYPTSALT = Convert.ToBase64String(Encoding.Default.GetBytes("qw5y88Ewkw5cS2Qf"));
				Class6.string_4 = Convert.ToBase64String(Encoding.Default.GetBytes("o00WidLX4fpa9UjS"));
				Class6.string_5 = Convert.ToBase64String(Encoding.Default.GetBytes("yalxYjXpveigzvIatmvC5wMF7EAXrtZI"));
				Class6.bool_1 = true;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000065D8 File Offset: 0x000047D8
		public static void smethod_4()
		{
			if (!Class6.bool_1)
			{
				MessageBox.Show("No session has been started, closing for security reasons!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				Class6.Token = null;
				ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(Class12.Class15.class15_0.method_0);
				Class6.APIENCRYPTKEY = null;
				Class6.APIENCRYPTSALT = null;
				Class6.string_4 = null;
				Class6.string_5 = null;
				Class6.bool_1 = false;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00006658 File Offset: 0x00004858
		private static bool smethod_5(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
		{
			return x509Certificate_0 != null && x509Certificate_0.GetPublicKeyString() == "046EECD33E469E9E1958D6BEEDE0A71843202724A5758BD1723F6C340C5E98EDE06FF5C21B35F359C65B850744729B3AA999B0B6392DA69EDB278EB31DBCE85774";
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000667C File Offset: 0x0000487C
		public static string smethod_6(string string_1)
		{
			string result;
			using (MD5 md = MD5.Create())
			{
				using (FileStream fileStream = File.OpenRead(string_1))
				{
					byte[] value = md.ComputeHash(fileStream);
					result = BitConverter.ToString(value).Replace("-", "").ToLowerInvariant();
				}
			}
			return result;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000066F4 File Offset: 0x000048F4
		public static bool smethod_7(string string_1)
		{
			DateTime d = DateTime.Parse(string_1);
			DateTime now = DateTime.Now;
			TimeSpan timeSpan = d - now;
			bool result;
			if (Convert.ToInt32(timeSpan.Seconds.ToString().Replace("-", "")) >= 5 || Convert.ToInt32(timeSpan.Minutes.ToString().Replace("-", "")) >= 1)
			{
				Class6.bool_0 = true;
				result = true;
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002064 File Offset: 0x00000264
		internal static string smethod_8(int int_0)
		{
			throw new NotImplementedException();
		}

		// Token: 0x04000037 RID: 55
		private const string string_0 = "046EECD33E469E9E1958D6BEEDE0A71843202724A5758BD1723F6C340C5E98EDE06FF5C21B35F359C65B850744729B3AA999B0B6392DA69EDB278EB31DBCE85774";

		// Token: 0x02000010 RID: 16
		[CompilerGenerated]
		private sealed class Class13
		{
			// Token: 0x06000095 RID: 149 RVA: 0x00002311 File Offset: 0x00000511
			internal char method_0(string string_0)
			{
				return string_0[this.random_0.Next(string_0.Length)];
			}

			// Token: 0x04000038 RID: 56
			public Random random_0;
		}

		// Token: 0x02000011 RID: 17
		[CompilerGenerated]
		private sealed class Class14
		{
			// Token: 0x06000097 RID: 151 RVA: 0x0000232A File Offset: 0x0000052A
			internal char method_0(string string_0)
			{
				return string_0[this.random_0.Next(string_0.Length)];
			}

			// Token: 0x04000039 RID: 57
			public Random random_0;
		}

		// Token: 0x02000012 RID: 18
		[CompilerGenerated]
		[Serializable]
		private sealed class Class15
		{
			// Token: 0x0600009A RID: 154 RVA: 0x00006780 File Offset: 0x00004980
			internal bool method_0(object object_0, X509Certificate x509Certificate_0, X509Chain x509Chain_0, SslPolicyErrors sslPolicyErrors_0)
			{
				return true;
			}

			// Token: 0x0400003A RID: 58
			public static readonly Class12.Class15 class15_0 = new Class12.Class15();

			// Token: 0x0400003B RID: 59
			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;
		}
	}
}
