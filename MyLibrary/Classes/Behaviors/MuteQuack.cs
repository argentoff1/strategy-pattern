using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Interfaces;

namespace MyLibrary.Classes.Behaviors
{
    public class MuteQuack: IQuackBehavior
    {
        public string Quack()
        {
            return "";
        }
    }
}
