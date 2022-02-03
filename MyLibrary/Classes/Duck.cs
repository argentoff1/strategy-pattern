using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Interfaces;

namespace MyLibrary.Classes
{
    public class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public string Swim()
        {
            return "Буль буль буль ";
        }
        public string Display()
        {
            return $"{GetType()} | {flyBehavior.GetType()} | {quackBehavior.GetType()}";
        }

        public string Quack()
        {
            return quackBehavior.Quack();
        }
        public string Fly()
        {
            return flyBehavior.Fly();
        }
        public void SetQuackBehavior(IQuackBehavior qBehavior)
        {
            quackBehavior = qBehavior;
        }
        public void SetFlyBehavior(IFlyBehavior fBehavior)
        {
            flyBehavior = fBehavior;
        }
    }
}
