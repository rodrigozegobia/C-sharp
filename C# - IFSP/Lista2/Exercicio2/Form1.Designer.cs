namespace Exercicio2
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
            this.ckbDormir = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.ckbComer = new System.Windows.Forms.CheckBox();
            this.ckbCinema = new System.Windows.Forms.CheckBox();
            this.ckbLerlivro = new System.Windows.Forms.CheckBox();
            this.ckbEstudar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ckbDormir
            // 
            this.ckbDormir.AutoSize = true;
            this.ckbDormir.Location = new System.Drawing.Point(73, 58);
            this.ckbDormir.Name = "ckbDormir";
            this.ckbDormir.Size = new System.Drawing.Size(56, 17);
            this.ckbDormir.TabIndex = 0;
            this.ckbDormir.Text = "Dormir";
            this.ckbDormir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "O que eu gosto de fazer:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(52, 197);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(173, 197);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // ckbComer
            // 
            this.ckbComer.AutoSize = true;
            this.ckbComer.Location = new System.Drawing.Point(73, 81);
            this.ckbComer.Name = "ckbComer";
            this.ckbComer.Size = new System.Drawing.Size(56, 17);
            this.ckbComer.TabIndex = 4;
            this.ckbComer.Text = "Comer";
            this.ckbComer.UseVisualStyleBackColor = true;
            // 
            // ckbCinema
            // 
            this.ckbCinema.AutoSize = true;
            this.ckbCinema.Location = new System.Drawing.Point(73, 104);
            this.ckbCinema.Name = "ckbCinema";
            this.ckbCinema.Size = new System.Drawing.Size(84, 17);
            this.ckbCinema.TabIndex = 5;
            this.ckbCinema.Text = "Ir ao cinema";
            this.ckbCinema.UseVisualStyleBackColor = true;
            // 
            // ckbLerlivro
            // 
            this.ckbLerlivro.AutoSize = true;
            this.ckbLerlivro.Location = new System.Drawing.Point(73, 127);
            this.ckbLerlivro.Name = "ckbLerlivro";
            this.ckbLerlivro.Size = new System.Drawing.Size(80, 17);
            this.ckbLerlivro.TabIndex = 6;
            this.ckbLerlivro.Text = "Ler um livro";
            this.ckbLerlivro.UseVisualStyleBackColor = true;
            // 
            // ckbEstudar
            // 
            this.ckbEstudar.AutoSize = true;
            this.ckbEstudar.Location = new System.Drawing.Point(73, 150);
            this.ckbEstudar.Name = "ckbEstudar";
            this.ckbEstudar.Size = new System.Drawing.Size(62, 17);
            this.ckbEstudar.TabIndex = 7;
            this.ckbEstudar.Text = "Estudar";
            this.ckbEstudar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 249);
            this.Controls.Add(this.ckbEstudar);
            this.Controls.Add(this.ckbLerlivro);
            this.Controls.Add(this.ckbCinema);
            this.Controls.Add(this.ckbComer);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbDormir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbDormir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox ckbComer;
        private System.Windows.Forms.CheckBox ckbCinema;
        private System.Windows.Forms.CheckBox ckbLerlivro;
        private System.Windows.Forms.CheckBox ckbEstudar;
    }
}

