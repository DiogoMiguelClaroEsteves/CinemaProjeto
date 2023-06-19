using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjeto
{
    internal class Sessao
    {
        public int ID { get; set; }
        public DateTime DataHora { get; set; }
        public string preco { get; set; }

        internal List<Sessao> Sessaos;
        public Sala Sala { get; set; }

        public Sessao()
        {
            Sessaos = new List<Sessao>();
        }

        public void EditarSessao(DateTime novoDataHora, string novoPreco)
        {
            using (var db = new CinemaContext())
            {
                // Obtém a sala do contexto do banco de dados
                Sessao sessaoDoBanco = db.Sessoes.FirstOrDefault(s => s.ID == ID);

                if (sessaoDoBanco != null)
                {
                    // Atualiza os dados da sala com os novos valores
                    sessaoDoBanco.DataHora = novoDataHora;
                    sessaoDoBanco.preco = novoPreco;

                    // Salva as alterações no banco de dados
                    db.SaveChanges();
                }
            }

            // Atualiza os dados da sala localmente
            DataHora = novoDataHora;
            preco = novoPreco;
        }

        public void RemoverSessao(Sessao sessao)
        {
            using (var db = new CinemaContext())
            {
                // Obtém a sala do contexto do banco de dados
                Sessao sessaoDoBanco = db.Sessoes.FirstOrDefault(s => s.ID == sessao.ID);

                if (sessaoDoBanco != null)
                {
                    // Remove a sala do contexto do banco de dados
                    db.Sessoes.Remove(sessaoDoBanco);

                    // Salva as alterações no banco de dados
                    db.SaveChanges();
                }
            }

            // Remove a sala da lista local
            Sessaos.Remove(sessao);
        }
        public override string ToString()
        {
            return $"Data e hora: {DataHora}  \t Preco: {preco} €";
        }
    }
}
