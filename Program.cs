// Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] GetArrayFromString(string stringArray)
{
    string[] res = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return res;
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]}\t ");
    }
    Console.WriteLine();
}

string[] FilterArray(string[] inArray)
{
    string[] x = new string[inArray.Length];
    int z = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= 3)
        {
            x[z] = inArray[i];
            z += 1;
        }
    }
    return x;
}

Console.Clear();
Console.Write("Введите массив через пробел:  ");
string result = Console.ReadLine()!;
string[] newArray = GetArrayFromString(result);
string[] array = FilterArray(newArray);
PrintArray(newArray);
PrintArray(array);