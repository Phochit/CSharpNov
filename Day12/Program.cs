using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    internal class Program
    {


        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public int id { get; set; }
            public string name { get; set; }
            public string company { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public string address { get; set; }
            public string zip { get; set; }
            public string state { get; set; }
            public string country { get; set; }
            public string phone { get; set; }
            public string photo { get; set; }
        }

        class Student
        {
            public int id { get; set; }

            public string name { get; set; }
            public string gender { get; set; }
            public string[] subjects { get; set; }
        }

        class Movie
        {
            public int id { get; set; }
            public string title {  get; set; }
            public string year { get; set; }
            public string genre { get; set; }

            public string director { get; set; }
        }

        static string GetJsonOutput()
        {
            List<Movie> movies = new List<Movie>();
            movies.AddRange(new Movie[] {

            new Movie{
            id= 1,
            title="Titanic",
            year="1997",
            genre="Romance",
            director="James Cameron"
            },

            new Movie {
            id = 2,
            title = "Inception",
            year = "2010",
            genre = "Sci-Fi",
            director = "Cristopher Nolan"
            },

            new Movie
            {
                id = 3,
                title = "Forest Gump",
                year = "2015",
                genre = "Documentary",
                director = "Cristopher Nolan"
            }

            });

            return JsonConvert.SerializeObject(movies);
        }

        static async Task Main(string[] args)
        {
            // LINQ to JSON
            #region JSON

            // Concept 
            // Serialize ( To JSON )
            // Deserialize ( From JSON )

            // Newtonsoft (Library)

            // Format
            // { key:value }

            // { "id":25,"name":"ABC", "gender":"Male","subjects":["Myanmar","English","Maths"] }

            

            //var jsonfile = File.ReadAllText("C:\\Users\\phoch\\source\\repos\\CSharpNov\\Day12\\StudentDataSource.json");

            //var stu = JsonConvert.DeserializeObject<List<Student>>(jsonfile);
            
            //foreach (var r in stu)
            //{
            //    Console.WriteLine($"{r.id} | {r.name} | {r.gender} " +
            //        $"| {r.subjects[0]},{r.subjects[1]},{r.subjects[2]}");
            //}

            var mov=JsonConvert.DeserializeObject<List<Movie>>(GetJsonOutput());

            //foreach(var r in mov)
            //{
            //    Console.WriteLine($"{r.id} - {r.title} - {r.year} - {r.genre} - {r.director}");
            //}

            #endregion

            // Exception Handling
            // User, Developer

            // Try,Catch,Finally,Throw

            Divide(12); // undefined

            Greeting(null);

            int? i = null;

            string s = null;
        }

        static void Greeting(string name)
        {
            
            try
            {
                if (string.IsNullOrEmpty(name))
                {
                    throw new ArgumentNullException("name");
                }
                else if(name=="a")
                {

                }
                Console.WriteLine("Hello " + name);
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Empty name");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            // CQRS
            // Q

            // UserInterface

            // Standardization

            // JWT, OAuth, API-KEY(U/SSID)

            // Telecom API, KBZ
        }

        static void Divide(int val)
        {
            try
            {
                double res = 100 / val;
                Console.WriteLine(res);

                Console.Write("Enter a number : ");
                int num=int.Parse(Console.ReadLine());

                Student student = new Student();
                student.id = num;
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Cannot divided by zero.");
            }
            catch(FormatException)
            {
                Console.WriteLine("Use number");
            }
            catch(OverflowException)
            {
                Console.WriteLine("number is too high or too low");
            }
            
            catch(Exception) // last defender
            {
                Console.WriteLine("Cannot divided by zero.");
            }
            finally
            {
                // Clean up , Reset

                new Student(); // 
            }
        }
    }
}
