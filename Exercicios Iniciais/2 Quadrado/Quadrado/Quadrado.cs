using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadrado
{
    class Quadrado
    {
        //Variavel Lado
        private int Lado { get; set; }


        /// <summary>
        /// Metodo mudar de lado - Que passa como parametro uma entrada e seta Lado
        /// </summary>
        /// <param name="entrada"></param>

        public void MudarLado(int entrada)
        {
            Lado = entrada;
        }

        /// <summary>
        /// Metodo RetornarValor - Retorna o valor do lado
        /// </summary>
        /// <returns></returns>

        public int RetornarValor()
        {
            return Lado;
        }

        /// <summary>
        /// Método para o calculo da area do quadrado
        /// </summary>
        /// <param name="lado"></param>
        /// <returns></returns>
        public int CalcularArea()
        {
            int area;
            area = Lado * Lado;
            return area;

        }
        /// <summary>
        /// Método construtor da classe
        /// </summary>
        /// <param name="lado"></param>
        public Quadrado(int lado)
        {
            Lado = lado;
        }

    }
}
