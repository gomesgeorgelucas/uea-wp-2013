using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Bicho
    {
        private int Fome { get; set; }
        private int Tedio { get; set; }

        /// <summary>
        /// Construtor - Cria um novo bicho, e seta um numero aleatorio para fome e tedio
        /// </summary>
        public Bicho()
        {
            Random randomNumber = new Random();
           
            Fome = randomNumber.Next(10) + 1;
            Tedio = randomNumber.Next(10) + 1;


        }

        /// <summary>
        /// Método para alimentar individualmente cada bicho
        /// retornando true se o bicho estiver cheio, e false se nao tiver cheio.
        /// </summary>
        public bool AlimentarBicho()
        {
            bool cheio;
            if (Fome > 10)
            {
                cheio = true;
            }
            else
            {
                Fome++;
                cheio = false;
            }
            return cheio;
        }

        /// <summary>
        /// Brincar - Enquanto nao brincar 10 vezes, ele nao ficara feliz e retornará false
        /// </summary>
        /// <returns></returns>
        public bool BrincarBicho()
        {
            bool feliz;
            if (Tedio > 10)
            {
                feliz = true;
            }
            else
            {
                Tedio++;
                feliz = false;
            }
         return feliz;
        }
        
        /// <summary>
        /// Escutar - Enquanto nao brincar 10 vezes, ele nao ficara feliz e retornará false
        /// </summary>
        /// <returns></returns>
        public bool EscutarBicho()
        {
            bool feliz;
            if (Tedio > 10)
            {
                feliz = true;
            }
            else
            {
                Tedio++;
                feliz = false;
            }
            return feliz;
        }
    }
}
