using AbstractFactory.Cheeses;
using AbstractFactory.Clams;
using AbstractFactory.Doughs;
using AbstractFactory.Pepperonis;
using AbstractFactory.Sauces;
using AbstractFactory.Veggies;

namespace AbstractFactory.IngredientFactories
{
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public IDough CreateDough()
        {
            return new ThickCrustDough();
        }

        public ISauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public ICheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public IVeggie[] CreateVeggies()
        {
            return new IVeggie[]
            {
                new BlackOlives(),
                new Spinach(),
                new Eggplant()
            };
        }

        public IPepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public IClam CreateClam()
        {
            return new FrozenClams();
        }
    }
}