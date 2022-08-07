using ByteBankAdm.Funcionarios;
using ByteBankAdm.ParceiroComercial;
using ByteBankAdm.SistemaInterno;
using ByteBankAdm.Utilitarios;

Console.WriteLine("Boas Vindas, ao ByteBank Administração.");

//CalcularBonificacao();
//UsarSistema();
ValidarCpf validaCpf = new ValidarCpf();
bool cpf = validaCpf.ValidaCPF("839.061.345-04");
if (cpf) Console.WriteLine("CPF Válido");
else Console.WriteLine("CPF inválido");

Console.ReadKey();

void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer joao = new Designer("156.165.605-04");
    joao.Nome = "João";

    Diretor paula = new Diretor("235.581.605-04");
    paula.Nome = "Paula";

    GerenteContas pedro = new GerenteContas("125.154.143-00");
    pedro.Nome = "Pedro";

    Auxiliar francisco = new Auxiliar("125.354.454-00");
    francisco.Nome = "Francisco";

    Desenvolvedor rodolfo = new Desenvolvedor("839.061.345-04");
    rodolfo.Nome = "Rodolfo";

    gerenciador.Registrar(joao);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(pedro);
    gerenciador.Registrar(francisco);
    gerenciador.Registrar(rodolfo);

    Console.WriteLine($"Total de Bonificação: {gerenciador.GetBonificacao()}");
}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor paula = new Diretor("235.581.605-04");
    paula.Nome = "Paula";
    paula.Senha = "1234";
    paula.Login = "paulaA";
    sistemaInterno.Logar(paula, "paulaA", "1234");

    GerenteContas jose = new GerenteContas("801.150.544-04");
    jose.Nome = "José";
    jose.Login = "joseS";
    jose.Senha = "1234";
    sistemaInterno.Logar(jose, "joseS", "1234");

    ParceiroComercial pedro = new ParceiroComercial();
    pedro.Login = "pedroA";
    pedro.Senha = "1234";
    sistemaInterno.Logar(pedro, "pedroA", "1234");
}
