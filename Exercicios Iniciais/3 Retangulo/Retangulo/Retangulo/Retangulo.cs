using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Retangulo.Retangulo
{
    class Retangulo
    {
        public double Comprimento { get; set; }
        public double Altura { get; set; }
        public double ComprimentoDef { get; set; }
        public double AlturaDef { get; set; }

        public Retangulo(double Comprimento, double Altura)
        {
            this.ComprimentoDef = Comprimento;
            this.AlturaDef = Altura;
            this.Comprimento = Comprimento;
            this.Altura = Altura;
        }

        public Retangulo()
        { 
        }

        public void AlterarLados (double altura , double comprimento)
        {
            Altura = altura;
            Comprimento = comprimento;
        }
        public double CalcularArea()
        {
            return Altura * Comprimento;
        }

        public double CalculaPerimetro()
        {
            return 2 * (Altura + Comprimento);
        }
    }
    class Local : Retangulo
    {
        public Local(double alt, double bas)
        {
            this.AlturaDef = alt;
            this.ComprimentoDef = bas;
        }
        public Local()
        {
        }
    }
        class Programa
        {
        static void Main(String [] Args)
        { 
            string entrada1, entrada2;
            double maxret;
            Console.WriteLine("Entre com as medidas do local");
            entrada1 = Console.ReadLine();
            entrada2 = Console.ReadLine();
            Local loc = new Local(double.Parse(entrada1),double.Parse(entrada2));
            Console.WriteLine("Altere os lados");
            entrada1 = Console.ReadLine();
            entrada2 = Console.ReadLine();
            Retangulo ret = new Retangulo(1.0,1.0);
            maxret = (loc.Comprimento / ret.Comprimento)+(loc.Altura/ret.Altura)-1;
            Console.WriteLine("Total de retangulos" + maxret);
        }
    }
}
