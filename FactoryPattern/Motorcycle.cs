using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle :IVehicule
    {
        public Motorcycle() { }
        public void Drive()
        {
            Console.WriteLine("the motorcycle is moving");
            
        }
    }
}
