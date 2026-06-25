using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o peso: ");
        double peso = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura: ");
        double alt = double.Parse(Console.ReadLine());

        Console.Write("Digite o sexo (M/F): ");
        string sexo = Console.ReadLine().ToUpper();

        double alturaQuadrado = alt * alt;
        double r = peso / alturaQuadrado;

        if (sexo == "F")
        {
            if (r < 19)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else
            {
                if (r < 24)
                {
                    Console.WriteLine("Peso ideal");
                }
                else
                {
                    Console.WriteLine("Acima do peso");
                }
            }
        }
        else if (sexo == "M")
        {
            if (r < 20)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else
            {
                if (r < 25)
                {
                    Console.WriteLine("Peso ideal");
                }
                else
                {
                    Console.WriteLine("Acima do peso");
                }
            }
        }
        else
        {
            Console.WriteLine("Sexo invalido.");
        }
    }
}