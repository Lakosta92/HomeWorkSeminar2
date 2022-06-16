/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
   456 -> 5
   782 -> 8
   918 -> 1 */

   Console.Clear();

   Console.WriteLine("Введите 3-ёх значное число:");
   int number = Convert.ToInt32(Console.ReadLine());

   if (number < 100 || number > 999)
   {
      Console.WriteLine("Ошибка! Число не 3-ёх значное:");
   }
   else 
   {
     number = (number/10)%10;
     Console.WriteLine(number);
   }