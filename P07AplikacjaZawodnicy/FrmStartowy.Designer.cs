namespace P07AplikacjaZawodnicy
{
    partial class FrmStartowy
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
            this.lbDane = new System.Windows.Forms.ListBox();
            this.btnWczytaj = new System.Windows.Forms.Button();
            this.btnSzczegoly = new System.Windows.Forms.Button();
            this.btnDodajZawodnika = new System.Windows.Forms.Button();
            this.btnUsunZawodnika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDane
            // 
            this.lbDane.FormattingEnabled = true;
            this.lbDane.Location = new System.Drawing.Point(12, 41);
            this.lbDane.Name = "lbDane";
            this.lbDane.Size = new System.Drawing.Size(373, 394);
            this.lbDane.TabIndex = 0;
            // 
            // btnWczytaj
            // 
            this.btnWczytaj.Location = new System.Drawing.Point(12, 12);
            this.btnWczytaj.Name = "btnWczytaj";
            this.btnWczytaj.Size = new System.Drawing.Size(55, 23);
            this.btnWczytaj.TabIndex = 1;
            this.btnWczytaj.Text = "Wczytaj";
            this.btnWczytaj.UseVisualStyleBackColor = true;
            this.btnWczytaj.Click += new System.EventHandler(this.btnWczytaj_Click);
            // 
            // btnSzczegoly
            // 
            this.btnSzczegoly.Location = new System.Drawing.Point(283, 12);
            this.btnSzczegoly.Name = "btnSzczegoly";
            this.btnSzczegoly.Size = new System.Drawing.Size(102, 23);
            this.btnSzczegoly.TabIndex = 2;
            this.btnSzczegoly.Text = "Pokaż szczegóły";
            this.btnSzczegoly.UseVisualStyleBackColor = true;
            this.btnSzczegoly.Click += new System.EventHandler(this.btnSzczegoly_Click);
            // 
            // btnDodajZawodnika
            // 
            this.btnDodajZawodnika.Location = new System.Drawing.Point(69, 12);
            this.btnDodajZawodnika.Name = "btnDodajZawodnika";
            this.btnDodajZawodnika.Size = new System.Drawing.Size(105, 23);
            this.btnDodajZawodnika.TabIndex = 3;
            this.btnDodajZawodnika.Text = "Dodaj Zawodnika";
            this.btnDodajZawodnika.UseVisualStyleBackColor = true;
            this.btnDodajZawodnika.Click += new System.EventHandler(this.btnDodajZawodnika_Click);
            // 
            // btnUsunZawodnika
            // 
            this.btnUsunZawodnika.Location = new System.Drawing.Point(175, 12);
            this.btnUsunZawodnika.Name = "btnUsunZawodnika";
            this.btnUsunZawodnika.Size = new System.Drawing.Size(105, 23);
            this.btnUsunZawodnika.TabIndex = 4;
            this.btnUsunZawodnika.Text = "Usuń Zawodnika";
            this.btnUsunZawodnika.UseVisualStyleBackColor = true;
            this.btnUsunZawodnika.Click += new System.EventHandler(this.btnUsunZawodnika_Click);
            // 
            // FrmStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 434);
            this.Controls.Add(this.btnUsunZawodnika);
            this.Controls.Add(this.btnDodajZawodnika);
            this.Controls.Add(this.btnSzczegoly);
            this.Controls.Add(this.btnWczytaj);
            this.Controls.Add(this.lbDane);
            this.Name = "FrmStartowy";
            this.Text = "Zawodnicy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDane;
        private System.Windows.Forms.Button btnWczytaj;
        private System.Windows.Forms.Button btnSzczegoly;
        private System.Windows.Forms.Button btnDodajZawodnika;
        private System.Windows.Forms.Button btnUsunZawodnika;
    }
}

