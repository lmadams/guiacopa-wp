using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaCopa.Dados
{
    public class Estadio : INotifyPropertyChanged
    {
        private int id;
        private string nome;
        private string cidade;
        private Uri caminhoImagem;
        private string descricao;

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value != id)
                {
                    id = value;
                    NotifyPropertyChanged("ID");
                }
            }
        }

        public string Cidade
        {
            get
            {
                return cidade;
            }
            set
            {
                if (value != cidade)
                {
                    cidade = value;
                    NotifyPropertyChanged("Cidade");
                }
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                if (value != nome)
                {
                    nome = value;
                    NotifyPropertyChanged("Nome");
                }
            }
        }

        public Uri Imagem
        {
            get
            {
                return caminhoImagem;
            }
            set
            {
                if (value != caminhoImagem)
                {
                    caminhoImagem = value;
                    NotifyPropertyChanged("Imagem");
                }
            }
        }

        public string Descricao
        {
            get
            {
                return descricao;
            }
            set
            {
                if (value != descricao)
                {
                    descricao = value;
                    NotifyPropertyChanged("Descricao");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
