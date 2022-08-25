using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHeranca_exerc
{
    internal class Pessoa
    {
        String Nome;
        DateTime Datanasc;
        String Cpf;

        
        //modo construtor
        public Pessoa (string nome, DateTime datanasc, string cpf)
        {
            Nome = nome;
            Datanasc = datanasc;
            Cpf = cpf;
        }

        //Acesso atributos
        public void setNome(String nome)
        {
            Nome = nome;
        }

        public String getNome()
        {
            return Nome;
        }
        
        public void setCpf(String cpf)
        {
            Cpf = cpf;
        }
        public String getCpf()
        {
            return Cpf;
        }
        
        public void setDatanasc(DateTime datanasc)
        {
            Datanasc = datanasc;
        }

        public String getDatanasc()
        {
            return Datanasc.ToShortDateString();
        }

        public string ImprimePessoa()
        {
            return $"Nome: {Nome}\nData de Nascimento: {Datanasc.ToShortDateString()}\nCPF: {Cpf}";
        }
        public override string ToString()
        {
            return $"\nNome: {Nome}\nData de nascimento: {Datanasc.ToShortDateString()}\nCPF: {Cpf}";
        }

    }
}
