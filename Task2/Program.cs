// / Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int summa=0;
while (number>0)
{
    summa += number%10;
number=number/10;
}

Console.WriteLine(summa);