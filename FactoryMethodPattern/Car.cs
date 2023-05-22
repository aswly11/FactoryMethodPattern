using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Car : Vehicle
    {
        public override void drive()
        {
            Console.WriteLine("Driving a car");
        }
    }
}
