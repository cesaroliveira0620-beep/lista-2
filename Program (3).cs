using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite a nota P1: ");
        double p1 = double.Parse(Console.ReadLine());

        double p2 = (15 - p1) / 2;

        Console.Write("Voce precisa tirar na p2, no minimo ");
        Console.Write(p2);
    }
}