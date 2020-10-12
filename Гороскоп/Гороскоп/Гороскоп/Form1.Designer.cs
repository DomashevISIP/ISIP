namespace Гороскоп
{
    partial class Goroskop
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
            this.lblZagolovok = new System.Windows.Forms.Label();
            this.lblZagolovok2 = new System.Windows.Forms.Label();
            this.txtBxChislo = new System.Windows.Forms.TextBox();
            this.btnGoroskop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBxMonth = new System.Windows.Forms.TextBox();
            this.lblChislo = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblZagolovok
            // 
            this.lblZagolovok.AutoSize = true;
            this.lblZagolovok.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZagolovok.ForeColor = System.Drawing.Color.Black;
            this.lblZagolovok.Location = new System.Drawing.Point(104, 9);
            this.lblZagolovok.Name = "lblZagolovok";
            this.lblZagolovok.Size = new System.Drawing.Size(165, 39);
            this.lblZagolovok.TabIndex = 0;
            this.lblZagolovok.Text = "Гороскоп";
            this.lblZagolovok.Click += new System.EventHandler(this.lblZagolovok_Click);
            // 
            // lblZagolovok2
            // 
            this.lblZagolovok2.AutoSize = true;
            this.lblZagolovok2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZagolovok2.ForeColor = System.Drawing.Color.Black;
            this.lblZagolovok2.Location = new System.Drawing.Point(17, 48);
            this.lblZagolovok2.Name = "lblZagolovok2";
            this.lblZagolovok2.Size = new System.Drawing.Size(336, 29);
            this.lblZagolovok2.TabIndex = 1;
            this.lblZagolovok2.Text = "Введи свою дату рождения";
            // 
            // txtBxChislo
            // 
            this.txtBxChislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxChislo.Location = new System.Drawing.Point(102, 96);
            this.txtBxChislo.Name = "txtBxChislo";
            this.txtBxChislo.Size = new System.Drawing.Size(41, 31);
            this.txtBxChislo.TabIndex = 2;
            this.txtBxChislo.TextChanged += new System.EventHandler(this.txtBxChislo_TextChanged);
            this.txtBxChislo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxChislo_KeyPress);
            // 
            // btnGoroskop
            // 
            this.btnGoroskop.BackColor = System.Drawing.Color.GhostWhite;
            this.btnGoroskop.Enabled = false;
            this.btnGoroskop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGoroskop.Location = new System.Drawing.Point(22, 133);
            this.btnGoroskop.Name = "btnGoroskop";
            this.btnGoroskop.Size = new System.Drawing.Size(158, 49);
            this.btnGoroskop.TabIndex = 5;
            this.btnGoroskop.Text = "Узнать судьбу";
            this.btnGoroskop.UseVisualStyleBackColor = false;
            this.btnGoroskop.Click += new System.EventHandler(this.btnGoroskop_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.GhostWhite;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(186, 133);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 49);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBxMonth
            // 
            this.txtBxMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxMonth.Location = new System.Drawing.Point(237, 98);
            this.txtBxMonth.Multiline = true;
            this.txtBxMonth.Name = "txtBxMonth";
            this.txtBxMonth.Size = new System.Drawing.Size(100, 29);
            this.txtBxMonth.TabIndex = 7;
            this.txtBxMonth.TextChanged += new System.EventHandler(this.txtBxMonth_TextChanged);
            this.txtBxMonth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxMonth_KeyPress);
            // 
            // lblChislo
            // 
            this.lblChislo.AutoSize = true;
            this.lblChislo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblChislo.ForeColor = System.Drawing.Color.Black;
            this.lblChislo.Location = new System.Drawing.Point(17, 96);
            this.lblChislo.Name = "lblChislo";
            this.lblChislo.Size = new System.Drawing.Size(79, 25);
            this.lblChislo.TabIndex = 8;
            this.lblChislo.Text = "Число:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMonth.ForeColor = System.Drawing.Color.Black;
            this.lblMonth.Location = new System.Drawing.Point(149, 96);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(82, 25);
            this.lblMonth.TabIndex = 9;
            this.lblMonth.Text = "Месяц:";
            // 
            // Goroskop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(363, 194);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lblChislo);
            this.Controls.Add(this.txtBxMonth);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGoroskop);
            this.Controls.Add(this.txtBxChislo);
            this.Controls.Add(this.lblZagolovok2);
            this.Controls.Add(this.lblZagolovok);
            this.Name = "Goroskop";
            this.Text = "Гороскоп";
            this.Load += new System.EventHandler(this.Goroskop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZagolovok;
        private System.Windows.Forms.Label lblZagolovok2;
        private System.Windows.Forms.TextBox txtBxChislo;
        private System.Windows.Forms.Button btnGoroskop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtBxMonth;
        private System.Windows.Forms.Label lblChislo;
        private System.Windows.Forms.Label lblMonth;
    }
}

