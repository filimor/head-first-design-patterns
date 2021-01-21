namespace Decorator.Condiments
{
    public class Mocha : CondimentsDecorator
    {
        public Mocha(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string Description => $"{Beverage.Description}, {nameof(Mocha)}";

        public override double Cost()
        {
            return Beverage.Cost() + 0.2;
        }
    }
}