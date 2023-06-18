using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjeto
{
    internal class Sala
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public decimal Colunas { get; set; }
        public decimal Filas { get; set; }

        internal List<Sala> Salas;

        public Cinema Cinema { get; set; }

        public Sala()
        {
            Salas = new List<Sala>();
        }

        public void EditarSala(string novoNome, decimal novasColunas, decimal novasFilas)
        {
            using (var db = new CinemaContext())
            {
                // Obtém a sala do contexto do banco de dados
                Sala salaDoBanco = db.Salas.FirstOrDefault(s => s.ID == ID);

                if (salaDoBanco != null)
                {
                    // Atualiza os dados da sala com os novos valores
                    salaDoBanco.Nome = novoNome;
                    salaDoBanco.Colunas = novasColunas;
                    salaDoBanco.Filas = novasFilas;

                    // Salva as alterações no banco de dados
                    db.SaveChanges();
                }
            }

            // Atualiza os dados da sala localmente
            Nome = novoNome;
            Colunas = novasColunas;
            Filas = novasFilas;
        }

        public void RemoverSala(Sala sala)
        {
            using (var db = new CinemaContext())
            {
                // Obtém a sala do contexto do banco de dados
                Sala salaDoBanco = db.Salas.FirstOrDefault(s => s.ID == sala.ID);

                if (salaDoBanco != null)
                {
                    // Remove a sala do contexto do banco de dados
                    db.Salas.Remove(salaDoBanco);

                    // Salva as alterações no banco de dados
                    db.SaveChanges();
                }
            }

            // Remove a sala da lista local
            Salas.Remove(sala);
        }



        public override string ToString()
        {
            int totalLugares = (int)(Colunas * Filas);
            return $"Sala: {Nome}  \t\t\t Número de Lugares: {totalLugares}";
        }
    }
}
