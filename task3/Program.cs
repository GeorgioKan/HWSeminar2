// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7)
{
    System.Console.WriteLine("Да");
}
else if (num > 0 && num < 6)
{
    System.Console.WriteLine("Нет");
}
else
    System.Console.WriteLine("Дня недели соответствующего такой цифре не существует.");