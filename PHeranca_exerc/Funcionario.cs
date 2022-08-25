using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHeranca_exerc
{
    internal class Funcionario: Pessoa
    {
        String NumeroPis;
        String Setor;
        float Salario;

        public Funcionario(string numeroPis, string setor, float salario, string nome, DateTime datanasc, string cpf): base(nome, datanasc, cpf)
        {
            NumeroPis = numeroPis;
            Setor = setor;
            Salario = salario;
        }

        public void setNumeroPis(string numeropis)
        {
            NumeroPis = numeropis;
        }

        public String getNumeroPis()
        {
            return NumeroPis;
        }

        public void setSetor(string setor)
        {
            Setor = setor;
        }

        public String getSetor()
        {
            return Setor;
        }

        public void setSalario(float salario)
        {
            Salario = salario;
        }

        public float getSalario()
        {
            return Salario;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPIS: {NumeroPis}\nSalario: {Salario}\nSetor: {Setor}";
        }

    }
}
