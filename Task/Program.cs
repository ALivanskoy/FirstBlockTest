// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трём символам.



void ArrayPrint(string[] array)
{
    //Метод вывода массива на экран.
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.Write("]\n");
}

int ArrayElementCounter(string[] array, int min, int max)
{
    //Метод подсчёта кол-ва элементов, чья длина больше значения min и меньше значения max.
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length > min && array[i].Length < max) counter += 1;

    return counter;
}

void ArrayFill(string[] fillingArray, string[] fillableArray, int min, int max)
{
    //Метод, заполняющий fillableArray элементами FillingArray, чья длина больше значения min и меньше значения max.
    int count = 0;
    for (int i = 0; i < fillableArray.Length; i++)
    {
        for (int j = count; j < fillingArray.Length; j++)
        {
            if (fillingArray[j].Length > min && fillingArray[j].Length < max)
            {
                fillableArray[i] = fillingArray[j];
                count = j + 1;
                break;
            }
        }
    }
}

string[] firstStringsArray = new string[] { "hello", "2", "world", ":-)" };
string[] secondStringsArray = new string[] { "1234", "1567", "-2", "computer science", "workwork" };
string[] thirdStringsArray = new string[] { "Russia", "Denmark" };
string[] stringsArray = new string[ArrayElementCounter(firstStringsArray, 0, 4)];
int min = 0,
max = 4;

Console.Clear();
Console.WriteLine("Исходный массив символов:");
ArrayPrint(firstStringsArray);
ArrayFill(firstStringsArray, stringsArray, min, max);
Console.WriteLine($"Все элементы массива с длинной более {min} символов и менее {max} символов перенесены в новый массив.");
Console.WriteLine("Новый массив символов:");
ArrayPrint(stringsArray);