using System;

namespace DIO.Musicas
{
        public class Musica : EntidadeBase
        {
        private string titulo;
        private string descricao;

        //Atributos
        private Genero genero { get; set; }
            private string nomeMusica { get; set; }
            private int ano { get; set; }
            private string banda { get; set; }
            private bool excluido { get; set; }
            

            // Métodos
            public Musica(int id, Genero genero, string nomeMusica, string banda, int ano, string titulo, string descricao)
            {
                this.Id = id;
                this.genero = genero;
                this.nomeMusica = nomeMusica;
                this.banda = banda;
                this.ano = ano;
                this.excluido = false;
            }

        public Musica(int id, Genero genero, string titulo, int ano, string descricao)
        {
            Id = id;
            this.genero = genero;
            this.titulo = titulo;
            this.ano = ano;
            this.descricao = descricao;
        }

        public override string ToString()
            {
                string retorno = "";
                retorno += "Gênero: " + this.genero + Environment.NewLine;
                retorno += "Nome da Música: " + this.nomeMusica + Environment.NewLine;
                retorno += "Banda: " + this.banda + Environment.NewLine;
                retorno += "Ano de Lançamento: " + this.ano + Environment.NewLine; 
                retorno += "Excluído: " + this.excluido;
                return retorno;
            }

            public string retornanomeMusica()
                {
                    return this.nomeMusica;
                }

            public int retornaId()
                {
                    return this.Id;
                }
             public bool retornaExcluido()
                {
                    return this.excluido;
                }

            public void Excluir()
                {
                    this.excluido = true;
                }
        }
}