using System;

namespace HeadFirstDesignPatterns.Behavioral.Strategy
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< Silence >>");
        }
    }
}