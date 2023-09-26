const int COUNT_SYMBOL = 3;

string[] sourceArray = createArrayString();
Console.Write("Исходный массив: ");
PrintArray(sourceArray);
Console.WriteLine();

Console.Write($"Строки длина которых <= {COUNT_SYMBOL}: ");
string[] formatArray = searchElementsArray(sourceArray, COUNT_SYMBOL);
PrintArray(formatArray);
Console.WriteLine();


string[] createArrayString()
{
    Console.WriteLine("Введите кол-во элементов массива");
    int size = int.Parse(Console.ReadLine()!);

    string[] arr = new string[size];

    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        arr[i] = Console.ReadLine()!;
    }

    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"\"{arr[i]}\", ");
        else Console.Write($"\"{arr[i]}\"");
    }
    Console.Write("]");
}

string[] searchElementsArray(string[] arr, int countSumbol)
{
    string[] arrayString = new string[arr.Length];
    int countSize = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= countSumbol)
        {
            arrayString[countSize] = arr[i];
            countSize++;
        }
    }

    if (arr.Length != countSize)
        resizeArray(ref arrayString, countSize);

    return arrayString;
}

void resizeArray(ref string[] array, int newSize)
{
    string[] newArray = new string[newSize];

    for (int i = 0; i < array.Length && i < newArray.Length; i++)
        newArray[i] = array[i];

    array = newArray;
}