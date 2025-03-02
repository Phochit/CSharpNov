// See https://aka.ms/new-console-template for more information


// SOLID Principle

using System;

namespace Solid
{
	#region SRP
	class Freezer
	{
		void PutInTheFrig(string things)
		{
			if (Things.CheckThings("water"))
			{
				// OK
			}
			else
			{
				// Not Ok
			}
		}
	}

	class Things
	{
		public static bool CheckThings(string thing)
		{
			return true;
		}
	}
	#endregion

	#region Open_Closed Priciple(OCP)

	// it works, dont touch it

	// SDLC (SAD)
	// SRS

	//class SellPrice
	//{
	//       public decimal Price { get; set; }
	//   }

	//class PurchasePrice
	//{
	//       public decimal Price { get; set; }
	//   }

	//class Cost
	//{
	//	public decimal Price { get; set; }
	//}

	abstract class PriceType
	{
		public abstract decimal Price();
	}

	class SellPrice : PriceType
	{
		public decimal sPrice { get; set; }
		public override decimal Price()
		{
			return sPrice;
		}
	}

	class PurchasePrice : PriceType
	{
		public decimal pPrice { get; set; }
		public override decimal Price()
		{
			return pPrice;
		}
	}

	class GrandTotalCalculator
	{
		public decimal GrandTotal(PriceType[] items)
		{
			decimal tot = 0;
			foreach (var item in items)
			{
				tot += item.Price();
			}
			return tot;
		}
	}

	#endregion

	#region Liskov Substitution Priciple(LSP)

	// Birds can fly
	// Penguin

	abstract class Discout
	{
		public abstract decimal ApplyDiscount(decimal amt);

	}

	class PercentageDiscount : Discout
	{
		public decimal percentage { get; set; }

		public override decimal ApplyDiscount(decimal amt)
		{
			return amt - (amt * percentage / 100);
		}
	}

	class FixedAmountDiscount : Discout
	{
		public decimal FixedAmount { get; set; }

		public override decimal ApplyDiscount(decimal amt)
		{
			return amt - FixedAmount;
		}
	}

	#endregion

	#region Interface Segregation Priciple(ISP)

	public interface ISample
	{
		void Save();
		void Show();

		void Update();

		void Delete();

		void ShowAll();
	}

	class CallInterface : ISample
	{
		public void Delete()
		{
			throw new NotImplementedException();
		}

		public void Save()
		{
			throw new NotImplementedException();
		}

		public void Show()
		{
			throw new NotImplementedException();
		}

		public void ShowAll()
		{
			throw new NotImplementedException();
		}

		public void Update()
		{
			throw new NotImplementedException();
		}
	}

	#endregion

	#region Dependency Inversion Priciple(DIP)
	// Constructor

	public interface IOrderValidator
	{
		bool ValidateOrder(Order order);
	}

	public interface IPaymentProcessor
	{
		void ProcessPayment(decimal amount);
	}

	public interface IDiscount
	{
		decimal ApplyDiscount(Order order);
	}

	public class Order
	{
		public Item[] Items { get; set; }

	}

	public class Item
	{
		public string Name { get; set; }
		public string Description { get; set; }

		public decimal Price {  get; set; }
	}

	public class OrderProcessor
	{
		private readonly IOrderValidator orderValidator;
		private readonly IPaymentProcessor paymentProcessor;
		private readonly IDiscount discount;

		public OrderProcessor(IOrderValidator ov,IPaymentProcessor pp,IDiscount ds)
		{
			orderValidator = ov;
			paymentProcessor = pp;
			discount = ds;
		}

		public void OrderProcess(Order order)
		{
			if(orderValidator.ValidateOrder(order))
			{
				var dis=discount.ApplyDiscount(order);
				var total = order.Items.Sum(i => i.Price) - dis;
				paymentProcessor.ProcessPayment(total);
			}
		}
	}
	#endregion

	// Design Pattern(GOF)
	// Creational
	// Structural
	// Behavioral
}
