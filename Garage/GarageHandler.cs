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
        public void AddCar(string regnr, string color, FuelType ft)
        {
            g.AddCar(regnr, color, ft);
        }

        public void AddBus(string regnr, string color, int numofseats)
        {
            g.AddBus(regnr, color, numofseats);
        }

        public void AddMotorcycle(string regnr, string color, string cylvol)
        {
            g.AddMotorcycle(regnr, color, cylvol);
        }

        public void RemoveVehicle(string regnr)
        {
            g.RemoveVehicle(regnr);
        }

        public void ShowVehicles()
        {
            g.ShowVehicles();
        }

        public void ShowStatistics() 
        {
            g.ShowStatistics();
        }

        public void SearchGarage(string vregnr, string vcolor, string vnumofwheels, string vtype)
        {
            g.Search(vregnr, vcolor, vnumofwheels, vtype);
        }
    }
}
