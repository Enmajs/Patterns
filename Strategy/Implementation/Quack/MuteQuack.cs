using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Implementation.Quack
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("......");
        }
    }
}
