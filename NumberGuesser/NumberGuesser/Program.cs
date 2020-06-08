using System;

// Namespace
namespace NumberGuesser
{
    // Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            // Run GetAppInfo to get info.
            GetAppInfo();
            // Ask user's name
            GreetUser();

            while (true)
            {
                // Init correct number
                //int correctNumber = 7;

                // Create a new Random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                // Init guess variable
                int guess = 0;

                // Ask user for number 
                Console.WriteLine("Guess a number between 1 and 10.");

                // While the guess is not correct....
                while (guess != correctNumber)
                {
                    // Get user's input
                    string inputGuess = Console.ReadLine();

                    // Make sure user's guess is a number.
                    // If the number/string can't be parsed...
                    if (!int.TryParse(inputGuess, out guess))
                    {
                        // Tell user it isn't a number.
                        PrintColorMessage(ConsoleColor.Red, "That's not a number, pal. Guess again.");

                        // Keep going.
                        continue;
                    }

                    // Cast guess to int and store as "guess" variable
                    guess = Int32.Parse(inputGuess);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        PrintColorMessage(ConsoleColor.Red, "Nope. Guess again.");

                    }

                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!!");

                // Ask user to play again.
                PrintColorMessage(ConsoleColor.Blue, "Wanna play again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                while (true)
                {
                    if (answer == "Y")
                    {
                        continue;
                    }
                    else if (answer == "N")
                    {
                        return;
                    }
                    else
                    {
                        PrintColorMessage(ConsoleColor.Red, "I guess that's a no...");
                        return;
                    }
                }

            }
        }

        // Print app info
        static void GetAppInfo()
        {
            // Set app variables

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "David";



            // Change text colour
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Greet the user and grab user's name
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello, {0}. Let's play a game...", inputName);

        }


        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        }


    }
}
