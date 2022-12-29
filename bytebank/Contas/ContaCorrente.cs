using bytebank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        public static double TaxaOperacao { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        private int _agencia;
        public int Agencia
        {
            get { return this._agencia; }
            private set
            {
                if (value > 0)
                {
                    this._agencia = value;
                }
            }
        }

        public int Conta { get; }
        public Cliente Titular { get; set; }
        public double saldo = 100;

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException("Saldo Insuficiente para saque no valor de " +  valor);                
            }
            else
            {
                saldo -= valor;
            }

            if (valor < 0)
            {
                throw new ArgumentException("Valor de saque não pode ser negativo", nameof(valor));
            }
            if (saldo < valor)
            {
                throw new SaldoInsuficienteException(saldo, valor);
            }
            saldo -= valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {            
            try
            {
                Sacar(valor);
            }
            catch(SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }
            saldo -= valor;
            destino.Depositar(valor);
            return true;
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular :" + Titular);
            Console.WriteLine("Conta :" + Conta);
            Console.WriteLine("Número Agência :" + _agencia);
            Console.WriteLine("Saldo: " + saldo);
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numero_agencia, int numero_conta)
        {
            this.Agencia = numero_agencia;
            this.Conta = numero_conta;

            //TaxaOperacao = 30 / TotalDeContasCriadas;

            if (numero_agencia <= 0)
            {
                throw new ArgumentException("O argumento agência deve ser maior que 0.", nameof(numero_agencia));
            }
            if (numero_conta <= 0)
            {
                throw new ArgumentException("O argumento conta deve ser maior que 0.", nameof(numero_conta));
            }
            TotalDeContasCriadas++;
        }

    }
}
