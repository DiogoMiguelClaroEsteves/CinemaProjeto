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
        public TimeSpan Duracao { get; set; }
        public bool Activo { get; set; }

        public Sessao Sessao { get; set; }

        public Filme()
        {

        }
    }
}
