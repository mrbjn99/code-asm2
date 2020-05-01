using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Food
{
    abstract class Food : Product
    {
        public Food(int price, int calories) : base(price)
        {
            Calories = calories;
        }
    }
}
