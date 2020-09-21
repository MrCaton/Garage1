using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1
{
    public class IGarage
    {
        public List<VehiclesGarage> VehiclesGarage = new List<VehiclesGarage>();

        public bool HaveVehicleInGarage(string registrationNumber)
        {
            bool exists = false;
            string registrationnumber;
            foreach (VehiclesGarage vehiclesGarage in VehiclesGarage)
            {
                registrationnumber = vehiclesGarage.GetRegistrationNumber();
                if (registrationnumber == registrationNumber)
                {
                    exists = true;
                    break;
                }
            }
            return exists;
        }
        public List<VehiclesGarage> VehiclesInGarages()
        {
            VehiclesGarage.Sort(new isInside());
            return VehiclesGarage;
        }


        public List<string> GetVehicleGarageDetails(string registrationNumber)
        {
            string registrationnumber;
            List<string> properties = new List<string>();
            foreach (VehiclesGarage vehiclesGarage in VehiclesGarage)
            {
                registrationnumber = vehiclesGarage.GetRegistrationNumber();
                if (registrationnumber == registrationNumber)
                {
                    properties = vehiclesGarage.User();
                    break;
                }
            }

            return properties;
        }
    }
}

