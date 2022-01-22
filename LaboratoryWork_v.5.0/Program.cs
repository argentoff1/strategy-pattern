using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
using MyLibrary.Interfaces;

namespace LaboratoryWork_v._5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            RedheadDuck redheadDuck = new RedheadDuck();
            MallardDuck mallardDuck = new MallardDuck();
            RubberDuck rubberDuck = new RubberDuck();
            DecoyDuck decoyDuck = new DecoyDuck();

            Duck[] ducks = { redheadDuck, mallardDuck, decoyDuck, rubberDuck };

            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Display());
                Console.WriteLine(duck.Swim());

                if (duck is IQuackable)
                {
                    Console.WriteLine((duck as IQuackable).Quack());
                }
                if (duck is IFlyable)
                {
                    Console.WriteLine((duck as IFlyable).Fly());
                }
            }

            Console.ReadKey();
        }
    }
}
