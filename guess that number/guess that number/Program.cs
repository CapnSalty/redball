namespace guess_that_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //All notes are for the lines above said note to explain my understanding of what the code means.

            Random random = new Random();
            int targetNumber = random.Next(0, 100);
            //random.Next provides value to the targetNumber using the values in range
            int guess = 0;
            int attempts = 0;
            //I would call this section setting everything to "Home" in the logic, aka start position.
            Console.WriteLine("Welcome to GUESS THAT NUMBER!");

            Console.WriteLine("Please enter your name, contestant.");

            //Using WriteLine to get input from user for interaction.
            string userName = Console.ReadLine();

        
            Console.WriteLine("Welcome," + userName);
            Console.WriteLine("Today you must guess a number between 0-100.");
            // RP Dialogue

            while (guess != targetNumber)
            {
                Console.Write("What's your guess?");
                string input = Console.ReadLine();

                // String being used with Console.ReadLine to place input in equation

                if (int.TryParse(input, out guess))
                {
                    attempts++;
                    if (guess < targetNumber)
                    {
                        Console.WriteLine("Nope! That's too low!");
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("Sorry, that's too high!");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed correctly!");
                    }
                }
                else
                {
                    Console.WriteLine("What number do you think it is?");
                }
                }
            }
            
        }
    }

