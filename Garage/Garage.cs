using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Garage<T> : IEnumerable<Vehicle> where T : Vehicle
    {
        private Vehicle[] vehicles;

        public Garage(int n)
        {
            vehicles = new Vehicle[n];
        }

        public void SetVehicles()
        {

            vehicles[0] = new Vehicle();
            vehicles[0].Setprice(10000);
            vehicles[1] = new Vehicle();
            vehicles[1].Setprice(25000);
            vehicles[2] = new Vehicle();
            vehicles[2].Setprice(7000);
            vehicles[3] = new Vehicle();
            vehicles[3].Setprice(50000);
            vehicles[4] = new Vehicle();
            vehicles[4].Setprice(35000);

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
