using System;
using System.Collections.Generic;
using System.Text;

namespace Retângulo
{
    class Retangulo
    {
        public double altura;
        public double largura;
        public double calculaArea()
        {
            double area = altura * largura;
            return (area);
        }
        public double calculaPerimetro()
        {
            double perimetro = (altura + largura) * 2;
            return (perimetro);
        }
        public double calculaDiagonal()
        {
            double alturaQuadrado = altura * altura;
            double larguraQuadrado = largura * largura;
            double resultadoSoma = alturaQuadrado + larguraQuadrado;
            double diagonal = Math.Sqrt(resultadoSoma);
            return (diagonal);
        }
    }
}
