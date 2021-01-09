namespace HeadFirstDesignPatterns.Behavioral.Strategy
{
    public static class MiniDuckSimulator
    {
        private static void Main()
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            Duck model = new ModelDuck();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}