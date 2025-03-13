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

        private void lbtTaxa_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaxa.Text = $"* Taxa: {taxa * 100}% a.c{timer1.Interval / 1000}s";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Deseja mesmo sair da aplicação?",
                "Banco menino ney", MessageBoxButtons.YesNo);
            if (r == DialogResult.No)
            {
                e.Cancel = true;

            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Tchau,pobre!");
        }
    }
}