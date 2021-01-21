namespace Decorator.Condiments
{
    public class Whip : CondimentsDecorator
    {
        public Whip(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string Description => $"{Beverage.Description}, {nameof(Whip)}";

        public override double Cost()
        {
            return Beverage.Cost() + 0.1;
        }
    }
}