using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Motorcycle : Vehicle
    {
        private string cylinderVolume = "";

        public Motorcycle(string regnr, string color, string cylinderVol) : base(regnr, color, "2")
        {
            cylinderVolume = cylinderVol;
        }
        public string GetCylinderVol()
        {
            return cylinderVolume;
        }
    }
}
