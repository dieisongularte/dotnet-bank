using System;

namespace DIO.Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta = new Conta(TipoConta.PessoaFisica, 0, 0, "Dieison");
            Console.WriteLine(conta.ToString());
        }
    }
}
