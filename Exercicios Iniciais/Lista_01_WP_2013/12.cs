using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    class Conta
    {
        //Instance variables and getters and setters
        private string _nome;

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        
        private int _numero;

        public int numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        private double _saldo;

        public double saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        private double _taxaJuros;

        public double taxaJuros
        {
            get { return _taxaJuros; }
            set { _taxaJuros = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="saldo"></param>
        /// <param name="taxaJuros"></param>
        public Conta(double saldo, double taxaJuros)
        {
            this.saldo = saldo;
            this.taxaJuros = taxaJuros;
        }

        /// <summary>
        /// 
        /// </summary>
        public void adicionaJuros()
        {
            this.saldo = this.saldo * (this.taxaJuros / 100);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Conta myConta = new Conta(1000, 10);

            myConta.adicionaJuros();
            myConta.adicionaJuros();
            myConta.adicionaJuros();
            myConta.adicionaJuros();
            myConta.adicionaJuros();

            System.Console.WriteLine(myConta.saldo);

            
        }
    }
        
}