namespace расчет_зп
{
    partial class formRaschetZP
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
            this.gBox1 = new System.Windows.Forms.GroupBox();
            this.rBtn3 = new System.Windows.Forms.RadioButton();
            this.rBtn2 = new System.Windows.Forms.RadioButton();
            this.rBtn1 = new System.Windows.Forms.RadioButton();
            this.gBox2 = new System.Windows.Forms.GroupBox();
            this.rbThird = new System.Windows.Forms.RadioButton();
            this.rbSecond = new System.Windows.Forms.RadioButton();
            this.rbFirst = new System.Windows.Forms.RadioButton();
            this.labOpl = new System.Windows.Forms.Label();
            this.labNalog = new System.Windows.Forms.Label();
            this.labDays = new System.Windows.Forms.Label();
            this.labHours = new System.Windows.Forms.Label();
            this.tBox1 = new System.Windows.Forms.TextBox();
            this.tBox2 = new System.Windows.Forms.TextBox();
            this.cBox1 = new System.Windows.Forms.ComboBox();
            this.lbHours = new System.Windows.Forms.ListBox();
            this.Raschet = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.gBox1.SuspendLayout();
            this.gBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox1
            // 
            this.gBox1.Controls.Add(this.rBtn3);
            this.gBox1.Controls.Add(this.rBtn2);
            this.gBox1.Controls.Add(this.rBtn1);
            this.gBox1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBox1.Location = new System.Drawing.Point(13, 13);
            this.gBox1.Name = "gBox1";
            this.gBox1.Size = new System.Drawing.Size(180, 128);
            this.gBox1.TabIndex = 0;
            this.gBox1.TabStop = false;
            this.gBox1.Text = "Стаж работника";
            // 
            // rBtn3
            // 
            this.rBtn3.AutoSize = true;
            this.rBtn3.Location = new System.Drawing.Point(7, 93);
            this.rBtn3.Name = "rBtn3";
            this.rBtn3.Size = new System.Drawing.Size(116, 26);
            this.rBtn3.TabIndex = 2;
            this.rBtn3.TabStop = true;
            this.rBtn3.Text = "Более 10 лет";
            this.rBtn3.UseVisualStyleBackColor = true;
            // 
            // rBtn2
            // 
            this.rBtn2.AutoSize = true;
            this.rBtn2.Location = new System.Drawing.Point(7, 61);
            this.rBtn2.Name = "rBtn2";
            this.rBtn2.Size = new System.Drawing.Size(127, 26);
            this.rBtn2.TabIndex = 1;
            this.rBtn2.TabStop = true;
            this.rBtn2.Text = "От 5 до 10 лет";
            this.rBtn2.UseVisualStyleBackColor = true;
            // 
            // rBtn1
            // 
            this.rBtn1.AutoSize = true;
            this.rBtn1.Location = new System.Drawing.Point(7, 29);
            this.rBtn1.Name = "rBtn1";
            this.rBtn1.Size = new System.Drawing.Size(111, 26);
            this.rBtn1.TabIndex = 0;
            this.rBtn1.TabStop = true;
            this.rBtn1.Text = "Менее 5 лет";
            this.rBtn1.UseVisualStyleBackColor = true;
            // 
            // gBox2
            // 
            this.gBox2.Controls.Add(this.rbThird);
            this.gBox2.Controls.Add(this.rbSecond);
            this.gBox2.Controls.Add(this.rbFirst);
            this.gBox2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gBox2.Location = new System.Drawing.Point(199, 13);
            this.gBox2.Name = "gBox2";
            this.gBox2.Size = new System.Drawing.Size(178, 128);
            this.gBox2.TabIndex = 3;
            this.gBox2.TabStop = false;
            this.gBox2.Text = "Разряд";
            // 
            // rbThird
            // 
            this.rbThird.AutoSize = true;
            this.rbThird.Location = new System.Drawing.Point(7, 93);
            this.rbThird.Name = "rbThird";
            this.rbThird.Size = new System.Drawing.Size(76, 26);
            this.rbThird.TabIndex = 2;
            this.rbThird.TabStop = true;
            this.rbThird.Text = "Третий";
            this.rbThird.UseVisualStyleBackColor = true;
            // 
            // rbSecond
            // 
            this.rbSecond.AutoSize = true;
            this.rbSecond.Location = new System.Drawing.Point(7, 61);
            this.rbSecond.Name = "rbSecond";
            this.rbSecond.Size = new System.Drawing.Size(77, 26);
            this.rbSecond.TabIndex = 1;
            this.rbSecond.TabStop = true;
            this.rbSecond.Text = "Второй";
            this.rbSecond.UseVisualStyleBackColor = true;
            // 
            // rbFirst
            // 
            this.rbFirst.AutoSize = true;
            this.rbFirst.Location = new System.Drawing.Point(7, 29);
            this.rbFirst.Name = "rbFirst";
            this.rbFirst.Size = new System.Drawing.Size(80, 26);
            this.rbFirst.TabIndex = 0;
            this.rbFirst.TabStop = true;
            this.rbFirst.Text = "Первый";
            this.rbFirst.UseVisualStyleBackColor = true;
            // 
            // labOpl
            // 
            this.labOpl.AutoSize = true;
            this.labOpl.Font = new System.Drawing.Font("Sylfaen", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labOpl.Location = new System.Drawing.Point(16, 144);
            this.labOpl.Name = "labOpl";
            this.labOpl.Size = new System.Drawing.Size(163, 22);
            this.labOpl.TabIndex = 4;
            this.labOpl.Text = "Оплата одного часа:";
            // 
            // labNalog
            // 
            this.labNalog.AutoSize = true;
            this.labNalog.Font = new System.Drawing.Font("Sylfaen", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labNalog.Location = new System.Drawing.Point(16, 173);
            this.labNalog.Name = "labNalog";
            this.labNalog.Size = new System.Drawing.Size(144, 22);
            this.labNalog.TabIndex = 5;
            this.labNalog.Text = "Налоговая ставка:";
            // 
            // labDays
            // 
            this.labDays.AutoSize = true;
            this.labDays.Font = new System.Drawing.Font("Sylfaen", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labDays.Location = new System.Drawing.Point(16, 195);
            this.labDays.Name = "labDays";
            this.labDays.Size = new System.Drawing.Size(278, 22);
            this.labDays.TabIndex = 6;
            this.labDays.Text = "Количество рабочих дней в месяце:";
            // 
            // labHours
            // 
            this.labHours.AutoSize = true;
            this.labHours.Font = new System.Drawing.Font("Sylfaen", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labHours.Location = new System.Drawing.Point(16, 222);
            this.labHours.Name = "labHours";
            this.labHours.Size = new System.Drawing.Size(271, 22);
            this.labHours.TabIndex = 7;
            this.labHours.Text = "Продолжительность рабочего дня:";
            // 
            // tBox1
            // 
            this.tBox1.Location = new System.Drawing.Point(304, 144);
            this.tBox1.Name = "tBox1";
            this.tBox1.Size = new System.Drawing.Size(73, 20);
            this.tBox1.TabIndex = 8;
            this.tBox1.TextChanged += new System.EventHandler(this.tBox1_TextChanged);
            // 
            // tBox2
            // 
            this.tBox2.Location = new System.Drawing.Point(304, 169);
            this.tBox2.Name = "tBox2";
            this.tBox2.Size = new System.Drawing.Size(73, 20);
            this.tBox2.TabIndex = 9;
            this.tBox2.TextChanged += new System.EventHandler(this.tBox2_TextChanged);
            // 
            // cBox1
            // 
            this.cBox1.FormattingEnabled = true;
            this.cBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21"});
            this.cBox1.Location = new System.Drawing.Point(304, 195);
            this.cBox1.Name = "cBox1";
            this.cBox1.Size = new System.Drawing.Size(73, 21);
            this.cBox1.TabIndex = 10;
            this.cBox1.TextChanged += new System.EventHandler(this.сBox1_TextChanged);
            // 
            // lbHours
            // 
            this.lbHours.FormattingEnabled = true;
            this.lbHours.Items.AddRange(new object[] {
            "8 часов",
            "6 часов"});
            this.lbHours.Location = new System.Drawing.Point(304, 222);
            this.lbHours.Name = "lbHours";
            this.lbHours.Size = new System.Drawing.Size(73, 30);
            this.lbHours.TabIndex = 11;
            // 
            // Raschet
            // 
            this.Raschet.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Raschet.Enabled = false;
            this.Raschet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Raschet.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Raschet.Location = new System.Drawing.Point(12, 258);
            this.Raschet.Name = "Raschet";
            this.Raschet.Size = new System.Drawing.Size(119, 60);
            this.Raschet.TabIndex = 12;
            this.Raschet.Text = "Расчет";
            this.Raschet.UseVisualStyleBackColor = false;
            this.Raschet.Click += new System.EventHandler(this.Raschet_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear.Location = new System.Drawing.Point(137, 258);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(112, 60);
            this.Clear.TabIndex = 13;
            this.Clear.Text = "Очиска";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit.Location = new System.Drawing.Point(255, 258);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(122, 60);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // formRaschetZP
            // 
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(380, 325);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Raschet);
            this.Controls.Add(this.lbHours);
            this.Controls.Add(this.cBox1);
            this.Controls.Add(this.tBox2);
            this.Controls.Add(this.tBox1);
            this.Controls.Add(this.labHours);
            this.Controls.Add(this.labDays);
            this.Controls.Add(this.labNalog);
            this.Controls.Add(this.labOpl);
            this.Controls.Add(this.gBox2);
            this.Controls.Add(this.gBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "formRaschetZP";
            this.Text = "Расчет заработной платы";
            this.Load += new System.EventHandler(this.formRaschetZP_Load);
            this.gBox1.ResumeLayout(false);
            this.gBox1.PerformLayout();
            this.gBox2.ResumeLayout(false);
            this.gBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox1;
        private System.Windows.Forms.RadioButton rBtn1;
        private System.Windows.Forms.RadioButton rBtn3;
        private System.Windows.Forms.RadioButton rBtn2;
        private System.Windows.Forms.GroupBox gBox2;
        private System.Windows.Forms.RadioButton rbThird;
        private System.Windows.Forms.RadioButton rbSecond;
        private System.Windows.Forms.RadioButton rbFirst;
        private System.Windows.Forms.Label labOpl;
        private System.Windows.Forms.Label labNalog;
        private System.Windows.Forms.Label labDays;
        private System.Windows.Forms.Label labHours;
        private System.Windows.Forms.TextBox tBox1;
        private System.Windows.Forms.TextBox tBox2;
        private System.Windows.Forms.ComboBox cBox1;
        private System.Windows.Forms.ListBox lbHours;
        private System.Windows.Forms.Button Raschet;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Exit;
    }
}

