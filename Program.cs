// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to my number guessing game");

Random rnd = new Random();

int randomnum = rnd.Next(1, 20);

bool exit = false;

while (!exit)
{
    Console.WriteLine("Please guess a number between 1 and 20! ");
    int guess = int.Parse(Console.ReadLine());

    if (guess == randomnum)
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
    else
    {
        Console.WriteLine("Please enter a valid number");
    }
}