using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using static Garage1.Color;


namespace Garage1
{
    class Bus : Vehicles
    {

        bool IsInterCity ;
        public Bus(string registrationNumber, string modelCar, ColorCars color, int wheels, bool isInterCity) : base(registrationNumber, modelCar, wheels)
        {
            IsInterCity = isInterCity;
        }
        public override List<string> GetDetails(List<string> vehicleprop)
        {

            return vehicleprop;
        }
    }
}
