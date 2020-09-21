using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1
{
    public class VehiclesGarage
    {
        string Name;
        string Phone;
        Vehicles Vehicles;

        public VehiclesGarage(string name, string phone, Vehicles vehicle)
        {
            Name = name;
            Phone = phone;
            Vehicles = vehicle;

        }

        public string GetRegistrationNumber()
        {
            string registrationnumber = Vehicles.RegistrationNumber;
            return registrationnumber;
        }



        public List<string> User()
        {
            List<string> user = new List<string>();
            user.Add("Name:" + Name);
            user.Add("Phone:" + Phone);
            user = Vehicles.GetVehicleDetails(user);
            return user;
        }
    }
}

