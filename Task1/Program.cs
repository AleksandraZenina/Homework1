//По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if (number2==number1*number1)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Это просто два числа");
}