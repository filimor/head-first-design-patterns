using FactoryMethod.NYStyle;

namespace FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string name)
        {
            return name switch
            {
                "cheese" => new NYStyleCheesePizza(),
                "veggie" => new NYStyleVeggiePizza(),
                "clam" => new NYStyleClamPizza(),
                "pepperoni" => new NYStylePepperoniPizza(),
                _ => null
            };
        }
    }
}