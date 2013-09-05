using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Fazenda fazenda = new Fazenda(); //Cria a fazenda
            int escolha = 1;
            while (escolha == 1)        //Entra no primeiro painel
            {
                Console.WriteLine("Aperte 1 para criar bicho");
                Console.WriteLine("Aperte outro para administrar a fazenda");
                string entrada = Console.ReadLine();
                escolha = Convert.ToInt32(entrada);
                if (escolha == 1)
                {
                    fazenda.CriarBicho();
                    Console.WriteLine("Voce agora tem:" + fazenda.RetornaQtde() + " Bichos");
                }
                else
                {
                    break;
                }
            }// Fim do primeiro painel
                escolha = 1;
                while (escolha != 0)        //Entra no segundo Painel
                {
                    bool todosalimentados, todosfelizes; // Variaveis para receber os resultados dos metodos 
                    // Entra com as escolhas do usuario para administrar a fazenda
                    Console.WriteLine("Entre com 1 para Alimentar os bichos");
                    Console.WriteLine("Entre com 2 para brincar com os bichos");
                    Console.WriteLine("Entre com 3 para brincar com os bichos");
                    Console.WriteLine("Entre com 0 para sair do programa");
                   string entrada = Console.ReadLine();
                    escolha = Convert.ToInt32(entrada);

                    // Caso escolha alimentar os bichos
                    if (escolha == 1)
                    {
                       todosalimentados = fazenda.AlimentarBichos();
                       if (todosalimentados == true)                //Se todos estiverem Defidamente alimentados
                           Console.WriteLine("Todos devidamente alimentados!");
                       else
                           Console.WriteLine("Ainda tem bicho com fome :/, tente denovo");
                    }
                    // Caso escolha Brincar os bichos
                    if (escolha == 2)
                    {
                        todosfelizes = fazenda.BrincarBichos();
                        if (todosfelizes == true)        //Se todos estiverem defidamente felizes
                            Console.WriteLine("Todos estão alegres!!");
                        else
                            Console.WriteLine("Ainda tem animal entediado, tente denovo!");
                    }

                    // Caso escolha escutar os bichos
                    if (escolha == 3)
                    {
                        todosfelizes = fazenda.EscutarBichos();
                        if (todosfelizes == true)        //Se todos estiverem defidamente felizes
                            Console.WriteLine("Todos estão alegres!!");
                        else
                            Console.WriteLine("Ainda tem animal entediado, tente denovo!");
                    }
                }//Fim do segundo Painel
            }//Fim da classe Main()
        }
    }

