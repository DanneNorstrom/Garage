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
                Console.WriteLine("2 = Lägg till ett fordon");
                Console.WriteLine("3 = Ta bort ett fordon");
                Console.WriteLine("4 = Se alla fordon i garaget");
                Console.WriteLine("5 = Se statistik om fordonen i garaget");
                Console.WriteLine("6 = Sök fordon");
                Console.WriteLine("0 = Avsluta");
                char input = Console.ReadLine()[0];

                switch (input)
                {
                    case '0':
                        quit = true;
                        break;

                    case '1':
                        Console.WriteLine("Ange antal parkeringsplatser:");
                        string inp = Console.ReadLine();
                        int plots = Convert.ToInt32(inp);

                        gh.CreateGarage(plots);
                        break;

                    case '2':
                        Console.WriteLine("1 = Lägg till en bil");
                        Console.WriteLine("2 = Lägg till en buss");
                        Console.WriteLine("3 = Lägg till en motorcykel");
                        char input2 = Console.ReadLine()[0];

                        switch (input2)
                        {
                            case '1':
                                Console.WriteLine("Ange regnummer:");
                                string regnr = Console.ReadLine().ToLower();
                                Console.WriteLine("Ange färg på bilen:");
                                string color = Console.ReadLine().ToLower();

                                gh.AddCar(regnr, color, FuelType.Diesel);
                            break;

                            case '2':
                                Console.WriteLine("Ange regnummer:");
                                string regnr2 = Console.ReadLine().ToLower();
                                Console.WriteLine("Ange färg på bussen:");
                                string color2 = Console.ReadLine().ToLower();
                                Console.WriteLine("Ange antal säten i bussen:");

                                string inp2 = Console.ReadLine();
                                int seats = Convert.ToInt32(inp2);

                                gh.AddBus(regnr2, color2, seats);
                            break;

                            case '3':
                                Console.WriteLine("Ange regnummer:");
                                string regnr4 = Console.ReadLine().ToLower();
                                Console.WriteLine("Ange färg på motorcykeln:");
                                string color4 = Console.ReadLine().ToLower();
                                Console.WriteLine("Ange cylindervolym:");
                                string cylvol = Console.ReadLine().ToLower();

                                gh.AddMotorcycle(regnr4, color4, cylvol);
                            break;

                            default:
                                break;
                        }

                        break;

                    case '3':
                        Console.WriteLine("Ange regnummer:");
                        string regnr3 = Console.ReadLine();
                        gh.RemoveVehicle(regnr3);
                        break;

                    case '4':
                        gh.ShowVehicles();
                        break;

                    case '5':
                        gh.ShowStatistics();
                        break;

                    case '6':
                        Console.WriteLine("Ange typ av fordon (Car, Bus, Motorcycle):");
                        string vtype = Console.ReadLine();
                        Console.WriteLine("Ange regnummer:");
                        string vregnr = Console.ReadLine().ToLower();
                        Console.WriteLine("Ange färg:");
                        string vcolor = Console.ReadLine().ToLower();
                        Console.WriteLine("Ange antal hjul på fordonet:");
                        string vnumofwheels = Console.ReadLine().ToLower();

                        gh.SearchGarage(vregnr, vcolor, vnumofwheels, vtype);
                    break;

                    default:
                    break;
                }
            } while (!quit);
        }
    }
}
