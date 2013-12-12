using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserLab
{
    class ExprParser
    {
        public List<string> expNumerals = new List<string>();
        public List<string> exprOperators = new List<string>();
        public List<string> SubExpr = new List<string>();
        
        public char[] operators = { '+', '-', 'x', '/' };
        public char[] numerals = {'0','1','2','3','4','5','6','7','8','9'};
        public ExprParser() {}

        public string[] getNumerals(String expr)
        {
            return expr.Split(operators);
        }

        public string[] getOperators(String expr)
        {
            return expr.Split(numerals);
        }

        public Boolean isValid(String expr)
        {
            if (expr.Split('(').Length != expr.Split(')').Length) //Quantidade de Parenteses
                return false;
            else if (expr.Split(operators).Length != ((expr.Split(numerals).Length) + 1)) //Qtd numeros deve ser igual a qtd de operadores mais 1
                return false;

            return false;
        }



    }
}
