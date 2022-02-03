using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Classes;
using MyLibrary.Classes.Behaviors;

namespace MyLibrary.Classes
{
    public class DecoyDuck: Duck
    {
        public DecoyDuck()
        {
            quackBehavior = new MuteQuack();
            flyBehavior = new FlyNoWay();
        }
    }
}
