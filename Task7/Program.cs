// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа.
//int number = new Random().Next(10,100);
//Console.Write("Случайное число: "+ number);//почему-то не соблюдается числовой отрезок 
//при запуске генератора случайных чисел (выдаёт трехзачные числа)
Console.Write("Введите любое число от 10 до 99: ");
int number = int.Parse(Console.ReadLine());
if (number>=10&&number<=99) 
{
  if (number/10>number%10)
  {
    Console.WriteLine(number/10);
  }
  else
  {
    Console.WriteLine(number%10);
  }
}
else
{
    Console.WriteLine("Введено неверное значение");
}
