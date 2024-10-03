using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class GarageHandler
    {
        Garage<Vehicle> g;

        public void CreateGarage(int numOfLots)
        {
            g = new Garage<Vehicle>(numOfLots);
        }

        public void AddCar(string regnr, string color, int numOfWheels, FuelType ft)
        {
            g.AddCar(regnr, color, numOfWheels, ft);
        }

        public void RemoveVehicle(string regnr)
        {
            g.RemoveVehicle(regnr);
        }

        public void ShowVehicles()
        {
            g.ShowVehicles();
        }
    }
}
