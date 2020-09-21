using System;
using System.Collections.Generic;
using System.Text;

namespace Garage1
{
    class isInside : IComparer<VehiclesGarage>
    {
        public int Compare(VehiclesGarage vehicle1, VehiclesGarage vehicle2)
        {

            if (vehicle1 == null || vehicle2 == null)
            {
                return 0;
            }
            return (vehicle1.GetRegistrationNumber()).CompareTo(vehicle2.GetRegistrationNumber());

        }
    }
}
