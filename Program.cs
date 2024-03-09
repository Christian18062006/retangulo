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
            //usando a classe//
            Retangulo retangulo1 = new Retangulo();
            retangulo1.altura=altura;
            retangulo1.largura = largura;
            double area1 = retangulo1.calculaArea();
            double perimetro1 = retangulo1.calculaPerimetro();
            double diagonal1 = retangulo1.calculaDiagonal();
            Console.WriteLine(area1.ToString("F2"));
            Console.WriteLine(perimetro1.ToString("F2"));
            Console.WriteLine(diagonal1.ToString("F2"));

        }
    }
}
