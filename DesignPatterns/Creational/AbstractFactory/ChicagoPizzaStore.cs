using AbstractFactory.Flavors;
using AbstractFactory.IngredientFactories;

namespace AbstractFactory
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            return item switch
            {
                "cheese" => new CheesePizza("Chicago Style Cheese Pizza", ingredientFactory),
                "veggie" => new VeggiePizza("Chicago Style Veggie Pizza", ingredientFactory),
                "clam" => new ClamPizza("Chicago Style Clam Pizza", ingredientFactory),
                "pepperoni" => new PepperoniPizza("Chicago Style Pepperoni Pizza", ingredientFactory),
                _ => null
            };
        }
    }
}