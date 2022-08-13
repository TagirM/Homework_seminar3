/*Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.*/


/*Console.Write("Введите координату по оси оХ: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оY: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("I четверть");
else if (x < 0 && y > 0) Console.WriteLine("II четверть");
else if (x < 0 && y < 0) Console.WriteLine("III четверть");
else if (x > 0 && y < 0) Console.WriteLine("IV четверть");
else System.Console.WriteLine("eror 404, quarter not found");*/

/*Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат 
точек в этой четверти (x и y).*/

/*Console.Write("Введите четверть: ");
int numberOfQuarter = Convert.ToInt32(Console.ReadLine());

if (numberOfQuarter == 1) Console.WriteLine("x > 0 и y > 0");
else if (numberOfQuarter == 2) Console.WriteLine("x < 0 и y > 0");
else if (numberOfQuarter == 3) Console.WriteLine("x < 0 и y < 0");
else if (numberOfQuarter == 4) Console.WriteLine("x > 0 и y < 0");
else System.Console.WriteLine("eror 404, quarter not found");*/

/*Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4*/

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица квадратов чисел от 1 до заданного");
int n = 1;
double PowN = 0;
while (n <= number)
{
    PowN = Math.Pow(n, 2);
    n++;
    Console.WriteLine(PowN);
}*/

// int i = 0 - точка старта; какое-то условие; инкремент(i++)
// 1 <= N
/*for (int i = 1; i < 5; i++)
{
    Console.WriteLine($"Переменная i = {i}");
}*/

/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Таблица квадратов чисел от 1 до заданного");
double PowN = 0;

for (int n = 1; n <= number; n++)
{ Console.WriteLine(Math.Pow(n, 2)); }*/

/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Write("Введите координату по оси оХ точки А: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оY точки А: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оZ точки А: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оХ точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оY точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оZ точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2) + Math.Pow((zB - zA),2));

Console.WriteLine("Расстояние между точками A и B " + Math.Round(distance,2));