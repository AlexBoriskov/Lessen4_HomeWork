// Задача 27: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summa (int a)
{
    int res = 0;
    while (a>0)
    {
        res = res+a%10;
        a /=10;
    }
    return res;
}


Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Summa(a));