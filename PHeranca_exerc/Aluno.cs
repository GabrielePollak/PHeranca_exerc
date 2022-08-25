using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PHeranca_exerc
{
    internal class Aluno: Pessoa
    {
        DateTime Datamatric;
        String registro;

        public Aluno(DateTime datamatric, string registro, string nome, DateTime datanasc, string cpf):base(nome, datanasc, cpf)
        {
            Datamatric = datamatric;
            this.registro = registro;
        }

        public override string ToString()
        {
            return base.ToString()+"Data matricula: " +Datamatric+"registro: " +registro;
        }

    }

}
