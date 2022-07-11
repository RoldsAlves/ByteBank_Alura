using ByteBankAdm.Utilitarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente
    {
        private string _cpf;
        public string CPF 
        {
            get { return _cpf; } 
            set 
            {
                ValidarCpf validar = new ValidarCpf();
                bool valido = validar.ValidaCPF(value);
                if (valido) _cpf = value;
                else
                {
                    Console.WriteLine("CPF Inválido!");
                    return;
                } 
            } 
        }
        public string Nome { get; set; }
        public string Profissao { get; set; }
        public static int TotalClientes { get; set; }
        public Cliente(string nome, string cpf,string profissao)
        {
            Nome = nome;
            CPF = cpf;
            Profissao = profissao;
            TotalClientes++;
        }
    }
}
