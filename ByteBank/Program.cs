using ByteBank;
using ByteBank.Titular;

Console.WriteLine("Seja bem vindo ao seu Banco, ByteBank!");
Console.WriteLine();

//ContaCorrente conta = new ContaCorrente();

//conta.Titular = "Rodolfo Alves";
//conta.Conta = "10123-x";
//conta.NumeroAgencia = 23;
//conta.NomeAgencia = "Agencia Central";
//conta.Saldo = 100.00;

//ContaCorrente conta2 = new ContaCorrente();

//conta2.Titular = "Lorena Alves";
//conta2.Conta = "10124-x";
//conta2.NumeroAgencia = 23;
//conta2.NomeAgencia = "Agencia Central";
//conta2.Saldo = 100.00;

//Console.WriteLine($"Saldo de {conta.Titular} pré-saque: {conta.Saldo}");
//bool saque = conta.Sacar(50);
//Console.WriteLine($"Saque realizado? {saque}");
//Console.WriteLine($"Saldo de {conta.Titular} pós-saque: {conta.Saldo}");
//Console.WriteLine();

//Console.WriteLine($"Saldo de {conta2.Titular} pré-depósito: {conta2.Saldo}");
//conta2.Depositar(50);
//Console.WriteLine($"Saldo de {conta2.Titular} pós-depósito: {conta2.Saldo}");
//Console.WriteLine();

//Console.WriteLine($"Saldo de {conta.Titular} pré-transferência: {conta.Saldo}");
//Console.WriteLine($"Saldo de {conta2.Titular} pré-transferência: {conta2.Saldo}");
//bool transferencia = conta2.Transferir(50, conta);
//Console.WriteLine($"Transferência realizada? {transferencia}");
//Console.WriteLine($"Saldo de {conta.Titular} pós-transferência: {conta.Saldo}");
//Console.WriteLine($"Saldo de {conta2.Titular} pós-transferência: {conta2.Saldo}");
//Console.WriteLine();

//conta.DadosConta();

Cliente cliente = new Cliente("Rodolfo Alves", "839.061.345-04", "Analista de Sistemas");
ContaCorrente conta3 = new ContaCorrente(cliente, "Agencia Central", 3646, "0622506-x");
conta3.Depositar(100.00);

conta3.DadosConta();
Console.WriteLine();

Cliente cliente2 = new Cliente("Lorena Alves", "014.836.695-30", "Engenheira Cívil");
ContaCorrente conta4 = new ContaCorrente(cliente2, "Agencia Orla", 3545, "250605-x");
conta4.Depositar(150.00);

conta4.DadosConta();
Console.WriteLine();

Console.WriteLine($"Total de Contas Cadastradas: {ContaCorrente.TotalDeContasCriadas}");
Console.WriteLine($"Total de Clientes Cadastrados: {Cliente.TotalClientes}");

Console.ReadKey();