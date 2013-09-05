using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funcionario.Funcionario
{
    class Funcionario
    {
        private string nome;

        public string _nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private double salario;

        public double _salario
        {
            get { return salario; }
            set { salario = value; }
        }
        public Funcionario(string nome, double salario)
        {
            this._nome = nome;
            this._salario = salario;
        }
        
    }
    class Programa
    {
        public void Main(String[] args)
        {
            List<Funcionario> lista = new List<Funcionario>();
            Funcionario f1 = new Funcionario("Minha", 222.2);
            Funcionario f2 = new Funcionario("Benga", 222.2);
            Funcionario f3 = new Funcionario("Porra", 222.2);
            lista.Add(f1);
            lista.Add(f2);
            lista.Add(f3);
            Console.WriteLine(f1._nome + f1._salario);
        }
    }
}
