namespace Garage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage<Vehicle> g = new Garage<Vehicle>(5);


            g.SetVehicles();

            foreach (var v in g)
            {
                Console.WriteLine(v.GetPrice());
            }

            Console.WriteLine("Hello, World!");
        }
    }
}
