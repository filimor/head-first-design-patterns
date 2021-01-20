using AbstractFactory.Flavors;
using AbstractFactory.IngredientFactories;

namespace AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

            return item switch
            {
                "cheese" => new CheesePizza("New York Style Cheese Pizza", ingredientFactory),
                "veggie" => new VeggiePizza("New York Style Veggie Pizza", ingredientFactory),
                "clam" => new ClamPizza("New York Style Clam Pizza", ingredientFactory),
                "pepperoni" => new PepperoniPizza("New York Style Pepperoni Pizza", ingredientFactory),
                _ => null
            };
        }
    }
}