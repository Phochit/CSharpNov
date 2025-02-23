// See https://aka.ms/new-console-template for more information


// Primary Constructor
using System;
namespace cs12
{
    class Program
    {
        
        class Person(string fn, string ln)
        {
            public void Print()
            {
                Console.WriteLine(fn + " " + ln);
            }
        }

        static void Main()
        {
            Person p = new Person("Cristiano","Ronaldo");
            p.Print();
        }
    }
}

