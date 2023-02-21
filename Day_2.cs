using System;
using System.Linq.Expressions;
using System.Runtime;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace SecondOne
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string firstname = "Yato ";
            string secondname = "Bog";
            string name = firstname + secondname;
            Console.WriteLine(name);

            string myString = "Hello";
            Console.WriteLine(myString[0]);

            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"



            // Full name
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);



            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }



            variable = (condition) ? expressionTrue : expressionFalse;
            string result = (time < 18) ? "Good day." : "Good evening.";



            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }
            // Outputs "Thursday" (day 4)


            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 5);


            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }









            Random random = new Random();
            bool playAgain = true;
            string player;
            string computer;

            while (playAgain)
            {
                player = "";
                computer = "";
                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                int randomNum = random.Next(1, 4);

                switch (randomNum)
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You lose!");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                }
          

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            int[] myNum = { 10, 20, 30, 40 };

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
            // Outputs Volvo



            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars.Length);
            // Outputs 4

            // Create an array of four elements, and add values later
            string[] cars = new string[4];

            // Create an array of four elements and add values right away 
            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };


            // Sort a string
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements





            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            Console.WriteLine(numbers[0, 2]);  // Outputs 2

            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };
            numbers[0, 0] = 5;  // Change value to 5
            Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1




            Also note that we have to use GetLength() instead of Length to specify how many times the loop should run:
                int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

*/
        }
    }
}