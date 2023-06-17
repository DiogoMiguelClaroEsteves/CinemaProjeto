using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjeto
{
    internal class Categoria
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public bool activa { get; set; }
        public Filme Filme { get; set; }
        public Categoria()
        {

        }
    }
}
