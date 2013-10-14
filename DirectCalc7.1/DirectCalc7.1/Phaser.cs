﻿using System;
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
        

        private double[] _numeros;

        public double[] numeros
        {
            get { return _numeros; }
            set { _numeros = value; }
        }
        

         private String _flutuante;

        public String flutuante
        {
            get { return _flutuante; }
            set { _flutuante = value; }
        }
        
        private String _inteiro1;

        public String inteiro1
        {
            get { return _inteiro1; }
            set { _inteiro1 = value; }
        }
        private String _inteiro2;

        public String inteiro2
        {
            get { return _inteiro2; }
            set { _inteiro2 = value; }
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

        Token tnum,toper;
        double a,b=0;
        int c = 0;
        public void tokenaizer(string msg)
        {
            
        //  inteiros(msg);
           
           /* inteiro1 = "2";
            inteiro1 = inteiro1 + "5" +"2"+ "1";
            inteiro2 = "2";
            foreach (char l in inteiro1)
            {
                if (l == '2' )
                {
                    inteiro1 = inteiro1.Remove(0, 1);
                }
            } 
            a = double.Parse(inteiro1);
            b = double.Parse(inteiro2);
            resultado = a * b;*/
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
                        flutuante = flutuante + ".";/// Caso encontrar um ponto é acrescentado a outra string um ponto
                        msg = msg.Remove(0,1);/// e removido esse item
                        flutuantes(msg,flutuante);/// e é enviado a mensagem restante com a string que representa o ponto flutuante
                        break;
                    case 'x':
                        tnum.numero = double.Parse(inteiro1);/// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        expressao.Add(tnum);                        
                        msg = msg.Remove(0,1);/// é removido esse item
                        toper.operador = 'x';
                        expressao.Add(toper);/// Acrescenta o operador especifico para essa operação no vetor de operadores
                        break;
                    case '/':
                        tnum.numero = double.Parse(inteiro1);/// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        expressao.Add(tnum);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        toper.operador = '/';
                        expressao.Add(toper);/// Acrescenta o operador especifico para essa operação no vetor de operadores
                        break;
                    case '+':
                        tnum.numero = double.Parse(inteiro1);/// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        expressao.Add(tnum);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        toper.operador = '+';
                        expressao.Add(toper);/// Acrescenta o operador especifico para essa operação no vetor de operadores
                        break;
                    case '-':
                        tnum.numero = double.Parse(inteiro1);/// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        expressao.Add(tnum);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        toper.operador = '-';
                        expressao.Add(toper);/// Acrescenta o operador especifico para essa operação no vetor de operadores
                        break;
                    case '(':
                        tnum.numero = double.Parse(inteiro1);/// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        expressao.Add(tnum);                        
                        msg = msg.Remove(0,1);/// é removido esse item
                        toper.operador = '(';
                        expressao.Add(toper);/// Acrescenta o operador especifico para essa operação no vetor de operadores
                        break;
                    case ')':
                        tnum.numero = double.Parse(inteiro1);/// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        expressao.Add(tnum);                        
                        msg = msg.Remove(0,1);/// é removido esse item
                        toper.operador = ')';
                        expressao.Add(toper);/// Acrescenta o operador especifico para essa operação no vetor de operadores
                        break;                    
                    default:
                        inteiro1 =  inteiro1.Remove(0);
                        break;   
                }
            }
        }
        public void flutuantes(string msg, string flutuante)
        {
            c = 0;
            foreach (char item in msg)
            {            
                switch (item)
                {
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
                        flutuante = flutuante + item;
                        msg = msg.Remove(0,c);
                        break;
                    case 'x':
                        tnum.numero = double.Parse(flutuante);/// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        expressao.Add(tnum);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        toper.operador = 'x';
                        expressao.Add(toper);/// Acrescenta o operador especifico para essa operação no vetor de operadores
                        break;
                    case '/':
                        tnum.numero = double.Parse(flutuante);/// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        expressao.Add(tnum);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        toper.operador = '/';
                        expressao.Add(toper);/// Acrescenta o operador especifico para essa operação no vetor de operadores
                        break;
                    case '+':
                        tnum.numero = double.Parse(flutuante);/// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        expressao.Add(tnum);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        toper.operador = '+';
                        expressao.Add(toper);/// Acrescenta o operador especifico para essa operação no vetor de operadores
                        break;
                    case '-':
                        tnum.numero = double.Parse(flutuante);/// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        expressao.Add(tnum);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        toper.operador = '-';
                        expressao.Add(toper);/// Acrescenta o operador especifico para essa operação no vetor de operadores
                        break;
                    case '(':
                        tnum.numero = double.Parse(flutuante);/// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        expressao.Add(tnum);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        toper.operador = '(';
                        expressao.Add(toper);/// Acrescenta o operador especifico para essa operação no vetor de operadores
                        break;
                    case ')':
                        tnum.numero = double.Parse(flutuante);/// Caso entrar uma multiplicaçao é feito o parse do inteiro lido até o momento e acrescentado a uma posição distinta do vetor de numeros
                        expressao.Add(tnum);
                        msg = msg.Remove(0, 1);/// é removido esse item
                        toper.operador = ')';
                        expressao.Add(toper);/// Acrescenta o operador especifico para essa operação no vetor de operadores
                        break;
                    default:
                        break;
                }
                c++;
            }
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