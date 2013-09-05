using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado(10);
          int area =  quadrado.CalcularArea();
            Console.WriteLine(area);
            quadrado.MudarLado(5);
            area = quadrado.CalcularArea();
            Console.WriteLine(area);
            int valor = quadrado.RetornarValor();
            Console.WriteLine(valor);
            Console.ReadKey();
        }
    }
}
