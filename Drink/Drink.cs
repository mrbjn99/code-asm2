using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Drink
{
    abstract class Drink :  Product
    {
        public Drink(int price, int calories) : base(price)
        {
            Calories = calories;
        }
    }
}
