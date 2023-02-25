// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или ровна 3 символов.

string[] array = new string[5] { "875", "hi", "me", "work", "arr" };
string[] arrayNew = new string[array.Length];

SortingArray(array, arrayNew);
PrintArray(arrayNew);

void SortingArray(string[] array, string[] arrayNew)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[count] = array[i];
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