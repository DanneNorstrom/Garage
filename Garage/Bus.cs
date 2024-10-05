using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class Bus : Vehicle
    {
        private int numOfSeats = 0;

        public Bus(string regnr, string color, int numOfSeats) : base(regnr, color, "4")
        {
            this.numOfSeats = numOfSeats;
        }

        public int GetNumOfSeats()
        {
            return numOfSeats;
        }
    }
}
