using System;
using System.Collections.Generic;
using System.Text;

using static Garage1.Color;

namespace Garage1
{
    public abstract class Vehicles
    {
        string ModelCar;
        string Registrationnumber;
        int Wheels;

        public Vehicles(string registrationnumber, string modelCar, int wheels)
        {
            ModelCar = modelCar;
            Registrationnumber = registrationnumber;
            Wheels = wheels;
        }

        public string RegistrationNumber
        {
            get
            {
                return Registrationnumber;
            }
            set
            {
                Registrationnumber = value;
            }
        }



        public List<string> GetVehicleDetails(List<string> vehicleprop)
        {

            vehicleprop.Add("Model Name:" + ModelCar);
            vehicleprop.Add("Registration Number:" + Registrationnumber);
            vehicleprop = GetDetails(vehicleprop);
            return vehicleprop;
        }
        public abstract List<string> GetDetails(List<string> vehicleprop);
    }
}

