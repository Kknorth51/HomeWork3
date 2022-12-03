// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27    5 -> 1, 8, 27, 64, 125

try
{
    Console.WriteLine("Ведите число");
    int N = Convert.ToInt32(Console.ReadLine());

    for (int a = 1; a <= N; a++)
    {
        int result = Convert.ToInt32(Math.Pow(a, 3));
        Console.Write($"{result} ");
    }
}
catch
{
    Console.WriteLine("Будьте внимательней при вводе числа>");
}