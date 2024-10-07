// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to my number guessing game");

bool playAgain = true;

while (playAgain)
{
    Random rnd = new Random();
    int randomnum = rnd.Next(1, 21);
    bool exit = false;

    while (!exit)
    {
        Console.WriteLine("Please guess a number between 1 and 20! ");
        if (int.TryParse(Console.ReadLine(), out int guess))
        {
            if (guess < 1 || guess > 20)
            {
                Console.WriteLine("Please enter a number between 1 and 20");
            }
            else if (guess == randomnum)
            {
                Console.WriteLine("Congrats you guessed the number!");
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