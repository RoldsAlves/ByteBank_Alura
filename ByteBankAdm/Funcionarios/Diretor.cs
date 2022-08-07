using ByteBankAdm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAdm.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf):base(cpf, 5000)
        {
            Console.WriteLine("Criando um Diretor.");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
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
