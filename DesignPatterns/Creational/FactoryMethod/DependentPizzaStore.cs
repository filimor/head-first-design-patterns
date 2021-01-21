using FactoryMethod.ChicagoStyle;
using FactoryMethod.NYStyle;

namespace FactoryMethod
{
    public static class DependentPizzaStore
    {
        public static Pizza CreatePizza(string style, string type)
        {
            return style switch
            {
                "NY" => type switch
                {
                    "cheese" => new NYStyleCheesePizza(),
                    "veggie" => new NYStyleVeggiePizza(),
                    "clam" => new NYStyleClamPizza(),
                    "pepperoni" => new NYStylePepperoniPizza(),
                    _ => null
                },
                "Chicago" => type switch
                {
                    "cheese" => new ChicagoStyleCheesePizza(),
                    "veggie" => new ChicagoStyleVeggiePizza(),
                    "clam" => new ChicagoStyleClamPizza(),
                    "pepperoni" => new ChicagoStylePepperoniPizza(),
                    _ => null
                },
                _ => null
            };
        }
    }
}