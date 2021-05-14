using System;

namespace Warmup.Mosh
{
    class Program
    {
        static void Main(string[] args)
        {

            //First Test

            Console.WriteLine("Enter a number between 1 and 10");
            int inputNum = Convert.ToInt32(Console.ReadLine());

            if (inputNum > 0 && inputNum < 11)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }

            Console.WriteLine("--------------");

            //Second Test

            Console.WriteLine("Enter two numbers. First number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second number: ");
            
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("First num is larger: " + num1);
            }
            else if (num1 == num2)
            {
                Console.WriteLine("Numbers are equal");
            }
            else
            {
                Console.WriteLine("Second num is larger: " + num2);
            }

            Console.WriteLine("--------------");
            //Thrd Test

            Console.WriteLine("Enter the height of an image");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The height is: " + height + ". Enter the width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The width is: " + width + ".");
            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is "+ orientation);


        Console.WriteLine("--------------");

            //Fourth Test
            Console.WriteLine("You must input a speed limit as well as a speed for a car to determine" +
                " if the car is obeying the law");
            Console.WriteLine("What is the speed limit?");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the speed of the vehicle?");
            int carSpeed = Convert.ToInt32(Console.ReadLine());

            int demerits = (carSpeed - speedLimit) / 5;

            if (speedLimit >= carSpeed)
            {
                Console.WriteLine("Obeying Law");
            }
            else
            {
                if (demerits >= 12)
                {
                    Console.WriteLine("License Suspended: You have " + demerits + "demerits");
                }
                else
                {
                    Console.WriteLine("Demerits: " + demerits);
                }
            }

        }
    }
}

    

