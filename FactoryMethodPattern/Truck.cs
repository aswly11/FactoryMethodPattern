using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    internal class Truck : Vehicle
    {
        public override void drive()
        {
            Console.WriteLine("Driving a Truck");
        }
    }
}
