// Задача 6: Напишите программу, 
//которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString!);


if (number%2 ==0)
{
    Console.WriteLine("Четное число");
}

else
{
    Console.WriteLine(" Не четное число");
}
