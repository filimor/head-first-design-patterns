using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    public abstract class Pizza
    {
        protected Pizza()
        {
            Toppings = new List<string>();
        }

        public string Name { get; protected set; }
        public string Dough { get; protected set; }
        public string Sauce { get; protected set; }
        public List<string> Toppings { get; protected set; }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
        }

        public void Bake()
        {
            Console.WriteLine($"Baking {Name}");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting {Name}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing {Name}");
        }

        public override string ToString()
        {
            var displayName = new StringBuilder();
            displayName.Append("---- ").Append(Name).Append(" ----\n");
            displayName.Append(Dough).Append('\n');
            displayName.Append(Sauce).Append('\n');
            foreach (string topping in Toppings)
            {
                displayName.Append(topping).Append('\n');
            }

            return displayName.ToString();
        }
    }
}