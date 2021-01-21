namespace Decorator
{
    public class Soy : CondimentsDecorator
    {
        public Soy(Beverage beverage)
        {
            Beverage = beverage;
        }

        public override string Description => $"{Beverage.Description}, {nameof(Soy)}";

        public override double Cost()
        {
            double multiplier = Size switch
            {
                BeverageSize.Tall => 0.66,
                BeverageSize.Venti => 1.33,
                _ => 1
            };

            return Beverage.Cost() + (0.15 * multiplier);
        }
    }
}