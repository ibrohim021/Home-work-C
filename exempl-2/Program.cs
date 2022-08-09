Console.Write("Введите первое число - ");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString!);

Console.Write("Введите второе число - ");

string? numberString2 = Console.ReadLine();

int number2 = int.Parse(numberString2!);

Console.Write("Введите третье число - ");

string? numberString3 = Console.ReadLine();

int number3 = int.Parse(numberString3!);

int max = number;

if(number > max) max =number;
if(number2 > max) max =number2;
if(number3 > max) max =number3;

Console.WriteLine("Максимальное число = "+ max);

