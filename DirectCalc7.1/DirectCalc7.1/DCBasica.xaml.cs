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

namespace DirectCalc7
{
    public partial class DCBasica : PhoneApplicationPage
    {
        List<char> calculo = new List<char>();
        StringBuilder cal = new StringBuilder();
        
        public DCBasica()
        {
            InitializeComponent();
        }
        private void mostrarCalc()
        {
            char
            c = calculo.Last<char>();
            cal.Append(c).Append("");
            
            string s = string.Join("",calculo.ToArray());
            txtExpressao.Text = s;
        }
        private void bt0_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('0');
           /* s = string.Join("",calculo.ToArray());
            txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void btPt_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('.');
           /* s = string.Join("", calculo.ToArray());
            txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void btIgual_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('1');
            /*s = string.Join("", calculo.ToArray());
            txtExpressao.Text = s;
*/
            mostrarCalc();
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('2');
           /* s = string.Join("", calculo.ToArray());
            txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('3');
            /*s = string.Join("", calculo.ToArray());
            txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void btDiv_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('/');
            /*s = string.Join("", calculo.ToArray());
             txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('4');
            /*s = string.Join("", calculo.ToArray());
                txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('5');
            /*s = string.Join("", calculo.ToArray());
                txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('6');
            /*s = string.Join("", calculo.ToArray());
                txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void btMult_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('x');
            /*s = string.Join("", calculo.ToArray());
                txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('7');
            /*s = string.Join("", calculo.ToArray());
                txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('8');
            /*s = string.Join("", calculo.ToArray());
                txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('9');
            /*s = string.Join("", calculo.ToArray());
                txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void btMin_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('-');
            /*s = string.Join("", calculo.ToArray());
                txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void btAbrepar_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('(');
            /*s = string.Join("", calculo.ToArray());
                txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void btFechapar_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add(')');
            /*s = string.Join("", calculo.ToArray());
                txtExpressao.Text = s;*/
            mostrarCalc();
        }

        private void btMais_Click(object sender, RoutedEventArgs e)
        {
            calculo.Add('+');
            /*s = string.Join("", calculo.ToArray());
                txtExpressao.Text = s;*/
            mostrarCalc();
        }

    }
}