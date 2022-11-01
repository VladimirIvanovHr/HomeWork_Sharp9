void Zadacha64()
// Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
{
Console.WriteLine ("Ввседите M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ввседите N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ответ");
Print(m, n);

void Print(int m, int num = 0)
    {
        if (m > n)
        {
           return;
        }
        num = m % 3;
        if (num == 0)
        {
            Console.WriteLine(m);
        }
        m++;
        Print(m, num = 0); 

    }

}

void Zadacha66()
// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
{
Console.WriteLine ("Ввседите M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ввседите N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ответ");
Sum(m, n);

void Sum(int m, int sum = 0)
    {
        if (m == n)
        {
           Console.WriteLine(sum);
           return;
        }
        sum = sum + m;
        m++;
        Sum(m, sum); 
    }
}

// 4+5 +6+7+8=



void Zadacha68()
// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
{
Console.WriteLine ("Ввседите M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Ввседите N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine (Ackermann(m, n));

static int Ackermann(int m, int n)
{
if (m == 0)
    {
    return n + 1;
    }
    else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
            else
            {
                return Ackermann(m - 1, Ackermann(m, n - 1));
            }
}
}

Zadacha68();
