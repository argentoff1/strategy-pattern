using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Classes.Behaviors;

namespace MyLibrary.Classes
{
    public class MallardDuck: Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new DQuack();
        }
    }
}
