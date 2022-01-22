using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Interfaces;

namespace MyLibrary
{
    public class MallardDuck: Duck, IFlyable, IQuackable
    {
        public override string Display()
        {
            return "MallardDuck " + this.GetType();
        }
        public string Fly()
        {
            return "Fly " + this.GetType();
        }
        public string Quack()
        {
            return "Quack " + this.GetType();
        }
    }
}
