using bytebank;
using bytebank.Contas;
using bytebank.Funcionarios;
using bytebank.Titular;
using bytebank.Utilitario;

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

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro Malazartes";
pedro.Cpf = "123456789";
pedro.Salario = 2000;

Console.WriteLine(pedro.Nome);
Console.WriteLine(pedro.GetBonificacao());

Diretor roberta = new Diretor();
roberta.Nome = "Roberta Silva";
roberta.Cpf = "987654321";
roberta.Salario = 5000;

Console.WriteLine(roberta.Nome);
Console.WriteLine(roberta.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(pedro);
gerenciador.Registrar(roberta);

Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacao}");

