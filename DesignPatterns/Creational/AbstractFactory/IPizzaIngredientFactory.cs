namespace AbstractFactory
{
    public interface IPizzaIngredientFactory
    {
        public IDough CreateDough();

        public ISauce CreateSauce();

        public ICheese CreateCheese();

        public IVeggie[] CreateVeggies();

        public IPepperoni CreatePepperoni();

        public IClam CreateClam();
    }
}