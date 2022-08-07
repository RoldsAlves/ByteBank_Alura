using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAdm.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(cpf, 3000)
        {
            Console.WriteLine("Criando um Desenvolvedor.");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }

        public override double PremioSemestral()
        {
            return Salario *= 1.2;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
