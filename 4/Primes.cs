// Fill out the function, it should take in an integer and return if it's prime or not.

bool IsPrime(int y)
{
    if (y % 2 == 0)
    return false;
    else
    return true;
}

bool IsOne(int x)
{
    if (x == 1)
    return true;
    else
    return false;
}

bool result = IsOne(1);
Console.WriteLine(result);

Console.WriteLine($"Is 4 prime? {IsPrime(4)}"); // false
Console.WriteLine($"Is 5 prime? {IsPrime(5)}"); // true