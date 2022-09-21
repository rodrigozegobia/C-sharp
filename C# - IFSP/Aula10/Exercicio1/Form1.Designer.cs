namespace Exercicio1
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
            if(disposing && (components != null))
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
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.btnRegisterManager = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIncreaseSalary = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnManagerInfo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(67, 27);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 0;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(19, 30);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(42, 13);
            this.lblSalary.TabIndex = 1;
            this.lblSalary.Text = "Salário:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(8, 42);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(34, 13);
            this.lblTax.TabIndex = 3;
            this.lblTax.Text = "Taxa:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(48, 39);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(82, 20);
            this.txtTax.TabIndex = 2;
            // 
            // btnRegisterManager
            // 
            this.btnRegisterManager.Location = new System.Drawing.Point(51, 78);
            this.btnRegisterManager.Name = "btnRegisterManager";
            this.btnRegisterManager.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterManager.TabIndex = 4;
            this.btnRegisterManager.Text = "Registrar";
            this.btnRegisterManager.UseVisualStyleBackColor = true;
            this.btnRegisterManager.Click += new System.EventHandler(this.OnBtnRegisterManagerClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSalary);
            this.groupBox1.Controls.Add(this.btnRegisterManager);
            this.groupBox1.Controls.Add(this.txtSalary);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 116);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar Gerente:";
            // 
            // btnIncreaseSalary
            // 
            this.btnIncreaseSalary.Location = new System.Drawing.Point(25, 102);
            this.btnIncreaseSalary.Name = "btnIncreaseSalary";
            this.btnIncreaseSalary.Size = new System.Drawing.Size(119, 23);
            this.btnIncreaseSalary.TabIndex = 6;
            this.btnIncreaseSalary.Text = "Aumentar Salário";
            this.btnIncreaseSalary.UseVisualStyleBackColor = true;
            this.btnIncreaseSalary.Click += new System.EventHandler(this.OnBtnIncreaseSalaryClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnManagerInfo);
            this.groupBox2.Controls.Add(this.txtTax);
            this.groupBox2.Controls.Add(this.lblTax);
            this.groupBox2.Controls.Add(this.btnIncreaseSalary);
            this.groupBox2.Location = new System.Drawing.Point(12, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 143);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operações:";
            // 
            // btnManagerInfo
            // 
            this.btnManagerInfo.Location = new System.Drawing.Point(150, 102);
            this.btnManagerInfo.Name = "btnManagerInfo";
            this.btnManagerInfo.Size = new System.Drawing.Size(119, 23);
            this.btnManagerInfo.TabIndex = 9;
            this.btnManagerInfo.Text = "Mostrar informações";
            this.btnManagerInfo.UseVisualStyleBackColor = true;
            this.btnManagerInfo.Click += new System.EventHandler(this.OnBtnManagerInfoClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 283);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Button btnRegisterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIncreaseSalary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnManagerInfo;
    }
}

