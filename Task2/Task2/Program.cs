using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //setup
            //TODO: All variables need to be initialized.
            Single height1;
            Single width1;
            Single height2;
            Single width2;
            Single area1;
            Single area2;

            //input
            do
            {
                Console.WriteLine("What is the height of the first rectangle?");
            } while (!Single.TryParse(Console.ReadLine(), out height1));

            do
            {
                Console.WriteLine("What is the width of the first rectangle?");
            } while (!Single.TryParse(Console.ReadLine(), out width1));

            do
            {
                Console.WriteLine("What is the height of the second rectangle?");
            } while (!Single.TryParse(Console.ReadLine(), out height2));

            do
            {
                Console.WriteLine("What is the width of the second rectangle?");
            } while (!Single.TryParse(Console.ReadLine(), out width2));

            //process
            area1 = height1 * width1;
            area2 = height2 * width2;

            //output
            if (area1 > area2)
            {
                Console.WriteLine("The first rectangle with an area of " + area1 + " is greater than the area of second rectangle with the area " + area2);
            } else if (area2 > area1) {
                Console.WriteLine("The second rectangle with an area of " + area2 + "  is greater than the first rectangle with the area of " + area1);
            } else
            {
                Console.WriteLine("The areas of the first rectangle " + area1 + " is equal to the area of the second rectangle " + area2);
            }

            Console.ReadLine();
        }
    }
}
