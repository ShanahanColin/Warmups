using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {


            //First
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    count++;
            }
            Console.WriteLine($"There are {count} numbers divisible by 3 between 1 and 100.");

            Console.WriteLine("--------------");
            //Second
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number or type 'ok' to exit ");
                var input = Console.ReadLine();

                if (input.ToLower() == "ok")
                    break;
                sum += Convert.ToInt32(input);

                Console.WriteLine($"The sum of all your numbers is: {sum}");
            }
            Console.WriteLine("--------------");
            //Third

            int fact = 1;
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            for (var i = 1; i <= number; i++)
            {
                fact = fact * i;

            }
            Console.WriteLine($"!{number} = {fact}");

            //Fourth
            int randomNumber = new Random().Next(1, 10);
            Console.WriteLine("You have 4 chances to guess a randomly generated " +
                "number between 1 and 10 ");

            for (var i = 0; i < 4; i++)
            {
                int usrGuess = int.Parse(Console.ReadLine());
                if (usrGuess == randomNumber)
                {
                    Console.WriteLine("You won");
                    return;
                }
            }
            Console.WriteLine("You lost");

            //Fifth

            Console.WriteLine("Enter as much numbers as you'd like. Add a comma in between");
            var numbers = Console.ReadLine().Split(',');
            var max = Convert.ToInt32(numbers[0]);

            foreach (var item in numbers)
            {
                var numberOne = int.Parse(item);
                if (numberOne > max)
                {
                    max = numberOne;
                }
            }
                Console.WriteLine(max);



        }

    }
}
