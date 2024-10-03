using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Vehicle
    {
        protected string regNumber = "";
        protected string color = "";
        protected int numOfWheels = 0;

        public Vehicle(string regnr, string color, int numOfWheels)
        {
            this.regNumber = regnr;
            this.color = color;
            this.numOfWheels = numOfWheels;
        }

        public string GetRegnum() { return regNumber; }
    }
}

