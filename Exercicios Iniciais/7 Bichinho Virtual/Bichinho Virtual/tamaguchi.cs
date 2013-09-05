using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bichinho_Virtual
{
    class Tamaguchi
    {
        /// <summary>
        /// Atributos da classe onde Fome, Saude e idade são inteiros para ser classificados em escala
        /// </summary>
        public string Nome {get; set;}
        public int Fome { get; set; }
        public int Saude { get; set; }
        public int Idade { get; set; }
        public int Humor;

           /// <summary>
        /// Construtor de tamaguchi
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="fome"></param>
        /// <param name="saude"></param>
        /// <param name="idade"></param>
        /// <param name="humor"></param>
        public Tamaguchi(string nome, int fome, int saude, int idade, int humor)
        {
            Nome = nome;
            Fome = fome;
            Saude = saude;
            Idade = idade;
            Humor = humor;
        }


    
         /// <summary>
        ///  Função para alterar a Fome, Mas só se estiver nos extremos
        /// </summary>
        public void Alimentar()
        {
            int Max = 100;
            int Min = 0;

            if (Fome == Max)
            {
                Console.WriteLine("Tamaguchi 100 porcento Alimentado!!");
            }
            else if (Fome == Min)
            {
                Console.WriteLine("Com FOME, MUITA! DEATH!!!");

            }
            else
            {
                Fome++;
            }
        }

        /// <summary>
        ///  Função para alterar a Fome, Mas só se estiver nos extremos
        /// </summary>
        public void Saude_Melhora()
        {
            int Max = 100;
            int Min = 0;

            if (Saude == Max)
            {
                Console.WriteLine("Tamaguchi 100 porcento Alimentado!!");
            }
            else if (Saude == Min)
            {
                Console.WriteLine("Com FOME, MUITA! DEATH!!!");

            }
            else
            {
                Saude++;
            }
        }


        /// <summary>
        /// Método para HUMOR
        /// </summary>
        /// <param name="fome"></param>
        /// <param name="saude"></param>
        /// <returns></returns>
        public int Cal_Humor()
        {
            Humor = (Fome + Saude) / 2;
            return Humor;
        }
    }
}
