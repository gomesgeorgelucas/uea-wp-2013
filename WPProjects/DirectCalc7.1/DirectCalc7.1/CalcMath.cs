using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DirectCalc7._1
{   
    /// <summary>
    /// Classe de operações matemáticas para a calculadora.
    /// </summary>
    class CalcMath
    {
        /// <summary>
        /// Construtor da classe CalcMath
        /// </summary>
        public CalcMath()
        {
        
        }

        public void multiplicar(int de, int ate)
        {
            for (int i = de; i < ate; i++)
            {
                if (operadores[i] == "x")
                {
                    numeros[i] = numeros[i] * numeros[i + 1];
                    numeros.Remove(numeros[i + 1]);
                    operadores.Remove(operadores[i]);
                }
            }
        }
        public void dividir(int de, int ate)
        {
            for (int i = de; i < ate; i++)
            {
                if (operadores[i] == "/")
                {
                    numeros[i] = numeros[i] / numeros[i + 1];
                    numeros.Remove(numeros[i + 1]);
                    operadores.Remove(operadores[i]);
                }
            }
        }
        public void somar(int de, int ate)
        {
            for (int i = de; i < ate; i++)
            {
                if (operadores[i] == "+")
                {
                    numeros[i] = numeros[i] + numeros[i + 1];
                    numeros.Remove(numeros[i + 1]);
                    operadores.Remove(operadores[i]);
                }
            }
        }
        public void subtrair(int de, int ate)
        {
            for (int i = de; i < ate; i++)
            {
                if (operadores[i] == "-")
                {
                    numeros[i] = numeros[i] - numeros[i + 1];
                    numeros.Remove(numeros[i + 1]);
                    operadores.Remove(operadores[i]);
                }
            }
        }

    }


}
