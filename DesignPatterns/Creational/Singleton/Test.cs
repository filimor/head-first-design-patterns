using System;

namespace Singleton
{
    public static class Test
    {
        private static void Main()
        {
            var chocolateBoiler1 = ChocolateBoiler.GetInstance;
            var chocolateBoiler2 = ChocolateBoiler.GetInstance;

            Console.WriteLine(chocolateBoiler1.GetHashCode());
            Console.WriteLine(chocolateBoiler2.GetHashCode());
        }
    }
}