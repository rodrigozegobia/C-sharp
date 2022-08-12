namespace Exercicio2
{
    partial class Cadastro_cliente
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeIn = new System.Windows.Forms.TextBox();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalarioOut = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoOut = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomeOut = new System.Windows.Forms.TextBox();
            this.txtCodigoIn = new System.Windows.Forms.TextBox();
            this.TxtSalarioIn = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNomeIn
            // 
            this.txtNomeIn.Location = new System.Drawing.Point(75, 12);
            this.txtNomeIn.Name = "txtNomeIn";
            this.txtNomeIn.Size = new System.Drawing.Size(194, 20);
            this.txtNomeIn.TabIndex = 1;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(62, 108);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 2;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salário:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSalarioOut);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCodigoOut);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNomeOut);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados cadastrados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Salário:";
            // 
            // txtSalarioOut
            // 
            this.txtSalarioOut.Enabled = false;
            this.txtSalarioOut.Location = new System.Drawing.Point(62, 91);
            this.txtSalarioOut.Name = "txtSalarioOut";
            this.txtSalarioOut.Size = new System.Drawing.Size(146, 20);
            this.txtSalarioOut.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Código:";
            // 
            // txtCodigoOut
            // 
            this.txtCodigoOut.Enabled = false;
            this.txtCodigoOut.Location = new System.Drawing.Point(62, 58);
            this.txtCodigoOut.Name = "txtCodigoOut";
            this.txtCodigoOut.Size = new System.Drawing.Size(146, 20);
            this.txtCodigoOut.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nome:";
            // 
            // txtNomeOut
            // 
            this.txtNomeOut.Enabled = false;
            this.txtNomeOut.Location = new System.Drawing.Point(63, 25);
            this.txtNomeOut.Name = "txtNomeOut";
            this.txtNomeOut.Size = new System.Drawing.Size(194, 20);
            this.txtNomeOut.TabIndex = 9;
            // 
            // txtCodigoIn
            // 
            this.txtCodigoIn.Location = new System.Drawing.Point(75, 45);
            this.txtCodigoIn.Name = "txtCodigoIn";
            this.txtCodigoIn.Size = new System.Drawing.Size(146, 20);
            this.txtCodigoIn.TabIndex = 7;
            // 
            // TxtSalarioIn
            // 
            this.TxtSalarioIn.Location = new System.Drawing.Point(75, 78);
            this.TxtSalarioIn.Name = "TxtSalarioIn";
            this.TxtSalarioIn.Size = new System.Drawing.Size(146, 20);
            this.TxtSalarioIn.TabIndex = 8;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(159, 108);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 9;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // Cadastro_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 263);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.TxtSalarioIn);
            this.Controls.Add(this.txtCodigoIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.txtNomeIn);
            this.Controls.Add(this.label1);
            this.Name = "Cadastro_cliente";
            this.Text = "Cadastro Cliente";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeIn;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalarioOut;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomeOut;
        private System.Windows.Forms.TextBox txtCodigoIn;
        private System.Windows.Forms.TextBox TxtSalarioIn;
        private System.Windows.Forms.Button btnMostrar;
    }
}

