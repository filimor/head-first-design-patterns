using System;

namespace HeadFirstDesignPatterns.Behavioral.Strategy
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}