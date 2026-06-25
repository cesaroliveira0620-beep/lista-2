using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o lado A: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Digite o lado B: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Digite o lado C: ");
        double c = double.Parse(Console.ReadLine());

        // Testa uma condição de existência por vez
        if (a + b > c)
        {
            if (a + c > b)
            {
                if (b + c > a)
                {
                    // Se chegou aqui, é um triângulo válido. Agora classifica:
                    if (a == b)
                    {
                        if (b == c)
                        {
                            Console.WriteLine("Forma um triangulo Equilatero");
                        }
                        else
                        {
                            Console.WriteLine("Forma um triangulo Isosceles");
                        }
                    }
                    else if (a == c)
                    {
                        Console.WriteLine("Forma um triangulo Isosceles");
                    }
                    else if (b == c)
                    {
                        Console.WriteLine("Forma um triangulo Isosceles");
                    }
                    else
                    {
                        Console.WriteLine("Forma um triangulo Escaleno");
                    }
                }
                else
                {
                    Console.WriteLine("Os valores nao formam um triangulo");
                }
            }
            else
            {
                Console.WriteLine("Os valores nao formam um triangulo");
            }
        }
        else
        {
            Console.WriteLine("Os valores nao formam um triangulo");
        }
    }
}