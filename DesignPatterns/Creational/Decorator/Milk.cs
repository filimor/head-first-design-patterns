namespace Decorator
{
    public class Milk : CondimentsDecorator
    {
        public Milk(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string Description => $"{Beverage.Description}, {nameof(Milk)}";

        public override double Cost()
        {
            return Beverage.Cost() + 0.1;
        }
    }
}