using System;
using Strategy.FlyBehaviors;
using Strategy.QuackBehaviors;

namespace Strategy.Ducks
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            QuackBehavior = new NormalQuack();
            FlyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Red Headed duck");
        }
    }
}