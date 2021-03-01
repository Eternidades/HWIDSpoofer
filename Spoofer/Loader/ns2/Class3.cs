using System;

namespace ns2
{
	// Token: 0x02000006 RID: 6
	internal class Class3
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00003DEC File Offset: 0x00001FEC
		public static void smethod_0()
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("  ____                     _                 ");
			Console.WriteLine(" |  _ \\ _ __ ___ _ __ ___ (_)_   _ _ __ ___  ");
			Console.WriteLine(" | |_) | '__/ _ \\ '_ ` _ \\| | | | | '_ ` _ \\ ");
			Console.WriteLine(" |  __/| | |  __/ | | | | | | |_| | | | | | |");
			Console.WriteLine(" |_|   |_|  \\___|_| |_| |_|_|\\__,_|_| |_| |_|");
			Console.WriteLine("                                             ");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002092 File Offset: 0x00000292
		public static void smethod_1()
		{
			Class3.int_0 = 0;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000209A File Offset: 0x0000029A
		public static void smethod_2()
		{
			Class3.int_1 = 0;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000020A2 File Offset: 0x000002A2
		public static void smethod_3(string string_0)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("\n[");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("+");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("] ");
			Console.Write(string_0);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000020E0 File Offset: 0x000002E0
		public static void smethod_4(string string_0)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("\n[");
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("~");
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("] ");
			Console.Write(string_0);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003E44 File Offset: 0x00002044
		public static void smethod_5(string string_0)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("\n[");
			Console.ForegroundColor = ConsoleColor.White;
			Class3.int_0++;
			Console.Write(Class3.int_0);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("] ");
			Console.Write(string_0);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003E98 File Offset: 0x00002098
		public static void smethod_6(string string_0)
		{
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("\n[");
			Console.ForegroundColor = ConsoleColor.Blue;
			Class3.int_1++;
			Console.Write(Class3.int_1);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("] ");
			Console.Write(string_0);
		}

		// Token: 0x0400000D RID: 13
		private static int int_0;

		// Token: 0x0400000E RID: 14
		private static int int_1;
	}
}
