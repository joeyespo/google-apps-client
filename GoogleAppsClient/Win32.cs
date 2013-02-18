using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace GoogleAppsClient
{
	public static class Win32
	{
		public const int SND_APPLICATION = 0x0080;
		public const int SND_ALIAS_START = 0x0000;
		public const int SND_RESOURCE = 0x00040004;
		public const int SND_FILENAME = 0x00020000;
		public const int SND_ALIAS_ID = 0x00110000;
		public const int SND_NOWAIT = 0x00002000;
		public const int SND_NOSTOP = 0x0010;
		public const int SND_MEMORY = 0x0004;
		public const int SND_PURGE = 0x0040;
		public const int SND_ASYNC = 0x0001;
		public const int SND_ALIAS = 0x00010000;
		public const int SND_SYNC = 0x0000;
		public const int SND_LOOP = 0x0008;
		public const int SND_NODEFAULT = 0x0002;

		[DllImportAttribute("winmm.dll", EntryPoint = "sndPlaySoundW")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool PlaySound([MarshalAsAttribute(UnmanagedType.LPWStr)] string pszSound, uint fuSound);
	}
}
