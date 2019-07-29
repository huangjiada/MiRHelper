using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace nMirHelper
{
	public static class Utility
	{
		private static Task _checkOutDate = null;

		private static CancellationTokenSource _cancelCheckOutDate = null;

		private static string _machineCode = null;

		private static string _license = null;

		private static string _mask = "pzsWaOZfyrr1yXTnJxDj";

		internal static bool PassReg = false;//默认加密

		private static string machineCode
		{
			get
			{
				if (_machineCode == null)
				{
					_machineCode = GetMCode();
				}
				return _machineCode;
			}
		}

		public static byte[] GetBytes(short @short)
		{
			byte[] bytes = BitConverter.GetBytes(@short);
			Array.Reverse(bytes);
			return bytes;
		}

		public static short GetRandom()
		{
			Random random = new Random(1);
			return (short)random.Next(0, 32767);
		}

		public static double r2d(this double radian)
		{
			return radian * 180.0 / Math.PI;
		}

		private static string GetMCode()
		{
			string text = GetCPUSerialNumber() + GetDiskVolumeSerialNumber();
			if (text == "")
			{
				text = "SUZHOUNONEADNETWORKSTCoLtd";
			}
			return text;
		}

		private static string GetCPUSerialNumber()
		{
			string result = string.Empty;
			ManagementClass managementClass = new ManagementClass("Win32_Processor");
			ManagementObjectCollection instances = managementClass.GetInstances();
			using (ManagementObjectCollection.ManagementObjectEnumerator managementObjectEnumerator = instances.GetEnumerator())
			{
				if (managementObjectEnumerator.MoveNext())
				{
					ManagementObject managementObject = (ManagementObject)managementObjectEnumerator.Current;
					result = managementObject["ProcessorId"].ToString();
				}
			}
			managementClass.Dispose();
			instances.Dispose();
			return result;
		}

		private static string GetDiskVolumeSerialNumber()
		{
			ManagementClass managementClass = new ManagementClass("Win32_NetworkAdapterConfiguration");
			ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
			managementObject.Get();
			return managementObject.GetPropertyValue("VolumeSerialNumber").ToString();
		}

		private static string nDecode(string sString, string sKey)
		{
			sString = DecodeBase64(sString);
			int length = sString.Length;
			int num = 32 - length % 32;
			int num2 = sString.Length / 32;
			sKey = ToMD5(sKey);
			string text = "";
			char[] array = sString.ToCharArray();
			char[] array2 = sKey.ToCharArray();
			int num3 = 0;
			for (int i = 0; i < array.Length; i++)
			{
				text += ((char)(ushort)(array[i] ^ array2[num3])).ToString();
				num3++;
				if (num3 == array2.Length)
				{
					num3 = 0;
				}
			}
			return text.Substring(0, length);
		}

		private static string ToMD5(string strPwd)
		{
			MD5 mD = new MD5CryptoServiceProvider();
			byte[] bytes = Encoding.Default.GetBytes(strPwd);
			byte[] array = mD.ComputeHash(bytes);
			mD.Clear();
			string text = "";
			for (int i = 0; i < array.Length; i++)
			{
				text += array[i].ToString("x").PadLeft(2, '0');
			}
			return text;
		}

		private static string DecodeBase64(string result)
		{
			return DecodeBase64(Encoding.UTF8, result);
		}

		private static string DecodeBase64(Encoding encode, string result)
		{
			string text = "";
			try
			{
				byte[] bytes = Convert.FromBase64String(result);
				return encode.GetString(bytes);
			}
			catch
			{
				return result;
			}
		}

		public static int RegisterLicense(string license)
		{
			if (string.IsNullOrEmpty(license))
			{
				return 1;
			}
			try
			{
				_license = nDecode(license, _mask);
				string[] array = _license.Split('-');
				if (array.Length != 4)
				{
					return 2;
				}
				string text = $"{array[1][0]}{array[1][1]}{array[1][2]}{array[1][3]}-{array[1][4]}{array[1][5]}-{array[1][6]}{array[1][7]}";
				string text2 = $"{array[2][0]}{array[2][1]}:{array[2][2]}{array[2][3]}:{array[2][4]}{array[2][5]}";
				if (!Regex.IsMatch(array[0], "^[A-Z][0-9][0-9][0-9]") || !Regex.IsMatch(text, "([0-9]{3}[1-9]|[0-9]{2}[1-9][0-9]{1}|[0-9]{1}[1-9][0-9]{2}|[1-9][0-9]{3})-(((0[13578]|1[02])-(0[1-9]|[12][0-9]|3[01]))|((0[469]|11)-(0[1-9]|[12][0-9]|30))|(02-(0[1-9]|[1][0-9]|2[0-8])))") || !Regex.IsMatch(text2, "^(0\\d{1}|1\\d{1}|2[0-3]):[0-5]\\d{1}:([0-5]\\d{1})$"))
				{
					return 3;
				}
				if (array[0] != "U018")
				{
					return 4;
				}
				DateTime outDate = Convert.ToDateTime($"{text} {text2}");
				if (DateTime.Now > outDate)
				{
					return 5;
				}
				if (machineCode.Equals(array[3]))
				{
					PassReg = true;
					if (_checkOutDate != null && _cancelCheckOutDate != null)
					{
						_cancelCheckOutDate.Cancel();
					}
					_cancelCheckOutDate = new CancellationTokenSource();
					_checkOutDate = new Task(delegate
					{
						do
						{
							if (_cancelCheckOutDate.IsCancellationRequested)
							{
								return;
							}
						}
						while (!(DateTime.Now > outDate));
						throw new Exception("软件注册码已过期.");
					}, _cancelCheckOutDate.Token);
					_checkOutDate.Start();
					return 0;
				}
				return 6;
			}
			catch (Exception)
			{
				return 9;
			}
		}
	}
}
