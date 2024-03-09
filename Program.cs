using System;

namespace Retângulo
{
    class Program
    {
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
        }
    }
}
