// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
//      a = 5; b = 7 -> max = 7
//      a = 2 b = 10 -> max = 10
//      a = -9 b = -3 -> max = -3

Console.WriteLine("Программа для вывода большего числа издвух");

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 == number2)
    {
        Console.WriteLine("Введены одинаковые числа");
        }
else 
    {
        if (number1 > number2)
    {
        Console.WriteLine("Первое число " + number1 + " больше чем второе " + number2);
        }
else
    {
        Console.WriteLine("Второе число " + number2 + " больше чем первое " + number1);
        }
        }