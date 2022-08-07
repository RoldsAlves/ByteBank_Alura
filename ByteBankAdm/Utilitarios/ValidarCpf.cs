using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankAdm.Utilitarios
{
    public class ValidarCpf
    {
        public bool ValidaCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");

            if (cpf.Length != 11) return false;

            tempCpf = cpf.Substring(0, 9);

            soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += (int.Parse(tempCpf[i].ToString()) * multiplicador1[i]);
            }

            digito = RetornarDigito(soma);
            tempCpf = tempCpf + digito;

            soma = 0;
            for(int i = 0; i < 10; i++)
            {
                soma += (int.Parse(tempCpf[i].ToString()) * multiplicador2[i]);
            }

            digito = digito + RetornarDigito(soma);

            return cpf.EndsWith(digito);
        }

        private string RetornarDigito(int soma)
        {
            int resto;
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            return resto.ToString();
        }
    }
}
