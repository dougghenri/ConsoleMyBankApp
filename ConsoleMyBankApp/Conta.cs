using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMyBankApp
{
    public abstract class Conta
    {
        public Cliente titular;
        public int agencia;
        public int conta;
        protected double saldo = 100.00;


        public double Depositar(double valor)
        {
            if (valor <= 0)
            {
                return 0;
            }
            else {
                this.saldo += valor;
            }

            return this.saldo;
        }

        public double Sacar(double valor)
        {
            if (valor > this.saldo)
            {
                return 0;
            }
            else
            {
                this.saldo -= valor;
            }

            return this.saldo;
        }

        public double PIX(double valor, ContaCorrente contaTerceiro)
        {
            if (valor > this.saldo)
            {
                return 0;
            }
            else
            {
                this.saldo -= valor;
                contaTerceiro.Depositar(valor);
            }

            return saldo;
        }
        public Cliente getTitular()
        {
            return this.titular;
        }

        public void setTitular(Cliente titular)
        {
            this.titular = titular;
        }

        public int getAgencia()
        {
            return this.agencia;
        }

        public void setAgencia(int agencia)
        {
            this.agencia = agencia;
        }

        public int getConta()
        {
            return this.conta;
        }

        public void setConta(int conta)
        {
            this.conta = conta;
        }

        public double getSaldo()
        {
            return this.saldo;
        }

        

    }
}
