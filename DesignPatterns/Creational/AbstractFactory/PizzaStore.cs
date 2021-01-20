using System;

namespace AbstractFactory
{
    public abstract class PizzaStore
    {
        protected abstract Pizza CreatePizza(string item);

        public Pizza OrderPizza(string type)
        {
            var pizza = CreatePizza(type);

            Console.WriteLine($"--- Making a {pizza.Name} ---");
            pizza.Prepare();
            Pizza.Bake();
            Pizza.Cut();
            Pizza.Box();

            return pizza;
        }
    }
}