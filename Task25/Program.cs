// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Step (int a, int b)
{
    int res = a;
    if (b==0) return 1;
    for (int i=1; i<b; i++)
    {
        res *=a;
    }
    return res;
}


Console.Clear();
Console.Write("Введите число для возведения в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень возведения: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Step(a,b));