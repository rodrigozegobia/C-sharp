using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Exercício1
{
    class Pessoa
    {
        private string nome;
        private int idade;

        //public Pessoa(string nome, int idade)    construtor
        //{
        //    this.nome = nome;
        //    this.idade = idade;
        //}

        public string getNome()
        {
            return nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
    }
}
