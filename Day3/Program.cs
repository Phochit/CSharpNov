using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Program
    {
        static void ShowName(string nm)
        {
            if(nm == null)
                throw new ArgumentNullException(nameof(nm));

            Console.WriteLine(nm);
        }
        static void Main(string[] args)
        {
            // String, Conversion

            string directory = "c:\\newfolder\\temp";

            string dir2 = @"c:\newfolder\temp";

            string name = "ITC";

            string Sentence = name + " is traning school"; // Concat

            string sen2 = $"{name} is a training school.";

            string myhtml = "<table>" +"<tr><td>"+name+"</td></tr>" +"</table>";

            string a = "99"; //  abc
            string pl = a.PadLeft(6, '0');
            string pr = a.PadRight(7);

            try
            {

                ShowName(null);
            }
            catch (Exception ex) 
            { 
                Console.WriteLine(ex);
            }

            Console.WriteLine(dir2);
            Console.WriteLine(sen2);
            Console.WriteLine("{0} | {1}", name, sen2);
            Console.WriteLine(pl + ".");
            Console.WriteLine(pr + ".");


            int intval = 15;
            string res = intval.ToString("0000");
            Console.WriteLine(res);

            double weight = 125.756;
            string res2 = weight.ToString("0.00");
            Console.WriteLine(res2);

            DateTime current = DateTime.UtcNow.AddMinutes(390);
            string res3 = current.ToString("MM-dd yyyy"); // BC, AD - TZ - +6:30(GMT,UTC)
            Console.WriteLine(current);

            // Conversion 
            // Casting (implicit,explicit,upcast,downcast,multicast,box,unbox)
            
            byte b = 10;
            int i = b; // Conversion (Implicit)
            b =(byte) i; // Explicit (Data Loss)
        }
    }
}
