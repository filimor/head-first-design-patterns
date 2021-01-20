namespace AbstractFactory
{
    public interface IPizzaIngredientFactory
    {
        public IDough CreateDough();

        public ISauce CreateSauce();

        public ICheese CreateCheese();

        public IVeggies[] CreateVeggies();

        public IPepperoni CreatePepperoni();

        public IClam CreateClam();
    }
}