using System;
using System.Collections.Generic;
using System.Text;

using static Garage1.Color;

namespace Garage1
{
    class Boat : Vehicles
    {
        bool IsSail;

        public Boat(string registrationNumber, string modelCar, ColorCars color, int wheels,bool isSail) : base(registrationNumber, modelCar, wheels)
        {
            IsSail = isSail;
        }
        public override List<string> GetDetails(List<string> vehicleprop)
        {

            return vehicleprop;
        }
    }
}
