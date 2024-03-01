//Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


Main();
void Main()
{
    try
    {
        Console.WriteLine("Введите натуральное число M соответствующее левой границе диапазона");
        uint M = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine("Введите натуральное число N соответствующее правой границе диапазона");
        uint N = Convert.ToUInt32(Console.ReadLine());
        if(N>=M)
        {
            ShowNumbers(M, N);
        }
        else
        {
            Console.WriteLine("Второе число не может быть меньше первого");
        }
       
    }
    catch(Exception error)
    {
         Console.WriteLine("Ошибка! Введите корректные данные! " + error.Message);
    }
}


void ShowNumbers(uint numbers,uint n)
{
    if (numbers>n)
    {
        return;
    }
    Console.Write(numbers + " ");
    ShowNumbers(numbers+1,n);
   
}
