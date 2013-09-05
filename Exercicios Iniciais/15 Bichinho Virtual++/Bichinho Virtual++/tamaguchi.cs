using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bichinho_Virtual__
{
    class Tamaguchi
    {
        /// <summary>
        /// Atributos da classe onde Fome, Saude e idade são inteiros para ser classificados em escala
        /// </summary>
        private string Nome;
        private int Fome;
        private int Saude;
        private int Idade;
        private int Humor;
        int Max = 100;
        int Min = 0;

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
        /// Função para alterar o nome
        /// </summary>
        /// <param name="entrada"></param>

        public void Altera_Nome(string entrada)
        {
            Nome = entrada;
        }

        /// <summary>
        /// Função para retornar o nome
        /// </summary>
        /// <returns></returns>
        public string Get_Nome()
        {
            return Nome;
        }




        /// <summary>
        /// Funcao para retornar A saude
        /// </summary>
        /// <returns></returns>
        public int get_Saude()
        {
            return Saude;
        }

        /// <summary>
        ///  Função para alterar a Fome, Mas só se estiver nos extremos
        /// </summary>
        public void Alimentar()
        {

           
                if (this.Fome == this.Max)
                {
                    Console.WriteLine("Tamaguchi 100 porcento Alimentado!!");
                    
                }
                else if (Fome == Min)
                {
                    Console.WriteLine("Com FOME, MUITA! DEATH!!!");

                }
                else
                {
                    this.Fome++;
                }
            
        }

        /// <summary>
        ///  Função para alterar a Fome, Mas só se estiver nos extremos
        /// </summary>
        public void Medicar()
        {


            if (this.Saude == this.Max)
            {
                Console.WriteLine("Tamaguchi 100 porcento Alimentado!!");

            }
            else if (Saude == Min)
            {
                Console.WriteLine("Com FOME, MUITA! DEATH!!!");

            }
            else
            {
                this.Saude++;
            }

        }

        /// <summary>
        /// Método para retornar a fome
        /// </summary>
        /// <returns></returns>
        public int get_Fome()
        {
            return Fome;
        }


        /// <summary>
        /// Método para HUMOR
        /// </summary>
        /// <param name="fome"></param>
        /// <param name="saude"></param>
        /// <returns></returns>
        public int Cal_Humor(int fome, int saude)
        {
            Humor = (fome + saude) / 2;
            return Humor;
        }

        /// <summary>
        /// Método para brincar com o bicho
        /// </summary>
        /// <param name="entrada"></param>
        public void BrincarBicho()
        {


                if (Humor == Max)
                {
                    Console.WriteLine("Pronto! ja estou feliz!!");
                    
                } else if (Humor == Min)
                {
                    Console.WriteLine("Estou Triste!!");
                }
                else
                {
                    Humor++;
                }
            
            
        }
        /// <summary>
        /// Método para retornar Humor
        /// </summary>
        /// <returns></returns>
        public int getHumor()
        {
            return Humor;
        }
    }
}
