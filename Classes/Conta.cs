using System;
using System.Collections.Generic;
using System.Text;

namespace DIO.Bank
{
    class Conta
    {
        public TipoConta TipoConta { get; set; }
        public double Saldo { get; set; }
        public double Credito { get; set; }
        public string Nome { get; set; }
    }
}
