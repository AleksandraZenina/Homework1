// Выяснить, кратно ли число заданному, если нет, вывести остаток
int a = 5;
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if (number%a==0)
{
    Console.WriteLine("Данное число кратно 5");
}
else
{
    Console.WriteLine(number%a);
}