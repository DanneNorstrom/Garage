using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Garage
{
    class Car : Vehicle
    {
        private FuelType ft;

        public Car(string regnr, string color, int numOfWheels, FuelType ft) : base(regnr, color, numOfWheels)
        {
            this.ft = ft;
        }


        /*public void SetFuelType(FuelType ft)
        {
            this.ft = ft;
        }

        public FuelType GetFuelType(FuelType ft)
        {
            return ft;
        }*/
    }

    public enum FuelType
    {
        Petrol,
        Diesel
    }
}
