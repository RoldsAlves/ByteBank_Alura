using ByteBankAdm.Funcionarios;
using ByteBankAdm.Utilitarios;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Funcionario joao = new Funcionario();
joao.Nome = "João";
joao.Cpf = "156.165.605-04";
joao.Salario = 2000;

Console.WriteLine($"Bonificação: {joao.getBonificacao()}");

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "235.581.605-04";
paula.Salario = 5000;

Console.WriteLine($"Bonificação: {paula.getBonificacao()}");

gerenciador.Registrar(joao);
gerenciador.Registrar(paula);

Console.WriteLine($"Total de Bonificação: {gerenciador.GetBonificacao()}");

Console.ReadKey();