using System;
using System.Net.Cache;

namespace NewsInCsharp8
{
    class Program
    {
        class Person
        {
            public string? ID { get; set; } // not null
        }

        static void Main()
        {
            //var col = FromRainbow(Rainbow.Violet);
            //Console.WriteLine(col);

            //var add = new Address { State = "YGN" };
            //var res = ComputeCommercialTax(add, 20000);
            //Console.WriteLine(res);

            //var person = ("P001", "ITC", 18); // Tuple
            //Console.WriteLine(person.Item1);
            //Console.WriteLine(person.Item2);
            //Console.WriteLine(person.Item3);


            //(string, string, int) p1 = ("P002", "HTW", 27);

            //p1.Item2 = "ABCD";

            //Console.WriteLine(p1.Item2);

            //var p2 = (ID: "P003", Name: "KKK", Age: 25);
            //Console.WriteLine(p2.Name);

            //var (id, name, age) = GetPerson();
            //Console.WriteLine(id);
            //Console.WriteLine(name);
            //Console.WriteLine(age);

            //Console.WriteLine(CheckWinner("rock", "scissor"));

            //// Local Method
            //DisplayMember();

            // Indice and Range

            var city = new string[]
            {                       // index from start         // index from end
                "Yangon",           // 0                        // ^9
                "Mandalay",         // 1                        // ^8
                "Taungyi",          // 2                        // ^7
                "Bago",
                "Bagan",
                "Saggain",
                "Taungoo",
                "Naypyitaw",
                "Mawlamyine"
            };

            //for(int i=0;i<city.Length;i++)
            //{
            //    if(i>0 && i<4)
            //    {
            //        Console.WriteLine(city[i]);
            //    }
            //}
            var res = city[1..4]; // index from start
            

            Console.WriteLine(city[^1]); // index from end
            Console.WriteLine();
            var full = city[..];

            var first4 = city[..4];

            var startfrom6 = city[6..];

            var lastposition2 = city[^2..^0];
            
            foreach (var item in lastposition2)
            {
                Console.WriteLine(item);
            }
        }

        static void DisplayMember()
        {
            Console.WriteLine(DoubleValue(3));
            Console.WriteLine(DoubleValue(4));
            Console.WriteLine(DoubleValue(5));
            int DoubleValue(int inp) // Local method
            {
                return inp * 2;
            }
        }

        public static string CheckWinner(string f, string s)
            => (f, s) switch
            {
                ("rock","paper") => "Paper Win",
                ("rock","scissor") => "Rock Win",
                ("paper","rock")=> "Paper Win",
                ("paper","scissor") => "Scissor Win",
                ("scissor","rock")=> "Rock Win",
                ("scissor","paper")=> "Scissor Win",
                (_,_)=>"Tie"
            };

        static (string,string,int) GetPerson()
        {
            var p3 = ("P004", "ZZZ", 30);
            return p3;
        }


        public static string FromRainbow(Rainbow col) =>
            col switch
            {
                Rainbow.Red=> "Red",
                Rainbow.Orange => "Orange",
                Rainbow.Yellow => "Yellow",
                Rainbow.Indigo => "Indigo",
                Rainbow.Violet => "Violet",
                Rainbow.Green => "Green",
                Rainbow.Blue => "Blue",
                _ => "Invalid Rainbow Color"
            };

        static double ComputeCommercialTax(Address loc, double amount) =>
            loc switch
            {
                { State:"YGN"}=> amount*0.1,
                { State:"MDY"}=> amount*0.09,
                { State:"MLM"}=> amount*0.08,
                _=>amount
            };

        class Address
        {
            public string State;
        }

        public enum Rainbow
        {
            Red,
            Orange,
            Yellow,
            Indigo,
            Violet,
            Green,
            Blue,
            Black
        }
    }
}

