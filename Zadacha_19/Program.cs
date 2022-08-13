/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Write("Введите число: ");
string number = Console.ReadLine();
int number1 = Convert.ToInt32(number[0]);
int number2 = Convert.ToInt32(number[1]);
int number4 = Convert.ToInt32(number[3]);
int number5 = Convert.ToInt32(number[4]);
if (number1 == number5 && number2 == number4)
{
Console.WriteLine($"Число {number} является палиндромом");
}
else Console.WriteLine($"Число {number} не является палиндромом");
