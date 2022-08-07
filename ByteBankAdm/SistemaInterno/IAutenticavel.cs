using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAdm.SistemaInterno
{
    public interface IAutenticavel
    {
        public bool Autenticar(string login, string senha);
    }
}
