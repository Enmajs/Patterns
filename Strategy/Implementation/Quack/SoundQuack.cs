
using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Implementation.Quack
{
    public class SoundQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("quack quack.....");
        }
    }
}
