string[] array = GetArray("Введите массив чисел: ");

string[] GetArray(string message)
{
    Console.WriteLine(message);
    string getArray = Console.ReadLine();
    string[] array = getArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);    
    return array;
}
