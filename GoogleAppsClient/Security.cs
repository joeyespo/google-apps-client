using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GoogleAppsClient
{
	public static class Security
	{
		static readonly byte[] entropy = Encoding.Unicode.GetBytes(Environment.MachineName + Application.ProductName);

		public static string EncryptString(string s)
		{
			return EncryptString(ToSecureString(s));
		}

		public static string EncryptString(SecureString s)
		{
			var encryptedData = ProtectedData.Protect(Encoding.Unicode.GetBytes(ToInsecureString(s)), entropy, DataProtectionScope.CurrentUser);
			return Convert.ToBase64String(encryptedData);
		}

		public static SecureString DecryptString(string encryptedData)
		{
			try
			{
				var decryptedData = ProtectedData.Unprotect(Convert.FromBase64String(encryptedData), entropy, DataProtectionScope.CurrentUser);
				return ToSecureString(Encoding.Unicode.GetString(decryptedData));
			}
			catch
			{
				return new SecureString();
			}
		}

		public static SecureString ToSecureString(string s)
		{
			var secure = new SecureString();
			foreach (var ch in s)
			{
				secure.AppendChar(ch);
			}
			secure.MakeReadOnly();
			return secure;
		}

		public static string ToInsecureString(string s)
		{
			return ToInsecureString(DecryptString(s));
		}

		public static string ToInsecureString(SecureString s)
		{
			var ptr = Marshal.SecureStringToBSTR(s);
			try
			{
				return Marshal.PtrToStringBSTR(ptr);
			}
			finally
			{
				Marshal.ZeroFreeBSTR(ptr);
			}
		}
	}
}
