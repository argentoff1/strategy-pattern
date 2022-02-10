using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
using MyLibrary.Interfaces;
using MyLibrary.Classes;
using MyLibrary.Classes.Behaviors;

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

            IQuackBehavior dQuack = new DQuack();
            IQuackBehavior muteQuack = new MuteQuack();
            IQuackBehavior squeak = new Squeak();

            IFlyBehavior flyNoWay = new FlyNoWay();
            IFlyBehavior flyWithWings = new FlyWithWings();

            redheadDuck.SetFlyBehavior(flyWithWings);
            redheadDuck.SetQuackBehavior(dQuack);

            mallardDuck.SetFlyBehavior(flyWithWings);
            mallardDuck.SetQuackBehavior(dQuack);

            rubberDuck.SetFlyBehavior(flyNoWay);
            rubberDuck.SetQuackBehavior(squeak);

            decoyDuck.SetFlyBehavior(flyNoWay);
            decoyDuck.SetQuackBehavior(muteQuack);

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