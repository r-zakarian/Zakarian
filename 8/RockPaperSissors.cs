//TODO: Make a rock, paper, sissors game. (Kinda like the guess the number game)
string[] choices = {"Rock", "Paper", "Scissors"};

Console.WriteLine($"Let's play one round of rock paper scissors!");
Console.WriteLine("Choose Rock, Paper, or Scissors:");
string playerChoice = Console.ReadLine();

int randomNumber = Random.Shared.Next(3);
string myChoice = choices[randomNumber];

Console.WriteLine($"I choose {myChoice}");

if (playerChoice == myChoice)
{
  Console.WriteLine("It's a tie!");
}
else if (
  (playerChoice == "Rock" && myChoice == "Scissors") ||
  (playerChoice == "Paper" && myChoice == "Rock") ||
  (playerChoice == "Scissors" && myChoice == "Paper")
  )
{
  Console.WriteLine("You win!");
}
else
{
  Console.WriteLine("You lost!");
}
