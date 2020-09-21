using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1
{
    class Motorcycle : Vehicles
    {
        bool IsCross;
        public Motorcycle(string registrationNumber, string modelMotorcycle, int wheels, bool isCross) : base(registrationNumber, modelMotorcycle, wheels)
        {
            IsCross = isCross;
        }
        public override List<string> GetDetails(List<string> vehicleprop)
        {

            return vehicleprop;
        }

    }
}
