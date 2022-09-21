namespace Metodos_Exercicio4
{
    partial class Calculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbDivide = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.rdbMultiplica = new System.Windows.Forms.RadioButton();
            this.rdbSubtrai = new System.Windows.Forms.RadioButton();
            this.rdbSoma = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(119, 155);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(114, 40);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(106, 29);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(147, 23);
            this.txtValor1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "1°Valor:";
            // 
            // rdbDivide
            // 
            this.rdbDivide.AutoSize = true;
            this.rdbDivide.Location = new System.Drawing.Point(293, 143);
            this.rdbDivide.Name = "rdbDivide";
            this.rdbDivide.Size = new System.Drawing.Size(63, 19);
            this.rdbDivide.TabIndex = 3;
            this.rdbDivide.TabStop = true;
            this.rdbDivide.Text = "Divisão";
            this.rdbDivide.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "2°Valor:";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(106, 71);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(145, 23);
            this.txtValor2.TabIndex = 4;
            // 
            // rdbMultiplica
            // 
            this.rdbMultiplica.AutoSize = true;
            this.rdbMultiplica.Location = new System.Drawing.Point(293, 106);
            this.rdbMultiplica.Name = "rdbMultiplica";
            this.rdbMultiplica.Size = new System.Drawing.Size(97, 19);
            this.rdbMultiplica.TabIndex = 6;
            this.rdbMultiplica.TabStop = true;
            this.rdbMultiplica.Text = "Multiplicação";
            this.rdbMultiplica.UseVisualStyleBackColor = true;
            // 
            // rdbSubtrai
            // 
            this.rdbSubtrai.AutoSize = true;
            this.rdbSubtrai.Location = new System.Drawing.Point(293, 70);
            this.rdbSubtrai.Name = "rdbSubtrai";
            this.rdbSubtrai.Size = new System.Drawing.Size(78, 19);
            this.rdbSubtrai.TabIndex = 7;
            this.rdbSubtrai.TabStop = true;
            this.rdbSubtrai.Text = "Subtração";
            this.rdbSubtrai.UseVisualStyleBackColor = true;
            // 
            // rdbSoma
            // 
            this.rdbSoma.AutoSize = true;
            this.rdbSoma.Location = new System.Drawing.Point(293, 33);
            this.rdbSoma.Name = "rdbSoma";
            this.rdbSoma.Size = new System.Drawing.Size(55, 19);
            this.rdbSoma.TabIndex = 8;
            this.rdbSoma.TabStop = true;
            this.rdbSoma.Text = "Soma";
            this.rdbSoma.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(106, 115);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(145, 23);
            this.txtResultado.TabIndex = 9;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 220);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.rdbSoma);
            this.Controls.Add(this.rdbSubtrai);
            this.Controls.Add(this.rdbMultiplica);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.rdbDivide);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Calculadora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcular;
        private TextBox txtValor1;
        private Label label1;
        private RadioButton rdbDivide;
        private Label label2;
        private TextBox txtValor2;
        private RadioButton rdbMultiplica;
        private RadioButton rdbSubtrai;
        private RadioButton rdbSoma;
        private Label label3;
        private TextBox txtResultado;
    }
}