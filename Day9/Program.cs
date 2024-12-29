using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day9
{
    internal class Program
    {
        class Asset
        {
            public string Name;
        }

        class Stock : Asset
        {
            public int SharesOwned;
        }

        class Cash : Asset
        {
            public int Dollar;
        }

        delegate void ProgressComplete(int complete);

        delegate int Transformer(int x);

        interface ITransformer
        {
            int Transform(int x);

        }

        class SquareObject : ITransformer
        {
            public int Transform(int x)
            {
                return x * x;
            }

        }
        class Utility
        {
            public static void TransformWithInterface(int[] values,ITransformer trs)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = trs.Transform(values[i]);
                }
            }
            public static void CompletePercentage(ProgressComplete pc)
            {
                for (int i = 0; i < 11; i++)
                {
                    pc(i * 10); // invoke delegate
                    Thread.Sleep(100);
                }
            }

            // 1,2,3 => square => 1,4,9
            public static void Transform(int[] values, Transformer ts)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = ts(values[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            // Upcast, Downcast, Multi-Cast

            Stock s = new Stock();
            Asset a = s; // upcast
            s = (Stock)a; // downcast

            //Console.WriteLine(a == s);

            //ProgressComplete pc = ShowOnConsole;
            //pc += WriteOnTextFile;
            //Utility.CompletePercentage(pc);

            int[] val = {1,2,3 };
            Utility.Transform(val, Cube); // hook 
            foreach (int i in val)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            val =new int[] { 1, 2, 3 };
            Utility.Transform(val, Square); // hook 
            foreach (int i in val)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            val = new int[] { 2, 4, 6 };
            Utility.TransformWithInterface(val, new SquareObject()); // hook 
            foreach (int i in val)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // LINQ
            // Conversion(ToList(),ToDictionary(),ToArray())
            // Filtering(Where)
            // Ordering (OrderBy,OrderByDescending)
            // Joining (Join)
            // Element (First,FirstOrDefault,FirstAsync)
            // Set (Intersect,Union,Concat)
            // Aggregation (Max,Min,Avg,Count)
            // Grouping (GroupBy)
            // Projecting (Select)

            string[] countries = { "Myanmar", "Thailand", "Singapore", "Laos", "Cambodia", "Malaysia" };

            var ord = countries.Where(x=>x.ToUpper().Contains("L"));
            foreach(var cou in  ord)
            {
                Console.WriteLine(cou);
                
            }

            int i = 10;
            float f = i; // implicit cast
            i = (int)f; // explicit cast

            object obj = i; // box
            i =(int) obj; // Unbox

            // IOS => Internet Operating System
            // Cisco, Juniper, MicroTik

            // MessageBlast
            // EDM
        }

        static void ShowOnConsole(int complete)
        {
            Console.WriteLine(complete + "%");
        }

        static void WriteOnTextFile(int complete)
        {
            File.AppendAllText("DownloadComplete.txt", complete.ToString() + " %");
        }

        static int Square(int x) => x * x;

        static int Cube(int x) => x * x * x;
    }
}
