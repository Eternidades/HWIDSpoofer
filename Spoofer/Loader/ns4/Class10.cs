using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Windows;

namespace ns4
{
	// Token: 0x0200000D RID: 13
	internal class Class10
	{
		// Token: 0x0600007F RID: 127 RVA: 0x00004BD8 File Offset: 0x00002DD8
		public static void smethod_0(string string_5, string string_6, string string_7, string string_8)
		{
			if (string.IsNullOrWhiteSpace(string_5) || string.IsNullOrWhiteSpace(string_6) || string.IsNullOrWhiteSpace(string_7) || string.IsNullOrWhiteSpace(string_8))
			{
				MessageBox.Show("Invalid application information!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			Class10.string_0 = string_6;
			Class10.string_1 = string_7;
			Class10.string_2 = string_8;
			Class10.string_3 = string_5;
			string[] array = new string[0];
			using (WebClient webClient = new WebClient())
			{
				try
				{
					webClient.Proxy = null;
					Class12.smethod_3();
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string string_9 = Class6.string_6;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Class16.smethod_1(Class6.Token);
					nameValueCollection["timestamp"] = Class16.smethod_1(DateTime.Now.ToString());
					nameValueCollection["aid"] = Class16.smethod_0(Class10.string_0);
					nameValueCollection["session_id"] = Class6.string_4;
					nameValueCollection["api_id"] = Class6.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Class6.APIENCRYPTKEY;
					nameValueCollection["session_key"] = Class6.string_5;
					nameValueCollection["secret"] = Class16.smethod_0(Class10.string_1);
					nameValueCollection["type"] = Class16.smethod_0("start");
					array = Class16.smethod_2(@default.GetString(webClient2.UploadValues(string_9, nameValueCollection))).Split("|".ToCharArray());
					if (Class12.smethod_7(array[1]) && array[0] != Class6.Token)
					{
						MessageBox.Show("Security error has been triggered!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
						Process.GetCurrentProcess().Kill();
					}
					string text = array[2];
					if (text != null)
					{
						if (!(text == "success"))
						{
							if (text == "binderror")
							{
								MessageBox.Show("Failed to bind to server, check your AID & Secret in your code!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
								Process.GetCurrentProcess().Kill();
								return;
							}
							if (text == "banned")
							{
								MessageBox.Show("This application has been banned for violating the TOS" + Environment.NewLine + "Contact us at support@auth.gg", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
								Process.GetCurrentProcess().Kill();
								return;
							}
						}
						else
						{
							Class6.bool_2 = true;
							if (array[3] == "Enabled")
							{
								Class9.Status = true;
							}
							if (array[4] == "Enabled")
							{
								Class9.DeveloperMode = true;
							}
							Class9.Hash = array[5];
							Class9.Version = array[6];
							Class9.Update_Link = array[7];
							if (array[8] == "Enabled")
							{
								Class9.Freemode = true;
							}
							if (array[9] == "Enabled")
							{
								Class9.Login = true;
							}
							Class9.Name = array[10];
							if (array[11] == "Enabled")
							{
								Class9.Register = true;
							}
							if (Class9.DeveloperMode)
							{
								File.Create(Environment.CurrentDirectory + "/hash.config").Close();
								string contents = Class12.smethod_6(Process.GetCurrentProcess().MainModule.FileName);
								File.WriteAllText(Environment.CurrentDirectory + "/hash.config", contents);
							}
							else
							{
								if (Class9.Version != Class10.string_2)
								{
									MessageBox.Show("Update " + Class9.Version + " available, redirecting to update!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
									Process.Start(Class9.Update_Link);
									Process.GetCurrentProcess().Kill();
								}
								array[12] == "Enabled";
							}
							if (!Class9.Status)
							{
								MessageBox.Show("Looks like this application is disabled, please try again later!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
								Process.GetCurrentProcess().Kill();
							}
						}
					}
					Class12.smethod_4();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
			}
		}

		// Token: 0x04000032 RID: 50
		public static string string_0 = null;

		// Token: 0x04000033 RID: 51
		public static string string_1 = null;

		// Token: 0x04000034 RID: 52
		public static string string_2 = null;

		// Token: 0x04000035 RID: 53
		public static string string_3 = null;

		// Token: 0x04000036 RID: 54
		public static string string_4 = null;
	}
}
