// Программа, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых или меньше, или равна трём символам

string[] firstArray = new string[] { "Hello", "2", "world", ":-)" };
string[] secondArray = new string[firstArray.Length];

void FillSecondArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            secondArray[count] = firstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

FillSecondArray(firstArray, secondArray);
PrintArray(secondArray);