/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
   6 -> да
   7 -> да
   1 -> нет        */

Console.Clear();

Console.WriteLine("Напишите цифру соответствующую дню недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1 || number > 7)
{
    Console.WriteLine("Ошибка");
}

else
{
    if (number >= 6 || number <= 7)
    {
    Console.WriteLine("Является выходным");
    }
    else if (number < 6)
    {
    Console.WriteLine("Не является выходным");
    }
}