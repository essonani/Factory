using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehiculeFactory
    {
        public static IVehicule GetVehicule(int WheelCount)
        {
            switch (WheelCount)
            {
                case 4:
                    return new Car();




                case 2:
                    Motorcycle myMotorcycle = new Motorcycle();
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}
