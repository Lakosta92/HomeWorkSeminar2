/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
   645 -> 5
   78 -> третьей цифры нет
   32679 -> 6                  */

Console.Clear();

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int number2=0;



if (number > 100)
{
    int number3 = Metod(number,number2);
    Console.WriteLine("Третья цифра в числе = " + number3);
}

else
{
 Console.WriteLine("В числе меньше 3-ёх символов!");
}

int Metod(int number, int number2)
{
    while (number > 999)
    {

    number2=number / 10;
    number = number2;
    
    }
    return (number%10);
 }