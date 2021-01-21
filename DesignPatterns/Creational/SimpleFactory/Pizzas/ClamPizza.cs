namespace SimpleFactory.Pizzas
{
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            Name = "Clam Pizza";
            Dough = "Thin Crust";
            Sauce = "White Garlic Sauce";
            Toppings.Add("Clams");
            Toppings.Add("Grated Parmesan Cheese");
        }
    }
}