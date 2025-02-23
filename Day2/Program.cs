using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    internal class Program
    {

        //class Employee(int i, int j)
        //{

        //}
        struct Person
        {
            public string name;
            public int age;


        }
        static void Main(string[] args)
        {

            Person person = new Person();

            // Operators

            // data -> information

            // Assignment Operator
            // =, +=,-=

            // Arithmatic Operators
            // +,-,*,/,%

            // Comparison Operators
            // >, <, >=, <=, ==, !=

            // Logical Operators
            // AND (&&) , OR (||), NOT(!)


            // Decision Making
            // (if-else) (switch)

            // Can be vote.
            // Can't vote.

            /*
            Console.Write("Enter your nationality : ");
            string nat = Console.ReadLine();
            Console.Write("Enter your age : ");
            //int age =int.Parse( Console.ReadLine());
            int age = Convert.ToInt32(Console.ReadLine());

            if(nat.ToLower()=="mm"  && age>=18) // TRUE
            {
                Console.WriteLine("Can be vote.");
            }
            else // Default
            {
                Console.WriteLine("Can't vote.");
            }
            */

            //int marks = 85;

            //if(marks>=50)
            //{
            //    if (marks >= 65 && marks < 85)
            //        Console.WriteLine("Pass with Credit");
            //    else if (marks >= 85)
            //        Console.WriteLine("Pass with D");
            //    else
            //        Console.WriteLine("Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Failed");
            //}

            int cardNo = 11;

            if (cardNo == 11)
            {
                Console.WriteLine("Jack");
            }
            else if (cardNo == 12)
            {
                Console.WriteLine("Queen");
            }
            else if (cardNo == 13)
            {
                Console.WriteLine("King");
            }
            else
            {
                Console.WriteLine("Plain Card");
            }

            switch (cardNo)
            {
                case 11:
                    Console.WriteLine("Jack"); break;
                case 12:
                    Console.WriteLine("Queen"); break;
                case 13:
                    Console.WriteLine("King"); break;
                default:
                    Console.WriteLine("Plain Card"); break;
            }

            int daysOfMonth = 9, year = 2024;

            if (daysOfMonth == 2)
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine("29 Days");
                }
                else
                    Console.WriteLine("28 Days");
            }
            else if (daysOfMonth == 4 || daysOfMonth == 6 || daysOfMonth == 9 || daysOfMonth == 11)
            {
                Console.WriteLine("30 Days");
            }
            else
            {
                Console.WriteLine("31 Days");
            }

            switch (daysOfMonth)
            {
                case 2:
                    Console.WriteLine("28 Days"); break;
                case 4:
                case 6:
                case 9:
                case 11:   // stacking case
                    Console.WriteLine("30 Days"); break;
                default:
                    Console.WriteLine("31 Days"); break;
            }


            // A, B , AB, O
            // A and A => A , O
            // A and B => All
            // A and AB => A,B,AB
            // A and O => A, O

            // BMI
            // Yesterday,Tomorrow




        }
    }
}
