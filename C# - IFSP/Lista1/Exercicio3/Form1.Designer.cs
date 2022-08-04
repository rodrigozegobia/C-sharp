namespace Exercicio3
{
    partial class Exercicio3
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
            this.btnClique = new System.Windows.Forms.Button();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClique
            // 
            this.btnClique.Location = new System.Drawing.Point(201, 110);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(75, 23);
            this.btnClique.TabIndex = 0;
            this.btnClique.Text = "Clique aqui";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(188, 169);
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(100, 20);
            this.txtMensagem.TabIndex = 1;
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 378);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.btnClique);
            this.Name = "Exercicio3";
            this.Text = "Exercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClique;
        private System.Windows.Forms.TextBox txtMensagem;
    }
}

