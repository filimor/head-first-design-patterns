using System;

namespace SimpleFactory
{
    public static class PizzaTestDrive
    {
        private static void Main()
        {
            var factory = new SimplePizzaFactory();
            var store = new PizzaStore(factory);

            var pizza = store.OrderPizza("cheese");
            Console.WriteLine($"We ordered a {pizza.Name}");
            Console.WriteLine(pizza);

            pizza = store.OrderPizza("veggie");
            Console.WriteLine($"We ordered a {pizza.Name}");
            Console.WriteLine(pizza);
        }
    }
}