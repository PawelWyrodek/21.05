namespace Postacie_mam_nadzieje_ze_ostatnie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonWojownik = new System.Windows.Forms.RadioButton();
            this.radioButtonMag = new System.Windows.Forms.RadioButton();
            this.radioButtonRolnik = new System.Windows.Forms.RadioButton();
            this.buttonDodajPostac = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonWojownik
            // 
            this.radioButtonWojownik.AutoSize = true;
            this.radioButtonWojownik.Location = new System.Drawing.Point(12, 71);
            this.radioButtonWojownik.Name = "radioButtonWojownik";
            this.radioButtonWojownik.Size = new System.Drawing.Size(72, 17);
            this.radioButtonWojownik.TabIndex = 0;
            this.radioButtonWojownik.TabStop = true;
            this.radioButtonWojownik.Text = "Wojownik";
            this.radioButtonWojownik.UseVisualStyleBackColor = true;
            // 
            // radioButtonMag
            // 
            this.radioButtonMag.AutoSize = true;
            this.radioButtonMag.Location = new System.Drawing.Point(90, 71);
            this.radioButtonMag.Name = "radioButtonMag";
            this.radioButtonMag.Size = new System.Drawing.Size(46, 17);
            this.radioButtonMag.TabIndex = 0;
            this.radioButtonMag.TabStop = true;
            this.radioButtonMag.Text = "Mag";
            this.radioButtonMag.UseVisualStyleBackColor = true;
            // 
            // radioButtonRolnik
            // 
            this.radioButtonRolnik.AutoSize = true;
            this.radioButtonRolnik.Location = new System.Drawing.Point(142, 71);
            this.radioButtonRolnik.Name = "radioButtonRolnik";
            this.radioButtonRolnik.Size = new System.Drawing.Size(55, 17);
            this.radioButtonRolnik.TabIndex = 0;
            this.radioButtonRolnik.TabStop = true;
            this.radioButtonRolnik.Text = "Rolnik";
            this.radioButtonRolnik.UseVisualStyleBackColor = true;
            // 
            // buttonDodajPostac
            // 
            this.buttonDodajPostac.Location = new System.Drawing.Point(12, 221);
            this.buttonDodajPostac.Name = "buttonDodajPostac";
            this.buttonDodajPostac.Size = new System.Drawing.Size(201, 70);
            this.buttonDodajPostac.TabIndex = 1;
            this.buttonDodajPostac.Text = "Dodaj";
            this.buttonDodajPostac.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 137);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(241, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(213, 199);
            this.listBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dodaj Postac";
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(241, 232);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(213, 58);
            this.buttonUsun.TabIndex = 5;
            this.buttonUsun.Text = "Usun";
            this.buttonUsun.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 305);
            this.Controls.Add(this.buttonUsun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonDodajPostac);
            this.Controls.Add(this.radioButtonRolnik);
            this.Controls.Add(this.radioButtonMag);
            this.Controls.Add(this.radioButtonWojownik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonWojownik;
        private System.Windows.Forms.RadioButton radioButtonMag;
        private System.Windows.Forms.RadioButton radioButtonRolnik;
        private System.Windows.Forms.Button buttonDodajPostac;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonUsun;
    }
}

