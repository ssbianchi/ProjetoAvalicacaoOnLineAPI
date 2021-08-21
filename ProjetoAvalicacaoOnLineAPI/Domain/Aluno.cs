﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAvalicacaoOnLineAPI.Domain
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Step { get; set; }

        public DateTime DataCriacao { get; set; }

    }
}