using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Garage
{
    internal class Garage<T> : IEnumerable<Vehicle> where T : Vehicle
    {
        private Vehicle[] vehicles;
        //private int numOfVehiclesInGar = 0;

        public Garage(int n)
        {
            vehicles = new Vehicle[n];
        }

        public void AddCar(string regnr, string color, int numOfWheels, FuelType ft)
        {
            int i = 0;
            for(i = 0; i < vehicles.Length; i++) 
            { 
                if(vehicles[i] == null) 
                {
                    break;
                }
            }

            if (i == vehicles.Length)
            {
                Console.WriteLine("Garaget är tyvärr fullt");
            }

            else
            {
                vehicles[i] = new Car(regnr, color, numOfWheels, ft);
            }
        }

        public void RemoveVehicle(string regnr)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null)
                {
                    if (vehicles[i].GetRegnum() == regnr)
                    {
                        vehicles[i] = null;
                        break;
                    }
                }
            }
        }

        public void ShowVehicles()
        {
            for(int i = 0;i < vehicles.Length; i++)
            {
                if (vehicles[i] != null)
                {
                    Console.WriteLine(vehicles[i].GetRegnum());
                }
            }
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            return vehicles.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return vehicles.GetEnumerator();
        }
    }
}
