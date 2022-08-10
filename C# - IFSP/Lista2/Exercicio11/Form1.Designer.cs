namespace aula7
{
    partial class frmExer11
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtTres = new System.Windows.Forms.TextBox();
            this.txtDois = new System.Windows.Forms.TextBox();
            this.txtUm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(42, 25);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 1;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(158, 28);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(171, 142);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "C";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(42, 90);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(42, 154);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 6;
            // 
            // txtTres
            // 
            this.txtTres.Enabled = false;
            this.txtTres.Location = new System.Drawing.Point(344, 154);
            this.txtTres.Name = "txtTres";
            this.txtTres.Size = new System.Drawing.Size(100, 20);
            this.txtTres.TabIndex = 9;
            // 
            // txtDois
            // 
            this.txtDois.Enabled = false;
            this.txtDois.Location = new System.Drawing.Point(344, 90);
            this.txtDois.Name = "txtDois";
            this.txtDois.Size = new System.Drawing.Size(100, 20);
            this.txtDois.TabIndex = 8;
            // 
            // txtUm
            // 
            this.txtUm.Enabled = false;
            this.txtUm.Location = new System.Drawing.Point(344, 25);
            this.txtUm.Name = "txtUm";
            this.txtUm.Size = new System.Drawing.Size(100, 20);
            this.txtUm.TabIndex = 7;
            // 
            // frmExer11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 207);
            this.Controls.Add(this.txtTres);
            this.Controls.Add(this.txtDois);
            this.Controls.Add(this.txtUm);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label1);
            this.Name = "frmExer11";
            this.Text = "Exercicio11";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtTres;
        private System.Windows.Forms.TextBox txtDois;
        private System.Windows.Forms.TextBox txtUm;
    }
}

