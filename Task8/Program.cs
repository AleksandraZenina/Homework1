// Удалить вторую цифру трёхзначного числа
Console.Write("Введите любое трёхзначное число: ");
int number = int.Parse (Console.ReadLine());
if (number>99&&number<=999)
{
    Console.Write(number/100);
    Console.Write(number%10);
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число!");
}