using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caixa_eletronico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double saldo = 0;
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)


        {
            if ((decimal)saldo - digitarValor.Value >= -numLimite.Value)
            {
                saldo -= (double)digitarValor.Value;
                lbtSaldo.Text = saldo.ToString();
            }

        }

        private void btDepositar_Click(object sender, EventArgs e)
        {
            saldo += (double)digitarValor.Value;
            lbtSaldo.Text = saldo.ToString("c");


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void valor_Click(object sender, EventArgs e)
        {

        }
        double taxa = 0.001;

        private void timer1_Tick(object sender, EventArgs e)
        {
            saldo += saldo * taxa;
            lbtSaldo.Text = saldo.ToString("c");
        }
    }
}