namespace Exemplo3
{
    partial class frmTres
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
            this.txtCopia = new System.Windows.Forms.TextBox();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCopia
            // 
            this.txtCopia.Enabled = false;
            this.txtCopia.Location = new System.Drawing.Point(39, 104);
            this.txtCopia.Multiline = true;
            this.txtCopia.Name = "txtCopia";
            this.txtCopia.ReadOnly = true;
            this.txtCopia.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCopia.Size = new System.Drawing.Size(186, 51);
            this.txtCopia.TabIndex = 0;
            this.txtCopia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(39, 29);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOriginal.Size = new System.Drawing.Size(186, 56);
            this.txtOriginal.TabIndex = 1;
            this.txtOriginal.Click += new System.EventHandler(this.txtOriginal_Click);
            this.txtOriginal.TextChanged += new System.EventHandler(this.txtOriginal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Original";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cópia";
            // 
            // frmTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 180);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.txtCopia);
            this.Name = "frmTres";
            this.Text = "Exemplo3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCopia;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

