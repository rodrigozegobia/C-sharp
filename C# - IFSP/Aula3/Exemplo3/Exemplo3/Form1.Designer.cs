namespace Exemplo3
{
    partial class FrmExemplo3
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
            this.cmbEscolaridade = new System.Windows.Forms.ComboBox();
            this.cmbEstacao = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbEscolaridade
            // 
            this.cmbEscolaridade.FormattingEnabled = true;
            this.cmbEscolaridade.Items.AddRange(new object[] {
            "Ensino Fundamental",
            "Ensino Médio",
            "Ensino Superior",
            "Pós-graduação"});
            this.cmbEscolaridade.Location = new System.Drawing.Point(88, 65);
            this.cmbEscolaridade.Name = "cmbEscolaridade";
            this.cmbEscolaridade.Size = new System.Drawing.Size(174, 21);
            this.cmbEscolaridade.TabIndex = 0;
            // 
            // cmbEstacao
            // 
            this.cmbEstacao.FormattingEnabled = true;
            this.cmbEstacao.Location = new System.Drawing.Point(88, 121);
            this.cmbEstacao.Name = "cmbEstacao";
            this.cmbEstacao.Size = new System.Drawing.Size(174, 21);
            this.cmbEstacao.TabIndex = 1;
            this.cmbEstacao.Text = "Qual a sua estação preferida?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Qual o seu nível de escolaridade?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnMensagem
            // 
            this.btnMensagem.Location = new System.Drawing.Point(110, 169);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(126, 55);
            this.btnMensagem.TabIndex = 3;
            this.btnMensagem.Text = "Mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // FrmExemplo3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 267);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEstacao);
            this.Controls.Add(this.cmbEscolaridade);
            this.Name = "FrmExemplo3";
            this.Text = "Exemplo3";
            this.Load += new System.EventHandler(this.FrmExemplo3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbEscolaridade;
        private System.Windows.Forms.ComboBox cmbEstacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMensagem;
    }
}

