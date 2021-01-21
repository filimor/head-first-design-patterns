namespace Decorator
{
    public abstract class Beverage
    {
        public virtual string Description { get; protected set; } = "Unknown Beverage";
        public virtual BeverageSize Size { get; set; }

        public abstract double Cost();

        public override string ToString()
        {
            return $"{Description} {Size} $ {Cost():F2}";
        }
    }
}