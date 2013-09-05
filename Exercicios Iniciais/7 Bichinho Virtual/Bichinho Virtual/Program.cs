using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bichinho_Virtual
{
    class program
    {
        static void Main(string[] args)
        {
            // Padrao inicial do tamaguchi.. Com nome andre
            // Fome 2, saude 5, idade 1 e humor 5
            Tamaguchi tamaguchi = new Tamaguchi("Andre", 2, 5, 1, 5);
            Console.WriteLine("Seu bichinho é: " + tamaguchi.Nome );
            Console.WriteLine("Tem :" + tamaguchi.Fome + "de fome");
            Console.WriteLine("Tem :" + tamaguchi.Saude + "de saude");
            Console.WriteLine("Tem :" + tamaguchi.Idade + "de idade");
            Console.WriteLine("Tem :" + tamaguchi.Cal_Humor() + "de Humor");
            
            
            Console.WriteLine("Entre com um novo nome:");
            tamaguchi.Nome = Console.ReadLine();

            tamaguchi.Saude_Melhora();
            Console.WriteLine("Seu tamaguchi foi curado");
            
            tamaguchi.Alimentar();
            Console.WriteLine("Seu tamaguchi foi alimentado");


            Console.WriteLine("Então o seu tamaguchi se chama" + tamaguchi.Nome);           
            Console.WriteLine("Agora a saude dele é: " + tamaguchi.Saude);
            Console.WriteLine("Agora a fome dele é: " + tamaguchi.Fome);
            Console.WriteLine("Então o seu humor é:" + tamaguchi.Cal_Humor());
            Console.ReadKey();
        }
    }
}
