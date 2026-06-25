using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a nota P1: ");
        double p1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota P2: ");
        double p2 = double.Parse(Console.ReadLine());
     
        double media = (p1 + 2 * p2) / 3;

        Console.Write("Media: ");
        Console.WriteLine(media);

        if (media >= 5)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
    }
}