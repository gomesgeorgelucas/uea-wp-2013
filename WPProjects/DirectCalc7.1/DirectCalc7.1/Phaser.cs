using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectCalc7._1
{
    /// <summary>
    /// Classe de parsing da expressão entrada pelo usuário.
    /// </summary>
    class Phaser
    {
        public Phaser()
        {
        }
                        
        private String _inteiro1;

        public String inteiro1
        {
            get { return _inteiro1; }
            set { _inteiro1 = value; }
        }        

        private String _resultado;

        public String resultado
        {
            get { return _resultado; }
            set { _resultado = value; }
        }

        List<double> numeros = new List<double>();
        List<string> operadores = new List<string>();

        //double[] numeros = new double[2];
        
        int c = 0;
        
        public void tokenaizer(string msg)
        {
            resultado = "";
            operadores.Add("(");
            numeros.Add(0);
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
                        numeros.Add(double.Parse(inteiro1));//faz o parse e adiciona na lista de numeros
                        inteiro1 = inteiro1.Remove(0,inteiro1.Length);//remove o numero em forma de string
                        operadores.Add("x");//insere o operador especifico da funcao
                        msg = msg.Remove(0,1);/// é removido esse item
                        c = c + 1;
                        break;
                    case '/':
                        numeros.Add(double.Parse(inteiro1));//faz o parse e adiciona na lista de numeros
                        inteiro1 = inteiro1.Remove(0, inteiro1.Length);//remove o numero em forma de string
                        operadores.Add("/");//insere o operador especifico da funcao
                        msg = msg.Remove(0, 1);/// é removido esse item
                        c = c + 1;
                        break;
                    case '+':
                        if (_inteiro1 == null)
                        {
                            inteiro1 = "0";
                        }
                            numeros.Add(double.Parse(inteiro1));//faz o parse e adiciona na lista de numeros
                            inteiro1 = inteiro1.Remove(0, inteiro1.Length);//remove o numero em forma de string
                            operadores.Add("+");//insere o operador especifico da funcao
                            msg = msg.Remove(0, 1);/// é removido esse item
                            c = c + 1;                        
                        if (operadores[operadores.Count - 1] == "x")
                        {
                            operadores[operadores.Count - 1] = "+";
                        }
                        if (operadores[operadores.Count - 1] == "/")
                        {
                            operadores[operadores.Count - 1] = "+";
                        }
                        break;
                    case '-':
                        if (_inteiro1 == "")
                        {
                            inteiro1 = "0";
                        }
                            numeros.Add(double.Parse(inteiro1));//faz o parse e adiciona na lista de numeros
                            inteiro1 = inteiro1.Remove(0, inteiro1.Length);//remove o numero em forma de string
                            operadores.Add("-");//insere o operador especifico da funcao
                            msg = msg.Remove(0, 1);/// é removido esse item
                            c = c + 1;                      
                        if (operadores[operadores.Count - 1] == "x")
                        {
                            operadores[operadores.Count - 1] = "-";
                        }
                        if (operadores[operadores.Count - 1] == "/")
                        {
                            operadores[operadores.Count - 1] = "-";
                        }
                        break;
                    case '(':
                        if (_inteiro1 == null)
                        {
                            inteiro1 = "0";
                        }
                        numeros.Add(double.Parse(inteiro1));
                        numeros.Add(0);
                        inteiro1 = inteiro1.Remove(0, inteiro1.Length);//remove o numero em forma de string
                            operadores.Add("(");//insere o operador especifico da funcao
                            msg = msg.Remove(0, 1);/// é removido esse item
                            c = c + 1;
                        
                        break;
                    case ')':
                        if (_inteiro1 == null)
                        {
                            inteiro1 = "0";
                        }
                            numeros.Add(double.Parse(inteiro1));//faz o parse e adiciona na lista de numeros
                            inteiro1 = inteiro1.Remove(0, inteiro1.Length);//remove o numero em forma de string
                            operadores.Add(")");//insere o operador especifico da funcao
                            msg = msg.Remove(0, 1);/// é removido esse item
                            c = c + 1;                        
                        break;                    
                    default:
                        if (numeros.Count == 0)
                        {
                            numeros.Add(0);
                        }
                        else
                        {
                            numeros.Add(double.Parse(inteiro1));
                            operadores.Add(")");
                            //numeros[c] = double.Parse(inteiro1);
                            msg = msg.Remove(0, 1);
                            inteiro1 = inteiro1.Remove(0, inteiro1.Length);
                            c = 0;
                        }
                        break;   
                }
            }
          //  resultado = numeros[0] * numeros[1];            
            resultado = resolver().ToString();
            numeros.Clear();
            operadores.Clear();
        }

        public double resolver()
        {
            double resposta;
            resposta = 0;
            int indice1=0, indice2=0;
            if (verificarParenteses(operadores))
            {
                foreach (string s in operadores)
                {
                    if (s == "(")
                    {
                        indice1 = operadores.IndexOf(s);
                    }
                    if (s == ")")
                    {
                        indice2 = operadores.IndexOf(s);
                        resolveparenteses(indice1, indice2);
                        break;
                    }
                }
            }
            resposta = numeros[0];
            return resposta;   
        }

        public void resolveparenteses(int index1,int index2)
        {
            multiplicar(index1, index2);
            dividir(index1, index2);
            somar(index1, index2);
            subtrair(index1, index2);
            numeros.Remove(index1);
            operadores.RemoveAt(index1);
            operadores.RemoveAt(index1);
            resolver();
        }

        public bool verificarParenteses(List<string> oper)
        {
            bool par = true;
            int delimita = 0;
            foreach (string s in oper)
            {
                if (s == "(")
                {
                    par = false;
                    delimita++;
                }
                if (s == ")")
                {
                    delimita--;
                }
                if (delimita == 0)
                {
                    par = true;
                }
                if (!par)
                {
                    resultado = "Erro dos parenteses";
                }
            }
            return par;
        }
        public int[] reorganizar(int[] numeros, int index)
        {
            for (int i = index; i < numeros.Length; i++)
            {
                numeros[index] = numeros[index + 1];
            }
            return numeros;
        }

             
    }
}