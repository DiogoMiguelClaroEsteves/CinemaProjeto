﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaProjeto
{
    internal class Pessoa
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Morada { get; set; }

        public Funcionario Funcionario { get; set; }
        public Cliente Cliente { get; set; }
        public Pessoa()
        {

        }
    }
}
