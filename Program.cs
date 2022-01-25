using Exercicio1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retang = new Retangulo(4, 9);

            

            Console.WriteLine("A área do triangulo é " + retang.area());
            Console.WriteLine("O perimeto do triangulo é " + retang.perimetro());
            Console.WriteLine("A diagonal do triangulo é "  +retang.diagonal());
        }
    }
}
