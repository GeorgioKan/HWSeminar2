// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

System.Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    System.Console.WriteLine((num/10) - (num/100)*10);
}
else
    System.Console.WriteLine("Число не трехзначно!");
