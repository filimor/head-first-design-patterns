using System;
using System.Text;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        protected Pizza(string name)
        {
            Name = name;
        }

        public string Name { get; init; }
        public IDough Dough { get; protected set; }
        public ISauce Sauce { get; protected set; }
        public IVeggie[] Veggies { get; protected set; }
        public ICheese Cheese { get; protected set; }
        public IPepperoni Pepperoni { get; protected set; }
        public IClam Clam { get; protected set; }

        public abstract void Prepare();

        public static void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public static void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public static void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append("---- ").Append(Name).Append(" ----\n");
            if (Dough != null)
            {
                result.Append(Dough).Append('\n');
            }

            if (Sauce != null)
            {
                result.Append(Sauce).Append('\n');
            }

            if (Cheese != null)
            {
                result.Append(Cheese).Append('\n');
            }

            if (Veggies != null)
            {
                result.AppendJoin<IVeggie>(", ", Veggies);
                result.Append('\n');
            }

            if (Clam != null)
            {
                result.Append(Clam).Append('\n');
            }

            if (Pepperoni != null)
            {
                result.Append(Pepperoni).Append('\n');
            }

            return result.ToString();
        }
    }
}