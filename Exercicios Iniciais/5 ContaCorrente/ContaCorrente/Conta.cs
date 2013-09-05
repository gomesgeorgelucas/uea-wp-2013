using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    class Conta
    {
        //Atributos da classe!
        private string Nome;
        private int NConta;
        public int Saldo { get; set; }

        /// <summary>
        /// Função que altera o nome
        /// </summary>
        /// <param name="entrada"></param>
        public void AlteraNome(string entrada)
        {
            Nome = entrada;
        }

        /// <summary>
        /// Método para depositar dinheiro
        /// </summary>
        /// <param name="entrada"></param>
        public void Deposito(int entrada)
        {
            Saldo = Saldo + entrada;
            Console.WriteLine("Foi depositado:" + entrada);

        }

        
        /// <summary>
        /// Função de saque, que só será disponivel se o saldo for positivo antes da operação 
        /// </summary>
        /// <param name="entrada"></param>

        public void Saque(int entrada)
        {
            if (Saldo < 0)
            {
                Console.WriteLine("Saque indisponivel! Conta Negativa!");
            }
            else
            {
                Saldo = Saldo - entrada;
            }
        }

        
        /// <summary>
        ///  Construtor onde só passa o nome do usuário e o numero da conta
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="numero"></param>

        public Conta(string nome, int numero)
        {
            Nome = nome;
            NConta = numero;
            Saldo = 0;
        }

        /// <summary>
        /// Construtor onde passa o nome do usuário, o numero da conta e o Saldo inicial
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="numero"></param>
        /// <param name="saldo"></param>
         public Conta(string nome, int numero, int saldo)
        {
            Nome = nome;
            NConta = numero;
            Saldo = saldo;
        }

        public string getNome()
         {
             return Nome;
         }
    }
}
