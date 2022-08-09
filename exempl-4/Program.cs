// Задача 8: Напишите программу, 
// которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число ");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString!);

int count = 0;

while(count < number)
{

    if(count%2==0)

    Console.WriteLine(count);

    count++;
}

