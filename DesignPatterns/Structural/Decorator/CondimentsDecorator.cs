namespace Decorator
{
    public abstract class CondimentsDecorator : Beverage
    {
        public Beverage Beverage { get; protected set; }
        public abstract override string Description { get; }
    }
}