/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Таблица кубов чисел от 1 до введенного числа: ");
double PowN = 0;

for (int n = 1; n <= number; n++)
{ Console.Write("\t" + Math.Pow(n, 3)); }
