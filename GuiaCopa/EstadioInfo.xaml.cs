using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace GuiaCopa
{
    public partial class EstadioInfo : PhoneApplicationPage
    {
        public EstadioInfo()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (DataContext == null)
            {
                string selectedIndex = "";
                if (NavigationContext.QueryString.TryGetValue("estadioSelecionado", out selectedIndex))
                {
                    int index = int.Parse(selectedIndex);
                    DataContext = App.bancoDeDados.listaEstadios[index];
                }
            }
        }
    }
}