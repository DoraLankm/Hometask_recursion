//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Main();
void Main()
{
    int m = 3;
    int n = 2;
    Console.WriteLine($"Значение функции Аккермана при m={m} и n={n}: {AccermamFunc(m, n)}");
}

int AccermamFunc(int m, int n)
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
