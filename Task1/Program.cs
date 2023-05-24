// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите целое число А");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число В");
int B = Convert.ToInt32(Console.ReadLine());
int С = A;
int result = 0;
for (int i=1; i<B; i++)
{
    С = С*A;
    result = С;

}

Console.WriteLine(result);