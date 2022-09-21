namespace Exercicio4
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
            this.btnShowAprovedStudents = new System.Windows.Forms.Button();
            this.grpRegisterStudent = new System.Windows.Forms.GroupBox();
            this.rdbCustomizedConstructor = new System.Windows.Forms.RadioButton();
            this.rdbStandardConstructor = new System.Windows.Forms.RadioButton();
            this.btnRegisterStudent = new System.Windows.Forms.Button();
            this.lblStudentCode = new System.Windows.Forms.Label();
            this.txtStudentCode = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.txtStudentGradeOne = new System.Windows.Forms.TextBox();
            this.lblStudentGradeTwo = new System.Windows.Forms.Label();
            this.lblStudentGradeOne = new System.Windows.Forms.Label();
            this.txtStudentGradeTwo = new System.Windows.Forms.TextBox();
            this.grpRegisterStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowAprovedStudents
            // 
            this.btnShowAprovedStudents.Location = new System.Drawing.Point(127, 258);
            this.btnShowAprovedStudents.Name = "btnShowAprovedStudents";
            this.btnShowAprovedStudents.Size = new System.Drawing.Size(203, 23);
            this.btnShowAprovedStudents.TabIndex = 15;
            this.btnShowAprovedStudents.Text = "Estudantes aprovados";
            this.btnShowAprovedStudents.UseVisualStyleBackColor = true;
            this.btnShowAprovedStudents.Click += new System.EventHandler(this.OnBtnShowAprovedStudentsClick);
            // 
            // grpRegisterStudent
            // 
            this.grpRegisterStudent.Controls.Add(this.rdbCustomizedConstructor);
            this.grpRegisterStudent.Controls.Add(this.rdbStandardConstructor);
            this.grpRegisterStudent.Controls.Add(this.btnRegisterStudent);
            this.grpRegisterStudent.Controls.Add(this.lblStudentCode);
            this.grpRegisterStudent.Controls.Add(this.txtStudentCode);
            this.grpRegisterStudent.Controls.Add(this.txtStudentName);
            this.grpRegisterStudent.Controls.Add(this.lblStudentName);
            this.grpRegisterStudent.Controls.Add(this.txtStudentGradeOne);
            this.grpRegisterStudent.Controls.Add(this.lblStudentGradeTwo);
            this.grpRegisterStudent.Controls.Add(this.lblStudentGradeOne);
            this.grpRegisterStudent.Controls.Add(this.txtStudentGradeTwo);
            this.grpRegisterStudent.Location = new System.Drawing.Point(12, 12);
            this.grpRegisterStudent.Name = "grpRegisterStudent";
            this.grpRegisterStudent.Size = new System.Drawing.Size(442, 229);
            this.grpRegisterStudent.TabIndex = 14;
            this.grpRegisterStudent.TabStop = false;
            this.grpRegisterStudent.Text = "Cadastrar estudante:";
            // 
            // rdbCustomizedConstructor
            // 
            this.rdbCustomizedConstructor.AutoSize = true;
            this.rdbCustomizedConstructor.Location = new System.Drawing.Point(288, 112);
            this.rdbCustomizedConstructor.Name = "rdbCustomizedConstructor";
            this.rdbCustomizedConstructor.Size = new System.Drawing.Size(136, 17);
            this.rdbCustomizedConstructor.TabIndex = 15;
            this.rdbCustomizedConstructor.TabStop = true;
            this.rdbCustomizedConstructor.Text = "Construtor Customizado";
            this.rdbCustomizedConstructor.UseVisualStyleBackColor = true;
            // 
            // rdbStandardConstructor
            // 
            this.rdbStandardConstructor.AutoSize = true;
            this.rdbStandardConstructor.Checked = true;
            this.rdbStandardConstructor.Location = new System.Drawing.Point(288, 68);
            this.rdbStandardConstructor.Name = "rdbStandardConstructor";
            this.rdbStandardConstructor.Size = new System.Drawing.Size(109, 17);
            this.rdbStandardConstructor.TabIndex = 14;
            this.rdbStandardConstructor.TabStop = true;
            this.rdbStandardConstructor.Text = "Construtor padrão";
            this.rdbStandardConstructor.UseVisualStyleBackColor = true;
            // 
            // btnRegisterStudent
            // 
            this.btnRegisterStudent.Location = new System.Drawing.Point(176, 192);
            this.btnRegisterStudent.Name = "btnRegisterStudent";
            this.btnRegisterStudent.Size = new System.Drawing.Size(98, 23);
            this.btnRegisterStudent.TabIndex = 13;
            this.btnRegisterStudent.Text = "Cadastrar";
            this.btnRegisterStudent.UseVisualStyleBackColor = true;
            this.btnRegisterStudent.Click += new System.EventHandler(this.OnBtnRegisterStudentClick);
            // 
            // lblStudentCode
            // 
            this.lblStudentCode.AutoSize = true;
            this.lblStudentCode.Location = new System.Drawing.Point(107, 26);
            this.lblStudentCode.Name = "lblStudentCode";
            this.lblStudentCode.Size = new System.Drawing.Size(43, 13);
            this.lblStudentCode.TabIndex = 1;
            this.lblStudentCode.Text = "Código:";
            // 
            // txtStudentCode
            // 
            this.txtStudentCode.Location = new System.Drawing.Point(161, 23);
            this.txtStudentCode.Name = "txtStudentCode";
            this.txtStudentCode.Size = new System.Drawing.Size(100, 20);
            this.txtStudentCode.TabIndex = 0;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(161, 65);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 2;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(112, 68);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(38, 13);
            this.lblStudentName.TabIndex = 3;
            this.lblStudentName.Text = "Nome:";
            // 
            // txtStudentGradeOne
            // 
            this.txtStudentGradeOne.Location = new System.Drawing.Point(161, 107);
            this.txtStudentGradeOne.Name = "txtStudentGradeOne";
            this.txtStudentGradeOne.Size = new System.Drawing.Size(100, 20);
            this.txtStudentGradeOne.TabIndex = 4;
            // 
            // lblStudentGradeTwo
            // 
            this.lblStudentGradeTwo.AutoSize = true;
            this.lblStudentGradeTwo.Location = new System.Drawing.Point(112, 154);
            this.lblStudentGradeTwo.Name = "lblStudentGradeTwo";
            this.lblStudentGradeTwo.Size = new System.Drawing.Size(42, 13);
            this.lblStudentGradeTwo.TabIndex = 7;
            this.lblStudentGradeTwo.Text = "Nota 2:";
            // 
            // lblStudentGradeOne
            // 
            this.lblStudentGradeOne.AutoSize = true;
            this.lblStudentGradeOne.Location = new System.Drawing.Point(112, 110);
            this.lblStudentGradeOne.Name = "lblStudentGradeOne";
            this.lblStudentGradeOne.Size = new System.Drawing.Size(42, 13);
            this.lblStudentGradeOne.TabIndex = 5;
            this.lblStudentGradeOne.Text = "Nota 1:";
            // 
            // txtStudentGradeTwo
            // 
            this.txtStudentGradeTwo.Location = new System.Drawing.Point(161, 149);
            this.txtStudentGradeTwo.Name = "txtStudentGradeTwo";
            this.txtStudentGradeTwo.Size = new System.Drawing.Size(100, 20);
            this.txtStudentGradeTwo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 291);
            this.Controls.Add(this.btnShowAprovedStudents);
            this.Controls.Add(this.grpRegisterStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpRegisterStudent.ResumeLayout(false);
            this.grpRegisterStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowAprovedStudents;
        private System.Windows.Forms.GroupBox grpRegisterStudent;
        private System.Windows.Forms.RadioButton rdbCustomizedConstructor;
        private System.Windows.Forms.RadioButton rdbStandardConstructor;
        private System.Windows.Forms.Button btnRegisterStudent;
        private System.Windows.Forms.Label lblStudentCode;
        private System.Windows.Forms.TextBox txtStudentCode;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox txtStudentGradeOne;
        private System.Windows.Forms.Label lblStudentGradeTwo;
        private System.Windows.Forms.Label lblStudentGradeOne;
        private System.Windows.Forms.TextBox txtStudentGradeTwo;
    }
}

