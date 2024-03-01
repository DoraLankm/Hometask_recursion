//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Main();
void Main()
{
    uint m = 3;
    uint n = 2;
    Console.WriteLine($"Значение функции Аккермана при m={m} и n={n}: {AccermamFunc(m, n)}");
}

uint AccermamFunc(uint m, uint n)
{
    if (m == 0)
    {
        return n + 1;
    }

    else //m>0
    {
        if (n == 0)
        {
            return AccermamFunc(m - 1, 1);
        }
        else //n>0
        {
            return AccermamFunc(m - 1, AccermamFunc(m, n - 1));
        }
    }

}
