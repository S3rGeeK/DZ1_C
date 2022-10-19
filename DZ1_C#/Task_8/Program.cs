// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
//      5 -> 2, 4
//      8 -> 2, 4, 6, 8

int temp = 1;
bool not = true;

Console.WriteLine("Введите число N: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine("Чётные числа от 1 до " + number);
while (temp <= number)
    {
        if (temp % 2 != 1)
            {
                Console.Write(temp + ", ");
                not = false;
            }
            temp++;
    }

        if (not)
        {
            Console.WriteLine("Нет чётных чисел!");
        }