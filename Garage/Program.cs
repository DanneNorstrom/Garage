namespace Garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GarageHandler gh = new GarageHandler();


            UI appUI = new UI();
            appUI.Menu(ref gh);

            /*Garage<Vehicle> g = new Garage<Vehicle>(5);

            g.SetVehicles();

            Car c1 = new Car();
            c1.SetFuelType(FuelType.Petrol);

            foreach (var v in g)
            {
                Console.WriteLine(v.GetColor());
            }

            Console.WriteLine("Hello, World!");*/
        }
    }
}
