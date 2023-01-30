// показать последнюю цифру трёхзначного числа
Console.Write("Введите любое трёхзначное число: ");
int number = int.Parse (Console.ReadLine());
if (number>=100 && number<=999)
{
    Console.WriteLine(number%10);
}
