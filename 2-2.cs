using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro numero: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Digite o segundo numero: ");
        double y = double.Parse(Console.ReadLine());

        Console.Write("Digite o terceiro numero: ");
        double z = double.Parse(Console.ReadLine());

        if (x > y && x > z)
        {
            Console.Write("O maior e: ");
            Console.WriteLine(x);
        }
        else if (y > x && y > z)
        {
            Console.Write("O maior e: ");
            Console.WriteLine(y);
        }
        else if (z > x && z > y)
        {
            Console.Write("O maior e: ");
            Console.WriteLine(z);
        }
        else
        {
            Console.WriteLine("Nao existe um maior valor.");
        }
    }
}