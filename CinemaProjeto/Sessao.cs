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
        public float preco { get; set; }

        public Sala Sala { get; set; }

        public Sessao()
        {

        }
    }
}
