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
        public double GetBonificacao()
        {
            return this.totalBonificacao;
        }

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }
        public void Registrar(Diretor diretor)
        {
            this.totalBonificacao += diretor.getBonificacao();
        }
    }
}
