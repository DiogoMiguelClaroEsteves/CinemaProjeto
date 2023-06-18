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

        public Sala(string nome, decimal colunas, decimal filas)
        {
            Nome = nome;
            Colunas = colunas;
            Filas = filas;
            Salas = new List<Sala>();
        }

        public void EditarSala(string novoNome, decimal novasColunas, decimal novasFilas)
        {
            Nome = novoNome;
            Colunas = novasColunas;
            Filas = novasFilas;
        }

        public void RemoverSala(Sala sala)
        {
            if (Salas.Contains(sala))
            {
                Salas.Remove(sala);
            }
        }


        public override string ToString()
        {
            return $"Sala: {Nome}  \t\t\t Número de Lugares: {Colunas * Filas}";
        }
    }
}
