namespace MyGroup
{
    partial class Menu
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
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPatronymic = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.lblNumber = new System.Windows.Forms.Label();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // gridMain
            // 
            this.gridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMain.BackgroundColor = System.Drawing.Color.White;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Surname,
            this.сName,
            this.Patronymic,
            this.Address,
            this.Number});
            this.gridMain.GridColor = System.Drawing.Color.Black;
            this.gridMain.Location = new System.Drawing.Point(11, 146);
            this.gridMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gridMain.Name = "gridMain";
            this.gridMain.Size = new System.Drawing.Size(646, 313);
            this.gridMain.TabIndex = 5;
            this.gridMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMain_CellContentClick);
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            // 
            // сName
            // 
            this.сName.HeaderText = "Имя";
            this.сName.Name = "сName";
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            // 
            // Address
            // 
            this.Address.HeaderText = "Адрес";
            this.Address.Name = "Address";
            // 
            // Number
            // 
            this.Number.HeaderText = "Номер телефона";
            this.Number.Name = "Number";
            // 
            // tbSurname
            // 
            this.tbSurname.BackColor = System.Drawing.Color.White;
            this.tbSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSurname.ForeColor = System.Drawing.Color.Black;
            this.tbSurname.Location = new System.Drawing.Point(119, 7);
            this.tbSurname.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(148, 31);
            this.tbSurname.TabIndex = 6;
            this.tbSurname.TextChanged += new System.EventHandler(this.TbSurname_TextChanged);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.Color.White;
            this.lblSurname.Location = new System.Drawing.Point(11, 9);
            this.lblSurname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(104, 25);
            this.lblSurname.TabIndex = 7;
            this.lblSurname.Text = "Фамилия";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(11, 43);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 25);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Имя";
            // 
            // lblPatronymic
            // 
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.ForeColor = System.Drawing.Color.White;
            this.lblPatronymic.Location = new System.Drawing.Point(11, 75);
            this.lblPatronymic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatronymic.Name = "lblPatronymic";
            this.lblPatronymic.Size = new System.Drawing.Size(105, 25);
            this.lblPatronymic.TabIndex = 9;
            this.lblPatronymic.Text = "Отчество";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.White;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.ForeColor = System.Drawing.Color.Black;
            this.tbName.Location = new System.Drawing.Point(119, 41);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(148, 31);
            this.tbName.TabIndex = 10;
            this.tbName.TextChanged += new System.EventHandler(this.TbName_TextChanged);
            // 
            // tbPatronymic
            // 
            this.tbPatronymic.BackColor = System.Drawing.Color.White;
            this.tbPatronymic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPatronymic.ForeColor = System.Drawing.Color.Black;
            this.tbPatronymic.Location = new System.Drawing.Point(119, 75);
            this.tbPatronymic.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPatronymic.Name = "tbPatronymic";
            this.tbPatronymic.Size = new System.Drawing.Size(148, 31);
            this.tbPatronymic.TabIndex = 11;
            this.tbPatronymic.TextChanged += new System.EventHandler(this.TbPatronymic_TextChanged);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(271, 26);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(73, 25);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Адрес";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.Color.White;
            this.tbAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbAddress.ForeColor = System.Drawing.Color.Black;
            this.tbAddress.Location = new System.Drawing.Point(348, 24);
            this.tbAddress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(291, 31);
            this.tbAddress.TabIndex = 12;
            this.tbAddress.TextChanged += new System.EventHandler(this.TbAddress_TextChanged);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.ForeColor = System.Drawing.Color.White;
            this.lblNumber.Location = new System.Drawing.Point(271, 61);
            this.lblNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(78, 25);
            this.lblNumber.TabIndex = 15;
            this.lblNumber.Text = "Номер";
            // 
            // tbNumber
            // 
            this.tbNumber.BackColor = System.Drawing.Color.White;
            this.tbNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNumber.ForeColor = System.Drawing.Color.Black;
            this.tbNumber.Location = new System.Drawing.Point(348, 59);
            this.tbNumber.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(291, 31);
            this.tbNumber.TabIndex = 14;
            this.tbNumber.TextChanged += new System.EventHandler(this.TbNumber_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnAdd.Location = new System.Drawing.Point(114, 118);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 25);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnRemove.Location = new System.Drawing.Point(271, 118);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 25);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnChange
            // 
            this.btnChange.AutoSize = true;
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.ForeColor = System.Drawing.Color.GreenYellow;
            this.btnChange.Location = new System.Drawing.Point(395, 118);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(163, 25);
            this.btnChange.TabIndex = 18;
            this.btnChange.Text = "Редактировать";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(667, 462);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPatronymic);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblPatronymic);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.tbSurname);
            this.Controls.Add(this.gridMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моя группа";
            this.Load += new System.EventHandler(this.formMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPatronymic;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Label btnAdd;
        private System.Windows.Forms.Label btnRemove;
        private System.Windows.Forms.Label btnChange;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn сName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
    }
}

