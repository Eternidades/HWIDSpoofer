using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;

namespace ns4
{
	// Token: 0x02000009 RID: 9
	internal class Class6
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00002130 File Offset: 0x00000330
		// (set) Token: 0x06000047 RID: 71 RVA: 0x00002137 File Offset: 0x00000337
		public static string Token { get; set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000213F File Offset: 0x0000033F
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002146 File Offset: 0x00000346
		public static string Date { get; set; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000214E File Offset: 0x0000034E
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002155 File Offset: 0x00000355
		public static string APIENCRYPTKEY { get; set; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0000215D File Offset: 0x0000035D
		// (set) Token: 0x0600004D RID: 77 RVA: 0x00002164 File Offset: 0x00000364
		public static string APIENCRYPTSALT { get; set; }

		// Token: 0x0600004E RID: 78 RVA: 0x00004B6C File Offset: 0x00002D6C
		public static string smethod_0(int int_0)
		{
			return new string(Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789", int_0).Select(new Func<string, char>(Class6.Class7.class7_0.method_0)).ToArray<char>());
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004BB8 File Offset: 0x00002DB8
		public static string smethod_1()
		{
			return WindowsIdentity.GetCurrent().User.Value;
		}

		// Token: 0x04000011 RID: 17
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static string string_0;

		// Token: 0x04000012 RID: 18
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static string string_1;

		// Token: 0x04000013 RID: 19
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static string string_2;

		// Token: 0x04000014 RID: 20
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static string string_3;

		// Token: 0x04000015 RID: 21
		public static bool bool_0 = false;

		// Token: 0x04000016 RID: 22
		public static bool bool_1 = false;

		// Token: 0x04000017 RID: 23
		public static string string_4 = null;

		// Token: 0x04000018 RID: 24
		public static string string_5 = null;

		// Token: 0x04000019 RID: 25
		public static string string_6 = "https://api.auth.gg/csharp/";

		// Token: 0x0400001A RID: 26
		public static bool bool_2 = false;

		// Token: 0x0400001B RID: 27
		public static Random random_0 = new Random();

		// Token: 0x0200000A RID: 10
		[CompilerGenerated]
		[Serializable]
		private sealed class Class7
		{
			// Token: 0x06000054 RID: 84 RVA: 0x000021AD File Offset: 0x000003AD
			internal char method_0(string string_0)
			{
				return string_0[Class6.random_0.Next(string_0.Length)];
			}

			// Token: 0x0400001C RID: 28
			public static readonly Class6.Class7 class7_0 = new Class6.Class7();

			// Token: 0x0400001D RID: 29
			public static Func<string, char> func_0;
		}
	}
}
