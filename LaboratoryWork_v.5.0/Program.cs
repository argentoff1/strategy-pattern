using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
using MyLibrary.Interfaces;
using MyLibrary.Classes;

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
                Console.WriteLine(duck.Quack());
                Console.WriteLine(duck.Fly());
            }

            Console.ReadKey();
        }
    }
}