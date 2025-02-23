using Day15.Controller;
using Day15.Model;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // UI(View), Model, Controller
            Console.Write("1: Insert\n2: Update\n3: Delete\n4: SelectAll\n5: SelectByID\n");
            Console.Write("Enter Number : ");
            int ch=int.Parse(Console.ReadLine());

            switch(ch)
            {
                case 1:
                    Tbl_Customer cus = new Tbl_Customer();
                    Console.Write("Enter Name : ");
                    cus.Name = Console.ReadLine();
                    cus.ID = Guid.NewGuid().ToString();
                    CustomerController cc = new CustomerController();
                    var obj = cc.InsertCustomerByStoreProcedure(cus);
                    if (obj != null)
                    {
                        Console.WriteLine($"{obj.Name} is insert successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Failed! Try Again.");
                    }
                    break;
                case 2:
                    Console.Write("Enter ID : ");
                    string id=Console.ReadLine();
                    Console.Write("Enter Name : ");
                    string nm=Console.ReadLine();
                    CustomerController cc1=new CustomerController ();
                    cc1.UpdateCustomerByID(id,nm);

                    break;
                case 3:
                    Console.Write("Enter ID : ");
                    string cid = Console.ReadLine();
                    CustomerController cc2 = new CustomerController();
                    cc2.DeleteCustomerByID(cid);
                    break;
                case 4:
                    
                    CustomerController cc3 = new CustomerController();
                    foreach(var res in cc3.SelectAllCustomer())
                    {
                        Console.WriteLine($"{res.ID} | {res.Name}");
                    }

                    break;
                case 5:
                    Console.Write("Enter ID : ");
                    string cuid = Console.ReadLine();
                    CustomerController cc4 = new CustomerController();
                    var mycus=cc4.SelectCustomerByID(cuid);
                    Console.WriteLine($"{mycus.ID} | {mycus.Name}");
                    break;
            }
        }
    }
}
