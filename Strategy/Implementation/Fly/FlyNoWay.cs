using Strategy.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Implementation.Fly
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
