using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace GuiaCopa.Dados
{
    [Table]
    public class Estadio : INotifyPropertyChanged
    {
        #region id
        private int id;

        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
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
        #endregion

        #region cidade
        private string cidade;

        [Column]
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
        #endregion

        #region nome
        private string nome;

        [Column]
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
        #endregion

        #region imagem
        private string caminhoImagem;
        
        [Column]
        public string CaminhoImagem
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
                    NotifyPropertyChanged("CaminhoImagem");
                }
            }
        }
        #endregion

        private Uri imagem;

        public Uri Imagem
        {
            get
            {
                return imagem;
            }
            set
            {
                if (value != imagem)
                {
                    imagem = value;
                    NotifyPropertyChanged("Imagem");
                }
            }
        }

        #region descricao
        private string descricao;

        [Column]
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
        #endregion

        #region NotifyProperty
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
