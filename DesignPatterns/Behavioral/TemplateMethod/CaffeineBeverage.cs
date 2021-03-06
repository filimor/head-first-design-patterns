﻿using System;

namespace TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public abstract void Brew();

        public abstract void AddCondiments();
    }
}