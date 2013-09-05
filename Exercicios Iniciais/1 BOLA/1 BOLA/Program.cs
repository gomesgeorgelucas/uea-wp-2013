using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BOLA
{
    class Program
    {
        static void Main(string[] args)
        {
            Bola bola = new Bola("Branco", 10, "Plastico");
            bola.MostrarCor();
            bola.TrocarCor("Azul");
            bola.MostrarCor();
            Console.ReadKey();
        }
    }
}
