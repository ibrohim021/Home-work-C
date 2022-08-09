// Заадча на проверку четного числа т е делится на 2 без остатка

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
