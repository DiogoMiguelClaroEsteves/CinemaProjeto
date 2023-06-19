using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjeto
{
    internal class Filme
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Duracao { get; set; }
        public bool Activo { get; set; }
        public string Categoria { get; set; }
        public Sessao Sessao { get; set; }

        internal List<Filme> Filmes;


        public Filme()
        {
            Filmes = new List<Filme>();
        }

        public void EditarFilme(string novoNome, bool novoAtivo, string novoDuracao, string novoCategoria)
        {
            using (var db = new CinemaContext())
            {
                // Obtém a sala do contexto do banco de dados
                Filme filmeDoBanco = db.Filmes.FirstOrDefault(s => s.ID == ID);

                if (filmeDoBanco != null)
                {
                    // Atualiza os dados da sala com os novos valores
                    filmeDoBanco.Nome = novoNome;
                    //filmeDoBanco.Duracao = novaDuracao;
                    filmeDoBanco.Activo = novoAtivo;

                    filmeDoBanco.Duracao = novoDuracao;

                    filmeDoBanco.Categoria = novoCategoria;
                    // Salva as alterações no banco de dados
                    db.SaveChanges();
                }
            }

            // Atualiza os dados da sala localmente
            Nome = novoNome;
            Duracao = novoDuracao;
            Categoria = novoCategoria;
        }

        public void RemoverFilme(Filme filme)
        {
            using (var db = new CinemaContext())
            {
                // Obtém a sala do contexto do banco de dados
                Filme filmeDoBanco = db.Filmes.FirstOrDefault(f => f.ID == filme.ID);

                if (filmeDoBanco != null)
                {
                    // Remove a sala do contexto do banco de dados
                    db.Filmes.Remove(filmeDoBanco);

                    // Salva as alterações no banco de dados
                    db.SaveChanges();
                }
            }

            // Remove a sala da lista local
            Filmes.Remove(filme);
        }
        
        public override string ToString()
        {
            return $"Filme: {Nome}  \t Duração: {Duracao} \t Exibição: {Activo} \t Categoria: {Categoria}";
        }
    }
}
