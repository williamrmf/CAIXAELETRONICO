﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIXAELETRONICO1
{
    public class ContaPoupanca : Conta
    {
        public override decimal Saque(decimal valor)
        {
            Saldo -= (valor + 0.10m);
            return Saldo;
        }
    }
}
    