using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Garage
{
    internal class Garage<T> : IEnumerable<Vehicle> where T : Vehicle
    {
        private Vehicle[] vehicles;
        //private int numOfVehiclesInGar = 0;

        public Garage(int n)
        {
            vehicles = new Vehicle[n];
        }

        public void AddVehicle(Vehicle v)
        {
            int i = 0;
            for (i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    break;
                }
            }

            if (i == vehicles.Length)
            {
                Console.WriteLine("Garaget är tyvärr fullt");
            }

            else
            {
                vehicles[i] = v;
                Console.WriteLine("Fordonet parkerat");
            }
        }
            
        /*public void AddCar(string regnr, string color, FuelType ft)
        {
            int i = 0;
            for(i = 0; i < vehicles.Length; i++) 
            { 
                if(vehicles[i] == null) 
                {
                    break;
                }
            }

            if (i == vehicles.Length)
            {
                Console.WriteLine("Garaget är tyvärr fullt");
            }

            else
            {
                vehicles[i] = new Car(regnr, color, ft);
                Console.WriteLine("Fordonet parkerat");
            }
        }

        public void AddBus(string regnr, string color, int numofseats)
        {
            int i = 0;
            for (i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    break;
                }
            }

            if (i == vehicles.Length)
            {
                Console.WriteLine("Garaget är tyvärr fullt");
            }

            else
            {
                vehicles[i] = new Bus(regnr, color, numofseats);
                Console.WriteLine("Fordonet parkerat");
            }
        }

        public void AddMotorcycle(string regnr, string color, string cylvol)
        {
            int i = 0;
            for (i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] == null)
                {
                    break;
                }
            }

            if (i == vehicles.Length)
            {
                Console.WriteLine("Garaget är tyvärr fullt");
            }

            else
            {
                vehicles[i] = new Motorcycle(regnr, color, cylvol);
                Console.WriteLine("Fordonet parkerat");
            }
        }*/

        public void RemoveVehicle(string regnr)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null)
                {
                    if (vehicles[i].GetRegnum() == regnr)
                    {
                        vehicles[i] = null;
                        Console.WriteLine("Fordonet uttaget");
                        break;
                    }
                }
            }
        }

        public void ShowVehicles()
        {
            for(int i = 0;i < vehicles.Length; i++)
            {
                if (vehicles[i] != null)
                {
                    Console.WriteLine(vehicles[i].GetRegnum());
                    Console.WriteLine(vehicles[i].GetType().Name);
                }
            }
        }

        public void ShowStatistics() 
        {
            int numOfCars = 0;
            int numOfBuses = 0;
            int numOfMotorcycles = 0;

            for (int i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] != null)
                {
                    if (vehicles[i].GetType().Name == "Car")
                    {
                        numOfCars++;
                    }
                    else if (vehicles[i].GetType().Name == "Bus")
                    {
                        numOfBuses++;
                    }
                    if (vehicles[i].GetType().Name == "Motorcycle")
                    {
                        numOfMotorcycles++;
                    }
                }
            }

            Console.WriteLine("Antal bilar i garaget = " + numOfCars);
            Console.WriteLine("Antal bussar i garaget = " + numOfBuses);
            Console.WriteLine("Antal motorcyclar i garaget = " + numOfMotorcycles);
        }

        public void Search(string vregnr, string vcolor, string vnumofwheels, string vtype)
        {
            foreach (var v in vehicles)
            {
                if(v != null)
                {
                    if (vregnr.Length == 0 && vcolor.Length == 0 && vnumofwheels.Length == 0 && vtype.Length != 0 && v.GetType().Name == vtype) Console.WriteLine(v.GetRegnum());

                    else if (vregnr.Length == 0 && vcolor.Length == 0 && vnumofwheels.Length != 0 && v.GetNumOfWheels() == vnumofwheels && vtype.Length == 0) Console.WriteLine(v.GetRegnum());

                    else if (vregnr.Length == 0 && vcolor.Length == 0 && vnumofwheels.Length != 0 && v.GetNumOfWheels() == vnumofwheels && vtype.Length != 0 && v.GetType().Name == vtype) Console.WriteLine(v.GetRegnum());



                    else if (vregnr.Length == 0 && vcolor.Length != 0 && v.GetColor() == vcolor && vnumofwheels.Length == 0 && vtype.Length == 0) Console.WriteLine(v.GetRegnum());

                    else if (vregnr.Length == 0 && vcolor.Length != 0 && v.GetColor() == vcolor && vnumofwheels.Length == 0 && vtype.Length != 0 && v.GetType().Name == vtype) Console.WriteLine(v.GetRegnum());

                    else if (vregnr.Length == 0 && vcolor.Length != 0 && v.GetColor() == vcolor && vnumofwheels.Length != 0 && v.GetNumOfWheels() == vnumofwheels && vtype.Length == 0) Console.WriteLine(v.GetRegnum());

                    else if (vregnr.Length == 0 && vcolor.Length != 0 && v.GetColor() == vcolor && vnumofwheels.Length != 0 && v.GetNumOfWheels() == vnumofwheels && vtype.Length != 0 && v.GetType().Name == vtype) Console.WriteLine(v.GetRegnum());



                    else if (vregnr.Length != 0 && v.GetRegnum() == vregnr && vcolor.Length == 0 && vnumofwheels.Length == 0 && vtype.Length == 0) Console.WriteLine(v.GetRegnum());

                    else if (vregnr.Length != 0 && v.GetRegnum() == vregnr && vcolor.Length == 0 && vnumofwheels.Length == 0 && vtype.Length != 0 && v.GetType().Name == vtype) Console.WriteLine(v.GetRegnum());

                    else if (vregnr.Length != 0 && v.GetRegnum() == vregnr && vcolor.Length == 0 && vnumofwheels.Length != 0 && v.GetNumOfWheels() == vnumofwheels && vtype.Length == 0) Console.WriteLine(v.GetRegnum());

                    else if (vregnr.Length != 0 && v.GetRegnum() == vregnr && vcolor.Length == 0 && vnumofwheels.Length != 0 && v.GetNumOfWheels() == vnumofwheels && vtype.Length != 0 && v.GetType().Name == vtype) Console.WriteLine(v.GetRegnum());



                    else if (vregnr.Length != 0 && v.GetRegnum() == vregnr && vcolor.Length != 0 && v.GetColor() == vcolor && vnumofwheels.Length == 0 && vtype.Length == 0) Console.WriteLine(v.GetRegnum());

                    else if (vregnr.Length != 0 && v.GetRegnum() == vregnr && vcolor.Length != 0 && v.GetColor() == vcolor && vnumofwheels.Length == 0 && vtype.Length != 0 && v.GetType().Name == vtype) Console.WriteLine(v.GetRegnum());

                    else if (vregnr.Length != 0 && v.GetRegnum() == vregnr && vcolor.Length != 0 && v.GetColor() == vcolor && vnumofwheels.Length != 0 && v.GetNumOfWheels() == vnumofwheels && vtype.Length == 0) Console.WriteLine(v.GetRegnum());
                    
                    else if (vregnr.Length != 0 && v.GetRegnum() == vregnr && vcolor.Length != 0 && v.GetColor() == vcolor && vnumofwheels.Length != 0 && v.GetNumOfWheels() == vnumofwheels && vtype.Length != 0 && v.GetType().Name == vtype) Console.WriteLine(v.GetRegnum());
                }
            }
        }


        public IEnumerator<Vehicle> GetEnumerator()
        {
            return vehicles.AsEnumerable().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return vehicles.GetEnumerator();
        }
    }
}
