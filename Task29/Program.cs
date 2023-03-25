// Задача 29: Напишите программу, которая будет создавать массив из 8 символов
// и заполнять значениями от пользователя
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

void NewArray (int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write("Введите " + (i+1) + " элемент: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.Clear();
int [] array = new int [8];
NewArray(array);
Console.WriteLine (string.Join(", ", array));