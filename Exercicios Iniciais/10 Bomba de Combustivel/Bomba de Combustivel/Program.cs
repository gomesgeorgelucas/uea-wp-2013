using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombaCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
		String tipoCombustivel;
		float valorLitro, quantidadeCombustivel;



        BombaCombustivel bomba = new BombaCombustivel();
		
		do{
			
			Console.WriteLine("\tMenu\t");
			Console.WriteLine("1 - Abastecer por valor");
			Console.WriteLine("2 - Abastecer por litro");
			Console.WriteLine("3 - Alterar valor do combustível");
			Console.WriteLine("4 - Alterar tipo de combustível");
			Console.WriteLine("5 - Sair");
            Console.WriteLine("Opção: ");
			
			opcao = Convert.ToInt32(Console.ReadLine());
			
			switch(opcao){
			
			case 1: bomba.AbastecerPorValor();
					break;
			case 2: bomba.AbastecerPorLitro();
					break;
			case 3: bomba.AlterarValor();
					break;
			case 4: bomba.AlterarCombustivel();
					break;
			}
		}while(opcao != 5);

        }
    }
}
