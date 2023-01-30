
int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }

    return result;
}

string[] InitArray(int dimension)
{
    string[] array = new string[dimension];

    for (int i = 0; i < dimension; i++)
    {
        Console.WriteLine("Введите строку");
        array[i] = Console.ReadLine() ??""; //ручной ввод элементов массива
    }
    return array;
}

string[] CheckArray(string[] array) 
{   
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++) // Перебор массива по элементам для определения размерности нового массива
    { 
        if (array[i].Length <= 3) count++;
    }

    string[] finalArray = new string[count];
    for (int j = 0; j < array.Length; j++) // Проверяем длину введенной строки и отбираем элементы длиной до 3 символов
    { 
        if (array[j].Length <=3) 
        {
            finalArray[index] = array[j];
            index++;
        }
    }
    return finalArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int dimension = GetNumber("Введите размерность массива:");
string[] array = InitArray(dimension);

Console.Write("Полученные данные: ");
PrintArray(array);
Console.Write("Результат: ");
PrintArray (CheckArray(array));

