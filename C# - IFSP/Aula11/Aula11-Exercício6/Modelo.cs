using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Exercício6
{
    internal class Modelo
    {
        private string nome, sobrenome, titulacao, naturalidade, endereco, cidade, estado;
        private char sexo;
        private int idade;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public void setSexo(char sexo)
        {
            this.sexo = sexo;
        }
        public void setTitulacao(string titulacao)
        {
            this.titulacao = titulacao;
        }
        public void setNaturalidade(string naturalidade)
        {
            this.naturalidade = naturalidade;
        }
        public void setEndereco(string endereco)
        {
            this.endereco = endereco;
        }
        public void setCidade(string cidade)
        {
            this.cidade = cidade;
        }
        public void setEstado(string estado)
        {
            this.estado = estado;
        }
        public void setIdade(int idade)
        {
            this.idade = idade;
        }
        
        public string getNome()
        {
            return nome;
        }
        public string getSobrenome()
        {
            return sobrenome;
        }
        public char getSexo()
        {
            return sexo;
        }
        public string getTitulacao()
        {
            return titulacao;
        }
        public string getNaturalidade()
        {
            return naturalidade;
        }
        public string getEndereco()
        {
            return endereco;
        }
        public string getCidade()
        {
            return cidade;
        }
        public string getEstado()
        {
            return estado;
        }
        public int getIdade()
        {
            return idade;
        }

        public string retornaFrase()
        {
            if(sexo == 'm')
            {
                return "O " + getTitulacao() + " " + getNome() + " " + getSobrenome() + " é natural de " +
                    getNaturalidade() + " e hoje reside na rua " + getEndereco() + ", " + getCidade() + ", " +
                    getEstado() + ".";
            } 
            else
            {
                return "A " + getTitulacao() + " " + getNome() + " " + getSobrenome() + " é natural de " +
                    getNaturalidade() + " e hoje reside na rua " + getEndereco() + ", " + getCidade() + ", " +
                    getEstado() + ".";
            }
        }
    }
}
