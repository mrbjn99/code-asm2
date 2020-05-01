using CoffeeShop.Drink;
using CoffeeShop.Food;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
    class Program
    {


        static void Main(string[] args)
        {
            Bill bill = new Bill();
  
            bill.AddProduct(new OrangeJuice());
            bill.AddProduct(new Soda());
            bill.AddProduct(new Cake());


            Console.WriteLine("Welcome to Health of bodybuilders Restaurant");
            Console.WriteLine("Enter the item name ");
 

            Console.WriteLine("Total Pice of Bill : " + bill.TotalPrice());
            Console.WriteLine("Your calories you get before use:" + bill.TotalCalo());
            Console.WriteLine(" Your item you order : {0}\n", OrangeJuice, Cake, Chicken, Soda,Sushi,Tea);


            bill.ShowDescription();
            Console.ReadLine();
        }
    }
}
