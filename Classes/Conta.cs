using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Bank
{
    class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            TipoConta = tipoConta;
            Saldo = saldo;
            Credito = credito;
            Nome = nome;
        }

        public bool Sacar(double valorSaque)
        {
            if (Saldo - valorSaque < (Credito *-1))
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            Saldo -= valorSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", Nome, Saldo);
            return true;
        }

        public void Depositar(double valorDeposito)
        {
            Saldo += valorDeposito;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", Nome, Saldo);
        }

        public void Transferir(Conta contaDestino, double valorTransferencia)
        {
            if (Sacar(valorTransferencia))
            {
                contaDestino.Depositar(valorTransferencia);
            }
        }

        public override string ToString()
        {
            string retorno = string.Empty;
            retorno += "TipoConta " + TipoConta + " | ";
            retorno += "Nome " + Nome + " | ";
            retorno += "Saldo " + Saldo + " | ";
            retorno += "Credito " + Credito + " | ";
            return retorno;
        }
    }
}
