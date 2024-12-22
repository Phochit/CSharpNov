using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Program // Ref
    {
        static void Main(string[] args)
        {
            #region Collections
            // Dictionary (Key, Value)

            Dictionary<int, string> month = new Dictionary<int, string>();
            month.Add(1, "January");
            month.Add(2, "February");
            month.Add(3, "March");

            foreach (var res in month)
            {
                Console.WriteLine($"{res.Key} = {res.Value}");
            }

            Dictionary<string, string> currency = new Dictionary<string, string>();
            currency.Add("MMK", "Myanmar Kyat");

            // order, order comfirmed, deliver, order finished

            // status=""

            // List
            List<string> Singers = new List<string>();
            Singers.Add("Doe Lone");
            Singers.Add("El Phyu");
            Singers.Add("Lin Lin");
            Singers.Insert(0, "Lay Phyu");

            // HashSet 
            HashSet<char> val = new HashSet<char>("Yangon International Airport");
            foreach (char c in val)
            {
                Console.Write(c);
            }

            Console.WriteLine();
            // LinkedList ( head, tail )
            // Music Note - Do,Re,Mi,Fa,So,La,Ti
            // Meter Bill - 10000 - 10200 - 10500
            // Pagination

            LinkedList<string> notes = new LinkedList<string>();
            notes.AddLast("Do");
            notes.AddLast("So");
            notes.AddBefore(notes.Last, "Re");
            notes.AddBefore(notes.First.Next.Next, "Mi");

            foreach (var res in notes)
            {
                Console.WriteLine(res);
            }

            // Sorted Dictionay,SortedSet

            SortedSet<string> days = new SortedSet<string>();
            days.Add("Sunday");
            days.Add("Monday");
            days.Add("Tuesday");
            days.Add("Wednesday");
            days.Add("Thursday");
            days.Add("Friday");
            days.Add("Saturday");
            foreach (var res in days)
            {
                Console.WriteLine(res);
            }
            #endregion

            // Class
            // AM (public,internal,private,protected)
            // Method(Function)

            Car ca= new Car();
            ca.BrandName = "Toyota";
            ca.ShowBrandName();

            Car2 c2=new Car2 ();
            c2.Name = "GMC";

            Date2 dt;
            dt.Hour = 32;
            dt.Min = 40;
            dt.Sec = 50;
            dt.ShowTimeTaken();

            Array a = Array.CreateInstance(typeof(string), 5);
            a.SetValue("Myanmar", 4);

            // Rank
        }

        static void showArray(Array a)
        {
            Console.WriteLine(a.Rank);

            int[] indexer= new int[a.Rank];
        }
    }

    // Context -> Content
    struct Car2
    {
        public string Name;

        public Car2(string s)
        {
            this.Name = s;
        }
    }

    public class Date1
    {
         int Day;
         int Month;
         int Year;
    }

    struct Date2
    {
        public int Hour;
        public int Min;
        public int Sec;

        public void ShowTimeTaken()
        {
            Hour = 32;
            Min = 15;
            Sec = 40;
            string tt = $"{Hour}:{Min}:{Sec}";
            Console.WriteLine(tt);
        }
    }

    public class Car
    {
        public Car()
        {

        }
        // Property, Field

        string _brandName = "Mercedez"; // private backing field
        public string BrandName
        {
            get { return _brandName; }
            set { _brandName = value; }
        }

        string Model { get; set; } // private property

        // Model ( MVC )
        public string Color { get; set; } // public property (Automatic Property)

        // Waterfall, V, Spiral, Agile
        // CI-CD

        public void ShowBrandName()
        {
            Console.WriteLine(_brandName);
        }

        // Color

        // A=B
        // B=C
        // A C
    }
}
