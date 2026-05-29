// Let's make a game, user has 3 chances to guess the number.
// Assignment: change the tries to 2 and tell the user if the number is higher or lower.

int randomNumber = Random.Shared.Next(10);
int numberOfTries = 2;


Console.WriteLine($"Guess the number! You have {numberOfTries} tries.");

for(int i = 0; i < numberOfTries; i++)
{
    string guessText = Console.ReadLine();
    int guessNumber = int.Parse(guessText);
    if(guessNumber == randomNumber)
    {
        Console.WriteLine("You win!");
        break;
    }
    if(guessNumber > randomNumber)
    {
        Console.WriteLine("Try again, your number was too high!");
        break;
    }
     if(guessNumber < randomNumber)
    {
        Console.WriteLine("Try again, your number was too low!");
        break;
    }
}

Console.WriteLine($"The number was: {randomNumber}");
