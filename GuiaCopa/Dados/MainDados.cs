using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaCopa.Dados
{
    public class MainData
    {
        public ObservableCollection<Estadio> listaEstadios { get; private set; }

        public MainData()
        {
            listaEstadios = new ObservableCollection<Estadio>();
        }
    }
}
