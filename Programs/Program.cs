string[] array1 = GetArray("Введите массив чисел: ");
string[] array2 = new string[array1.Length];

string[] GetArray(string message)
{
    Console.WriteLine(message);
    string getArray = Console.ReadLine();
    string[] array = getArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);    
    return array;
}

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArrayWithIF(array1, array2);
PrintArray(array2);