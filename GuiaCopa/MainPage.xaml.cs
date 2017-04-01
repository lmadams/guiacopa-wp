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
            // Desafio 2
            if (string.IsNullOrEmpty(nomeTextBox.Text))
            {
                MessageBox.Show("Informe o nome?", "Erro", MessageBoxButton.OK);
                return;
            }
            if (string.IsNullOrEmpty(cidadeTextBox.Text))
            {
                MessageBox.Show("Informe a cidade?", "Erro", MessageBoxButton.OK);
                return;
            }
            if (string.IsNullOrEmpty(descricaoTextBox.Text))
            {
                MessageBox.Show("Informe a descrição?", "Erro", MessageBoxButton.OK);
                return;
            }
            if (string.IsNullOrEmpty(caminhoIconeSelecionado))
            {
                MessageBox.Show("Informe a imagem?", "Erro", MessageBoxButton.OK);
                return;
            }

            Estadio novoEstadio = new Estadio()
            {
                Nome = nomeTextBox.Text,
                Cidade = cidadeTextBox.Text,
                Descricao = descricaoTextBox.Text,
                CaminhoImagem = caminhoIconeSelecionado
            };

            App.bancoDeDados.AdicionarEstadio(novoEstadio);
            Pivot.SelectedIndex = 0;
        }

        private void IconeSeleted(object sender, System.Windows.Input.MouseButtonEventArgs e) 
        {
            Image img = (Image)sender;
            caminhoIconeSelecionado = ((System.Windows.Media.Imaging.BitmapImage)img.Source).UriSource.ToString();
        }
    }
}