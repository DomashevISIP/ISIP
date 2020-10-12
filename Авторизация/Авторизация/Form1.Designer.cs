namespace Авторизация
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnVxod = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(90, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(144, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Авторизация";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(57, 71);
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(139, 20);
            this.tbxLogin.TabIndex = 1;
            this.tbxLogin.TextChanged += new System.EventHandler(this.tbxLogin_TextChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(57, 102);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(139, 20);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            // 
            // btnVxod
            // 
            this.btnVxod.Location = new System.Drawing.Point(202, 69);
            this.btnVxod.Name = "btnVxod";
            this.btnVxod.Size = new System.Drawing.Size(114, 23);
            this.btnVxod.TabIndex = 3;
            this.btnVxod.Text = "Войти";
            this.btnVxod.UseVisualStyleBackColor = true;
            this.btnVxod.Click += new System.EventHandler(this.BtnVxod_Click);
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(202, 105);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(114, 23);
            this.btnReg.TabIndex = 4;
            this.btnReg.Text = "Регистрация ";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.BtnReg_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(13, 71);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(38, 13);
            this.lblLogin.TabIndex = 5;
            this.lblLogin.Text = "Логин";
            this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(13, 105);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(45, 13);
            this.lblpassword.TabIndex = 6;
            this.lblpassword.Text = "Пароль";
            this.lblpassword.Click += new System.EventHandler(this.lblpassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 139);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnVxod);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxLogin);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxLogin;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnVxod;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblpassword;
    }
}

