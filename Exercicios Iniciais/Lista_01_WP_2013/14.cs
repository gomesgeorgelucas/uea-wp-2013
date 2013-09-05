using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_01_WP_2013
{
    class NovoFuncionario
    {
        private string _nome;

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private double _salario;

        public double salario
        {
            get { return _salario; }
            set { _salario = value; }
        }

        public NovoFuncionario(string nome, double salario)
        {
            this.nome = nome;
            this.salario = salario;
        }

        public void aumentarSalario(double percentualDeAumento)
        {
            this.salario = this.salario * ((percentualDeAumento / 100) + 1);
        }
        
        public void Main(String[] args)
        {
            List<NovoFuncionario> lista = new List<NovoFuncionario>();
            
            NovoFuncionario f1 = new NovoFuncionario("Minha", 222.2);
            NovoFuncionario f2 = new NovoFuncionario("Benga", 222.2);
            NovoFuncionario f3 = new NovoFuncionario("Porra", 222.2);
            lista.Add(f1);
            lista.Add(f2);
            lista.Add(f3);
            System.Console.WriteLine(f1.nome + f1.salario);
        }
    }
}