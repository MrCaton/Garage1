using System;
using System.Collections.Generic;
using System.Text;
using static Garage1.Color;

namespace Garage1
{
    public class IVehicle
    {
        public enum VehicleTypes
        {
            Car,
            Motorcycle,
            Plane,
            Boat,
            Bus
        }

        public Vehicles CreateVehicle(string registrationNumber, string modelCar, VehicleTypes vehicleType, ColorCars color, bool isSail, bool isInterCity, bool isCross, int nrMotors)
        {
            Vehicles newVehicle = null;
            switch (vehicleType)
            {

                case VehicleTypes.Car:
                    newVehicle = new Car(registrationNumber, modelCar, color, 0);
                    break;
                case VehicleTypes.Motorcycle:
                    newVehicle = new Motorcycle(registrationNumber, modelCar, 0, isCross);
                    break;
                case VehicleTypes.Plane:
                    newVehicle = new Plane(registrationNumber, modelCar, color, 0, nrMotors);
                    break;
                case VehicleTypes.Boat:
                    newVehicle = new Boat(registrationNumber, modelCar, color, 0, isSail);
                    break;
                case VehicleTypes.Bus:
                    newVehicle = new Bus(registrationNumber, modelCar, color, 0, isInterCity);
                    break;


            }
            return newVehicle;
        }
    }
}

