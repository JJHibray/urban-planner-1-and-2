using System;
using System.Collections.Generic;

namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Noshville = new City("Noshville");

            Noshville._CityMayor = "Mayer Hawthorne";

            Building Batman = new Building("200 Commerce St.")
            {
                Width = 3200.13,
                Depth = 3469.46,
                Stories = 68
            };

            Building MyHouse = new Building("3124 Barksdale Harbor Dr.")
            {
                Width = 756.00,
                Depth = 555.25,
                Stories = 2
            };

            Building DreamHouse = new Building("12 Oceanfront Way")
            {
                Width = 3000000.15,
                Depth = 5000000.50,
                Stories = 7
            };


            Batman.Construct();
            MyHouse.Construct();
            DreamHouse.Construct();

            Batman.Purchase("Bellsouth");
            MyHouse.Purchase("Josh Hibray");
            DreamHouse.Purchase("Future Josh Hibray");


            Noshville.addProperty(Batman);
            Noshville.addProperty(MyHouse);
            Noshville.addProperty(DreamHouse);

            foreach(Building Build in Noshville.Properties){
                 {
                Console.WriteLine();
                Console.WriteLine(Build.getAddress());
                Console.WriteLine($"City: {Noshville._CityName}");
                Console.WriteLine($"City Mayor: {Noshville._CityMayor}");
                Console.WriteLine("-----");
                Console.WriteLine($"Designed by {Build.getDesigner()}");
                Console.WriteLine($"Constructed on {Build.getDate()}");
                Console.WriteLine($"Owned by {Build.getOwner()}");
                Console.WriteLine($"{Build.Volume} cubic meters of space");
                Console.WriteLine(" ");
                }

            }
        }

    }
}
