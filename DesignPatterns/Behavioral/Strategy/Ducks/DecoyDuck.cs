using System;
using Strategy.FlyBehaviors;
using Strategy.QuackBehaviors;

namespace Strategy.Ducks
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            QuackBehavior = new MuteQuack();
            FlyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a duck Decoy");
        }
    }
}