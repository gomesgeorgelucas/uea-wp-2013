using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bichinho_Virtual__
{
    class Program
    {

        
        static void Main(string[] args)
        {
            int qtde;
            int entrada = 0;
            Boolean sair = true;
            // Padrao inicial do tamaguchi.. Com nome andre
            // Fome 2, saude 5, idade 1 e humor 5
            Tamaguchi tamaguchi = new Tamaguchi("Andre", 2, 5, 1, 5);


            Console.WriteLine("/BEM VINDO/");
            while (sair)
            {
                Console.WriteLine("Seu Tamaguchi:");
                Console.WriteLine("Nome:" + tamaguchi.Get_Nome());
                Console.WriteLine("Saude:" + tamaguchi.get_Saude());
                Console.WriteLine("Fome:" + tamaguchi.get_Fome());
                Console.WriteLine("Humor:" + tamaguchi.getHumor());
                Console.WriteLine(" ");
                Console.WriteLine("1 para mudar o nome ");
                Console.WriteLine("2 para Alimentar ");
                Console.WriteLine("3 para brincar");
                Console.WriteLine("4 para Medicar");
                Console.WriteLine("0 para Sair ");
                //Console.WriteLine(" ");
                entrada = int.Parse(Console.ReadLine());

                switch (entrada)
                {
                    case 1:
                        Console.WriteLine("Entre com o nome:");
                        tamaguchi.Altera_Nome(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Entre com a qtde de vezes q vc quer alimentar:");
                        qtde = int.Parse(Console.ReadLine());
                        while (qtde > 0)
                        {
                            tamaguchi.Alimentar();
                            qtde--;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Entre com a qtde de vezes q vc quer brincar:");
                        qtde = int.Parse(Console.ReadLine());
                        while (qtde > 0)
                        {
                            tamaguchi.BrincarBicho();
                            qtde--;
                        }
                        break;
                    case 4:
                        Console.WriteLine("Entre com a qtde de vezes q vc quer Medicar:");
                        qtde = int.Parse(Console.ReadLine());
                        while (qtde > 0)
                        {
                            tamaguchi.Medicar();
                            qtde--;
                        }
                        break;
                    case 0:
                        return;
                        
                    default:
                        Console.WriteLine("Opção nao existe!!");
                        break;
                }
            }    
       }
    }
}
