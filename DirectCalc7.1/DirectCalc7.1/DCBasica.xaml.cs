using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Text;
using DirectCalc7._1;

namespace DirectCalc7
{
    public partial class DCBasica : PhoneApplicationPage
    {
        /// <summary>
        ///     Interface da calculadora
        /// </summary>
      // propriedade do diaplay da calculadora
        private String _displayMsg;

	    public String displayMsg
	    {
	    	get { return _displayMsg;}
	    	set {
                    _displayMsg = value;
            }
	    }

        private String _resposta;

        public String resposta
        {
            get { return _resposta; }
            set { _resposta = value; }
        }
        

        Phaser verificador = new Phaser();

        public DCBasica()
        ///Inicializador da calculadora
        {
            InitializeComponent();
           
        }

        private void mostrarCalc(String displayMsg)
        {
        /// mostra a string no display de acompanhamento da expressão
            txtExpressao.TextWrapping = TextWrapping.Wrap;//evita que a string ulttrapasse o textBlock
            txtExpressao.Visibility = System.Windows.Visibility.Visible;//mostra o exedente da string abaixo
            txtExpressao.TextAlignment = TextAlignment.Right;//alinha a string a direita do textBlock
            txtExpressao.Text = displayMsg;//mostra o que tem na string no textBlock
        }

        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o número 0
            displayMsg = displayMsg + "0";
            mostrarCalc(displayMsg);
        }

        private void btPt_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o ponto
            displayMsg = displayMsg + ".";
            mostrarCalc(displayMsg);
        }

        private void btIgual_Click(object sender, RoutedEventArgs e)
        {
            verificador.tokenaizer(displayMsg);
            btResultado.Text = verificador.resultado.ToString();
            displayMsg = displayMsg.Remove(0);
            mostrarCalc(displayMsg);
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o número 1
            displayMsg = displayMsg + "1";
            mostrarCalc(displayMsg);
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o número 2
            displayMsg = displayMsg + "2";
            mostrarCalc(displayMsg);
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o número 3
            displayMsg = displayMsg + "3";
            mostrarCalc(displayMsg);
        }

        private void btDiv_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o operador de divisão
            displayMsg = displayMsg + "/";
            mostrarCalc(displayMsg);
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o número 4
            displayMsg = displayMsg + "4";
            mostrarCalc(displayMsg);
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o número 5
            displayMsg = displayMsg + "5";
            mostrarCalc(displayMsg);
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o número 6
            displayMsg = displayMsg + "6";
            mostrarCalc(displayMsg);
        }

        private void btMult_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o operador de multiplicação
            displayMsg = displayMsg + "x";
            mostrarCalc(displayMsg);
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o número 7
            displayMsg = displayMsg + "7";
            mostrarCalc(displayMsg);
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o número 8
            displayMsg = displayMsg + "8";
            mostrarCalc(displayMsg);
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o número 9
            displayMsg = displayMsg + "9";
            mostrarCalc(displayMsg);
        }

        private void btMin_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o operador de subtração
            displayMsg = displayMsg + "-";
            mostrarCalc(displayMsg);
        }

        private void btAbrepar_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o caractere de prioridade abre parenteses
            displayMsg = displayMsg + "(";
            mostrarCalc(displayMsg);
        }

        private void btFechapar_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o caractere de prioridade fecha parenteses
            displayMsg = displayMsg + ")";
            mostrarCalc(displayMsg);
        }

        private void btMais_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para o operador de adição
            displayMsg = displayMsg + "+";
            mostrarCalc(displayMsg);
        }

        private void btAC_Click(object sender, RoutedEventArgs e)
        {
            ///Botão para apagar o ultimo acrescimo a string
            displayMsg = displayMsg.Remove(displayMsg.Length - 1);
            mostrarCalc(displayMsg);
        }

        private void btResultado_ManipulationStarted(object sender, System.Windows.Input.ManipulationStartedEventArgs e)
        {
            AbrePagina("/DCBasica.xaml");
        }
        private void AbrePagina(string destino)
        {
            NavigationService.Navigate(new Uri(destino, UriKind.Relative));
        }

    }
}