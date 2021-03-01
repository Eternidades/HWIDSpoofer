using System;
using System.IO;
using System.Net;
using System.Threading;
using ns1;
using ns2;
using ns3;
using ns4;

namespace ns0
{
	// Token: 0x02000002 RID: 2
	internal class Class0
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002410 File Offset: 0x00000610
		private static string smethod_0()
		{
			string result;
			using (WebClient webClient = new WebClient())
			{
				result = webClient.DownloadString("https://pastebin.com/raw/iiX4GJNp");
			}
			return result;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000244C File Offset: 0x0000064C
		private static string smethod_1()
		{
			string result;
			using (WebClient webClient = new WebClient())
			{
				result = webClient.DownloadString("https://pastebin.com/raw/PHZ6sn6R");
			}
			return result;
		}

		// Token: 0x06000003 RID: 3
		public static void smethod_2()
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789s87dash986YDSIUs7dtauhdvsahdt-87asjidasnxvbbznvsnd87as0910371031-VANITY=GOD-23013=1391293981273SAGAHJDsdVASJDFASsdTQsSAsUHvosds7t785vuashdgasd785hasbdhasd";
			char[] array = new char[30];
			Random random = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = text[random.Next(text.Length)];
			}
			Console.Title = (new string(array) ?? "");
			if (!Directory.Exists("C:/Premium"))
			{
				Directory.CreateDirectory("C:/Premium");
			}
			Console.WindowHeight = 30;
			Console.WindowWidth = 60;
			Class3.smethod_3("Premium Spoofer - Working\r\nExecutor coming soon");
			Class3.smethod_2();
			Console.Clear();
			Class3.smethod_0();
			Class3.smethod_4("Username: ");
			string contents = Console.ReadLine();
			File.WriteAllText("C:\\Premium\\Username.txt", contents);
			Class3.smethod_4("Password: ");
			string text2 = Console.ReadLine();
			File.WriteAllText("C:\\Premium\\Password.txt", text2);
			if (Class11.smethod_4(contents, text2))
			{
				Console.Clear();
				Class3.smethod_0();
				Console.ForegroundColor = ConsoleColor.White;
				Class11.smethod_0(contents, "Logged in!");
				Console.WriteLine();
				Class3.smethod_3("User Info\n");
				Console.WriteLine("User : " + Class8.Username);
				Console.WriteLine("ID : " + Class8.ID);
				Class3.smethod_3("Premium Spoofer - Working\r\nExecutor coming soon");
				Class3.smethod_6("Unlink XBOX");
				Class3.smethod_6("Unlink Discord");
				Class3.smethod_6("Clean Traces");
				Class3.smethod_6("(AMD) HWID Changer");
				Class3.smethod_6("(INT) HWID Changer");
				Class3.smethod_6("Exit");
				Class3.smethod_4("Select an option above : ");
				string a2 = Console.ReadLine();
				if (a2 == "1")
				{
					Class4.smethod_4();
					Thread.Sleep(3000);
					Console.Clear();
					Class0.smethod_2();
					return;
				}
				if (a2 == "2")
				{
					Class4.smethod_3();
					Thread.Sleep(3000);
					Console.Clear();
					Class0.smethod_2();
					return;
				}
				if (a2 == "3")
				{
					Class4.smethod_2();
					Class4.smethod_0();
					Thread.Sleep(3000);
					Console.Clear();
					Class0.smethod_2();
					return;
				}
				if (a2 == "4")
				{
					Class4.smethod_7();
					Class1.smethod_16();
					Class1.smethod_2();
					Class1.smethod_14();
					Class1.smethod_15();
					Class1.smethod_17();
					Class1.smethod_23();
					Class4.smethod_5();
					Class4.smethod_6();
					Thread.Sleep(3000);
					Console.Clear();
					Class0.smethod_2();
					return;
				}
				if (a2 == "5")
				{
					Class4.smethod_7();
					Class1.smethod_2();
					Class1.smethod_14();
					Class1.smethod_15();
					Class1.smethod_23();
					Class4.smethod_5();
					Class4.smethod_6();
					Thread.Sleep(3000);
					Console.Clear();
					Class0.smethod_2();
					return;
				}
				if (a2 == "6")
				{
					Class3.smethod_3("Press any key to exit");
					Console.ReadLine();
					return;
				}
			}
		}

		// Token: 0x04000001 RID: 1
		private const string string_0 = "C:/Premium";

		// Token: 0x04000002 RID: 2
		private static Random random_0 = new Random();
	}
}
