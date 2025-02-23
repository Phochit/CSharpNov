using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AES

            // KEY

            Console.WriteLine(Encrypt("htw@gmail.com"));
            Console.WriteLine("------------------");
            Console.WriteLine(Decrypt(Encrypt("htw@gmail.com")));


        }

        static string Encrypt(string original)
        {
            string encKey = "INTEGRITY";
            byte[] encByte= Encoding.UTF8.GetBytes(original);

            using(Aes enc=Aes.Create())
            {
                var mixCode = new byte[] { 0x12, 0x87, 0x19, 0x21, 0x45, 0x61, 0x31, 0x58 };
                Rfc2898DeriveBytes rdb=new Rfc2898DeriveBytes(encKey, mixCode);

                enc.Key = rdb.GetBytes(32);
                enc.IV = rdb.GetBytes(16);

                using(MemoryStream ms=new MemoryStream ())
                {
                    using(CryptoStream cs=new CryptoStream(ms,enc.CreateEncryptor(),CryptoStreamMode.Write))
                    {
                        cs.Write(encByte,0,encByte.Length);
                        cs.Close();
                    }
                    original=Convert.ToBase64String(ms.ToArray());
                }
            }

            return original;
        }

        static string Decrypt(string encString)
        {
            string encKey = "INTEGRITY";
            encString = encString.Replace(" ", "+");
            byte[] encByte = Convert.FromBase64String(encString);

            using (Aes enc = Aes.Create())
            {
                var mixCode = new byte[] { 0x12, 0x87, 0x19, 0x21, 0x45, 0x61, 0x31, 0x58 };
                Rfc2898DeriveBytes rdb = new Rfc2898DeriveBytes(encKey, mixCode);

                enc.Key = rdb.GetBytes(32);
                enc.IV = rdb.GetBytes(16);

                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, enc.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(encByte, 0, encByte.Length);
                        cs.Close();
                    }
                    encString = Encoding.UTF8.GetString(ms.ToArray());
                }
            }

            return encString;
        }
    }
}
