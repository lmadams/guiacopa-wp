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
            PopulaEstadios();
        }

        private void PopulaEstadios()
        {
            listaEstadios.Add(new Estadio() { ID = 0, Nome = "Maracanã", Descricao = "Tem capacidade para 78.838", Cidade = "Rio de Janeiro", Imagem = new Uri("/Imagens/maracana.jpg", UriKind.Relative) });
            listaEstadios.Add(new Estadio() { ID = 1, Nome = "Mané Garrincha", Descricao = "Tem capacidade para 72.788", Cidade = "Brasília", Imagem = new Uri("/Imagens/maneGarrincha.jpg", UriKind.Relative) });
            listaEstadios.Add(new Estadio() { ID = 2, Nome = "Morumbi", Descricao = "Tem capacidade para 72.039", Cidade = "São Paulo", Imagem = new Uri("/Imagens/morumbi.jpg", UriKind.Relative) });

            listaEstadios.Add(new Estadio() { ID = 3, Nome = "Castelão", Descricao = "Tem capacidade para 63.903", Cidade = "Fortaleza", Imagem = new Uri("/Imagens/castelao.jpg", UriKind.Relative) });
            listaEstadios.Add(new Estadio() { ID = 4, Nome = "Mineirão", Descricao = "Tem capacidade para 61.846", Cidade = "Minas Gerais", Imagem = new Uri("/Imagens/mineirao.jpg", UriKind.Relative) });
            listaEstadios.Add(new Estadio() { ID = 5, Nome = "Arruda", Descricao = "Tem capacidade para 60.044", Cidade = "Pernambuco", Imagem = new Uri("/Imagens/arruda.jpg", UriKind.Relative) });

            listaEstadios.Add(new Estadio() { ID = 6, Nome = "Arena do Grêmio", Descricao = "Tem capacidade para 55.662", Cidade = "Porto Alegre", Imagem = new Uri("/Imagens/gremio.jpg", UriKind.Relative) });
            listaEstadios.Add(new Estadio() { ID = 7, Nome = "Parque do Sabiá", Descricao = "Tem capacidade para 53.350", Cidade = "Uberlândia", Imagem = new Uri("/Imagens/sabia.jpg", UriKind.Relative) });
            listaEstadios.Add(new Estadio() { ID = 8, Nome = "Albertão", Descricao = "Tem capacidade para 52.296", Cidade = "Teresina", Imagem = new Uri("/Imagens/albertao.jpg", UriKind.Relative) });
        }
    }
}
