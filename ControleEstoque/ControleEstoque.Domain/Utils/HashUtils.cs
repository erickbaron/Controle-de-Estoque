using System;
using System.Security.Cryptography;
using System.Text;

namespace ControleEstoque.Domain.Utils
{
    public class HashUtils
    {
        public static string GetHashSha256(string text)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            if (hashString.Length > 50)
            {
                hashString = hashString.Substring(0, 50);
            }
            return hashString;
        }
    }
}