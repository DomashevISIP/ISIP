namespace Гороскоп
{
    partial class FormZnak
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblZnakText = new System.Windows.Forms.Label();
            this.lblZnak = new System.Windows.Forms.Label();
            this.lblPredskazanieSegodna = new System.Windows.Forms.Label();
            this.lblPredskazanieSeg = new System.Windows.Forms.Label();
            this.lblGoroskopYear = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pctBxZnak = new System.Windows.Forms.PictureBox();
            this.lblOpisanie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctBxZnak)).BeginInit();
            this.SuspendLayout();
            // 
            // lblZnakText
            // 
            this.lblZnakText.AutoSize = true;
            this.lblZnakText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZnakText.ForeColor = System.Drawing.Color.Black;
            this.lblZnakText.Location = new System.Drawing.Point(13, 29);
            this.lblZnakText.Name = "lblZnakText";
            this.lblZnakText.Size = new System.Drawing.Size(251, 29);
            this.lblZnakText.TabIndex = 0;
            this.lblZnakText.Text = "Ваш знак зодиака - ";
            // 
            // lblZnak
            // 
            this.lblZnak.AutoSize = true;
            this.lblZnak.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZnak.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblZnak.Location = new System.Drawing.Point(270, 29);
            this.lblZnak.Name = "lblZnak";
            this.lblZnak.Size = new System.Drawing.Size(79, 29);
            this.lblZnak.TabIndex = 1;
            this.lblZnak.Text = "label1";
            // 
            // lblPredskazanieSegodna
            // 
            this.lblPredskazanieSegodna.AutoSize = true;
            this.lblPredskazanieSegodna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPredskazanieSegodna.ForeColor = System.Drawing.Color.Black;
            this.lblPredskazanieSegodna.Location = new System.Drawing.Point(12, 175);
            this.lblPredskazanieSegodna.Name = "lblPredskazanieSegodna";
            this.lblPredskazanieSegodna.Size = new System.Drawing.Size(211, 20);
            this.lblPredskazanieSegodna.TabIndex = 2;
            this.lblPredskazanieSegodna.Text = "Гороскоп на сегодня:";
            this.lblPredskazanieSegodna.Click += new System.EventHandler(this.lblPredskazanieSegodna_Click);
            // 
            // lblPredskazanieSeg
            // 
            this.lblPredskazanieSeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPredskazanieSeg.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblPredskazanieSeg.Location = new System.Drawing.Point(12, 210);
            this.lblPredskazanieSeg.Name = "lblPredskazanieSeg";
            this.lblPredskazanieSeg.Size = new System.Drawing.Size(498, 194);
            this.lblPredskazanieSeg.TabIndex = 3;
            this.lblPredskazanieSeg.Text = "label1";
            // 
            // lblGoroskopYear
            // 
            this.lblGoroskopYear.AutoSize = true;
            this.lblGoroskopYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGoroskopYear.ForeColor = System.Drawing.Color.Black;
            this.lblGoroskopYear.Location = new System.Drawing.Point(13, 384);
            this.lblGoroskopYear.Name = "lblGoroskopYear";
            this.lblGoroskopYear.Size = new System.Drawing.Size(168, 20);
            this.lblGoroskopYear.TabIndex = 4;
            this.lblGoroskopYear.Text = "Гороскоп на год:";
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYear.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblYear.Location = new System.Drawing.Point(13, 418);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(499, 239);
            this.lblYear.TabIndex = 5;
            this.lblYear.Text = "label2";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(519, 588);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pctBxZnak
            // 
            this.pctBxZnak.Location = new System.Drawing.Point(453, 12);
            this.pctBxZnak.Name = "pctBxZnak";
            this.pctBxZnak.Size = new System.Drawing.Size(162, 124);
            this.pctBxZnak.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctBxZnak.TabIndex = 7;
            this.pctBxZnak.TabStop = false;
            // 
            // lblOpisanie
            // 
            this.lblOpisanie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOpisanie.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblOpisanie.Location = new System.Drawing.Point(12, 72);
            this.lblOpisanie.Name = "lblOpisanie";
            this.lblOpisanie.Size = new System.Drawing.Size(434, 103);
            this.lblOpisanie.TabIndex = 8;
            this.lblOpisanie.Text = "label1";
            // 
            // FormZnak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(627, 658);
            this.Controls.Add(this.lblOpisanie);
            this.Controls.Add(this.pctBxZnak);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblGoroskopYear);
            this.Controls.Add(this.lblPredskazanieSeg);
            this.Controls.Add(this.lblPredskazanieSegodna);
            this.Controls.Add(this.lblZnak);
            this.Controls.Add(this.lblZnakText);
            this.Name = "FormZnak";
            this.Text = "Знак";
            this.Load += new System.EventHandler(this.FormZnak_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctBxZnak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblZnakText;
        private System.Windows.Forms.Label lblZnak;
        private System.Windows.Forms.Label lblPredskazanieSegodna;
        private System.Windows.Forms.Label lblPredskazanieSeg;
        private System.Windows.Forms.Label lblGoroskopYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pctBxZnak;
        private System.Windows.Forms.Label lblOpisanie;
    }
}