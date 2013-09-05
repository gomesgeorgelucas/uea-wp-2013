using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Fazenda
    {
       
        List<Bicho> MeusBichos = new List<Bicho>(); //Lista de bichos
        int contsatisfeitos = 0;        //Qtde de bichos satisfeitos
        int contfelicidade = 0;         //Qtde de bichos felizes
        bool todosAlimentados = false;  //Variavel que parti do principio que todos os bichos nao foram alimentados 
        bool todosFelizes = false;      //Variavel que parti do principio que todos os bichos nao estao felizes

        /// <summary>
        /// Método CriarBicho - Cria um bicho dentro da lista
        /// </summary>
        public void CriarBicho()
        {
            this.MeusBichos.Add(new Bicho());
        }

        /// <summary>
        /// Retorna a quantidade de elementos da lista
        /// </summary>
        /// <returns></returns>
        public int RetornaQtde()
        {
             return this.MeusBichos.Count;
        }

        /// <summary>
        /// Alimentar Bicho - Percorre toda a lista e chama o método alimentar o bicho 
        /// Enquanto todos nao forem alimentados retornará false
        /// quando todos forem alimentados direitinho retornará true
        /// </summary>
        public bool AlimentarBichos()
        {
          

            foreach (Bicho bicho in MeusBichos)
            {
                int qtde = RetornaQtde();
                
                bool estado;
                estado = bicho.AlimentarBicho();
                if (estado == true)
                {
                    contsatisfeitos++;    
                }
                if ( contsatisfeitos == qtde)
                {
                    todosAlimentados = true;
                }
              
            }

            return todosAlimentados;
        }
        /// <summary>
        /// BrincarBicho -  Segue a mesma ideia do método alimentar,
        /// Verifica primeiro o estado de cada bicho e coloca dentro de uma variavel contadora
        /// Se a quantidade de bichos for igual a quantidade de bichos satisfeitos
        /// A variavel todosFelizes recebe true. e o método retorna isso.
        /// </summary>
        public bool BrincarBichos()
        {
            foreach (Bicho bicho in MeusBichos)
            {
                int qtde = RetornaQtde();
                bool estado;
                estado = bicho.BrincarBicho();
                if(estado == true)
                {
                    contfelicidade++;
                }
                if (contfelicidade == qtde)
                {
                    todosFelizes = true;
                }
            }
            return todosFelizes;
        }

        /// <summary>
        /// EscutarBicho -  Segue a mesma ideia do método de brincar,
        /// Verifica primeiro o estado de cada bicho e coloca dentro de uma variavel contadora
        /// Se a quantidade de bichos for igual a quantidade de bichos satisfeitos
        /// A variavel todosFelizes recebe true. e o método retorna isso.
        /// </summary>
        public bool EscutarBichos()
        {
            foreach (Bicho bicho in MeusBichos)
            {
                int qtde = RetornaQtde();
                bool estado;
                estado = bicho.EscutarBicho();
                if (estado == true)
                {
                    contfelicidade++;
                }
                if (contfelicidade == qtde)
                {
                    todosFelizes = true;
                }
            }
            return todosFelizes;
        }
    }
}
