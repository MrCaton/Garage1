using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1
{
    class Garage
    {
        IGarage garage = new IGarage();
        IVehicle iVehicle = new IVehicle();

        public void StartMenuGarage()
        {
            string options;
            bool exit = false;

            while (!exit)
            {
                options = GarageHandler.MenuGarage();
                switch (options)
                {
                    case "1":
                        GarageHandler.Clear();
                        EnterNewVehicle();
                        break;
                    case "2":
                        GarageHandler.Clear();
                        ShowListVehicles();
                        break;
                    case "3":
                        GarageHandler.Clear();
                        VehiclesGarage();
                        break;
                    case "Q":
                        exit = true;
                        break;


                }
                GarageHandler.Clear();
            }
        }
        public void EnterNewVehicle()
        {
            bool exist = false;
            string registrationNumber = GarageHandler.GetRegNumber();
            exist = garage.HaveVehicleInGarage(registrationNumber);
            if (!exist)
            {
                AddNewVehicle(registrationNumber);
            }
           
        }
        public void AddNewVehicle(string registrationNumber)
        {
            IVehicle.VehicleTypes type = GarageHandler.GetVehicleType();
            string modelVehicle = GarageHandler.GetModelName();
            Color.ColorCars color = GarageHandler.GetColor();
            Vehicles newVehicle;
            newVehicle = iVehicle.CreateVehicle(registrationNumber, modelVehicle, type, color);
            GarageHandler.SetColor(newVehicle);
            AddNewVehicleGarage(newVehicle);
        }
        public void AddNewVehicleGarage(Vehicles vehicle)
        {
            string name = GarageHandler.GetName();
            string phoneNumber = GarageHandler.GetPhoneNumber();
            VehiclesGarage newVehicleGarage = new VehiclesGarage(name, phoneNumber, vehicle);
            garage.VehiclesGarage.Add(newVehicleGarage);
        }
        public void ShowListVehicles()
        {
            garage.VehiclesGarage = garage.VehiclesInGarages();
            GarageHandler.PrintVehicles(garage.VehiclesGarage);
            
        }
        public void VehiclesGarage()
        {
            string registrationnumber;
            List<string> vehicle = new List<string>(); ;
            registrationnumber = GarageHandler.GetRegNumber();
            vehicle = garage.GetVehicleGarageDetails(registrationnumber);
            if (vehicle != null)
            {
                GarageHandler.PrintVehicle(vehicle);
            }
            else
            {
                GarageHandler.NotHaveVehicleInGarage();
            }
        }

    }
}

