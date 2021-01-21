using System;

namespace Strategy.QuackBehaviors
{
    public class FakeQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Qwak");
        }
    }
}