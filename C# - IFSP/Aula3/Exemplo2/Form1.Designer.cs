namespace Exemplo2
{
    partial class frmExemplo2
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
            this.ckbLingC = new System.Windows.Forms.CheckBox();
            this.ckbCSharp = new System.Windows.Forms.CheckBox();
            this.ckbJava = new System.Windows.Forms.CheckBox();
            this.ckbPython = new System.Windows.Forms.CheckBox();
            this.btnClique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Linguagens de programação que já aprendi:";
            // 
            // ckbLingC
            // 
            this.ckbLingC.AutoSize = true;
            this.ckbLingC.Location = new System.Drawing.Point(155, 93);
            this.ckbLingC.Name = "ckbLingC";
            this.ckbLingC.Size = new System.Drawing.Size(57, 17);
            this.ckbLingC.TabIndex = 1;
            this.ckbLingC.Text = "C/C++";
            this.ckbLingC.UseVisualStyleBackColor = true;
            // 
            // ckbCSharp
            // 
            this.ckbCSharp.AutoSize = true;
            this.ckbCSharp.Location = new System.Drawing.Point(155, 132);
            this.ckbCSharp.Name = "ckbCSharp";
            this.ckbCSharp.Size = new System.Drawing.Size(40, 17);
            this.ckbCSharp.TabIndex = 2;
            this.ckbCSharp.Text = "C#";
            this.ckbCSharp.UseVisualStyleBackColor = true;
            // 
            // ckbJava
            // 
            this.ckbJava.AutoSize = true;
            this.ckbJava.Location = new System.Drawing.Point(155, 176);
            this.ckbJava.Name = "ckbJava";
            this.ckbJava.Size = new System.Drawing.Size(49, 17);
            this.ckbJava.TabIndex = 3;
            this.ckbJava.Text = "Java";
            this.ckbJava.UseVisualStyleBackColor = true;
            // 
            // ckbPython
            // 
            this.ckbPython.AutoSize = true;
            this.ckbPython.Location = new System.Drawing.Point(155, 215);
            this.ckbPython.Name = "ckbPython";
            this.ckbPython.Size = new System.Drawing.Size(59, 17);
            this.ckbPython.TabIndex = 4;
            this.ckbPython.Text = "Python";
            this.ckbPython.UseVisualStyleBackColor = true;
            // 
            // btnClique
            // 
            this.btnClique.Location = new System.Drawing.Point(155, 256);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(75, 23);
            this.btnClique.TabIndex = 5;
            this.btnClique.Text = "Clique aqui";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // frmExemplo2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 373);
            this.Controls.Add(this.btnClique);
            this.Controls.Add(this.ckbPython);
            this.Controls.Add(this.ckbJava);
            this.Controls.Add(this.ckbCSharp);
            this.Controls.Add(this.ckbLingC);
            this.Controls.Add(this.label1);
            this.Name = "frmExemplo2";
            this.Text = "Exemplo2";
            this.Load += new System.EventHandler(this.frmExemplo2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbLingC;
        private System.Windows.Forms.CheckBox ckbCSharp;
        private System.Windows.Forms.CheckBox ckbJava;
        private System.Windows.Forms.CheckBox ckbPython;
        private System.Windows.Forms.Button btnClique;
    }
}

