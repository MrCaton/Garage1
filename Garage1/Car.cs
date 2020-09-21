using System;
using System.Collections.Generic;
using System.Text;
using static Garage1.Color;

namespace Garage1
{
    class Car : Vehicles
    {
        ColorCars Colorcar;


        public Car(string registrationNumber, string modelCar, ColorCars colorcar, int wheels) : base(registrationNumber, modelCar,  wheels)
        {
            Colorcar = colorcar;

        }
        public override List<string> GetDetails(List<string> vehicleprop)
        {
            vehicleprop.Add("Color Car:" + Colorcar.ToString());
            return vehicleprop;
        }
        public ColorCars ColorCar
        {
            set
            {
                Colorcar = value;
            }
            get
            {
                return Colorcar;
            }
        }




    }
}
