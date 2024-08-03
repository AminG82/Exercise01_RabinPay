
//RabinPay Exercise01 :

int arrayIndex;

Console.Write("Input number of strings to store in the array : ");
arrayIndex = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\r\n");

Console.WriteLine($"Input {arrayIndex} strings for the array :");

string[] array = new string[arrayIndex];
for (int i = 0; i < arrayIndex; i++)
{
    Console.Write($"Element[{i}] : ");
    array[i] = Console.ReadLine();
}

Console.WriteLine("\r\n");

Console.Write("Input the minimum length of the item you want to find : ");
int minLength = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\r\n");

Console.WriteLine($"The items of minimum {minLength} characters are :");

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length >= minLength)
    {
        Console.WriteLine($"Item: {array[i]}");
    }
}

Console.ReadKey();