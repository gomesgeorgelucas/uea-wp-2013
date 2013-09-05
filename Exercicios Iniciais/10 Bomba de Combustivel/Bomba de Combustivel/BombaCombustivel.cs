using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombaCombustivel
{
    class BombaCombustivel
    {
        private string tipoCombustivel;
        private float valorLitro, quantidadeCombustivel;

        /// <summary>
        /// Construtor da Bomba de Combustivel
        /// </summary>
        public BombaCombustivel(){
		
		
		
		Console.WriteLine("\tValores Iniciais\t");
		Console.WriteLine("Tipo de combustível: ");
		this.tipoCombustivel = Console.ReadLine();
		Console.WriteLine("Valor por litro: ");
		this.valorLitro = float.Parse(Console.ReadLine());
           
		Console.WriteLine("Quantidade de combustível na bomba: ");
		this.quantidadeCombustivel = float.Parse(Console.ReadLine());	
		
	}

        String getTipoCombustivel()
        {
            return this.tipoCombustivel;
        }

        /// <summary>
        /// Seta o tipo de Combustivel
        /// </summary>
        /// <param name="tipo"></param>
        public void setTipoCombustivel(String tipo)
        {
            this.tipoCombustivel = tipo;
        }

        /// <summary>
        /// Retorna o Valor do livro
        /// </summary>
        /// <returns></returns>
       public float getValorLitro()
        {
            return this.valorLitro;
        }

        /// <summary>
        /// Seta o valor do Litro
        /// </summary>
        /// <param name="valor"></param>
        public void setValorLitro(float valor)
        {
            this.valorLitro = valor;
        }

        /// <summary>
        /// Get a Quantidade de Combustivel
        /// </summary>
        /// <returns></returns>
       public float getQuantidadeCombustivel()
        {
            return this.quantidadeCombustivel;
        }

        /// <summary>
        /// Seta a quantidade de Combustivel
        /// </summary>
        /// <param name="quantidade"></param>
      public  void setQuantidadeCombustivel(float quantidade)
        {
            this.quantidadeCombustivel = quantidade;
        }

        /// <summary>
        /// Função da opção de Abastecer por litro
        /// </summary>
       public void AbastecerPorValor(){
		
		float valor, quantidadeAbastecida;
		
		
		Console.WriteLine("Valor a ser abastecido: ");
		valor = float.Parse(Console.ReadLine()); 
		
		quantidadeAbastecida = valor/valorLitro;
		
		if(this.quantidadeCombustivel > quantidadeAbastecida){
			AlterarQuantidadeCombustivel(quantidadeAbastecida);
			
			Console.WriteLine("Valor abastecido: " + quantidadeAbastecida);	
		}else{
			Console.WriteLine("Não existe combustivel suficiente");
		}
	}

        /// <summary>
        /// Método para abastecer Por litro
        /// </summary>
       public void AbastecerPorLitro(){
		
		float litro, valorPagar;
		
		
		
		Console.WriteLine("Quantidade de litros a ser abastecido ");
		litro = float.Parse(Console.ReadLine()); 
		
		valorPagar = litro/valorLitro;
		if(this.quantidadeCombustivel > litro){
			AlterarQuantidadeCombustivel(litro);
			
			Console.WriteLine("Valor a pagar: R$" + valorPagar);	
		}else{
			Console.WriteLine("Não existe combustivel suficiente");
		}
		
		
	}

        /// <summary>
        /// Altera o Valor do litro
        /// </summary>
        public void AlterarValor(){
		
		
		
		Console.WriteLine("Novo valor de combustivel: ");
		this.valorLitro = float.Parse(Console.ReadLine());
		
	}

        /// <summary>
        /// Altera o tipo de Combustivel
        /// </summary>
        public void AlterarCombustivel(){
		
		
		
		Console.WriteLine("Novo valor de combustivel: ");
		this.tipoCombustivel = Console.ReadLine();
		
	}

        /// <summary>
        /// Altera a Quantidade de Combustivel
        /// </summary>
        /// <param name="litros"></param>
        public void AlterarQuantidadeCombustivel(float litros)
        {

            this.quantidadeCombustivel -= litros;
        }
	


    }

}
