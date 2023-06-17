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

        public Cinema Cinema { get; set; }
            
        public Sala(string nome, decimal colunas, decimal filas)
        {
            Nome = nome;
            Colunas = colunas;
            Filas = filas;
        }

        public override string ToString()
        {
            decimal Lugares = Colunas * Filas;
            return $"{Nome} | {Lugares}";
        }
    }
}
