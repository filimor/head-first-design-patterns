using AbstractFactory.Cheeses;
using AbstractFactory.Clams;
using AbstractFactory.Doughs;
using AbstractFactory.Pepperonis;
using AbstractFactory.Sauces;
using AbstractFactory.Veggies;

namespace AbstractFactory.IngredientFactories
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThinCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public ICheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public IVeggie[] CreateVeggies()
        {
            return new IVeggie[]
            {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClam CreateClam()
        {
            return new FreshClams();
        }
    }
}