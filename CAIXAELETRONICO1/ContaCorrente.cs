using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAIXAELETRONICO1
{
    public class ContaCorrente : Conta //para herdar de conta
    {
        public override decimal Saque(decimal valor)  //escrever override e der um espaço, ele aparece os metodos para sobrescrever
        {
            Saldo -= (valor + 0.20m);  //m para diferenciar o deciaml
            return Saldo;
        }
    }
}
