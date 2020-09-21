using System;
using System.Collections.Generic;
using System.Reflection;

namespace Garage1
{
    class GarageHandler
    {
        public static string MenuGarage()
        {
            string options;
            Console.WriteLine("Select a number from the options.");
            Console.WriteLine("1.Enter vehicles.");
            Console.WriteLine("2. List of vehicle in the garage.");
            Console.WriteLine("3. Properties vehicles");
            Console.WriteLine("Q exit");
            options = Console.ReadLine();
            return options;
        }
        public static void PrintVehicles(List<VehiclesGarage> vehicles)
        {
            foreach (VehiclesGarage vehiclesGarage in vehicles)
            {
                Console.WriteLine(string.Format("Registration number: {0}", vehiclesGarage.GetRegistrationNumber()));

            }
        }
        
        public static string GetRegNumber()
        {
            string registrationNumber;
            Console.WriteLine("Enter registration number.");
            registrationNumber = Console.ReadLine();
            return registrationNumber;
        }
        public static Color.ColorCars GetColor()
        {
            string color;
            int options = 0;
            Color.ColorCars vehicleColor;
            int length = Enum.GetNames(typeof(Color.ColorCars)).Length;
            Console.WriteLine("Enter your vehicle.");
            foreach (string enumName in Enum.GetNames(typeof(Color.ColorCars)))
            {
                Console.WriteLine(string.Format("{0} = {1}", enumName, options));
                options++;
            }
            while (true)
            {
                try
                {
                    color = Console.ReadLine();
                    vehicleColor = (Color.ColorCars)Enum.Parse(typeof(Color.ColorCars), color);
                    if ((int)vehicleColor > length - 1 || (int)vehicleColor < 0)
                    {
                        Console.WriteLine("Invalid data.");
                    }
                    else
                    {
                        return vehicleColor;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid data.");
                }

            }
        }
        public static void SetColor(Vehicles vehiclecolor)
        {
            Color.ColorCars color;
            Type vehicleType = vehiclecolor.GetType();
            PropertyInfo colorPropertyInfo = vehicleType.GetProperty("ColorCar");
            if (colorPropertyInfo != null)
            {
                color = GarageHandler.GetColor();
                colorPropertyInfo.SetValue(vehiclecolor, color, null);
            }
        }



        public static void NotHaveVehicleInGarage()
        {
            Console.WriteLine("The vehicle is not in the garage");

        }
       
        public static IVehicle.VehicleTypes GetVehicleType()
        {
            string type;
            int options = 0;
            IVehicle.VehicleTypes vehicleType;
            int length = Enum.GetNames(typeof(IVehicle.VehicleTypes)).Length;
            Console.WriteLine("Enter your vehicle type.");
            foreach (string enumName in Enum.GetNames(typeof(IVehicle.VehicleTypes)))
            {
                Console.WriteLine(string.Format("{0} = {1}", enumName, options));
                options++;
            }
            while (true)
            {

                try
                {
                    type = Console.ReadLine();
                    vehicleType = (IVehicle.VehicleTypes)Enum.Parse(typeof(IVehicle.VehicleTypes), type);
                    if ((int)vehicleType > length - 1 || (int)vehicleType < 0)
                    {
                        Console.WriteLine("Invalid data.");
                    }
                    else
                    {
                        return vehicleType;
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid data.");
                }
            }
        }
        public static string GetModelName()
        {
            string modelName;
            Console.WriteLine("Enter the model of the vehicle.");
            modelName = Console.ReadLine();
            return modelName;
        }

        public static string GetName()
        {
            string name;
            Console.WriteLine("Enter your name.");
            name = Console.ReadLine();
            return name;
        }
        public static string GetPhoneNumber()
        {
            string phoneNumber;
            Console.WriteLine("Enter your phone.");
            phoneNumber = Console.ReadLine();
            return phoneNumber;
        }
        public static void PrintVehicle(List<string> propVehicle)
        {
            Console.WriteLine("The vehicle:");
            foreach (string properties in propVehicle)
            {
                Console.WriteLine(properties);
            }
        }
       
        public static void Clear()
        {
            Console.Clear();
        }

    }
}
