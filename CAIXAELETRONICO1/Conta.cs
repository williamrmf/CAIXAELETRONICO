using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIXAELETRONICO1
{
    public class Conta
    {
        public string Numero { get; set; }
        public int Id { get; set; }
        public int Agencia { get; set; }
        public decimal Saldo { get; set; }

        public virtual decimal Saque(decimal valor)//virtual para sobrescrever 
        {
            Saldo = Saldo - valor;
            return Saldo;
        }
    }

  
}
