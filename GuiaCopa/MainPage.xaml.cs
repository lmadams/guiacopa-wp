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
        private string caminhoIconeSelecionado;

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

            NavigationService.Navigate(new Uri("/EstadioInfo.xaml?estadioSelecionado=" + ((MainLongListSelector.SelectedItem as Estadio).ID - 1),
                UriKind.Relative));

            MainLongListSelector.SelectedItem = null;
        }

        private void adicionarEstadio(object sender, RoutedEventArgs e)
        {
            Estadio novoEstadio = new Estadio()
            {
                Nome = nomeTextBox.Text,
                Cidade = cidadeTextBox.Text,
                Descricao = descricaoTextBox.Text,
                CaminhoImagem = caminhoIconeSelecionado
            };

            App.bancoDeDados.AdicionarEstadio(novoEstadio);
        }

        private void Icone1Seleted(object sender, System.Windows.Input.MouseButtonEventArgs e) 
        {
            caminhoIconeSelecionado = "/Imagens/gremio.jpg";
        }

        private void Icone2Seleted(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            caminhoIconeSelecionado = "/Imagens/maracana.jpg";
        }

        private void Icone3Seleted(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            caminhoIconeSelecionado = "/Imagens/arruda.jpg";
        }
    }
}