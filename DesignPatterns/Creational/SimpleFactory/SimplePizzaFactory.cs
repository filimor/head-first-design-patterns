namespace SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            return type switch
            {
                "cheese" => new CheesePizza(),
                "pepperoni" => new PepperoniPizza(),
                "clam" => new ClamPizza(),
                "veggie" => new VeggiePizza()
            };
        }
    }
}