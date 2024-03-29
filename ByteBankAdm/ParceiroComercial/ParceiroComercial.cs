﻿using ByteBankAdm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAdm.ParceiroComercial
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Autenticar(string login, string senha)
        {
            return (Senha == senha && Login == login);
        }
    }
}

