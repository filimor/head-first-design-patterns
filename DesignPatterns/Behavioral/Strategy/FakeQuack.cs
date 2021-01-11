using System;

namespace Strategy
{
    public class FakeQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Qwak");
        }
    }
}