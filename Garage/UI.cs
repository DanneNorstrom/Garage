using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Garage
{
    internal class UI
    {
        public void Menu(ref GarageHandler gh)
        {
            bool quit = false;

            do
            {
                Console.WriteLine("1 = Skapa ett nytt garage");
                Console.WriteLine("2 = Lägg till en bil");
                Console.WriteLine("3 = Ta bort ett fordon");
                Console.WriteLine("4 = se alla fordon i garaget");
                Console.WriteLine("0 = Avsluta");
                char input = Console.ReadLine()[0];

                switch (input)
                {
                    case '0': 
                        quit = true;
                    break;

                    case '1':
                        Console.WriteLine("Ange antal parkeringsplatser: ");
                        string inp = Console.ReadLine();
                        int plots = Convert.ToInt32(inp);

                        //GarageHandler gh = new GarageHandler();
                        gh.CreateGarage(plots);
                    break;

                    case '2':
                        Console.WriteLine("Ange regnummer:");
                        string regnr = Console.ReadLine();
                        Console.WriteLine("Ange färg på bilen:");
                        string color = Console.ReadLine();

                        gh.AddCar(regnr, color, 4, FuelType.Diesel);
                    break;

                    case '3':
                        Console.WriteLine("Ange regnummer:");
                        string regnr2 = Console.ReadLine();
                        gh.RemoveVehicle(regnr2);
                    break;

                    case '4':
                        gh.ShowVehicles();
                    break;

                    default:
                    break;
                }


            } while (!quit);
        }
    }
}
