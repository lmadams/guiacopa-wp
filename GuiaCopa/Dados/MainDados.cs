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
            listaEstadios.Add(new Estadio() { 
                ID = 0, Nome = "Maracanã", 
                Descricao = "Estádio Jornalista Mário Filho, mais conhecido como Maracanã, o popular Maraca (\"semelhante a um chocalho\" em tupi-guarani, devido ao som de pássaros que viviam por ali[8]), é um estádio de futebol localizado na Zona Norte do Rio de Janeiro e inaugurado em 1950, durante o mandato do então General de Divisão e Prefeito do Distrito Federal do Rio de Janeiro Marechal Ângelo Mendes de Moraes, tendo sido utilizado na Copa do Mundo de Futebol daquele ano.", 
                Cidade = "Rio de Janeiro", 
                Imagem = new Uri("/Imagens/maracana.jpg", UriKind.Relative) 
            });
            listaEstadios.Add(new Estadio() { 
                ID = 1, 
                Nome = "Mané Garrincha",
                Descricao = "Estádio Mané Garrincha, também conhecido como Marechal Hermes, ou anteriormente, Estádio Glorioso de Marechal Hermes, foi um antigo estádio de futebol do Botafogo de Futebol e Regatas no bairro de Deodoro, na zona norte da cidade do Rio de Janeiro.", 
                Cidade = "Brasília", 
                Imagem = new Uri("/Imagens/maneGarrincha.jpg", UriKind.Relative) 
            });
            listaEstadios.Add(new Estadio() { 
                ID = 2, Nome = "Morumbi",
                Descricao = "O Estádio Cícero Pompeu de Toledo, mais conhecido como Estádio do Morumbi, é um estádio construído para receber partidas de futebol, sendo a sede oficial do time brasileiro de futebol São Paulo Futebol Clube, já tendo recebido a Seleção Brasileira em várias ocasiões. O Morumbi é o maior estádio particular do país. Localiza-se na praça Roberto Gomes Pedrosa, nº 1, em São Paulo[4].", 
                Cidade = "São Paulo", 
                Imagem = new Uri("/Imagens/morumbi.jpg", UriKind.Relative) 
            });

            listaEstadios.Add(new Estadio() { 
                ID = 3, 
                Nome = "Castelão",
                Descricao = "O Estádio Governador Plácido Castelo, também conhecido como Arena Castelão, ou simplesmente Castelão, é um estádio de futebol brasileiro localizado em Fortaleza, Ceará, e inaugurado em 1973.", 
                Cidade = "Fortaleza", 
                Imagem = new Uri("/Imagens/castelao.jpg", UriKind.Relative) 
            });
            listaEstadios.Add(new Estadio() { 
                ID = 4, 
                Nome = "Mineirão",
                Descricao = "O Estádio Governador Magalhães Pinto, mais conhecido como Mineirão, é um estádio de futebol localizado em Belo Horizonte, Minas Gerais, Brasil. Inaugurado em 1965, é o quinto maior estádio do Brasil, já tendo sediado cinco finais da Copa Libertadores, uma Copa Intercontinental e escolhido como uma das sedes da Copa do Mundo FIFA de 2014", 
                Cidade = "Minas Gerais", 
                Imagem = new Uri("/Imagens/mineirao.jpg", UriKind.Relative) 
            });
            listaEstadios.Add(new Estadio() { 
                ID = 5, Nome = "Arruda",
                Descricao = "O Estádio José do Rego Maciel (conhecido popularmente como Colosso do Arruda ou ainda Mundão do Arruda) é um estádio de futebol localizado em Recife, estado de Pernambuco, Brasil. Pertencente ao Santa Cruz Futebol Clube, tem atualmente capacidade para 60.044 espectadores.", 
                Cidade = "Pernambuco", 
                Imagem = new Uri("/Imagens/arruda.jpg", UriKind.Relative) 
            });

            listaEstadios.Add(new Estadio() { 
                ID = 6, 
                Nome = "Arena do Grêmio",
                Descricao = "A Arena do Grêmio é um estádio multiuso localizado na cidade de Porto Alegre, Brasil. É a casa do Grêmio Foot-Ball Porto Alegrense.", 
                Cidade = "Porto Alegre", 
                Imagem = new Uri("/Imagens/gremio.jpg", UriKind.Relative) 
            });
            listaEstadios.Add(new Estadio() { 
                ID = 7, 
                Nome = "Parque do Sabiá",
                Descricao = "O Estádio Municipal Parque do Sabiá, que por muitos anos levou o nome de Estádio Municipal João Havelange, é um estádio multiuso localizado na Zona Leste da cidade de Uberlândia", 
                Cidade = "Uberlândia", 
                Imagem = new Uri("/Imagens/sabia.jpg", UriKind.Relative) 
            });
            listaEstadios.Add(new Estadio() { 
                ID = 8, 
                Nome = "Albertão",
                Descricao = "O Estádio Governador Alberto Tavares Silva, ou simplesmente Albertão, é o maior estádio de futebol do Piauí, e o terceiro maior do Nordeste. I", 
                Cidade = "Teresina", 
                Imagem = new Uri("/Imagens/albertao.jpg", UriKind.Relative) 
            });
        }
    }
}
