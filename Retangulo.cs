using System;

namespace Exercicio1.Models
{
    internal class Retangulo
    {
        public double largura;
        public double altura;

        public Retangulo(double largura, double altura)
        {
            this.largura = largura;
            this.altura = altura;
        }

        public double area()
        {
            return largura * altura;
        }

        public double perimetro()
        {
            return 2 * (largura + altura);
        }

        public double diagonal()
        {
            double diagonal = (largura * largura) + (altura * altura);
            return Math.Sqrt(diagonal) ;
        }
    }
}
