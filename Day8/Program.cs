using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Program
    {
        partial class PaymentForm
        {
            public int x;
            public PaymentForm()
            {
            }

            public PaymentForm(int amount)
            {
                ValidatePayment(amount);     
            }

            partial void ValidatePayment(int amount); // abstraction
        }

        partial class PaymentForm
        {
            public int y;

            partial void ValidatePayment(int amount)
            {
                if (amount > 1000)
                {
                    Console.WriteLine("Payment is valid");
                }
                else
                {
                    Console.WriteLine("Amount is too low");
                }
            }
        }

        class Asset
        {
            public string Name;

            public virtual void GetUOM()
            {
                Console.WriteLine("UOM is not defined");
            }
        }

        class Stock : Asset
        {
            public int SharesOwned;

            public override void GetUOM()
            {
                Console.WriteLine("Coins");
            }
        }

        class Cash : Asset
        {
            public decimal Dollars;
            public override void GetUOM() 
            {
                Console.WriteLine("USD");
            }
        }

        static void Show(Asset a)
        {
            Console.WriteLine(a.Name);
        }

        interface IUser
        {
            void Register();
            void Login();
        }

        class Myuser : IUser
        {
            
        }


        static void Main(string[] args)
        {
            // Partial, Inheritance

            // Mordularization

            var pf = new PaymentForm(900);

            Stock s = new Stock();
            s.Name= "BitCoin";
            s.SharesOwned = 100;
            s.GetUOM(); // Coins

            Cash c = new Cash();
            c.Name = "USD";
            c.Dollars = 1000;
            c.GetUOM(); // USD

            //Show(s);
            //Show(c);

            // Polymorphism
        }
    }
}
