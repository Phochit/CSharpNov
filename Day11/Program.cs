using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day11
{
    internal class Program
    {
        class Person
        {
            public string Name { get; set; }

            public int Age { get; set; }
        }

        class Customer
        {
            public string ID { get; set; } // Primary Key
            public string Name { get; set; }

        }

        class PurchaseHeader
        {
            public string ID { get; set; }
            public string CustomerID { get; set; } // Foreign Key

            public string Description {  get; set; }
        }

        class PurchaseDetail
        {
            public string ID { get; set; }

            public string PurchaseHeaderID { get; set; } // Foreign Key

            public string Detail { get; set; }
        }

        static void Main(string[] args)
        {
            #region Group

            List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // 135792468
            var grp = lst.GroupBy(l => l % 2 != 0);

            //foreach (var gp in grp)
            //{
            //    foreach (var item in gp)
            //    {
            //        Console.Write(item);
            //    }
            //}

            // DBA, Data Science, DevOps

            List<Person> people = new List<Person>();
            people.Add(new Person() { Name = "Mg Mg", Age = 20 });
            people.Add(new Person() { Name = "Aung Aung", Age = 20 });
            people.Add(new Person() { Name = "U Ba", Age = 45 });
            people.Add(new Person() { Name = "U Mya", Age = 46 });
            people.Add(new Person() { Name = "Aye Aye", Age = 15 });
            people.Add(new Person() { Name = "Mya Mya", Age = 15 });
            people.Add(new Person() { Name = "Kyaw Kyaw", Age = 15 });
            people.Add(new Person() { Name = "Min Min", Age = 25 });

            var query = people.GroupBy(p => p.Age);

            //foreach (var res in query)
            //{

            //    Console.WriteLine("Age : " + res.Key);
            //    Console.WriteLine("******");

            //    foreach (var item in res)
            //    {
            //        Console.WriteLine(item.Name);
            //    }

            //    Console.WriteLine();
            //}

            #endregion

            #region Joining Multiple Collections
            // [0],[1]
            var cus = new List<Customer>()
            {
                new Customer()
                {
                    ID=Guid.NewGuid().ToString(), // char(36) PK
                    Name="Ma Hla" // varchar(50)
                },
                new Customer()
                {
                    ID=Guid.NewGuid().ToString(),
                    Name="Ma Mya"
                }
            };

            var ph = new List<PurchaseHeader>()
            {
                new PurchaseHeader()
                {
                    ID = Guid.NewGuid().ToString(), // char(36) PK
                    CustomerID=cus[0].ID, // char(36) 
                    Description=cus[0].Name+" - Purchase1" // varchar(300)
                },
                new PurchaseHeader()
                {
                    ID = Guid.NewGuid().ToString(),
                    CustomerID=cus[1].ID,
                    Description=cus[1].Name+" - Purchase1"
                },
                new PurchaseHeader()
                {
                    ID = Guid.NewGuid().ToString(),
                    CustomerID=cus[0].ID,
                    Description=cus[0].Name+" - Purchase2"
                },
                new PurchaseHeader()
                {
                    ID = Guid.NewGuid().ToString(),
                    CustomerID=cus[1].ID,
                    Description=cus[1].Name+" - Purchase2"
                }
            };

            var pd = new List<PurchaseDetail>()
            {
                new PurchaseDetail()
                {
                    ID = Guid.NewGuid().ToString(), // char(6) PK
                    PurchaseHeaderID=ph[0].ID, // char(36)
                    Detail="Bread, Egg, Sugar" // varchar(300)
                },
                new PurchaseDetail()
                {
                    ID = Guid.NewGuid().ToString(),
                    PurchaseHeaderID=ph[1].ID,
                    Detail="Onion, Potato, Tomato"
                },
                new PurchaseDetail()
                {
                    ID = Guid.NewGuid().ToString(),
                    PurchaseHeaderID=ph[2].ID,
                    Detail="Noddle, Vermicile, Fish Sauge"
                },
                new PurchaseDetail()
                {
                    ID = Guid.NewGuid().ToString(),
                    PurchaseHeaderID=ph[3].ID,
                    Detail="Fish, Pork, Mutton"
                }
            };


            var result = from c in cus
                         join purH in ph on c.ID equals purH.CustomerID
                         join purD in pd on purH.ID equals purD.PurchaseHeaderID
                         select new
                         {
                             c.Name,
                             purH.Description,
                             purD.Detail
                         };

            //foreach (var res in result)
            //{
            //    Console.WriteLine($"{res.Name} | {res.Description} | {res.Detail}");
            //}

            #endregion

            #region XML with LINQ
            // Extensible Markup Language

            XDocument doc = XDocument.Load(@"C:\Users\phoch\source\repos\CSharpNov\Day11\books.xml");

            IEnumerable<XElement> emp = doc.Root.Elements();

            foreach(var e in emp)
            {
                Console.WriteLine(e.Attribute("id").Value);
                Console.WriteLine($"{e.Element("author").Value}");
            }

            #endregion
        }
    }
}
