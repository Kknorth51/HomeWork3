// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84 A (7,-5, 0); B (1,-1,9) -> 11.53

try
{
    Console.WriteLine("Введите координаты А");
    int x = Convert.ToInt32(Console.ReadLine());
    int y = Convert.ToInt32(Console.ReadLine());
    int z = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите координаты B");
    int x1 = Convert.ToInt32(Console.ReadLine());
    int y1 = Convert.ToInt32(Console.ReadLine());
    int z1 = Convert.ToInt32(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow((x - x1), 2) + Math.Pow((y - y1), 2) + Math.Pow((z - z1), 2));

    Console.WriteLine($"Расстояние равное {Math.Round(result, 2, MidpointRounding.AwayFromZero)}");
}
catch
{
    Console.WriteLine("Что-то пошло не так, поробуйте ввести координаты заново");
}