using Strategy.Implementation.Fly;
using Strategy.Implementation.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.TypeDuck
{
    public class MallardDuck : Duck
    {

        public MallardDuck() : base(new FlyWithWings(), new SoundQuack()) { }
        public override void Display()
        {
            Console.WriteLine("real duck");
        }
    }
}
