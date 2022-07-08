using ByteBank.Titular;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public string NomeAgencia { get; set; }
        private int _numeroAgencia;
        public int NumeroAgencia 
        {
            get { return _numeroAgencia; }
            set
            {
                if (value <= 0) return;
                _numeroAgencia = value;
            }
        }
        private string _conta;
        public string Conta
        {
            get { return _conta; }
            set
            {
                if (value == null) return;
                _conta = value;
            }
        }
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

        public bool Sacar(double valor)
        {
            if(Saldo < valor || valor < 0) return false;
            else
            {
                _saldo = Saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (Saldo < valor || valor < 0) return false;
            else
            {
                _saldo = Saldo - valor;
                destino.Saldo += valor;
                return true;
            }
        }

        public void DadosConta()
        {
            Console.WriteLine($"Titular da Conta: {Titular.Nome}");
            Console.WriteLine($"Nome da Agência: {NomeAgencia}");
            Console.WriteLine($"Agência: {NumeroAgencia}");
            Console.WriteLine($"Número da Conta: {Conta}");
            Console.WriteLine($"Saldo: R$ {String.Format("{0:0.00}", Saldo)}");
        }

        public ContaCorrente(Cliente titular, string nomeAgencia, int numeroAgencia, string conta)
        {
            Titular = titular;
            NomeAgencia = nomeAgencia;
            NumeroAgencia = numeroAgencia;
            Conta = conta;
            TotalDeContasCriadas += 1;
            Saldo = 0;
        }

        public static int TotalDeContasCriadas { get; set; }
    }
}