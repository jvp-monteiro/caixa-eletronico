namespace caixa_eletronico
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.digitarValor = new System.Windows.Forms.NumericUpDown();
            this.valor = new System.Windows.Forms.Label();
            this.lbtSaldo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btDepositar = new System.Windows.Forms.Button();
            this.btSacar = new System.Windows.Forms.Button();
            this.numLimite = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.digitarValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).BeginInit();
            this.SuspendLayout();
            // 
            // digitarValor
            // 
            this.digitarValor.Location = new System.Drawing.Point(84, 62);
            this.digitarValor.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.digitarValor.Name = "digitarValor";
            this.digitarValor.Size = new System.Drawing.Size(132, 20);
            this.digitarValor.TabIndex = 0;
            this.digitarValor.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // valor
            // 
            this.valor.AutoSize = true;
            this.valor.Location = new System.Drawing.Point(35, 64);
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(43, 13);
            this.valor.TabIndex = 1;
            this.valor.Text = "VALOR";
            this.valor.Click += new System.EventHandler(this.valor_Click);
            // 
            // lbtSaldo
            // 
            this.lbtSaldo.AutoSize = true;
            this.lbtSaldo.Location = new System.Drawing.Point(175, 156);
            this.lbtSaldo.Name = "lbtSaldo";
            this.lbtSaldo.Size = new System.Drawing.Size(28, 13);
            this.lbtSaldo.TabIndex = 2;
            this.lbtSaldo.Text = "0,00";
            this.lbtSaldo.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "SALDO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btDepositar
            // 
            this.btDepositar.Location = new System.Drawing.Point(29, 112);
            this.btDepositar.Name = "btDepositar";
            this.btDepositar.Size = new System.Drawing.Size(98, 23);
            this.btDepositar.TabIndex = 4;
            this.btDepositar.Text = "Depositar";
            this.btDepositar.UseVisualStyleBackColor = true;
            this.btDepositar.Click += new System.EventHandler(this.btDepositar_Click);
            // 
            // btSacar
            // 
            this.btSacar.Location = new System.Drawing.Point(133, 112);
            this.btSacar.Name = "btSacar";
            this.btSacar.Size = new System.Drawing.Size(83, 23);
            this.btSacar.TabIndex = 5;
            this.btSacar.Text = "Sacar";
            this.btSacar.UseVisualStyleBackColor = true;
            this.btSacar.Click += new System.EventHandler(this.button2_Click);
            // 
            // numLimite
            // 
            this.numLimite.Location = new System.Drawing.Point(84, 214);
            this.numLimite.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numLimite.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.numLimite.Name = "numLimite";
            this.numLimite.Size = new System.Drawing.Size(132, 20);
            this.numLimite.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "LIMITE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 265);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numLimite);
            this.Controls.Add(this.btSacar);
            this.Controls.Add(this.btDepositar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbtSaldo);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.digitarValor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.digitarValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLimite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown digitarValor;
        private System.Windows.Forms.Label valor;
        private System.Windows.Forms.Label lbtSaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDepositar;
        private System.Windows.Forms.Button btSacar;
        private System.Windows.Forms.NumericUpDown numLimite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

