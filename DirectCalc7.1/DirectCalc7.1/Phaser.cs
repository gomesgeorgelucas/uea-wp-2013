using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectCalc7._1
{
    class Token
    {
        public Token()
        { }
        private double _numeros;

        public double numero
        {
            get { return _numeros; }
            set { _numeros = value; }
        }

        private char _operador;

        public char operador
        {
            get { return _operador; }
            set { _operador = value; }
        }
    }

    class Phaser
    {
        public Phaser()
        {
        }
        private char[] _operadores;

        public char[] operadores
        {
            get { return _operadores; }
            set { _operadores = value; }
        }
                
        private String _inteiro1;

        public String inteiro1
        {
            get { return _inteiro1; }
            set { _inteiro1 = value; }
        }        

        private double _resultado;

        public double resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }

        private List<Token> _expressao;

        public List<Token> expressao
        {
            get { return _expressao; }
            set { _expressao = value; }
        }

        private Token _tnum;

        public Token tnum
        {
            get { return _tnum; }
            set { _tnum = value; }
        }

        private Token _toper;

        public Token toper
        {
            get { return _toper; }
            set { _toper = value; }
        }

        double[] numeros = new double[2];
        String operadores;
        int c = 0;
        public void tokenaizer(string msg)
        {
            resultado = 0;
          inteiros(msg);          
        }

        
        public void inteiros(string msg)
        {
            foreach (char item in msg)
            {                                
            switch (item)
                {/// Verifica todos os numeros inteiros na mensagem
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        inteiro1 = inteiro1 + item;/// Caso for digito é acrescentado a uma outra string
                        msg = msg.Remove(0,1);/// entao esse item é removido
                        break;
                    case '.':
                        inteiro1 = inteiro1 + ".";/// Caso encontrar um ponto é acrescentado a outra string um ponto
                        msg = msg.Remove(0,1);/// e removido esse item
                        break;
                    case 'x':
                        numeros[c] = double.Parse(inteiro1);// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        inteiro1 = inteiro1.Remove(0,inteiro1.Length);
                        msg = msg.Remove(0,1);/// é removido esse item
                        c = c + 1;
                        break;
                    case '/':
                        numeros[c] = double.Parse(inteiro1);// Caso entrar uma divisao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        inteiro1 = inteiro1.Remove(0, inteiro1.Length);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        c = c + 1;
                        break;
                    case '+':
                        numeros[c] = double.Parse(inteiro1);// Caso entrar uma soma é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        inteiro1 = inteiro1.Remove(0, inteiro1.Length);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        c = c + 1;
                        break;
                    case '-':
                        numeros[c] = double.Parse(inteiro1);// Caso entrar uma subtracao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        inteiro1 = inteiro1.Remove(0, inteiro1.Length);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        c = c + 1;
                        break;
                    case '(':
                        numeros[c] = double.Parse(inteiro1);// Caso entrar um abre parenteses é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros               
                        inteiro1 = inteiro1.Remove(0, inteiro1.Length);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        c = c + 1;
                        break;
                    case ')':
                        numeros[c] = double.Parse(inteiro1);// Caso entrar um fecha parenteses é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        inteiro1 = inteiro1.Remove(0, inteiro1.Length);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        c = c + 1;
                        break;                    
                    default:
                        numeros[c] = double.Parse(inteiro1);
                        msg = msg.Remove(0, 1);
                        inteiro1 = inteiro1.Remove(0, inteiro1.Length);
                        c = 0;
                        break;   
                }
            }
            resultado = numeros[0] * numeros[1];
            //resolver(expressao);
            
        }
        
        public int[] reorganizar(int[] numeros, int index)
        {
            for (int i = index; i < numeros.Length; i++)
            {
                numeros[index] = numeros[index + 1];
            }
            return numeros;
        }

        public double multiplicar(double multiplicado, double multiplicador)
        { return (multiplicado * multiplicador); }
        public double dividir(double divisor, double dividendo)
        { return (divisor / dividendo); }
        public double somar(double num1, double num2)
        { return (num1 + num2); }
        public double subtrair(double num1, double num2)
        { return (num1 - num2); }

        public void resposta(int[] numeros, char[] operdores)
        {

        }
    }
}