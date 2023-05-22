using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class VehicleFactory : IVehicleFactory
    {
        public Vehicle CreateVehicle(string type)
        {
            switch (type)
            {
                case "Car":
                    return new Car();

                case "Truck":
                    return new Truck();
                default:
                    return null;
            }
        }
    }
}
