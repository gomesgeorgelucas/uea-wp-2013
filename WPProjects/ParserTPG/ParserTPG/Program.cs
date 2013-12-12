using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyPG;

namespace ParserTPG
{
    class Program
    {
        public Program()
        {
        
        
        }
        
        static void Main(string[] args)
        {
            // create the scanner to use
            Scanner scanner = new Scanner(); 

            // create the parser, and supply the scanner it should use
            Parser parser = new Parser(scanner); 
            
            // define the input for the parser
            string input = "2-*3";

            // parse the input. the result is a parse tree.
            ParseTree tree = parser.Parse(input);

            // evaluate the parse tree; do not pass any additional parameters
            object result = tree.Eval(null);

            // write the result of the evaluation to the console:
            Console.WriteLine("result: " + result.ToString());

            Console.Read();


        }
    }
}
