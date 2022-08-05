namespace Exercicio7
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.rdbAntecessor = new System.Windows.Forms.RadioButton();
            this.rdbSucessor = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(131, 18);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 1;
            // 
            // rdbAntecessor
            // 
            this.rdbAntecessor.AutoSize = true;
            this.rdbAntecessor.Location = new System.Drawing.Point(146, 54);
            this.rdbAntecessor.Name = "rdbAntecessor";
            this.rdbAntecessor.Size = new System.Drawing.Size(78, 17);
            this.rdbAntecessor.TabIndex = 2;
            this.rdbAntecessor.TabStop = true;
            this.rdbAntecessor.Text = "Antecessor";
            this.rdbAntecessor.UseVisualStyleBackColor = true;
            // 
            // rdbSucessor
            // 
            this.rdbSucessor.AutoSize = true;
            this.rdbSucessor.Location = new System.Drawing.Point(146, 77);
            this.rdbSucessor.Name = "rdbSucessor";
            this.rdbSucessor.Size = new System.Drawing.Size(69, 17);
            this.rdbSucessor.TabIndex = 3;
            this.rdbSucessor.TabStop = true;
            this.rdbSucessor.Text = "Sucessor";
            this.rdbSucessor.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(24, 116);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 151);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rdbSucessor);
            this.Controls.Add(this.rdbAntecessor);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.RadioButton rdbAntecessor;
        private System.Windows.Forms.RadioButton rdbSucessor;
        private System.Windows.Forms.Button btnCalcular;
    }
}

