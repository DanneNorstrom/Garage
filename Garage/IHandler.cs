namespace Garage
{
    internal interface IHandler 
    {
        public void CreateGarage(int numOfLots);
        //public void AddCar(string regnr, string color, FuelType ft);
        //public void AddBus(string regnr, string color, int numofseats);
        //public void AddMotorcycle(string regnr, string color, string cylvol);

        public void AddVehicle(Vehicle v);
        public void RemoveVehicle(string regnr);
        public void ShowVehicles();
        public void ShowStatistics();
        public void SearchGarage(string vregnr, string vcolor, string vnumofwheels, string vtype);
    }
}