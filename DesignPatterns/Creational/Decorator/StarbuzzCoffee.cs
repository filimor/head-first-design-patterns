using System;

namespace Decorator
{
    public static class StarbuzzCoffee
    {
        public static void Main()
        {
            Beverage beverage = new Expresso();
            Console.WriteLine(beverage.ToString());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.ToString());

            Beverage beverage3 = new HouseBlend
            {
                Size = BeverageSize.Venti
            };
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.ToString());
        }
    }
}