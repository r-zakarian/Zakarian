//TODO: Make a rock, paper, sissors game. (Kinda like the guess the number game)
using System.Data.Common;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

int randomNumber = Random.Shared.Next(3);

Console.WriteLine($"Choose Rock (type 0), Paper (type 1), or Scissors (type 2).");
string guessType = Console.ReadLine();
int playerChoice = int.Parse(guessType);
if (playerChoice == 0)
{
    Console.WriteLine("You chose Rock");
}
else if (playerChoice == 1)
{
    Console.WriteLine("You chose Paper");
}
else
{
    Console.WriteLine("You chose Scissors");
}


if (randomNumber == 0)
{
    Console.WriteLine("Rock");
}
else if (randomNumber == 1)
{
    Console.WriteLine("Paper");
}
else
{
    Console.WriteLine("Scissors");
}

if (playerChoice == 0) // rock
{
    if (randomNumber == 0)
    {
        Console.WriteLine("You both chose rock, you tied!");
    }
    else if (randomNumber == 1) // Paper
    {
        Console.WriteLine("Computer chose Paper, you lost!");
    }
    else
    {
        Console.WriteLine("Computer chose Scissors, you win!");
    }
}
else if (playerChoice == 1) // Paper
{
    if (randomNumber == 0)
    {
        Console.WriteLine("Computer chose Rock, you win!");
    }
    else if (randomNumber == 1)
    {
        Console.WriteLine("Computer chose Paper, you tied!");
    }
    else
    {
        Console.WriteLine("Computer chose Scissors, you lost!");
    }
}
else
{
    if (randomNumber == 0)
    {
        Console.WriteLine("Computer chose Rock, you lost!");
    }
    else if (randomNumber == 1)
    {
        Console.WriteLine("Computer chose Paper, you win!");
    }
    else
    {
        Console.WriteLine("Computer chose Scissors, you tied!");
    }
}