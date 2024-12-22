using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Methods, Constants

            //Computer com = new Computer();
            //com.Compute();

            //Computer.Compute2();

            ////string res= com.Compute3();
            //Console.WriteLine(com.Compute3());


            Console.Write("1 : Register , 2 : Continue with Google : ");
            int ch=int.Parse(Console.ReadLine());

            if(ch==1)
            {
                User user = new User();
                Console.Write("Enter UserName : ");
                user.Name= Console.ReadLine();
                Console.Write("Enter Email : ");
                user.Email = Console.ReadLine();
                Console.Write("Enter Password : ");
                user.Password = Console.ReadLine();

                var retobj= user.Register(em:user.Email,pw:user.Password,nm:user.Name);
                if(retobj!=null)
                {
                    Console.WriteLine($"{retobj.ID} | {retobj.Name} is Created");
                }
            }
            else if(ch==2)
            {

            }

            
        }

        // AM_Optional_ReturnType_MethodName(Parameter)
    }

    class User
    {
        public string ID { get; set; } // string (char(36)) GUID
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        // 20

        // register, login
        public User Register(string nm, string em, string pw)
        {
            User u = new User();
            string id = Guid.NewGuid().ToString();
            u.ID = id;
            u.Name = nm;
            u.Email = em;
            u.Password = pw;

            return u;

        }
        public User Register(string jtoken)
        {
            return new User();
        }

        public User Register(User u) // 6
        {
            return new User();
        }

        // Readability



    }

    class Computer
    {
        public void Compute()
        {
            Console.WriteLine("Can Computing");
        }

        public static void Compute2()
        {
            Console.WriteLine("Can Computing"); // string

        }

        public string Compute3()
        {
            string output = "Can Computing";
            return output;
        }
    }
}
