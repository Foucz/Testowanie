namespace Kalkulator
{
    partial class Form1
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
            this.liczba1 = new System.Windows.Forms.TextBox();
            this.liczba2 = new System.Windows.Forms.TextBox();
            this.dodaj = new System.Windows.Forms.Button();
            this.odejmij = new System.Windows.Forms.Button();
            this.pomnoz = new System.Windows.Forms.Button();
            this.podziel = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.TextBox();
            this.wyczysc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // liczba1
            // 
            this.liczba1.Location = new System.Drawing.Point(162, 148);
            this.liczba1.Name = "liczba1";
            this.liczba1.Size = new System.Drawing.Size(100, 20);
            this.liczba1.TabIndex = 0;
            // 
            // liczba2
            // 
            this.liczba2.Location = new System.Drawing.Point(453, 147);
            this.liczba2.Name = "liczba2";
            this.liczba2.Size = new System.Drawing.Size(100, 20);
            this.liczba2.TabIndex = 1;
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(131, 202);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(75, 23);
            this.dodaj.TabIndex = 2;
            this.dodaj.Text = "dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // odejmij
            // 
            this.odejmij.Location = new System.Drawing.Point(295, 202);
            this.odejmij.Name = "odejmij";
            this.odejmij.Size = new System.Drawing.Size(75, 23);
            this.odejmij.TabIndex = 3;
            this.odejmij.Text = "odejmij";
            this.odejmij.UseVisualStyleBackColor = true;
            this.odejmij.Click += new System.EventHandler(this.odejmij_Click);
            // 
            // pomnoz
            // 
            this.pomnoz.Location = new System.Drawing.Point(424, 202);
            this.pomnoz.Name = "pomnoz";
            this.pomnoz.Size = new System.Drawing.Size(75, 23);
            this.pomnoz.TabIndex = 4;
            this.pomnoz.Text = "pomnoz";
            this.pomnoz.UseVisualStyleBackColor = true;
            this.pomnoz.Click += new System.EventHandler(this.pomnoz_Click);
            // 
            // podziel
            // 
            this.podziel.Location = new System.Drawing.Point(563, 202);
            this.podziel.Name = "podziel";
            this.podziel.Size = new System.Drawing.Size(75, 23);
            this.podziel.TabIndex = 5;
            this.podziel.Text = "podziel";
            this.podziel.UseVisualStyleBackColor = true;
            this.podziel.Click += new System.EventHandler(this.podziel_Click);
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(224, 275);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(337, 20);
            this.wynik.TabIndex = 6;
            // 
            // wyczysc
            // 
            this.wyczysc.Location = new System.Drawing.Point(323, 317);
            this.wyczysc.Name = "wyczysc";
            this.wyczysc.Size = new System.Drawing.Size(75, 23);
            this.wyczysc.TabIndex = 7;
            this.wyczysc.Text = "wyczysc";
            this.wyczysc.UseVisualStyleBackColor = true;
            this.wyczysc.Click += new System.EventHandler(this.wyczysc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wyczysc);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.podziel);
            this.Controls.Add(this.pomnoz);
            this.Controls.Add(this.odejmij);
            this.Controls.Add(this.dodaj);
            this.Controls.Add(this.liczba2);
            this.Controls.Add(this.liczba1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox liczba1;
        private System.Windows.Forms.TextBox liczba2;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button odejmij;
        private System.Windows.Forms.Button pomnoz;
        private System.Windows.Forms.Button podziel;
        private System.Windows.Forms.TextBox wynik;
        private System.Windows.Forms.Button wyczysc;
    }
}

