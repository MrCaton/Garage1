using System;
using System.Collections.Generic;
using System.Text;

using static Garage1.Color;

namespace Garage1
{
    class Plane : Vehicles
    {
        int NrMotors;


        public Plane(string registrationNumber, string modelCar, ColorCars color, int wheels, int nrMotors) : base(registrationNumber, modelCar, wheels)
        {
            NrMotors = nrMotors;
        }
        public override List<string> GetDetails(List<string> vehicleprop)
        {

            return vehicleprop;
        }
    }
}
