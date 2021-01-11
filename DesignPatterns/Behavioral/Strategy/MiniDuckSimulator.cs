namespace Strategy
{
    public static class MiniDuckSimulator
    {
        private static void Main()
        {
            Duck mallard = new MallardDuck();
            Duck rubberDuckie = new RubberDuck();
            Duck decoy = new DecoyDuck();
            Duck model = new ModelDuck();

            mallard.PerformQuack();
            rubberDuckie.PerformQuack();
            decoy.PerformQuack();
            mallard.PerformFly();

            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
        }
    }
}