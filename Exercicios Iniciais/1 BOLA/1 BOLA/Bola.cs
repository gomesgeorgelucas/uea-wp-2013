using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_BOLA
{
    class Bola
    {

        // Variaveis da Bola
        private string Cor{get; set;}
        private string Material { get; set; }
        private double Circurferencia { get; set; }


        /// <summary>
        /// Metodo para trocar a cor 
        /// </summary>
        /// <param name="entrada"></param>

        public void TrocarCor(string entrada)
        {
            Cor = entrada;
        }


        /// <summary>
        /// Método para mostrar a cor
        /// </summary>
        public void MostrarCor()
        {
            Console.WriteLine("A cor é:" + Cor);
        }
        /// <summary>
        /// Método construtor da classe.
        /// </summary>
        /// <param name="cor"></param>
        /// <param name="diametro"></param>
        /// <param name="material"></param>
        public Bola(string cor, double diametro, string material)
        {
            Cor = cor;
            Circurferencia = diametro;
            Material = material;
        }
    }
}
