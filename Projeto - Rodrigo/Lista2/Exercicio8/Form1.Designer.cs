namespace Exercicio8
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.rdbSoma = new System.Windows.Forms.RadioButton();
            this.rdbSubtrai = new System.Windows.Forms.RadioButton();
            this.rdbDivide = new System.Windows.Forms.RadioButton();
            this.rdbMultiplica = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num1:";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(71, 48);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(71, 90);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 3;
            // 
            // rdbSoma
            // 
            this.rdbSoma.AutoSize = true;
            this.rdbSoma.Location = new System.Drawing.Point(6, 19);
            this.rdbSoma.Name = "rdbSoma";
            this.rdbSoma.Size = new System.Drawing.Size(52, 17);
            this.rdbSoma.TabIndex = 4;
            this.rdbSoma.TabStop = true;
            this.rdbSoma.Text = "Soma";
            this.rdbSoma.UseVisualStyleBackColor = true;
            // 
            // rdbSubtrai
            // 
            this.rdbSubtrai.AutoSize = true;
            this.rdbSubtrai.Location = new System.Drawing.Point(6, 42);
            this.rdbSubtrai.Name = "rdbSubtrai";
            this.rdbSubtrai.Size = new System.Drawing.Size(74, 17);
            this.rdbSubtrai.TabIndex = 5;
            this.rdbSubtrai.TabStop = true;
            this.rdbSubtrai.Text = "Subtração";
            this.rdbSubtrai.UseVisualStyleBackColor = true;
            // 
            // rdbDivide
            // 
            this.rdbDivide.AutoSize = true;
            this.rdbDivide.Location = new System.Drawing.Point(6, 65);
            this.rdbDivide.Name = "rdbDivide";
            this.rdbDivide.Size = new System.Drawing.Size(60, 17);
            this.rdbDivide.TabIndex = 6;
            this.rdbDivide.TabStop = true;
            this.rdbDivide.Text = "Divisão";
            this.rdbDivide.UseVisualStyleBackColor = true;
            // 
            // rdbMultiplica
            // 
            this.rdbMultiplica.AutoSize = true;
            this.rdbMultiplica.Location = new System.Drawing.Point(6, 88);
            this.rdbMultiplica.Name = "rdbMultiplica";
            this.rdbMultiplica.Size = new System.Drawing.Size(87, 17);
            this.rdbMultiplica.TabIndex = 7;
            this.rdbMultiplica.TabStop = true;
            this.rdbMultiplica.Text = "Multiplicação";
            this.rdbMultiplica.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMultiplica);
            this.groupBox1.Controls.Add(this.rdbDivide);
            this.groupBox1.Controls.Add(this.rdbSoma);
            this.groupBox1.Controls.Add(this.rdbSubtrai);
            this.groupBox1.Location = new System.Drawing.Point(211, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 115);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operações";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(32, 210);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(139, 23);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(71, 176);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 264);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.RadioButton rdbSoma;
        private System.Windows.Forms.RadioButton rdbSubtrai;
        private System.Windows.Forms.RadioButton rdbDivide;
        private System.Windows.Forms.RadioButton rdbMultiplica;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
    }
}

