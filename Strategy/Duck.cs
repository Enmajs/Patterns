using Strategy.Implementation.Fly;
using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public abstract class Duck
    {
        private readonly IFlyBehavior _flyBehavior;
        private readonly IQuackBehavior _quackBehavior;
        private FlyNoWay flyNoWay;

        protected Duck(IFlyBehavior flyBehavior, IQuackBehavior quackBehavior)
        {
            _flyBehavior = flyBehavior;
            _quackBehavior = quackBehavior;
        }

        protected Duck(FlyNoWay flyNoWay)
        {
            this.flyNoWay = flyNoWay;
        }

        public void Quack()
        {
            _quackBehavior.Quack();
        }

        public void Fly()
        {
            _flyBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("Swimming");
        }

        public abstract void Display();

    }
}
