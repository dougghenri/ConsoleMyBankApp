using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyBankApp
{
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string profissao;

        public Cliente(string nome, string cpf, string profissao)
        {
            this.setNome(nome);
            this.setCpf(cpf);
            this.setProfissao(profissao);
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getProfissao()
        {
            return this.profissao;
        }

        public void setProfissao(string profissao)
        {
            this.profissao = profissao;
        }
    }
}
