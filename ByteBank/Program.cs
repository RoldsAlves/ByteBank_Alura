using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Seja bem vindo ao seu Banco, ByteBank!");
Console.WriteLine();
try
{
    Cliente cliente = new Cliente("Rodolfo Alves", "839.061.345-04", "Analista de Sistemas");
    ContaCorrente conta = new ContaCorrente(cliente, "Agencia Central", 3646, 06225063);
    conta.Depositar(500);
    conta.Transferir(1000, conta);
    conta.Sacar(1000);
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.ParamName);
    Console.WriteLine("Ocorreu um erro do tipo ArgumentException.");
    Console.WriteLine(ex.Message);
}
catch (SaldoInsuficienteException ex)
{
    Console.WriteLine("Ocorreu um erro do tipo SaldoInsuficienteException.");
    //Console.WriteLine(ex.ParamName);
    Console.WriteLine(ex.Message);
}

//conta.Depositar(100.00);

//conta.DadosConta();
//Console.WriteLine($"Taxa de operação: {ContaCorrente.TaxaOperacao}");
//Console.WriteLine();

//Console.WriteLine($"Total de Contas Cadastradas: {ContaCorrente.TotalDeContasCriadas}");
//Console.WriteLine($"Total de Clientes Cadastrados: {Cliente.TotalClientes}");

Console.ReadKey();