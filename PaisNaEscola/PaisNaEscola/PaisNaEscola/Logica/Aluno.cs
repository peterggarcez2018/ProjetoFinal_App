using System;
using System.Collections.Generic;
using System.Text;

namespace PaisNaEscola.Logica {
    class Aluno {
        public string nome;
        public string matricula;
        public int turma; 
        public string responsavel;
        public string senha;


        public Aluno(string nome, string matricula, int turma, string responsavel, string senha)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.turma = turma;
            this.responsavel = responsavel;
            this.senha = senha; 
        }

    }
}
