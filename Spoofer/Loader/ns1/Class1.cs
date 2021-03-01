using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Principal;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;
using ns2;

namespace ns1
{
	// Token: 0x02000003 RID: 3
	internal class Class1
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002ACC File Offset: 0x00000CCC
		public static bool smethod_0()
		{
			return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002AF0 File Offset: 0x00000CF0
		public static string smethod_1(int int_0)
		{
			char[] array = new char[int_0];
			for (int i = 0; i < int_0; i++)
			{
				array[i] = "ABCDEF0123456789"[Class1.random_0.Next("ABCDEF0123456789".Length)];
			}
			return new string(array);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002B40 File Offset: 0x00000D40
		public static void smethod_2()
		{
			Console.WriteLine();
			Class3.smethod_4("Current GUID : " + "{4ba54d49-8cea-7e89-8a8d-efe8afb5813e}");
			Console.WriteLine();
			string value = Guid.NewGuid().ToString();
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Cryptography", true);
			registryKey.SetValue("MachineGuid", value);
			Class3.smethod_4("GUID CHANGED TO : " + "{4ba54d49-8cea-7e89-8a8d-efe8afb5813e}");
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002BC0 File Offset: 0x00000DC0
		public static void smethod_3()
		{
			Console.WriteLine();
			Console.WriteLine();
			string value = Guid.NewGuid().ToString();
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\0", true);
			registryKey.SetValue("Identifier", value);
			Class3.smethod_4("SERIAL CHANGED");
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002C24 File Offset: 0x00000E24
		public static void smethod_4()
		{
			Console.WriteLine();
			Console.WriteLine();
			string value = Class1.smethod_5().ToString();
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\MultifunctionAdapter\\0\\DiskController\\0\\DiskPeripheral\\1", true);
			registryKey.SetValue("Identifier", value);
			Class3.smethod_4("SERIAL CHANGED");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002064 File Offset: 0x00000264
		private static object smethod_5()
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002C7C File Offset: 0x00000E7C
		public static string smethod_6()
		{
			string text = "SOFTWARE\\Microsoft\\Cryptography";
			string text2 = "MachineGuid";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002D30 File Offset: 0x00000F30
		public static void smethod_7()
		{
			Console.WriteLine();
			Class3.smethod_4("CURRENT PRODUCT ID : " + "84OL1-d8Nd7-35TRO-KO32f-LOKKP");
			Console.WriteLine("");
			string value = string.Concat(new string[]
			{
				"2ECEB",
				"-",
				"FBDE7",
				"-",
				"0AF06",
				"-",
				"3ECA0"
			});
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("ProductID", value);
			registryKey.Close();
			Class3.smethod_4("PRODUCT ID CHANGED TO : " + "84OL1-d8Nd7-35TRO-KO32f-LOKKP");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002DF4 File Offset: 0x00000FF4
		public static string smethod_8()
		{
			string text = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
			string text2 = "ProductID";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002EA8 File Offset: 0x000010A8
		public static string smethod_9(int int_0)
		{
			char[] array = new char[int_0];
			for (int i = 0; i < int_0; i++)
			{
				array[i] = "abcdef0123456789"[Class1.random_1.Next("abcdef0123456789".Length)];
			}
			return new string(array);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002EF8 File Offset: 0x000010F8
		public static void smethod_10()
		{
			Console.WriteLine("");
			Class3.smethod_4("CURRENT INSTALL TIME : " + "110359184671493");
			Console.WriteLine();
			string value = "2ecebfbde70af06";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallTime", value);
			registryKey.Close();
			Class3.smethod_4("INSTALL TIME CHANGED TO : " + "110359184671493");
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002F78 File Offset: 0x00001178
		public static string smethod_11()
		{
			string text = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
			string text2 = "InstallTime";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000302C File Offset: 0x0000122C
		public static void smethod_12()
		{
			Console.WriteLine();
			Class3.smethod_4("CURRENT INSTALL DATE : " + "77326591226095");
			Console.WriteLine("");
			string value = "3eca0821";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", true);
			registryKey.SetValue("InstallDate", value);
			registryKey.Close();
			Class3.smethod_4("INSTALL DATE CHANGED TO : " + "77326591226095");
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000030AC File Offset: 0x000012AC
		public static string smethod_13()
		{
			string text = "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion";
			string text2 = "InstallDate";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003160 File Offset: 0x00001360
		public static void smethod_14()
		{
			Console.WriteLine();
			Class3.smethod_4("CURRENT HWID : " + "{zlRedman-34030-30189-3815-087208815}");
			Console.WriteLine("");
			string value = "{" + Guid.NewGuid().ToString() + "}";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001", true);
			registryKey.SetValue("HwProfileGUID", value);
			registryKey.Close();
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Class3.smethod_4("NEW HWID : " + "{zlRedman-34030-30189-3815-087208815}");
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003238 File Offset: 0x00001438
		public static void smethod_15()
		{
			Console.WriteLine();
			Class3.smethod_4("CURRENT MOBO HWID : " + "{daaacdfc-5314-11e2-9765-32239305c203}");
			Console.WriteLine("");
			string value = "{" + Guid.NewGuid().ToString() + "}";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("SYSTEM\\HardwareConfig", true);
			registryKey.SetValue("LastConfig", value);
			registryKey.Close();
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Class3.smethod_4("NEW MOBO HWID : " + "{daaacdfc-5314-11e2-9765-32239305c203}");
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003310 File Offset: 0x00001510
		public static void smethod_16()
		{
			Console.WriteLine();
			Class3.smethod_4("CURRENT UUID : " + Class1.smethod_20());
			Console.WriteLine("");
			string value = Guid.NewGuid().ToString() ?? "";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("SOFTWARE\\INextUUID", true);
			registryKey.SetValue("ATHENAUUID", value);
			registryKey.Close();
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Class3.smethod_4("NEW UUID : " + Class1.smethod_20());
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000033E4 File Offset: 0x000015E4
		public static void smethod_17()
		{
			Console.WriteLine();
			Console.WriteLine("");
			string value = "{" + Guid.NewGuid().ToString() + "}";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\AmdPPM\\Parameters", true);
			registryKey.SetValue("WppRecorder_TraceGuid", value);
			registryKey.Close();
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.UseShellExecute = true;
			process.StartInfo.CreateNoWindow = false;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Class3.smethod_4("NEW CPU GUID : " + Class1.smethod_18());
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000034A8 File Offset: 0x000016A8
		public static string smethod_18()
		{
			string text = "SYSTEM\\CurrentControlSet\\Services\\AmdPPM\\Parameters";
			string text2 = "WppRecorder_TraceGuid";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x0000355C File Offset: 0x0000175C
		public static string smethod_19()
		{
			string text = "SYSTEM\\HardwareConfig";
			string text2 = "LastConfig";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003610 File Offset: 0x00001810
		public static string smethod_20()
		{
			string text = "SOFTWARE\\INextUUID";
			string text2 = "ATHENAUUID";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000036C4 File Offset: 0x000018C4
		public static string smethod_21()
		{
			string text = "SYSTEM\\CurrentControlSet\\Control\\IDConfigDB\\Hardware Profiles\\0001";
			string text2 = "HwProfileGUID";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003778 File Offset: 0x00001978
		public static bool smethod_22(string string_2, byte[] byte_0, int int_0)
		{
			for (int i = 0; i < string_2.Length; i++)
			{
				if (byte_0[i + int_0] != (byte)string_2[i])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000037B4 File Offset: 0x000019B4
		public static void smethod_23()
		{
			string text = "82172A5E";
			uint uint_ = uint.Parse(text, NumberStyles.HexNumber);
			Console.WriteLine();
			Class3.smethod_4("NEW HWID SERIAL : " + text + " - " + uint_.ToString());
			Console.WriteLine();
			Class1.smethod_24('C', uint_);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000206B File Offset: 0x0000026B
		private static void smethod_24(char char_0, uint uint_0)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003804 File Offset: 0x00001A04
		public static void smethod_25()
		{
			Console.WriteLine();
			Class3.smethod_4("CURRENT PC NAME : " + "Desktop19124");
			Console.WriteLine("");
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName", true);
			registryKey.SetValue("ComputerName", "Premium-" + "7A148E99A5B569D");
			registryKey.Close();
			Class3.smethod_4("NEW PC NAME : " + "Desktop19124");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000388C File Offset: 0x00001A8C
		public static string smethod_26()
		{
			string text = "SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ActiveComputerName";
			string text2 = "ComputerName";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003940 File Offset: 0x00001B40
		public static void smethod_27()
		{
			Console.WriteLine();
			Class3.smethod_4("CURRENT HWID : {TOO BIG}" + "{zlRedman-34030-30189-3815-087208815}");
			Console.WriteLine("");
			string value = "{" + Guid.NewGuid().ToString() + "}";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("HARDWARE\\DEVICEMAP\\VIDEO", true);
			registryKey.SetValue("\\Device\\Video1", value);
			registryKey.Close();
			Class3.smethod_4("NEW HWID : {TOO BIG}" + "{zlRedman-34030-30189-3815-087208815}");
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003940 File Offset: 0x00001B40
		public static void smethod_28()
		{
			Console.WriteLine();
			Class3.smethod_4("CURRENT HWID : {TOO BIG}" + "{zlRedman-34030-30189-3815-087208815}");
			Console.WriteLine("");
			string value = "{" + Guid.NewGuid().ToString() + "}";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("HARDWARE\\DEVICEMAP\\VIDEO", true);
			registryKey.SetValue("\\Device\\Video1", value);
			registryKey.Close();
			Class3.smethod_4("NEW HWID : {TOO BIG}" + "{zlRedman-34030-30189-3815-087208815}");
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000039E0 File Offset: 0x00001BE0
		public static void smethod_29()
		{
			Console.WriteLine();
			Class3.smethod_4("CURRENT HWID : {TOO BIG}" + "{zlRedman-34030-30189-3815-087208815}");
			Console.WriteLine("");
			string value = "{" + Guid.NewGuid().ToString() + "}";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("HARDWARE\\DEVICEMAP\\VIDEO", true);
			registryKey.SetValue("\\Device\\Video2", value);
			registryKey.Close();
			Class3.smethod_4("NEW HWID : {TOO BIG}" + "{zlRedman-34030-30189-3815-087208815}");
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003A80 File Offset: 0x00001C80
		public static void smethod_30()
		{
			Console.WriteLine();
			Class3.smethod_4("CURRENT HWID : {TOO BIG}" + "{zlRedman-34030-30189-3815-087208815}");
			Console.WriteLine("");
			string value = "{" + Guid.NewGuid().ToString() + "}";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("HARDWARE\\DEVICEMAP\\VIDEO", true);
			registryKey.SetValue("\\Device\\Video3", value);
			registryKey.Close();
			Class3.smethod_4("NEW HWID : {TOO BIG}" + "{zlRedman-34030-30189-3815-087208815}");
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003B20 File Offset: 0x00001D20
		public static void smethod_31()
		{
			Console.WriteLine();
			Class3.smethod_4("CURRENT HWID : {TOO BIG}" + "{zlRedman-34030-30189-3815-087208815}");
			Console.WriteLine("");
			string value = "{" + Guid.NewGuid().ToString() + "}";
			RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
			registryKey = registryKey.OpenSubKey("HARDWARE\\DEVICEMAP\\VIDEO", true);
			registryKey.SetValue("\\Device\\Video4", value);
			registryKey.Close();
			Class3.smethod_4("NEW HWID : {TOO BIG}" + "{zlRedman-34030-30189-3815-087208815}");
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003BC0 File Offset: 0x00001DC0
		public static string smethod_32()
		{
			string text = "HARDWARE\\DEVICEMAP\\VIDEO";
			string text2 = "\\Device\\Video0";
			string result;
			using (RegistryKey registryKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
			{
				using (RegistryKey registryKey2 = registryKey.OpenSubKey(text))
				{
					if (registryKey2 == null)
					{
						throw new KeyNotFoundException(string.Format("Key Not Found: {0}", text));
					}
					object value = registryKey2.GetValue(text2);
					if (value == null)
					{
						throw new IndexOutOfRangeException(string.Format("Index Not Found: {0}", text2));
					}
					result = value.ToString();
				}
			}
			return result;
		}

		// Token: 0x04000003 RID: 3
		public static Random random_0 = new Random();

		// Token: 0x04000004 RID: 4
		public const string string_0 = "ABCDEF0123456789";

		// Token: 0x04000005 RID: 5
		public static Random random_1 = new Random();

		// Token: 0x04000006 RID: 6
		public const string string_1 = "abcdef0123456789";

		// Token: 0x02000004 RID: 4
		private class Class2 : IDisposable
		{
			// Token: 0x06000029 RID: 41 RVA: 0x00003C74 File Offset: 0x00001E74
			public Class2(char char_0)
			{
				IntPtr preexistingHandle = Class1.Class2.CreateFile(string.Format("\\\\.\\{0}:", char_0), FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, 0, IntPtr.Zero);
				this.safeFileHandle_0 = new SafeFileHandle(preexistingHandle, true);
				if (this.safeFileHandle_0.IsInvalid)
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
			}

			// Token: 0x0600002A RID: 42 RVA: 0x00003CD0 File Offset: 0x00001ED0
			public void method_0(uint uint_1, byte[] byte_0)
			{
				if (byte_0 == null)
				{
					throw new ArgumentNullException("buffer");
				}
				if (Class1.Class2.SetFilePointer(this.safeFileHandle_0, uint_1, IntPtr.Zero, Class1.Class2.Enum0.const_0) == 4294967295U)
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
				uint num;
				if (!Class1.Class2.ReadFile(this.safeFileHandle_0, byte_0, byte_0.Length, out num, IntPtr.Zero))
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
				if ((ulong)num != (ulong)((long)byte_0.Length))
				{
					throw new IOException();
				}
			}

			// Token: 0x0600002B RID: 43 RVA: 0x00003D48 File Offset: 0x00001F48
			public void method_1(uint uint_1, byte[] byte_0)
			{
				if (byte_0 == null)
				{
					throw new ArgumentNullException("buffer");
				}
				if (Class1.Class2.SetFilePointer(this.safeFileHandle_0, uint_1, IntPtr.Zero, Class1.Class2.Enum0.const_0) == 4294967295U)
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
				uint num;
				if (!Class1.Class2.WriteFile(this.safeFileHandle_0, byte_0, byte_0.Length, out num, IntPtr.Zero))
				{
					Marshal.ThrowExceptionForHR(Marshal.GetHRForLastWin32Error());
				}
				if ((ulong)num != (ulong)((long)byte_0.Length))
				{
					throw new IOException();
				}
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00002083 File Offset: 0x00000283
			public void Dispose()
			{
				this.Dispose(true);
				GC.SuppressFinalize(this);
			}

			// Token: 0x0600002D RID: 45 RVA: 0x00003DC0 File Offset: 0x00001FC0
			protected virtual void Dispose(bool bool_0)
			{
				if (bool_0 && this.safeFileHandle_0 != null)
				{
					this.safeFileHandle_0.Dispose();
				}
			}

			// Token: 0x0600002E RID: 46
			[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
			public static extern IntPtr CreateFile(string string_0, [MarshalAs(UnmanagedType.U4)] FileAccess fileAccess_0, [MarshalAs(UnmanagedType.U4)] FileShare fileShare_0, IntPtr intptr_0, [MarshalAs(UnmanagedType.U4)] FileMode fileMode_0, int int_0, IntPtr intptr_1);

			// Token: 0x0600002F RID: 47
			[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
			private static extern uint SetFilePointer([In] SafeFileHandle safeFileHandle_1, [In] uint uint_1, [In] IntPtr intptr_0, [In] Class1.Class2.Enum0 enum0_0);

			// Token: 0x06000030 RID: 48
			[DllImport("kernel32.dll", SetLastError = true)]
			private static extern bool ReadFile(SafeFileHandle safeFileHandle_1, [Out] byte[] byte_0, int int_0, out uint uint_1, IntPtr intptr_0);

			// Token: 0x06000031 RID: 49
			[DllImport("kernel32.dll")]
			private static extern bool WriteFile(SafeFileHandle safeFileHandle_1, [In] byte[] byte_0, int int_0, out uint uint_1, [In] IntPtr intptr_0);

			// Token: 0x04000007 RID: 7
			private SafeFileHandle safeFileHandle_0;

			// Token: 0x04000008 RID: 8
			private const uint uint_0 = 4294967295U;

			// Token: 0x02000005 RID: 5
			private enum Enum0 : uint
			{
				// Token: 0x0400000A RID: 10
				const_0,
				// Token: 0x0400000B RID: 11
				const_1,
				// Token: 0x0400000C RID: 12
				const_2
			}
		}
	}
}
