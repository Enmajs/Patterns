using Strategy.Implementation.Fly;
using Strategy.Implementation.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.TypeDuck
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new FlyNoWay(), new Squeak()) { }

        public override void Display()
        {
            Console.WriteLine("rubber duck...........");
        }
    }
}
