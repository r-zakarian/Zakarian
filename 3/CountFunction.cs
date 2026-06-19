// Fill out the function, it should take in an integer and print all numbers up to it.

void Count(int value)
{
    for (int i = 1; i <= value; i++)
    Console.WriteLine(i);
}

void Tens(int start, int end)
{
    for (int i = start; i <= end; i++)
    Console.WriteLine(i);
}

Tens(end: 40, start: 20);