using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day7
{
    internal class Program
    {
        class userProfile : user
        {
            //~userProfile()
            //{
            //    Console.WriteLine("Object is destroyed");
            //    // Clean up code
            //}
        }

        struct userStruct
        {
            public string ID;
            public string Name;
            public string Role;
            public string AppName;
            string myVar;

            public userStruct(string id)
            {
                ID = id;
                Name = "Default";
                Role = "User";
                AppName = "AAA001";
                myVar = "MyVar";
            }
        }
        class user
        {
            public user() : this("Default") // default constructor (Method)
            {

            }

            public user(string dn)
            {
                ID = "00001";
                Name = dn; // Default
                Role = "User";
                AppName = "AAA001";
            }

            public user(string id, string name, string role, string appname) // method
            {
                ID = id;
                Name = name;
                Role = role;
                AppName = appname;
            }

            ~user() // finalizer
            {
                Console.WriteLine("Object is destroyed");
                // Clean up code
            }

            public string ID { get; set; }

            public string Name { get; set; }

            public string Role { get; set; }

            public string AppName { get; set; }
        }


        delegate void ShowMessage(string nm);
        static void Main(string[] args)
        {
            #region Constants, Constructors, Finalizer
            // Constants, Constructors, Finalizer

            // ITC00123
            // Roles
            //user u = new user();
            //u.ID = "ITC00123";
            //u.Name = "John Doe";
            //u.Role = "Manager";
            //u.AppName = CommonConstants.APP_NAME;


            //user u2=new user() 
            //{ 
            //    AppName = CommonConstants.APP_NAME, 
            //    ID = "ITC00124", 
            //    Name = "Jane Doe", 
            //    Role = "Admin" 
            //};

            //user u3 = new user("ABC123", "KKK", "ADMIN", "ITC");

            //user user = new user();
            //Console.WriteLine($"{user.Name} | {user.ID}");

            //userProfile up = new userProfile();

            //userStruct userStruct = new userStruct();




            #endregion

            // Lamda Expression
            // Arrow Function
            // =>

            // Delegate

            // Interface


            ShowMessage sm = ShowName;
            sm("Japan");

            ShowMessage sm2 = new ShowMessage(ShowName);
            sm2.Invoke("USA");

            Func<string, string> getString = x => "Welcome to " + x;
            Console.WriteLine(getString("Canada"));

            Func<int> getInt = () => 100;
            Console.WriteLine(getInt());

            Func<string,string,int> getStringLength= (s1,s2) => s1.Length + s2.Length;
            Console.WriteLine(getStringLength("United", "States"));

            
        }

        // ref, out
        static void ShowName(string nm)
        {
            Console.WriteLine($"Welcome to {nm}");
        }

        List<string> getNames()
        {
            return new List<string>();
        }
    }
}
