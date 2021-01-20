using System;

namespace FactoryMethod
{
    public abstract class PizzaStore
    {
        public abstract Pizza CreatePizza(string name);

        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);
            Console.WriteLine($"--- Making a {pizza.Name} ---");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
    }
}