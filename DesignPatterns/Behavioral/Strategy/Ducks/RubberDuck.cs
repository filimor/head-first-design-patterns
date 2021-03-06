﻿using System;
using Strategy.FlyBehaviors;
using Strategy.QuackBehaviors;

namespace Strategy.Ducks
{
    internal class RubberDuck : Duck
    {
        public RubberDuck()
        {
            QuackBehavior = new NormalQuack();
            FlyBehavior = new FlyNoWay();
        }

        public RubberDuck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            FlyBehavior = flyBehavior;
            QuackBehavior = quackBehavior;
        }

        public override void Display()
        {
            Console.WriteLine("I'm a rubber duckie");
        }
    }
}