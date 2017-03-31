using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using GuiaCopa.Resources;
using GuiaCopa.Dados;

namespace GuiaCopa
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            DataContext = App.bancoDeDados;
        }

        private void EstadoSelecionado(object sender, SelectionChangedEventArgs e)
        {
            if (MainLongListSelector.SelectedItem == null)
            {
                return; 
            }

            NavigationService.Navigate(new Uri("/EstadioInfo.xaml?estadioSelecionado=" + (MainLongListSelector.SelectedItem as Estadio).ID,
                UriKind.Relative));

            MainLongListSelector.SelectedItem = null;
        }
    }
}