using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Vehicle : IVehicle
    {
        protected string regNumber = "";
        protected string color = "";
        protected string numOfWheels = "";

        public Vehicle(string regnr, string color, string numOfWheels)
        {
            this.regNumber = regnr;
            this.color = color;
            this.numOfWheels = numOfWheels;
        }

        public string GetRegnum() { return regNumber; }
        public string GetColor() { return color; }
        public string GetNumOfWheels() { return numOfWheels; }
    }
}

