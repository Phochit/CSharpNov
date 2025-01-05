using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ Query

            // Syntax ( Fluent, Query )

            string[] countries = { "Myanmar", "Thailand", "Singapore", "Laos", "Cambodia", "Malaysia" };

            var list = countries.Where(c => c.Length > 7).ToList(); // Fluent

            var list2 = (from c in countries
                         where c.Length > 7
                         select c).ToList(); // Query

            //foreach(var c in list2)
            //{
            //    Console.WriteLine(c);
            //}

            var Nums = new int[] { 4, 3, 2, 1 };

            // Method Chaining
            var multiply = Nums.Select(n => n * 2);
            var filter = multiply.Where(n => n != 4);
            var order = filter.OrderBy(n => n);

            // Extension Method
            var onesentanc = Nums.Select(n => n * 2).Where(n => n != 4).OrderBy(n => n);

            //foreach (var n in onesentanc)
            //{
            //    Console.WriteLine(n);
            //}

            // Element
            // First,Last,Single
            var first = countries.Where(c => c.StartsWith("M")).OrderBy(c => c).First();
            var first2 = countries.OrderBy(c => c).First(c => c.StartsWith("M"));

            //Console.WriteLine(first2);

            //Console.WriteLine(new string[] { "a","z","a" }.Single(s=>s.Equals("a"))); 

            //foreach(var c in countries.Skip(3))
            //{
            //    Console.WriteLine(c);
            //}


            // SET
            // Intersect,Union,Concat,Except

            int[] fnums = new int[] { 1, 2, 3, 4 }; // 1,4
            int[] snums = new int[] { 0, 2, 3, 5 }; // 0,5

            //foreach (var res in snums.Except(fnums))
            //{
            //    Console.WriteLine(res);
            //}

            // Aggregation
            //int dec =(int) fnums.Average();
            //Console.WriteLine(fnums.Sum()); // 10
            //Console.WriteLine(dec); // 2.5
            //Console.WriteLine(fnums.Max()); // 4
            //Console.WriteLine(fnums.Min()); // 1

            // Join
            // Inner,Left,Right,Cross,Full



            var singers = new string[] { "Myo Gyi", "Ah Nge", "Lay Phyu" };
            var band = new string[] { "Iron Cross", "Myo Gyi", "Lay Phyu" };

            // Inner Join
            var result = from s in singers
                         join b in band
                         on s equals b
                         select new { s, b };

            var result2 = singers.Join(band,
                        s => s,
                        b => b,
                        (s, b) => new { s, b });

            foreach (var r in result2)
            {
                Console.WriteLine(r.s + " | " + r.b);
            }
            Console.WriteLine();

            // Left Outer Join
            var lresult = from s in singers
                          join b in band
                          on s equals b into temp
                          from t in temp.DefaultIfEmpty()
                          select new { Singer = s, Band = t };

            var lresult2 = from b in band
                           from s in singers.Where(x => x == b).DefaultIfEmpty()
                           select new { Band = b, Singer = s };

            foreach (var r in lresult2)
            {
                Console.WriteLine(r.Singer + " | " + r.Band);
            }
            Console.WriteLine();

            // Cross Join
            var cresult = from s in singers
                          from b in band
                          where s!=b
                          select s+" Vs " + b;

            foreach(var r in cresult)
            {
                Console.WriteLine(r);
            }

        }
    }
}
