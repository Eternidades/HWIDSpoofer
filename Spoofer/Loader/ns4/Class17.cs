using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows;

namespace ns4
{
	// Token: 0x02000014 RID: 20
	internal class Class17
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000234F File Offset: 0x0000054F
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x00002356 File Offset: 0x00000556
		public static string Secret { get; private set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000235E File Offset: 0x0000055E
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x00002365 File Offset: 0x00000565
		public static string Version { get; private set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000236D File Offset: 0x0000056D
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00002374 File Offset: 0x00000574
		public static string Name { get; private set; }

		// Token: 0x060000A8 RID: 168 RVA: 0x0000237C File Offset: 0x0000057C
		public Class17()
		{
			this.string_0 = this.method_3();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002390 File Offset: 0x00000590
		public void method_0()
		{
			this.timer_0 = new Timer(new TimerCallback(this.method_4), null, 5000, -1);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00006A90 File Offset: 0x00004C90
		private void method_1()
		{
			this.timer_0.Dispose();
			if (!(this.method_3() == this.string_0))
			{
				Class6.bool_0 = true;
				MessageBox.Show("ARP Cache poisoning has been detected!", Class10.string_3, MessageBoxButton.OK, MessageBoxImage.Hand);
				Process.GetCurrentProcess().Kill();
			}
			else
			{
				this.string_0 = this.method_3();
			}
			this.timer_0 = new Timer(new TimerCallback(this.method_5), null, 5000, -1);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00006B10 File Offset: 0x00004D10
		public static IPAddress smethod_0()
		{
			return NetworkInterface.GetAllNetworkInterfaces().Where(new Func<NetworkInterface, bool>(Class17.Class18.class18_0.method_0)).Where(new Func<NetworkInterface, bool>(Class17.Class18.class18_0.method_1)).SelectMany(new Func<NetworkInterface, IEnumerable<GatewayIPAddressInformation>>(Class17.Class18.class18_0.method_2)).Select(new Func<GatewayIPAddressInformation, IPAddress>(Class17.Class18.class18_0.method_3)).Where(new Func<IPAddress, bool>(Class17.Class18.class18_0.method_4)).FirstOrDefault<IPAddress>();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00006BE0 File Offset: 0x00004DE0
		private string method_2()
		{
			string pathRoot = Path.GetPathRoot(Environment.SystemDirectory);
			string result;
			using (Process process = Process.Start(new ProcessStartInfo
			{
				FileName = pathRoot + "Windows\\System32\\arp.exe",
				Arguments = "-a",
				UseShellExecute = false,
				RedirectStandardOutput = true
			}))
			{
				using (StreamReader standardOutput = process.StandardOutput)
				{
					result = standardOutput.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00006C74 File Offset: 0x00004E74
		private string method_3()
		{
			string arg = Class17.smethod_0().ToString();
			string pattern = string.Format("({0} [\\W]*) ([a-z0-9-]*)", arg);
			Regex regex = new Regex(pattern);
			Match match = regex.Match(this.method_2());
			return match.Groups[2].ToString();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000023B0 File Offset: 0x000005B0
		[CompilerGenerated]
		private void method_4(object object_0)
		{
			this.method_1();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000023B0 File Offset: 0x000005B0
		[CompilerGenerated]
		private void method_5(object object_0)
		{
			this.method_1();
		}

		// Token: 0x0400003C RID: 60
		private Timer timer_0;

		// Token: 0x0400003D RID: 61
		private string string_0;

		// Token: 0x0400003E RID: 62
		private static string string_1;

		// Token: 0x0400003F RID: 63
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static string string_2;

		// Token: 0x04000040 RID: 64
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static string string_3;

		// Token: 0x04000041 RID: 65
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static string string_4;

		// Token: 0x02000015 RID: 21
		[CompilerGenerated]
		[Serializable]
		private sealed class Class18
		{
			// Token: 0x060000B2 RID: 178 RVA: 0x000023C4 File Offset: 0x000005C4
			internal bool method_0(NetworkInterface networkInterface_0)
			{
				return networkInterface_0.OperationalStatus == OperationalStatus.Up;
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x000023CF File Offset: 0x000005CF
			internal bool method_1(NetworkInterface networkInterface_0)
			{
				return networkInterface_0.NetworkInterfaceType != NetworkInterfaceType.Loopback;
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x000023DE File Offset: 0x000005DE
			internal IEnumerable<GatewayIPAddressInformation> method_2(NetworkInterface networkInterface_0)
			{
				IPInterfaceProperties ipproperties = networkInterface_0.GetIPProperties();
				return (ipproperties != null) ? ipproperties.GatewayAddresses : null;
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x000023F2 File Offset: 0x000005F2
			internal IPAddress method_3(GatewayIPAddressInformation gatewayIPAddressInformation_0)
			{
				return (gatewayIPAddressInformation_0 != null) ? gatewayIPAddressInformation_0.Address : null;
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x00002400 File Offset: 0x00000600
			internal bool method_4(IPAddress ipaddress_0)
			{
				return ipaddress_0 != null;
			}

			// Token: 0x04000042 RID: 66
			public static readonly Class17.Class18 class18_0 = new Class17.Class18();

			// Token: 0x04000043 RID: 67
			public static Func<NetworkInterface, bool> func_0;

			// Token: 0x04000044 RID: 68
			public static Func<NetworkInterface, bool> func_1;

			// Token: 0x04000045 RID: 69
			public static Func<NetworkInterface, IEnumerable<GatewayIPAddressInformation>> func_2;

			// Token: 0x04000046 RID: 70
			public static Func<GatewayIPAddressInformation, IPAddress> func_3;

			// Token: 0x04000047 RID: 71
			public static Func<IPAddress, bool> func_4;
		}
	}
}
