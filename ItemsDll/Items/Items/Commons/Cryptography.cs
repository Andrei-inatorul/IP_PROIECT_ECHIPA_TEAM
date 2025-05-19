using System;
using System.Security.Cryptography;
using System.Text;

namespace Items.Commons
{
    public class Cryptography
    {
        public static string HashString(string str)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            byte[] buf = Encoding.UTF8.GetBytes(str);
            byte[] result = sha.ComputeHash(buf);
            return Convert.ToBase64String(result);
        }
    }
}