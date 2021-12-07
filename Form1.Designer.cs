namespace pole_ukol_kolacka
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.radioButtonVzestupne = new System.Windows.Forms.RadioButton();
            this.radioButtonSestupne = new System.Windows.Forms.RadioButton();
            this.textBoxVstup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 27;
            this.listBox1.Location = new System.Drawing.Point(155, 112);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 355);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vygenerované pole";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(705, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Změněné pole";
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 27;
            this.listBox2.Location = new System.Drawing.Point(711, 112);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(152, 355);
            this.listBox2.TabIndex = 2;
            // 
            // radioButtonVzestupne
            // 
            this.radioButtonVzestupne.AutoSize = true;
            this.radioButtonVzestupne.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonVzestupne.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonVzestupne.ForeColor = System.Drawing.Color.White;
            this.radioButtonVzestupne.Location = new System.Drawing.Point(420, 245);
            this.radioButtonVzestupne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonVzestupne.Name = "radioButtonVzestupne";
            this.radioButtonVzestupne.Size = new System.Drawing.Size(150, 35);
            this.radioButtonVzestupne.TabIndex = 4;
            this.radioButtonVzestupne.TabStop = true;
            this.radioButtonVzestupne.Text = "Vzestupně";
            this.radioButtonVzestupne.UseVisualStyleBackColor = false;
            this.radioButtonVzestupne.CheckedChanged += new System.EventHandler(this.radioButtonVzestupne_CheckedChanged);
            // 
            // radioButtonSestupne
            // 
            this.radioButtonSestupne.AutoSize = true;
            this.radioButtonSestupne.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSestupne.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButtonSestupne.ForeColor = System.Drawing.Color.White;
            this.radioButtonSestupne.Location = new System.Drawing.Point(420, 325);
            this.radioButtonSestupne.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonSestupne.Name = "radioButtonSestupne";
            this.radioButtonSestupne.Size = new System.Drawing.Size(134, 35);
            this.radioButtonSestupne.TabIndex = 5;
            this.radioButtonSestupne.TabStop = true;
            this.radioButtonSestupne.Text = "Sestupně";
            this.radioButtonSestupne.UseVisualStyleBackColor = false;
            this.radioButtonSestupne.CheckedChanged += new System.EventHandler(this.radioButtonSestupne_CheckedChanged);
            // 
            // textBoxVstup
            // 
            this.textBoxVstup.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxVstup.Location = new System.Drawing.Point(493, 142);
            this.textBoxVstup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxVstup.Name = "textBoxVstup";
            this.textBoxVstup.Size = new System.Drawing.Size(132, 30);
            this.textBoxVstup.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(365, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vstup N";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(420, 402);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generovat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxVstup);
            this.Controls.Add(this.radioButtonSestupne);
            this.Controls.Add(this.radioButtonVzestupne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Úkol Pole 1 - Koláčka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RadioButton radioButtonVzestupne;
        private System.Windows.Forms.RadioButton radioButtonSestupne;
        private System.Windows.Forms.TextBox textBoxVstup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

