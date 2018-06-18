using System;
using System.Collections.Generic;
using System.Text;

namespace PaisNaEscola.Logica {
    class Professor {
        public string nome, disciplina, matricula, senha;
        public int turma;

        public Professor(string nome, string disciplina, string matricula, string senha, int turma)
        {
            this.nome = nome;
            this.disciplina = disciplina;
            this.matricula = matricula;
            this.senha = senha;
            this.turma = turma; 
        }
    }
}
