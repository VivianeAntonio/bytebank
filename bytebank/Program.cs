using bytebank;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "Andre Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-X";
contaDoAndre.saldo =  100;


Console.WriteLine("Saldo da conta do Andre: " + contaDoAndre.saldo);

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1010-5";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta da Maria: " + contaDaMaria.saldo);

contaDoAndre.Transferir(50, contaDaMaria);

Console.WriteLine("Saldo do Andre " + contaDoAndre.saldo);
Console.WriteLine("Saldo da Maria " + contaDaMaria.saldo);


contaDoAndre.Depositar(100);

Console.WriteLine("Saldo da conta do Andre pós depósito: " + contaDoAndre.saldo);

if(contaDoAndre.Sacar(30) == true)
{
    Console.WriteLine("Saldo da conta do Andre pós saque: " + contaDoAndre.saldo);
}
else
{
    Console.WriteLine("Saldo insuficiente para saque.");
}



//ContaCorrente conta = new ContaCorrente();
//Console.WriteLine($"Titular da conta: {conta.titular}");
//Console.WriteLine($"Número da conta: {conta.conta}");
//Console.WriteLine($"Agência: {conta.numero_agencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");

//Console.ReadKey();
