// See https://aka.ms/new-console-template for more information


using System;
using System.Text.RegularExpressions;

namespace RegularExpression
{
	class Program
	{
		static void Main(string[] args)
		{
            #region Regular Expression

            // Basic Match
            // . 
            // \d => 0 to 9
            // \D 
            // \w => a to z, A to Z, 0 to 9, _
            // \W
            // \s => spaces,tabs,newlines
            // \S
            // dupe, \k


            // Anchor
            // ^ => Begin
            // $ => End

            // Quantifiers
            // * => 0 or More
            // + => 1 or More
            // ? => Optional
            // {x} => 

            // user DOB (YYYY-MM-DD)
            // 2000-01-01

            // ^\d{4}-\d{2}-\d{2}$

            // user IP address
            // 192.168.1.120

            // ^(\d{1,3}\.){3}\d{1,3}$

            // User Email
            // abcd@gmail.info

            // ^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$
            // ^\w+@\w\.\w{2,}$

            // User URL
            // http or https or ftp

            // User Favourite Color Code (#RRGGBB)
            // #FF0000
            // #F00

            // ^#?([a-fA-F0-9]{6} | [a-fA-F0-9]{3})$
            #endregion

            string pattern = @"\d+";
            string patDOB = @"^\d{4}-\d{2}-\d{2}$";

            Console.Write("Enter DOB(YYYY-MM-DD) : ");
            string check=Console.ReadLine();

            Regex reg = new Regex(patDOB);

            if(reg.IsMatch(check))
            {
                Console.WriteLine("Valid Date of Birth");
            }
            else
            {
                Console.WriteLine("Invalid Date of Birth");
            }

            var sigleResult=reg.Match(check);

            // Replace, Split

            //MatchCollection matches = reg.Matches(check);

            //foreach (Match match in matches)
            //{
            //    Console.WriteLine(match.Value);
            //}

            // Strong Password
            // Special Character 1
            // Uppercase 1
            // Lowercase 1
            // Number 1
            // Character lenght 8s

            // public ip

        }
    }
}
