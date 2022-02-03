using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Interfaces;
using MyLibrary.Classes.Behaviors;

namespace MyLibrary.Classes
{
    public class RubberDuck: Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }
    }
}
