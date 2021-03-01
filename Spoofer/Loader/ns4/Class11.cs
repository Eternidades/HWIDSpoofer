using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Windows;
using ns2;

namespace ns4
{
	// Token: 0x0200000E RID: 14
	internal class Class11
	{
		// Token: 0x06000082 RID: 130 RVA: 0x00004FC8 File Offset: 0x000031C8
		public static void smethod_0(string string_0, string string_1)
		{
			if (!Class6.bool_2)
			{
				Process.GetCurrentProcess().Kill();
			}
			if (string.IsNullOrWhiteSpace(string_1))
			{
				Class3.smethod_4("No username/password!");
			}
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Class12.smethod_3();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string string_2 = Class6.string_6;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Class16.smethod_1(Class6.Token);
					nameValueCollection["aid"] = Class16.smethod_0(Class10.string_0);
					nameValueCollection["username"] = Class16.smethod_0(string_0);
					nameValueCollection["pcuser"] = Class16.smethod_0(Environment.UserName);
					nameValueCollection["session_id"] = Class6.string_4;
					nameValueCollection["api_id"] = Class6.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Class6.APIENCRYPTKEY;
					nameValueCollection["data"] = Class16.smethod_0(string_1);
					nameValueCollection["session_key"] = Class6.string_5;
					nameValueCollection["secret"] = Class16.smethod_0(Class10.string_1);
					nameValueCollection["type"] = Class16.smethod_0("log");
					Class16.smethod_2(@default.GetString(webClient2.UploadValues(string_2, nameValueCollection))).Split("|".ToCharArray());
					Class12.smethod_4();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00005180 File Offset: 0x00003380
		public static bool smethod_1(string string_0)
		{
			return Class11.smethod_2(string_0) || Class11.smethod_3(string_0);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000051A8 File Offset: 0x000033A8
		public static bool smethod_2(string string_0)
		{
			if (!Class6.bool_2)
			{
				MessageBox.Show("Please initialize your application first!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			if (string.IsNullOrWhiteSpace(string_0))
			{
				Class3.smethod_4("Incorrect login information!");
			}
			string[] array = new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Class12.smethod_3();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string string_ = Class6.string_6;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Class16.smethod_1(Class6.Token);
					nameValueCollection["timestamp"] = Class16.smethod_1(DateTime.Now.ToString());
					nameValueCollection["aid"] = Class16.smethod_0(Class10.string_0);
					nameValueCollection["session_id"] = Class6.string_4;
					nameValueCollection["api_id"] = Class6.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Class6.APIENCRYPTKEY;
					nameValueCollection["username"] = Class16.smethod_0(string_0);
					nameValueCollection["password"] = Class16.smethod_0(string_0);
					nameValueCollection["hwid"] = Class16.smethod_0("S-1-5-21-1053965767-4168882328-669648460-1001");
					nameValueCollection["session_key"] = Class6.string_5;
					nameValueCollection["secret"] = Class16.smethod_0(Class10.string_1);
					nameValueCollection["type"] = Class16.smethod_0("login");
					array = Class16.smethod_2(@default.GetString(webClient2.UploadValues(string_, nameValueCollection))).Split("|".ToCharArray());
					if (array[0] != Class6.Token)
					{
						MessageBox.Show("Security error has been triggered!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
						Process.GetCurrentProcess().Kill();
					}
					if (Class12.smethod_7(array[1]))
					{
						MessageBox.Show("Possible malicious activity detected!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					if (Class6.bool_0)
					{
						MessageBox.Show("Possible malicious activity detected!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					string text = array[2];
					string text2 = text;
					if (text2 != null)
					{
						if (text2 == "success")
						{
							Class12.smethod_4();
							Class8.ID = array[3];
							Class8.Username = array[4];
							Class8.Password = array[5];
							Class8.Email = array[6];
							Class8.HWID = array[7];
							Class8.UserVariable = array[8];
							Class8.Rank = array[9];
							Class8.IP = array[10];
							Class8.Expiry = array[11];
							Class8.LastLogin = array[12];
							Class8.RegisterDate = array[13];
							string text3 = array[14];
							foreach (string text4 in text3.Split(new char[]
							{
								'~'
							}))
							{
								string[] array3 = text4.Split(new char[]
								{
									'^'
								});
								try
								{
									Class5.dictionary_0.Add(array3[0], array3[1]);
								}
								catch
								{
								}
							}
							return true;
						}
						if (text2 == "invalid_details")
						{
							Class12.smethod_4();
							return false;
						}
						if (text2 == "time_expired")
						{
							Class3.smethod_4("Your subscription has expired/and or you have been blacklisted!");
							Class12.smethod_4();
							return false;
						}
						if (text2 == "hwid_updated")
						{
							Class3.smethod_3("Your HWID has been binded successfully please restart the spoofer!");
							Class12.smethod_4();
							return false;
						}
						if (text2 == "invalid_hwid")
						{
							Class3.smethod_4("This account is already binded to another PC please reset your HWID!");
							Class12.smethod_4();
							return false;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class12.smethod_4();
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000055B0 File Offset: 0x000037B0
		public static bool smethod_3(string string_0)
		{
			if (!Class6.bool_2)
			{
				MessageBox.Show("Please initialize your application first!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Class12.smethod_4();
				Process.GetCurrentProcess().Kill();
			}
			if (string.IsNullOrWhiteSpace(string_0))
			{
				MessageBox.Show("Invalid registrar information!", Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			string[] array = new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Class12.smethod_3();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string string_ = Class6.string_6;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Class16.smethod_1(Class6.Token);
					nameValueCollection["timestamp"] = Class16.smethod_1(DateTime.Now.ToString());
					nameValueCollection["aid"] = Class16.smethod_0(Class10.string_0);
					nameValueCollection["session_id"] = Class6.string_4;
					nameValueCollection["api_id"] = Class6.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Class6.APIENCRYPTKEY;
					nameValueCollection["session_key"] = Class6.string_5;
					nameValueCollection["secret"] = Class16.smethod_0(Class10.string_1);
					nameValueCollection["type"] = Class16.smethod_0("register");
					nameValueCollection["username"] = Class16.smethod_0(string_0);
					nameValueCollection["password"] = Class16.smethod_0(string_0);
					nameValueCollection["email"] = Class16.smethod_0(string_0);
					nameValueCollection["license"] = Class16.smethod_0(string_0);
					nameValueCollection["hwid"] = Class16.smethod_0("S-1-5-21-1053965767-4168882328-669648460-1001");
					array = Class16.smethod_2(@default.GetString(webClient2.UploadValues(string_, nameValueCollection))).Split("|".ToCharArray());
					if (array[0] != Class6.Token)
					{
						MessageBox.Show("Security error has been triggered!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
						Class12.smethod_4();
						Process.GetCurrentProcess().Kill();
					}
					if (Class12.smethod_7(array[1]))
					{
						MessageBox.Show("Possible malicious activity detected!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					if (Class6.bool_0)
					{
						MessageBox.Show("Possible malicious activity detected!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					Class12.smethod_4();
					string text = array[2];
					string text2 = text;
					if (text2 != null)
					{
						if (text2 == "success")
						{
							return true;
						}
						if (text2 == "error")
						{
							return false;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00005898 File Offset: 0x00003A98
		public static bool smethod_4(string string_0, string string_1)
		{
			if (!Class6.bool_2)
			{
				MessageBox.Show("Please initialize your application first!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			if (string.IsNullOrWhiteSpace(string_0) || string.IsNullOrWhiteSpace(string_1))
			{
				Class3.smethod_4("Missing username/and or password!");
			}
			string[] array = new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Class12.smethod_3();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string string_2 = Class6.string_6;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Class16.smethod_1(Class6.Token);
					nameValueCollection["timestamp"] = Class16.smethod_1(DateTime.Now.ToString());
					nameValueCollection["aid"] = Class16.smethod_0(Class10.string_0);
					nameValueCollection["session_id"] = Class6.string_4;
					nameValueCollection["api_id"] = Class6.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Class6.APIENCRYPTKEY;
					nameValueCollection["username"] = Class16.smethod_0(string_0);
					nameValueCollection["password"] = Class16.smethod_0(string_1);
					nameValueCollection["hwid"] = Class16.smethod_0("S-1-5-21-1053965767-4168882328-669648460-1001");
					nameValueCollection["session_key"] = Class6.string_5;
					nameValueCollection["secret"] = Class16.smethod_0(Class10.string_1);
					nameValueCollection["type"] = Class16.smethod_0("login");
					array = Class16.smethod_2(@default.GetString(webClient2.UploadValues(string_2, nameValueCollection))).Split("|".ToCharArray());
					if (array[0] != Class6.Token)
					{
						MessageBox.Show("Security error has been triggered!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
						Process.GetCurrentProcess().Kill();
					}
					if (Class12.smethod_7(array[1]))
					{
						MessageBox.Show("Possible malicious activity detected!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					if (Class6.bool_0)
					{
						MessageBox.Show("Possible malicious activity detected!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					string text = array[2];
					string text2 = text;
					if (text2 != null)
					{
						if (text2 == "success")
						{
							Class8.ID = array[3];
							Class8.Username = array[4];
							Class8.Password = array[5];
							Class8.Email = array[6];
							Class8.HWID = array[7];
							Class8.UserVariable = array[8];
							Class8.Rank = array[9];
							Class8.IP = array[10];
							Class8.Expiry = array[11];
							Class8.LastLogin = array[12];
							Class8.RegisterDate = array[13];
							string text3 = array[14];
							foreach (string text4 in text3.Split(new char[]
							{
								'~'
							}))
							{
								string[] array3 = text4.Split(new char[]
								{
									'^'
								});
								try
								{
									Class5.dictionary_0.Add(array3[0], array3[1]);
								}
								catch
								{
								}
							}
							Class12.smethod_4();
							return true;
						}
						if (text2 == "invalid_details")
						{
							Class3.smethod_4("Your username/and or password is incorrect!");
							Class12.smethod_4();
							return false;
						}
						if (text2 == "time_expired")
						{
							Class3.smethod_4("Your subscription has expired/and or you have been blacklisted!");
							Class12.smethod_4();
							return false;
						}
						if (text2 == "hwid_updated")
						{
							Class3.smethod_3("Your HWID has been binded successfully please restart the spoofer!");
							Class12.smethod_4();
							return false;
						}
						if (text2 == "invalid_hwid")
						{
							Class3.smethod_4("This account is already binded to another PC please reset your HWID!");
							Class12.smethod_4();
							return false;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
					Class12.smethod_4();
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00005CB8 File Offset: 0x00003EB8
		public static bool smethod_5(string string_0, string string_1, string string_2, string string_3)
		{
			if (!Class6.bool_2)
			{
				MessageBox.Show("Please initialize your application first!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Class12.smethod_4();
				Process.GetCurrentProcess().Kill();
			}
			if (string.IsNullOrWhiteSpace(string_0) || string.IsNullOrWhiteSpace(string_1) || string.IsNullOrWhiteSpace(string_2) || string.IsNullOrWhiteSpace(string_3))
			{
				MessageBox.Show("Invalid registrar information!", Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			string[] array = new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Class12.smethod_3();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string string_4 = Class6.string_6;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Class16.smethod_1(Class6.Token);
					nameValueCollection["timestamp"] = Class16.smethod_1(DateTime.Now.ToString());
					nameValueCollection["aid"] = Class16.smethod_0(Class10.string_0);
					nameValueCollection["session_id"] = Class6.string_4;
					nameValueCollection["api_id"] = Class6.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Class6.APIENCRYPTKEY;
					nameValueCollection["session_key"] = Class6.string_5;
					nameValueCollection["secret"] = Class16.smethod_0(Class10.string_1);
					nameValueCollection["type"] = Class16.smethod_0("register");
					nameValueCollection["username"] = Class16.smethod_0(string_0);
					nameValueCollection["password"] = Class16.smethod_0(string_1);
					nameValueCollection["email"] = Class16.smethod_0(string_2);
					nameValueCollection["license"] = Class16.smethod_0(string_3);
					nameValueCollection["hwid"] = Class16.smethod_0("S-1-5-21-1053965767-4168882328-669648460-1001");
					array = Class16.smethod_2(@default.GetString(webClient2.UploadValues(string_4, nameValueCollection))).Split("|".ToCharArray());
					if (array[0] != Class6.Token)
					{
						MessageBox.Show("Security error has been triggered!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
						Class12.smethod_4();
						Process.GetCurrentProcess().Kill();
					}
					if (Class12.smethod_7(array[1]))
					{
						MessageBox.Show("Possible malicious activity detected!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					if (Class6.bool_0)
					{
						MessageBox.Show("Possible malicious activity detected!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					string text = array[2];
					string text2 = text;
					if (text2 != null)
					{
						if (text2 == "success")
						{
							Class12.smethod_4();
							return true;
						}
						if (text2 == "invalid_license")
						{
							MessageBox.Show("License does not exist!", Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
							Class12.smethod_4();
							Process.GetCurrentProcess().Kill();
							return false;
						}
						if (text2 == "email_used")
						{
							MessageBox.Show("Email has already been used!", Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
							Class12.smethod_4();
							Process.GetCurrentProcess().Kill();
							return false;
						}
						if (text2 == "invalid_username")
						{
							MessageBox.Show("You entered an invalid/used username!", Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
							Class12.smethod_4();
							Process.GetCurrentProcess().Kill();
							return false;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000605C File Offset: 0x0000425C
		public static bool smethod_6(string string_0, string string_1, string string_2)
		{
			if (!Class6.bool_2)
			{
				MessageBox.Show("Please initialize your application first!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Class12.smethod_4();
				Process.GetCurrentProcess().Kill();
			}
			if (string.IsNullOrWhiteSpace(string_0) || string.IsNullOrWhiteSpace(string_1) || string.IsNullOrWhiteSpace(string_2))
			{
				MessageBox.Show("Invalid registrar information!", Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			string[] array = new string[0];
			bool result;
			using (WebClient webClient = new WebClient())
			{
				try
				{
					Class12.smethod_3();
					webClient.Proxy = null;
					Encoding @default = Encoding.Default;
					WebClient webClient2 = webClient;
					string string_3 = Class6.string_6;
					NameValueCollection nameValueCollection = new NameValueCollection();
					nameValueCollection["token"] = Class16.smethod_1(Class6.Token);
					nameValueCollection["timestamp"] = Class16.smethod_1(DateTime.Now.ToString());
					nameValueCollection["aid"] = Class16.smethod_0(Class10.string_0);
					nameValueCollection["session_id"] = Class6.string_4;
					nameValueCollection["api_id"] = Class6.APIENCRYPTSALT;
					nameValueCollection["api_key"] = Class6.APIENCRYPTKEY;
					nameValueCollection["session_key"] = Class6.string_5;
					nameValueCollection["secret"] = Class16.smethod_0(Class10.string_1);
					nameValueCollection["type"] = Class16.smethod_0("extend");
					nameValueCollection["username"] = Class16.smethod_0(string_0);
					nameValueCollection["password"] = Class16.smethod_0(string_1);
					nameValueCollection["license"] = Class16.smethod_0(string_2);
					array = Class16.smethod_2(@default.GetString(webClient2.UploadValues(string_3, nameValueCollection))).Split("|".ToCharArray());
					if (array[0] != Class6.Token)
					{
						MessageBox.Show("Security error has been triggered!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
						Class12.smethod_4();
						Process.GetCurrentProcess().Kill();
					}
					if (Class12.smethod_7(array[1]))
					{
						MessageBox.Show("Possible malicious activity detected!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					if (Class6.bool_0)
					{
						MessageBox.Show("Possible malicious activity detected!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Exclamation);
						Process.GetCurrentProcess().Kill();
					}
					string text = array[2];
					string text2 = text;
					if (text2 != null)
					{
						if (text2 == "success")
						{
							Class12.smethod_4();
							return true;
						}
						if (text2 == "invalid_token")
						{
							MessageBox.Show("Token does not exist!", Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
							Class12.smethod_4();
							Process.GetCurrentProcess().Kill();
							return false;
						}
						if (text2 == "invalid_details")
						{
							MessageBox.Show("Your user details are invalid!", Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
							Class12.smethod_4();
							Process.GetCurrentProcess().Kill();
							return false;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, Class9.Name, MessageBoxButton.OK, MessageBoxImage.Hand);
					Process.GetCurrentProcess().Kill();
				}
				result = false;
			}
			return result;
		}
	}
}
