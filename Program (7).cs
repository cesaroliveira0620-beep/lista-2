using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a base: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura: ");
        double h = double.Parse(Console.ReadLine());

        double area = b * h;

        Console.Write("Area: ");
        Console.WriteLine(area);

        if (area > 100)
        {
            Console.WriteLine("Terreno grande");
        }
    }
}