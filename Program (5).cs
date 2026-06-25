using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o peso: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura: ");
        double alt = double.Parse(Console.ReadLine());

        double r = peso / (alt * alt);

        if (r < 20)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (r >= 20 && r < 25)
        {
            Console.WriteLine("Peso ideal");
        }
        else
        {
            Console.WriteLine("Acima do peso");
        }
    }
}