//Задача 2: Напишите программу, 
//которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число - ");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString!);

Console.Write("Введите второе число - ");

string? numberString2 = Console.ReadLine();

int number2 = int.Parse(numberString2!);

int max = number;
int min = number2;

if(number > max) max =number;
if(number2 > max) max =number2;

if(number < min) max =number;
if(number < min) max =number2;

Console.WriteLine("Максимальное число = "+ max);
Console.WriteLine("Минимальное число = "+ min);
