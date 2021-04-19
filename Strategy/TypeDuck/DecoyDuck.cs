using Strategy.Implementation.Fly;
using Strategy.Implementation.Quack;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.TypeDuck
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck() : base(new FlyNoWay(), new MuteQuack()) {}
        public override void Display()
        {
            Console.WriteLine("just a decoy duck.......");
        }
    }
}
