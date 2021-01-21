using System;
using Strategy.FlyBehaviors;
using Strategy.QuackBehaviors;

namespace Strategy.Ducks
{
    internal class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}