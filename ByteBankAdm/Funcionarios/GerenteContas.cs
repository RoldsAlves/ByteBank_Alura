using ByteBankAdm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAdm.Funcionarios
{
    public class GerenteContas : FuncionarioAutenticavel
    {
        public GerenteContas(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("Criando um Gerente de Contas.");
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override double PremioSemestral()
        {
            return Salario *= 1.2;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }
    }
}
