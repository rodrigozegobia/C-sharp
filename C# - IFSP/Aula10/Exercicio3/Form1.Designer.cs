namespace Exercicio3
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
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblCompanyAddress = new System.Windows.Forms.Label();
            this.txtCompanyAddress = new System.Windows.Forms.TextBox();
            this.lblCompanyState = new System.Windows.Forms.Label();
            this.txtCompanyState = new System.Windows.Forms.TextBox();
            this.lblCompanyCity = new System.Windows.Forms.Label();
            this.txtCompanyCity = new System.Windows.Forms.TextBox();
            this.lblCompanyEmployeeQty = new System.Windows.Forms.Label();
            this.txtlCompanyEmployeeQty = new System.Windows.Forms.TextBox();
            this.lblCompanyEquityValue = new System.Windows.Forms.Label();
            this.txtCompanyEquityValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegisterCompany = new System.Windows.Forms.Button();
            this.btnShowHighestEquityValue = new System.Windows.Forms.Button();
            this.rdbStandardConstructor = new System.Windows.Forms.RadioButton();
            this.rdbCustomizedConstructor = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(161, 23);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyName.TabIndex = 0;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(58, 26);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(97, 13);
            this.lblCompanyName.TabIndex = 1;
            this.lblCompanyName.Text = "Nome da Empresa:";
            // 
            // lblCompanyAddress
            // 
            this.lblCompanyAddress.AutoSize = true;
            this.lblCompanyAddress.Location = new System.Drawing.Point(99, 68);
            this.lblCompanyAddress.Name = "lblCompanyAddress";
            this.lblCompanyAddress.Size = new System.Drawing.Size(56, 13);
            this.lblCompanyAddress.TabIndex = 3;
            this.lblCompanyAddress.Text = "Endereço:";
            // 
            // txtCompanyAddress
            // 
            this.txtCompanyAddress.Location = new System.Drawing.Point(161, 65);
            this.txtCompanyAddress.Name = "txtCompanyAddress";
            this.txtCompanyAddress.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyAddress.TabIndex = 2;
            // 
            // lblCompanyState
            // 
            this.lblCompanyState.AutoSize = true;
            this.lblCompanyState.Location = new System.Drawing.Point(112, 152);
            this.lblCompanyState.Name = "lblCompanyState";
            this.lblCompanyState.Size = new System.Drawing.Size(43, 13);
            this.lblCompanyState.TabIndex = 7;
            this.lblCompanyState.Text = "Estado:";
            // 
            // txtCompanyState
            // 
            this.txtCompanyState.Location = new System.Drawing.Point(161, 149);
            this.txtCompanyState.Name = "txtCompanyState";
            this.txtCompanyState.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyState.TabIndex = 6;
            // 
            // lblCompanyCity
            // 
            this.lblCompanyCity.AutoSize = true;
            this.lblCompanyCity.Location = new System.Drawing.Point(112, 110);
            this.lblCompanyCity.Name = "lblCompanyCity";
            this.lblCompanyCity.Size = new System.Drawing.Size(43, 13);
            this.lblCompanyCity.TabIndex = 5;
            this.lblCompanyCity.Text = "Cidade:";
            // 
            // txtCompanyCity
            // 
            this.txtCompanyCity.Location = new System.Drawing.Point(161, 107);
            this.txtCompanyCity.Name = "txtCompanyCity";
            this.txtCompanyCity.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyCity.TabIndex = 4;
            // 
            // lblCompanyEmployeeQty
            // 
            this.lblCompanyEmployeeQty.AutoSize = true;
            this.lblCompanyEmployeeQty.Location = new System.Drawing.Point(12, 236);
            this.lblCompanyEmployeeQty.Name = "lblCompanyEmployeeQty";
            this.lblCompanyEmployeeQty.Size = new System.Drawing.Size(143, 13);
            this.lblCompanyEmployeeQty.TabIndex = 11;
            this.lblCompanyEmployeeQty.Text = "Quantidade de Funcionários:";
            // 
            // txtlCompanyEmployeeQty
            // 
            this.txtlCompanyEmployeeQty.Location = new System.Drawing.Point(161, 233);
            this.txtlCompanyEmployeeQty.Name = "txtlCompanyEmployeeQty";
            this.txtlCompanyEmployeeQty.Size = new System.Drawing.Size(100, 20);
            this.txtlCompanyEmployeeQty.TabIndex = 10;
            // 
            // lblCompanyEquityValue
            // 
            this.lblCompanyEquityValue.AutoSize = true;
            this.lblCompanyEquityValue.Location = new System.Drawing.Point(67, 194);
            this.lblCompanyEquityValue.Name = "lblCompanyEquityValue";
            this.lblCompanyEquityValue.Size = new System.Drawing.Size(88, 13);
            this.lblCompanyEquityValue.TabIndex = 9;
            this.lblCompanyEquityValue.Text = "Valor Patrimonial:";
            // 
            // txtCompanyEquityValue
            // 
            this.txtCompanyEquityValue.Location = new System.Drawing.Point(161, 191);
            this.txtCompanyEquityValue.Name = "txtCompanyEquityValue";
            this.txtCompanyEquityValue.Size = new System.Drawing.Size(100, 20);
            this.txtCompanyEquityValue.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbCustomizedConstructor);
            this.groupBox1.Controls.Add(this.rdbStandardConstructor);
            this.groupBox1.Controls.Add(this.btnRegisterCompany);
            this.groupBox1.Controls.Add(this.lblCompanyName);
            this.groupBox1.Controls.Add(this.lblCompanyEmployeeQty);
            this.groupBox1.Controls.Add(this.txtCompanyName);
            this.groupBox1.Controls.Add(this.txtlCompanyEmployeeQty);
            this.groupBox1.Controls.Add(this.txtCompanyAddress);
            this.groupBox1.Controls.Add(this.lblCompanyEquityValue);
            this.groupBox1.Controls.Add(this.lblCompanyAddress);
            this.groupBox1.Controls.Add(this.txtCompanyEquityValue);
            this.groupBox1.Controls.Add(this.txtCompanyCity);
            this.groupBox1.Controls.Add(this.lblCompanyState);
            this.groupBox1.Controls.Add(this.lblCompanyCity);
            this.groupBox1.Controls.Add(this.txtCompanyState);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(442, 309);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nova Empresa:";
            // 
            // btnRegisterCompany
            // 
            this.btnRegisterCompany.Location = new System.Drawing.Point(176, 280);
            this.btnRegisterCompany.Name = "btnRegisterCompany";
            this.btnRegisterCompany.Size = new System.Drawing.Size(98, 23);
            this.btnRegisterCompany.TabIndex = 13;
            this.btnRegisterCompany.Text = "Cadastrar";
            this.btnRegisterCompany.UseVisualStyleBackColor = true;
            this.btnRegisterCompany.Click += new System.EventHandler(this.OnBtnRegisterCompanyClick);
            // 
            // btnShowHighestEquityValue
            // 
            this.btnShowHighestEquityValue.Location = new System.Drawing.Point(127, 340);
            this.btnShowHighestEquityValue.Name = "btnShowHighestEquityValue";
            this.btnShowHighestEquityValue.Size = new System.Drawing.Size(203, 23);
            this.btnShowHighestEquityValue.TabIndex = 13;
            this.btnShowHighestEquityValue.Text = "Mostrar Maior Valor Patrimonial";
            this.btnShowHighestEquityValue.UseVisualStyleBackColor = true;
            this.btnShowHighestEquityValue.Click += new System.EventHandler(this.OnBtnShowHighestEquityValueClick);
            // 
            // rdbStandardConstructor
            // 
            this.rdbStandardConstructor.AutoSize = true;
            this.rdbStandardConstructor.Checked = true;
            this.rdbStandardConstructor.Location = new System.Drawing.Point(289, 108);
            this.rdbStandardConstructor.Name = "rdbStandardConstructor";
            this.rdbStandardConstructor.Size = new System.Drawing.Size(109, 17);
            this.rdbStandardConstructor.TabIndex = 14;
            this.rdbStandardConstructor.TabStop = true;
            this.rdbStandardConstructor.Text = "Construtor padrão";
            this.rdbStandardConstructor.UseVisualStyleBackColor = true;
            // 
            // rdbCustomizedConstructor
            // 
            this.rdbCustomizedConstructor.AutoSize = true;
            this.rdbCustomizedConstructor.Location = new System.Drawing.Point(289, 152);
            this.rdbCustomizedConstructor.Name = "rdbCustomizedConstructor";
            this.rdbCustomizedConstructor.Size = new System.Drawing.Size(136, 17);
            this.rdbCustomizedConstructor.TabIndex = 15;
            this.rdbCustomizedConstructor.TabStop = true;
            this.rdbCustomizedConstructor.Text = "Construtor Customizado";
            this.rdbCustomizedConstructor.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 376);
            this.Controls.Add(this.btnShowHighestEquityValue);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblCompanyAddress;
        private System.Windows.Forms.TextBox txtCompanyAddress;
        private System.Windows.Forms.Label lblCompanyState;
        private System.Windows.Forms.TextBox txtCompanyState;
        private System.Windows.Forms.Label lblCompanyCity;
        private System.Windows.Forms.TextBox txtCompanyCity;
        private System.Windows.Forms.Label lblCompanyEmployeeQty;
        private System.Windows.Forms.TextBox txtlCompanyEmployeeQty;
        private System.Windows.Forms.Label lblCompanyEquityValue;
        private System.Windows.Forms.TextBox txtCompanyEquityValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegisterCompany;
        private System.Windows.Forms.Button btnShowHighestEquityValue;
        private System.Windows.Forms.RadioButton rdbCustomizedConstructor;
        private System.Windows.Forms.RadioButton rdbStandardConstructor;
    }
}

