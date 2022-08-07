using ByteBankAdm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAdm.Funcionarios
{
    public abstract class Funcionario : IBonificavel
    {
        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            Console.WriteLine("Criando um Funcionário.");
            totalFuncionarios++;
        }

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
        public static int totalFuncionarios { get; private set; }

        public abstract double GetBonificacao();

        public abstract double PremioSemestral();

        public abstract void AumentarSalario();
    }
}
