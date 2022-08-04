namespace teste
{
    partial class Exercicio2
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
            this.btnClique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClique
            // 
            this.btnClique.Location = new System.Drawing.Point(107, 48);
            this.btnClique.Name = "btnClique";
            this.btnClique.Size = new System.Drawing.Size(159, 51);
            this.btnClique.TabIndex = 0;
            this.btnClique.Text = "Clique Aqui!";
            this.btnClique.UseVisualStyleBackColor = true;
            this.btnClique.Click += new System.EventHandler(this.btnClique_Click);
            // 
            // Exercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 156);
            this.Controls.Add(this.btnClique);
            this.Name = "Exercicio2";
            this.Text = "Exercicio2";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnClique;
    }
}