using ByteBankAdm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAdm.Utilitarios
{
    public class GerenciadorBonificacao
    {
        private double totalBonificacao;
        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        }
        public double GetBonificacao()
        {
            return this.totalBonificacao;
        }

    }
}
