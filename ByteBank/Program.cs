using ByteBank;
using ByteBank.Titular;

class Program
{
    static void Main(string[] args)
    {
        CarregarContas();
        Console.ReadKey();
    }

    private static void CarregarContas()
    {
        try
        {
            using (LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
        }catch(IOException e)
        {
            Console.WriteLine("Exceção do tipo IOException capturada e tratada.");
            Console.WriteLine(e.Message);
        }
    }

    private static void TestaInnerException()
    {
        try
        {
            Cliente cliente = new Cliente("Rodolfo Alves", "839.061.345-04", "Analista de Sistemas");
            ContaCorrente conta = new ContaCorrente(cliente, "Agencia Central", 3650, 06225063);

            ContaCorrente conta2 = new ContaCorrente(cliente, "Agência Salvador", 3646, 06225063);
            conta.Depositar(500);
            conta.Transferir(1000, conta2);
            conta.Sacar(1000);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro no parâmetro: {ex.ParamName}");
            Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
            Console.WriteLine(ex.StackTrace);
            Console.WriteLine(ex.Message);
        }
        catch (OperacaoFinanceiraException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);

            Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");
            Console.WriteLine(ex.InnerException.Message);
            Console.WriteLine(ex.InnerException.StackTrace);
        }
    }
}
//Console.WriteLine("Seja bem vindo ao seu Banco, ByteBank!");
//Console.WriteLine();
//try
//{
//    Cliente cliente = new Cliente("Rodolfo Alves", "839.061.345-04", "Analista de Sistemas");
//    ContaCorrente conta = new ContaCorrente(cliente, "Agencia Central", 3650, 06225063);

//    ContaCorrente conta2 = new ContaCorrente(cliente, "Agência Salvador", 3646, 06225063);
//    conta.Depositar(500);
//    conta.Transferir(1000, conta2);
//    conta.Sacar(1000);
//}
//catch (ArgumentException ex)
//{
//    Console.WriteLine($"Erro no parâmetro: {ex.ParamName}");
//    Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
//    Console.WriteLine(ex.StackTrace);
//    Console.WriteLine(ex.Message);
//}
//catch (OperacaoFinanceiraException ex)
//{
//    Console.WriteLine(ex.Message);
//    Console.WriteLine(ex.StackTrace);

//    Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");
//    Console.WriteLine(ex.InnerException.Message);
//    Console.WriteLine(ex.InnerException.StackTrace);
//}

//conta.Depositar(100.00);

//conta.DadosConta();
//Console.WriteLine($"Taxa de operação: {ContaCorrente.TaxaOperacao}");
//Console.WriteLine();

//Console.WriteLine($"Total de Contas Cadastradas: {ContaCorrente.TotalDeContasCriadas}");
//Console.WriteLine($"Total de Clientes Cadastrados: {Cliente.TotalClientes}");
