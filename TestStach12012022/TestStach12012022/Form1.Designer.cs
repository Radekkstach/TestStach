namespace TestStach12012022
{
    partial class Stach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stach));
            this.buttonsmazat = new System.Windows.Forms.Button();
            this.buttonkonec = new System.Windows.Forms.Button();
            this.buttonvysledek = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.vysledektext = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonsmazat
            // 
            this.buttonsmazat.BackColor = System.Drawing.Color.Black;
            this.buttonsmazat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonsmazat.ForeColor = System.Drawing.Color.White;
            this.buttonsmazat.Location = new System.Drawing.Point(225, 138);
            this.buttonsmazat.Name = "buttonsmazat";
            this.buttonsmazat.Size = new System.Drawing.Size(76, 67);
            this.buttonsmazat.TabIndex = 17;
            this.buttonsmazat.Text = "Smazat";
            this.buttonsmazat.UseVisualStyleBackColor = false;
            this.buttonsmazat.Click += new System.EventHandler(this.buttonsmazat_Click);
            // 
            // buttonkonec
            // 
            this.buttonkonec.BackColor = System.Drawing.Color.Black;
            this.buttonkonec.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonkonec.ForeColor = System.Drawing.Color.White;
            this.buttonkonec.Location = new System.Drawing.Point(307, 138);
            this.buttonkonec.Name = "buttonkonec";
            this.buttonkonec.Size = new System.Drawing.Size(76, 67);
            this.buttonkonec.TabIndex = 18;
            this.buttonkonec.Text = "Konec";
            this.buttonkonec.UseVisualStyleBackColor = false;
            this.buttonkonec.Click += new System.EventHandler(this.buttonkonec_Click);
            // 
            // buttonvysledek
            // 
            this.buttonvysledek.BackColor = System.Drawing.Color.Black;
            this.buttonvysledek.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonvysledek.ForeColor = System.Drawing.Color.White;
            this.buttonvysledek.Location = new System.Drawing.Point(63, 138);
            this.buttonvysledek.Name = "buttonvysledek";
            this.buttonvysledek.Size = new System.Drawing.Size(156, 67);
            this.buttonvysledek.TabIndex = 19;
            this.buttonvysledek.Text = "Výsledek";
            this.buttonvysledek.UseVisualStyleBackColor = false;
            this.buttonvysledek.Click += new System.EventHandler(this.buttonvysledek_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 20;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%",
            "x²",
            "odmocnina"});
            this.comboBox1.Location = new System.Drawing.Point(218, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(107, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 22;
            // 
            // vysledektext
            // 
            this.vysledektext.AutoSize = true;
            this.vysledektext.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vysledektext.Location = new System.Drawing.Point(59, 227);
            this.vysledektext.Name = "vysledektext";
            this.vysledektext.Size = new System.Drawing.Size(0, 24);
            this.vysledektext.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(60, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Číslo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(61, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Číslo 2";
            // 
            // Stach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(447, 272);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vysledektext);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonvysledek);
            this.Controls.Add(this.buttonkonec);
            this.Controls.Add(this.buttonsmazat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stach";
            this.Text = "Stach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonsmazat;
        private System.Windows.Forms.Button buttonkonec;
        private System.Windows.Forms.Button buttonvysledek;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label vysledektext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

