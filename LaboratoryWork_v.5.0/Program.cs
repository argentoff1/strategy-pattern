using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace LaboratoryWork_v._5._0
{
    class Program
    {
        static void Main(string[] args)
        {
            RedheadDuck redheadDuck = new RedheadDuck();
            MallardDuck mallardDuck = new MallardDuck();

            Duck[] ducks = { redheadDuck, mallardDuck };

            foreach (Duck q in ducks)
            {
                Console.WriteLine(q.Display());
                Console.WriteLine(q.Quack());
                Console.WriteLine(q.Swim());
            }

            Console.ReadKey();
        }
    }
}
