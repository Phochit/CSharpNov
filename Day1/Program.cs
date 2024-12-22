using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Literals
            // Number,Words,Decision, Date & Time

            // Numbers
            // Integer,Decimal,Real,Rational,Prime
            // Constant,Variable

            // Name 

            // Variable Declaration

            // string, char

            string name = "Ko Aye"; // Ko Aye (string literal)
            name = "Ko Phyu"; // Ko Phyu

            char vowel = 'e'; // char literal

            Console.WriteLine(name);

            // byte,sbyte
            // short,ushort
            // int, uint ( 32 bits) - 4
            // long, ulong ( 64 bits ) - 8

            // byte -> 8 bits -> 0 to 255 ( 2p0 to 2p7)
            // sbyte -> 8 bits -> -128 to 127

            // short -> 16 bits -> -32768 to 32767
            // ushort -> 16 bits -> 0 to 65535

            byte age = 18;
            byte day = 24;

            Console.WriteLine(age);
            Console.WriteLine(day);

            // double,float,decimal (27)

            double dou = 10.123;
            float flo = 10.123f;
            decimal dec = 10.123m; // 128 bits 

            decimal a = dec;

            Console.WriteLine(dou);
            Console.WriteLine(flo);
            Console.WriteLine(dec);

            string nm,nm2;
            nm = "abcdd";


            string mystr = null; 

            object myobj= null;

            int? i = null;

            // Class, Struct

            // bool
            bool bo = true;

            Console.WriteLine(bo);

            // DateTime
            DateTime today = DateTime.Now.Date;
            Console.WriteLine(today.ToString("MM/dd/yyyy"));

            Console.WriteLine("Decimal : " + sizeof(decimal) + " bytes"); // 16

            // CV 

            Console.WriteLine(sizeof(int));


        }
    }
}
