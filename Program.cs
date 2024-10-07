// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to my number guessing game");

bool playAgain = true;
int highscore = 0;
while (playAgain)
{
    Random rnd = new Random();
    int randomnum = rnd.Next(1, 21);
    bool exit = false;
    int count = 0;

    while (!exit)
    {
        Console.WriteLine("Please guess a number between 1 and 20! ");
        if (int.TryParse(Console.ReadLine(), out int guess))
        {
            count++;
            if (guess < 1 || guess > 20)
            {
                Console.WriteLine("Please enter a number between 1 and 20");
            }
            else if (guess == randomnum)
            {
                Console.WriteLine("Congrats you guessed the number!");
                Console.WriteLine($"It took {count} guesses");

                if (highscore = 0 || count < highscore)
                {
                    highscore = count;
                    Console.WriteLine($"Congrats you achieved a new highscore of {count}");
                }
                exit = true;
            }
            else if (guess < randomnum)
            {
                Console.WriteLine("Guess higher");
            }
            else if (guess > randomnum)
            {
                Console.WriteLine("Guess lower");
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
            count = +1;
        }
    }
    Console.WriteLine("Do you want to play again? (y/n)");
    string response = Console.ReadLine().ToLower();
    if (response != "y")
    {
        playAgain = false;
    }
}
Console.WriteLine("Thanks for playing!");