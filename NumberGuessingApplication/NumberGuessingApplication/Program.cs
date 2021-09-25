using System;

namespace NumberGuessingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool play = true;
            int minNumber = 1;
            int maxNumber = 100;
            int playerInput;
            int correctNumber;
            int attempt;
            string message;

            while (play)
            {
                playerInput = 0;
                attempt = 0;
                message = string.Empty;
                correctNumber = random.Next(minNumber, maxNumber);

                while (playerInput != correctNumber)
                {
                    Console.WriteLine("Guess a number between " + minNumber + "-" + maxNumber);
                    playerInput = Convert.ToInt32(Console.ReadLine());
                    if(playerInput>=1 && playerInput <= 100)
                    {
                        Console.WriteLine("Guess: " + playerInput);
                        if (playerInput > correctNumber)
                        {
                            Console.WriteLine(playerInput + " is too High");

                        }
                        else if (playerInput < correctNumber)
                        {
                            Console.WriteLine(playerInput + " is too Low");
                        }
                        attempt++;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                   

                }

                Console.WriteLine("You Guess it correct after attemting " + attempt + " times");
                Console.WriteLine("YOU WIN!!!!!");
                Console.WriteLine("Would you like to play again?(Y/N)");
                message = Console.ReadLine();
                message = message.ToUpper().Trim();
                if (message == "N")
                {
                    play = false;
                }
                else if(message !="N" && message != "Y")
                {
                    Console.WriteLine("Please enter a valid option");
                    play = false;
                    Console.WriteLine("Would you like to play again?(Y/N)");
                    message = Console.ReadLine();
                }
                

            }
            Console.WriteLine("Thanks for playing!!");
            Console.ReadKey();
        }
    }
}
