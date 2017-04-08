using System;
using System.Collections.Generic;
using System.Text;

namespace MyPublicFuntion
{
    public class StringOperation
    {
        public static string GetPath(string FullName)
        {
            return FullName.Substring(0, FullName.LastIndexOf("\\", StringComparison.Ordinal) + 1);
        }

        public static string GetFileName(string FullName)
        {
            return FullName.Substring(FullName.LastIndexOf("\\", StringComparison.Ordinal) + 1, 
                FullName.LastIndexOf(".", StringComparison.Ordinal) - (FullName.LastIndexOf("\\", StringComparison.Ordinal) + 1));
        }

        public static string GetFileexc(string FullName)
        {
            return FullName.Substring(FullName.LastIndexOf(".", StringComparison.Ordinal) + 1, FullName.Length - FullName.LastIndexOf(".", StringComparison.Ordinal) - 1);
        }

        public static byte[] HexstringToHexBytes(string hexstring)
        {
            hexstring = hexstring.Replace(" ", "");
            if (hexstring.Length % 2 != 0)
            {
                hexstring += "0";
            }
            byte[] result = new byte[hexstring.Length / 2];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Convert.ToByte(hexstring.Substring(i * 2, 2), 16);
            }
            return result;
        }
    }
}
