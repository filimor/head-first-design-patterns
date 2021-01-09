using System;

namespace HeadFirstDesignPatterns.Behavioral.Strategy
{
    internal class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!!");
        }
    }
}