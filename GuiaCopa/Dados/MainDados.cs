using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace GuiaCopa.Dados
{
    public class ConnectionToDatabase : DataContext
    {
        public Table<Estadio> dados;

        public static string DBConnectionString = "Data Source=isostore:/Database.sdf";

        public ConnectionToDatabase(string connectionString)
            : base(connectionString)
        {

        }
    }

    public class MainData : INotifyPropertyChanged
    {
        private ConnectionToDatabase connection;
        private ObservableCollection<Estadio> ListaEstadios;

        public ObservableCollection<Estadio> listaEstadios
        {
            get
            {
                return ListaEstadios;
            }
            set
            {
                if (ListaEstadios != value)
                {
                    ListaEstadios = value;
                    NotifyPropertyChanged("listaEstadios");
                }
            }
        }

        public MainData()
        {
            connection = new ConnectionToDatabase(ConnectionToDatabase.DBConnectionString);
            if (connection.DatabaseExists() == false)
            {
                connection.CreateDatabase();
            }

            QueryDados();
        }

        private void QueryDados()
        {
            var resultado = from Estadio item in connection.dados
                            orderby item.ID ascending
                            select item;

            listaEstadios = new ObservableCollection<Estadio>(resultado);
        }

        public void AdicionarEstadio(Estadio novoEstadio)
        {
            connection.dados.InsertOnSubmit(novoEstadio);
            connection.SubmitChanges();

            QueryDados();
        }

        #region NotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
