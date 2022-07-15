using ByteBank.Titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        public ContaCorrente(Cliente titular, string nomeAgencia, int numeroAgencia, int numeroConta)
        {
            Titular = titular;
            NomeAgencia = nomeAgencia;
            NumeroAgencia = numeroAgencia;
            NumeroConta = numeroConta;
            Saldo = 0;
            //try
            //{
            //    TaxaOperacao = 30 / TotalDeContasCriadas;
            //}catch(DivideByZeroException ex)
            //{
            //    TaxaOperacao = 30;
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            if(numeroAgencia <= 0)
                throw new ArgumentException("O argumento NumeroAgencia deve ser maior que 0.", nameof(numeroAgencia));
            if(numeroConta <= 0)
                throw new ArgumentException("O argumento Conta deve ser maior que 0.", nameof(numeroConta));

            TotalDeContasCriadas += 1;
        }

        public Cliente Titular { get; set; }
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; set; }
        public string NomeAgencia { get; private set; }
        public int NumeroAgencia { get; }
        public int NumeroConta { get; }

        private double _saldo;
        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < 0) return;
                _saldo = value;
            }
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor de saque não pode ser negativo.", nameof(valor));
            if (_saldo < valor)
                throw new SaldoInsuficienteException(_saldo, valor);
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Transferir(double valor, ContaCorrente destino)
        {
            if (valor < 0)
                throw new ArgumentException("Valor inválido para a transferência.", nameof(valor));
            Sacar(valor);
            destino.Depositar(valor);
        }

        public void DadosConta()
        {
            Console.WriteLine($"Titular da Conta: {Titular.Nome}");
            Console.WriteLine($"Agência: {NumeroAgencia} - {NomeAgencia}");
            Console.WriteLine($"Número da Conta: {NumeroConta}");
            Console.WriteLine($"Saldo: R$ {String.Format("{0:0.00}", Saldo)}");
        }
    }
}