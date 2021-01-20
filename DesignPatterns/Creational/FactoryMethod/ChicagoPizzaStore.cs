namespace FactoryMethod
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string name)
        {
            return name switch
            {
                "cheese" => new ChicagoStyleCheesePizza(),
                "veggie" => new ChicagoStyleVeggiePizza(),
                "clam" => new ChicagoStyleClamPizza(),
                "pepperoni" => new ChicagoStylePepperoniPizza(),
                _ => null
            };
        }
    }
}