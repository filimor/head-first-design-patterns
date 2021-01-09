using System;

namespace HeadFirstDesignPatterns.Behavioral.Strategy
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly...");
        }
    }
}