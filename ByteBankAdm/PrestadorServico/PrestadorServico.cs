using ByteBankAdm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAdm.PrestadorServico
{
    public abstract class PrestadorServico : IBonificavel
    {
        public string CNPJ { get; set; }

        public abstract double GetBonificacao();
    }
}
