using System;

namespace PHeranca_exerc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe nome: ");
            String nome = Console.ReadLine();
            Console.WriteLine("Informe data de nascimento: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe Cpf: ");
            String cpf = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, data, cpf);
            Console.WriteLine(pessoa.ToString());

            
            Console.WriteLine("Informe nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe data de nascimento: ");
            data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe Cpf: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Informe numero do registro: ");
            String registro = Console.ReadLine();
            Console.WriteLine("Informe data da matricula: ");
            DateTime datamatric = DateTime.Parse(Console.ReadLine());

            Aluno aluno= new Aluno(datamatric, registro, nome, data, cpf);
            Console.WriteLine(aluno.ToString());

            Console.WriteLine("Informe nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Informe data de nascimento: ");
            data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Informe Cpf: ");
            cpf = Console.ReadLine();
            Console.WriteLine("Informe número do Pis: ");
            String numpis = Console.ReadLine();
            Console.WriteLine("Informe setor: ");
            String setor = Console.ReadLine();
            Console.WriteLine("Informe salario: ");
            float salario = float.Parse(Console.ReadLine());
            

            Funcionario funcionario = new Funcionario(numpis, setor, salario, nome, data, cpf);
            Console.WriteLine(funcionario.ToString());


        }

        
    }
}

