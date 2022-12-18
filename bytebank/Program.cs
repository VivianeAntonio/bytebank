using bytebank;
using bytebank.Contas;
using bytebank.Funcionarios;
using bytebank.SistemaInterno;
using bytebank.Titular;
using bytebank.Utilitario;

#region CONTAS
//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "Andre Silva";
//contaDoAndre.numero_agencia = 15;
//contaDoAndre.conta = "1010-X";
//contaDoAndre.saldo = 100;

//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "Andre Silva";
//contaDoAndre2.numero_agencia = 15;
//contaDoAndre2.conta = "1010-X";
//contaDoAndre2.saldo = 100;

//contaDoAndre = contaDoAndre2;
//Console.WriteLine(contaDoAndre==contaDoAndre2);

//contaDoAndre.ExibirDadosDaConta();

//Console.WriteLine("Saldo da conta do Andre: " + contaDoAndre.saldo);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 17;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria: " + contaDaMaria.saldo);

//contaDoAndre.Transferir(50, contaDaMaria);

//Console.WriteLine("Saldo do Andre " + contaDoAndre.saldo);
//Console.WriteLine("Saldo da Maria " + contaDaMaria.saldo);


//contaDoAndre.Depositar(100);

//Console.WriteLine("Saldo da conta do Andre pós depósito: " + contaDoAndre.saldo);

//if(contaDoAndre.Sacar(30) == true)
//{
//    Console.WriteLine("Saldo da conta do Andre pós saque: " + contaDoAndre.saldo);
//}
//else
//{
//    Console.WriteLine("Saldo insuficiente para saque.");
//}

//ContaCorrente contaDoPedro = new ContaCorrente();
//contaDoPedro.titular = "Pedro Silva";
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.conta);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.saldo);

//ContaCorrente conta = new ContaCorrente();
//Console.WriteLine($"Titular da conta: {conta.titular}");
//Console.WriteLine($"Número da conta: {conta.conta}");
//Console.WriteLine($"Agência: {conta.numero_agencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");

//Console.ReadKey();


//double valor1 = 300;
//double valor2 = valor1;
//Console.WriteLine(valor1 == valor2);
//Console.WriteLine(valor1);
//Console.WriteLine(valor2);

//new ContaCorrente();

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente();
//conta4.Numero_agencia = 18;
//conta4.Conta = "1010-X";
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

//ContaCorrente conta4 = new ContaCorrente(18, "1158-J");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

//ContaCorrente conta5 = new ContaCorrente(541, "6525-3");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente conta6 = new ContaCorrente(841, "2555-8");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente conta7 = new ContaCorrente(881, "2574-8");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
#endregion 

#region FUNCIONARIOS 
//Funcionario pedro = new Funcionario("123456789",2000);
//pedro.Nome = "Pedro Malazartes";

//Console.WriteLine(pedro.Nome);
//Console.WriteLine(pedro.GetBonificacao());

//Diretor roberta = new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine(roberta.Nome);
//Console.WriteLine(roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");
//Console.WriteLine($"Total de funcionarios: {Funcionario.TotalDeFuncionarios}");

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine($"Novo salario do Pedro: {pedro.Salario}");
//Console.WriteLine($"Novo salario do Roberta: {roberta.Salario}");
#endregion 

#region BONIFICACAO
//CalcularBonificacao();

void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("456123789");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("741258963");
    paula.Nome = "Paula Silva";

    Auxiliar igor = new Auxiliar("147852963");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("753148265");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine($"Total de bonificação: {gerenciador.TotalDeBonificacao}");
}
#endregion

#region AUTENTICACAO

UsarSistema();

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();
    Diretor ingrid = new Diretor("852147951");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("357159852");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";
    
    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");
 
}

#endregion