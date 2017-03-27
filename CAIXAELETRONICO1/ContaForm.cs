using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAIXAELETRONICO1
{
    public partial class ContaForm : Form
    {
        public  List<Conta> listaContas { get; set; }
        public ContaForm()
        {
            InitializeComponent();
        }
        public ContaForm(List<Conta> lista)
        {
            InitializeComponent();
            listaContas = new List<Conta>();
            listaContas.AddRange(lista);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Conta conta = new ContaCorrente();
                conta.Agencia = Convert.ToInt32 (textBox1.Text);
                conta.Numero = textBox2.Text;
                conta.Saldo = Convert.ToDecimal(textBox4.Text);

               
            }else
            {
                Conta conta = new ContaPoupanca();
                conta.Agencia = Convert.ToInt32(textBox1.Text);
                conta.Numero = textBox2.Text;
                conta.Saldo = Convert.ToDecimal(textBox4.Text);

            }
        }
    }
}
