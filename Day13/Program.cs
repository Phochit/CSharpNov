using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cryptography, DB

            #region Cryptography(Cipher)

            // WDP
            // Hashing (1 way)
            // DES or AES => QES
            // RSA 

            // mywebsite - google

            // Encrypt, Decrypt

            #region WDP
            byte[] ori = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Original Values");
            //foreach (byte b in ori)
            //{
            //    Console.Write(b);
            //}

            Console.WriteLine();

            DataProtectionScope sc = DataProtectionScope.CurrentUser;

            //byte[] enc = ProtectedData.Protect(ori, null, sc);
            //Console.WriteLine("Encrypted Values");
            //foreach (byte b in enc)
            //{
            //    Console.Write(b);
            //}
            //Console.WriteLine();

            //byte[] dec = ProtectedData.Unprotect(enc, null, sc);
            //Console.WriteLine("Decrypted Values");
            //foreach (byte b in dec)
            //{
            //    Console.Write(b);
            //}
            //Console.WriteLine();
            #endregion

            #region Hashing

            // MD5,SHA1,SHA256,SHA384,SHA512

            string pw = "p@ssw@rd"+GenerateSalt();

            

            using(SHA256 sha256 = SHA256.Create())
            {
                byte[] enc = sha256.ComputeHash(Encoding.UTF8.GetBytes(pw));

                StringBuilder sb = new StringBuilder();
                foreach(byte b in enc)
                {
                    sb.Append(b.ToString());
                }

                string hashedOutput=sb.ToString();

                Console.WriteLine(hashedOutput);
            }

            #endregion

            #region What is Database(RDBMS)

            // Data -> Create -> View,Modify,Remove

            // Filebase

            // Relational Data Model

            // SQL(Conssitency), NoSQL(Performance)

            // MSSQL,Oracle,MySQL,DB2

            // MongoDB,Sqlite,Cough,Cassendra

            // Data Attribute

            // Atomic Attribute (FirstName,Day,Month,Year)
            // Single Attribute (NRC,BloodGroup,EmployeeID,Gender)
            // Multi Attribute (Email,Phone,PenColor,Subjects,Languages)
            // Composite Attribute (Address,DOB,Time,FullName,Height)

            // Normalization
            // 1NF,2NF,3NF,BCNF

            // 1NF -> atomic
            // 2NF -> multi -> modular object,remove calculate properties
            // 3NF -> define key(Primary,Foreign)

            // ERD

            // ADO.NET,LINQ(EF)

            #endregion

            #endregion

        }

        static string GenerateSalt()
        {
            byte[] saltByte= new byte[16];
            using(var rng=new RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltByte);
            }
            return Convert.ToBase64String(saltByte);
        }
    }
}
