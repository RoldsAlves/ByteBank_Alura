using ByteBankAdm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAdm.PrestadorServico
{
    public class Arquiteto : PrestadorServico, IAutenticavel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Autenticar(string login, string senha)
        {
            return (Login == login && Senha == senha);
        }

        public override double GetBonificacao()
        {
            return 1000;
        }
    }
}
