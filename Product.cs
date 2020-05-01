using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
	abstract class Product
	{
		protected int Price;
		public int Calories;
		public Product(int price)
		{
			Price = price;
		}

		public int GetPrice()
		{
			return Price;
		}

		public int GetCalo()
		{
			return Calories;
		}
		public virtual void GetDescription()
		{
			Console.WriteLine(ToString());
		}
	}
}
