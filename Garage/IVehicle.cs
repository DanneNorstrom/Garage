using System.Drawing;
using System.Security.Cryptography;

namespace Garage
{
    internal interface IVehicle
    {
        public string GetRegnum();
        public string GetColor();
        public string GetNumOfWheels();
    }
}