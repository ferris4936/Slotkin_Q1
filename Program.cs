//Programmer: Erica Slotkin

//Filename: Program.cs

using System;

namespace Slotkin_Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "y";
            do
            {
                Console.WriteLine("\nThis program will calculate the gravitational force between 2 objects given");
                Console.WriteLine("the mass of each object and the distance between the two.  Let's do this!");

                Console.WriteLine("\nPlease enter the mass of the first object in kilograms: ");
                string massObject1 = Console.ReadLine();
                double mass1 = Convert.ToDouble(massObject1);     

                Console.WriteLine("\nPlease enter the mass of the second object in kilograms: ");
                string massObject2 = Console.ReadLine();
                double mass2 = Convert.ToDouble(massObject2);

                Console.WriteLine("\nPlease enter the distance between the 2 objects in meters: ");
                string distance = Console.ReadLine();
                double dist = Convert.ToDouble(distance);

                GravitationalForce force = new GravitationalForce(mass1, mass2, dist);

                string results = force.CalcGravForce().ToString();

                Console.WriteLine("\nThe gravitational force between the two objects is {0} newton.  Impressed?", results); 

                Console.WriteLine("\nWould you like to do another? y/n");
                answer = Console.ReadLine();

            } while (answer == "y");

            Console.WriteLine("\nHope I passed this quiz!");
        }
    }
}
