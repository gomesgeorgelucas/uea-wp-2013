using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace DirectCalc7
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void AbrePagina(string destino)
        {
            NavigationService.Navigate(new Uri(destino, UriKind.Relative));
        }

        private void DCBasica_Click(object sender, RoutedEventArgs e)
        {
            AbrePagina("/DCBasica.xaml");
        }

    }
}