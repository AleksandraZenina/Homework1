// Показать четные числа от 1 до N
int count = 2;
int N = new Random().Next(1,100);
Console.WriteLine("Случайное число: " + N);
while (count<=N)
{
    Console.WriteLine(count);
    count = count + 2;
}

