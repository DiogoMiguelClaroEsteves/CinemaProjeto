using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjeto
{
    internal class Bilhete
    {
        public int ID { get; set; }
        public int Lugar { get; set; }
        public bool Estado { get; set; }
        public Sessao Sessao { get; set; }
        public Cliente Cliente { get; set; }
        public Funcionario Funcionario { get; set; }

        public Bilhete()
        {

        }
    }
}
