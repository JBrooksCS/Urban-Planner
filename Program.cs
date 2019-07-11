using System;
using System.Collections.Generic;
using System.Globalization;

namespace Urban_Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create several buildings in the Main() method of Program.cs.
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            Building StoneFox = new Building("111 81st Avenue");
            Building Mickeys = new Building("500 4th St");

            // Give each building a width, height, and number of stories.
            FiveOneTwoEigth.Width = 500;
            FiveOneTwoEigth.Stories = 10;
            FiveOneTwoEigth.Depth = 200;

            StoneFox.Width = 100;
            StoneFox.Stories = 1;
            StoneFox.Depth = 500;

            Mickeys.Width = 50;
            Mickeys.Stories = 1;
            Mickeys.Depth = 500;
            // Construct each building.
            FiveOneTwoEigth.Construct();
            StoneFox.Construct();
            Mickeys.Construct();
            // Have business people in your city purchase each of your buildings.
            FiveOneTwoEigth.Purchase("Bill Gates");
            StoneFox.Purchase("Eddie Van Halen");
            Mickeys.Purchase("Weird Al");
            //Display to Console
            Console.WriteLine(FiveOneTwoEigth.GetLocation());
            Console.WriteLine("---------------");
            Console.WriteLine("Designed by Jason Brooks");
            Console.WriteLine("Constructed on " + FiveOneTwoEigth.GetDateConstructed());
            Console.WriteLine("Owned By " + FiveOneTwoEigth.GetOwner());
            Console.WriteLine(FiveOneTwoEigth.Volume + " cubic meters of space");
            Console.WriteLine("                         ");

            Console.WriteLine(StoneFox.GetLocation());
            Console.WriteLine("---------------");
            Console.WriteLine("Designed by Jason Brooks");
            Console.WriteLine("Constructed on " + StoneFox.GetDateConstructed());
            Console.WriteLine("Owned By " + StoneFox.GetOwner());
            Console.WriteLine(StoneFox.Volume + " cubic meters of space");
            Console.WriteLine("                         ");

            Console.WriteLine(Mickeys.GetLocation());
            Console.WriteLine("---------------");
            Console.WriteLine("Designed by Jason Brooks");
            Console.WriteLine("Constructed on " + Mickeys.GetDateConstructed());
            Console.WriteLine("Owned By " + Mickeys.GetOwner());
            Console.WriteLine(Mickeys.Volume + " cubic meters of space");
            Console.WriteLine("                         ");


        }
    }
}
