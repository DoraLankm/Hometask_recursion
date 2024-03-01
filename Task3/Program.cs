
//Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
Main();
void Main()
{
   int[] array = GenerateArray(10, 1, 10);
    ShowArrayWithFor(array); //для проверки корректности вывода 
    Console.WriteLine("Рекурсионный вывод массива с конца: ");
    ShowArrayReverse(array, 0); //рекурсионный вывод массива 

}



int[] GenerateArray(int size, int min, int max)
{
    int[] result = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(min, max);
    }
    return result;
}

void ShowArrayWithFor(int [] array)
{
    Console.WriteLine("Массив изначальный: ");
    for (int i=0;i<array.Length;i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ShowArrayReverse(int[] array, int index)
{
    if (index > array.Length-1)
    {
        return;
    }
    ShowArrayReverse(array, index + 1);
    Console.Write(array[index] + " ");
}