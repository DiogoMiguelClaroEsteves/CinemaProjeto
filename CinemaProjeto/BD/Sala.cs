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
        public int Colunas { get; set; }
        public int Filas { get; set; }

        public Cinema Cinema { get; set; }
            
        public Sala()
        {

        }
    }
}
