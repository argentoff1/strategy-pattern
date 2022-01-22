using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Interfaces;

namespace MyLibrary
{
    public class RubberDuck: Duck, IQuackable
    {
        public override string Display()
        {
            return "RubberDuck " + GetType();
        }
        public string Quack()
        {
            return "Quack " + this.GetType();
        }
    }
}
