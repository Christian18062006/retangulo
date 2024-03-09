using System;

namespace Retângulo
{
    class Program
    {
        public static double calculaDiagonal(double altura, double largura)
        {
            double multiplicaAltura = altura * altura;
            double multiplicaLargura = largura * largura;
            double resultado = multiplicaAltura + multiplicaLargura;
            double diagonal = Math.Sqrt(resultado);
            return (diagonal);
        }
        public static double CalculaPerimetro(double altura, double largura)
        {
            double perimetro = (altura+largura)*2;
            return (perimetro);
        }
        public static double calcula_area(double altura, double largura)
        {
            double area = altura * largura;
            return (area);
        }
        static void Main(string[] args)
        {
            double altura;
            double largura;
            Console.WriteLine("Retângulo");
            Console.WriteLine("Digite a altura do retângulo.");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("digite a largura do retângulo.");
            largura = double.Parse(Console.ReadLine());
            double area=calcula_area(altura, largura);
            Console.WriteLine(area.ToString("F2"));
            double perimetro = CalculaPerimetro(altura, largura);
            Console.WriteLine(perimetro.ToString("F2"));
            double diagonal = calculaDiagonal(altura, largura);
            Console.WriteLine(diagonal.ToString("F2"));
        }
    }
}
