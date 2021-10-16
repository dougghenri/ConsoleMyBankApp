using System;

namespace ConsoleMyBankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Douglas Henrique", "000.000.000-00", "DEV");


            ContaCorrente conta = new ContaCorrente(cliente, 01, 0001);


            Console.WriteLine("Conta Corrente criada");
            Console.WriteLine("Titular: {0}", conta.getTitular().getNome());
            Console.WriteLine("Agência: {0}", conta.getAgencia());
            Console.WriteLine("Conta: {0}", conta.getConta());

            Console.WriteLine("Parabéns! Seu saldo é R${0}, obrigado por criar sua conta", conta.getSaldo());

            Console.WriteLine("Informe o valor do depósito: ");
            double valorDeposito = Convert.ToDouble(Console.ReadLine());
            conta.Depositar(valorDeposito);

            Console.WriteLine("Seu saldo é R${0}", conta.getSaldo());

            Console.WriteLine("Informe o valor do saque: ");
            double valorSaque = Convert.ToDouble(Console.ReadLine());
            conta.Sacar(valorSaque);

            Console.WriteLine("Seu saldo é R${0}", conta.getSaldo());

            Cliente clienteEdson = new Cliente("Edson Correira de Souza", "000.000.000-00", "Motorista");

            ContaCorrente contaEdson = new ContaCorrente(clienteEdson, 01, 0002);

            Console.WriteLine("Informe o valor do PIX: ");
            double valorPix = Convert.ToDouble(Console.ReadLine());
            conta.PIX(valorPix, contaEdson);

            Console.WriteLine("Seu saldo é R${0}", conta.getSaldo());
            Console.WriteLine("Seu saldo é R${0}", contaEdson.getSaldo());

            ContaPoupanca contaPoupanca = new ContaPoupanca(cliente, 01, 0003);

            Console.WriteLine("Titular: {0}", contaPoupanca.getTitular().getNome());
            Console.WriteLine("Agência: {0}", contaPoupanca.getAgencia());
            Console.WriteLine("Conta: {0}", contaPoupanca.getConta());

        }
    }
}
