using System;

namespace Retângulo
{
    class Program
    {
static void Main(string[] args)
        {
            double altura;
            double largura;
            Console.WriteLine("Retângulo");
            Console.WriteLine("Digite a altura do retângulo.");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a largura do retângulo.");
            largura = double.Parse(Console.ReadLine());
Retangulo retangulo1 = new Retangulo();
            retangulo1.altura=altura;
            retangulo1.largura = largura;
            double area retangulo1.calculaArea();
            double perimetro = retangulo1.calculaPerimetro();
            double diagonal = retangulo1.calculaDiagonal();
            Console.WriteLine(area.ToString("F2"));
            Console.WriteLine(perimetro.ToString("F2"));
            Console.WriteLine(diagonal.ToString("F2"));

        }
    }
}
