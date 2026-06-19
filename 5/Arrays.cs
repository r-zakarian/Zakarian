// Fill out the functions:

//Print each value of the array in a new line.
void PrintArray(int[] values)
{
    foreach (int value in values)
    {
        Console.WriteLine(value);
    }
}
//Sample: return numbers greater than 0
int[] GreaterThanZero(int[] values)
{
    List<int> results = [];
    for(int i = 0; i < values.Length; i++)
    {
        if(values[i] > 0)
        {
            results.Add(values[i]);
        }
    }
    return results.ToArray();
}
//Return even numbers in array.
int[] EvenNumbersOnly(int[] values)
{
    List<int> results = [];
    for (int i = 0; i < values.Length; i++)
    {
        if (values[i] % 2 == 0)
        {
            results.Add(values[i]);
        }
    }
    return results.ToArray(); //placeholer
}
//Return array in reverse.
int[] ArrayInReverse(int[] values)
{
    List<int> results = [];
    for (int i = values.Length - 1; i >= 0; i--)
    {
        results.Add(values[i]);
    }
    return results.ToArray(); //placeholer
}
Console.WriteLine("PrintArray");
PrintArray([1, 2, 3, 4, 5]);
Console.WriteLine("PrintArray - GreaterThanZero");
PrintArray(GreaterThanZero([1, 2, -3, 4, 0]));
Console.WriteLine("PrintArray - EvenNumbersOnly");
PrintArray(EvenNumbersOnly([1, 2, 3, 4, 5]));
Console.WriteLine("PrintArray - ArrayInReverse");
PrintArray(ArrayInReverse([1, 2, 3, 4, 5]));