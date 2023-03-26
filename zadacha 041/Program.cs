/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
int ligth;
Console.WriteLine("Сколько чисел будет введено?");
int.TryParse(Console.ReadLine(), out ligth);
int[] array = new int[ligth];
Console.WriteLine("Введите ваши числа: ");
massiv(array, ligth);
void massiv(int[] name, int size)
{
for (int i = 0; i < ligth; i++)
{
    int a;
    int.TryParse(Console.ReadLine(), out a);
    array[i] = a;
}
}
rezult(array);
void rezult(int[]array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
     if (array[i] > 0)
    sum++;
    }
Console.WriteLine($"Количество положительных чисел равно: {sum}");
}
