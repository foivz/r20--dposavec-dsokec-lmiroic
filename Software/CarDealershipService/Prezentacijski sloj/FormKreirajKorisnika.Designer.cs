namespace Prezentacijski_sloj
{
    partial class FormKreirajKorisnika
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
            this.panelUpravKorisnicimaHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUpravKorisnicimaFooter = new System.Windows.Forms.Panel();
            this.uiActionAzuriranje = new System.Windows.Forms.Button();
            this.uiActionKreiraj = new System.Windows.Forms.Button();
            this.uiInputImeKorisnika = new System.Windows.Forms.TextBox();
            this.uiInputPrezimeKorisnika = new System.Windows.Forms.TextBox();
            this.uiInputAdresaKorisnika = new System.Windows.Forms.TextBox();
            this.uiInputIBANKorisnika = new System.Windows.Forms.TextBox();
            this.uiInputKorisnickoIme = new System.Windows.Forms.TextBox();
            this.uiInputLozinka = new System.Windows.Forms.TextBox();
            this.uiInputMailKorisnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uiInputTipKorisnika = new System.Windows.Forms.ComboBox();
            this.uiInputKorisnikovaPoslovnica = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelUpravKorisnicimaHeader.SuspendLayout();
            this.panelUpravKorisnicimaFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUpravKorisnicimaHeader
            // 
            this.panelUpravKorisnicimaHeader.Controls.Add(this.label1);
            this.panelUpravKorisnicimaHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpravKorisnicimaHeader.Location = new System.Drawing.Point(0, 0);
            this.panelUpravKorisnicimaHeader.Name = "panelUpravKorisnicimaHeader";
            this.panelUpravKorisnicimaHeader.Size = new System.Drawing.Size(800, 100);
            this.panelUpravKorisnicimaHeader.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(290, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisnici";
            // 
            // panelUpravKorisnicimaFooter
            // 
            this.panelUpravKorisnicimaFooter.Controls.Add(this.uiActionAzuriranje);
            this.panelUpravKorisnicimaFooter.Controls.Add(this.uiActionKreiraj);
            this.panelUpravKorisnicimaFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUpravKorisnicimaFooter.Location = new System.Drawing.Point(0, 350);
            this.panelUpravKorisnicimaFooter.Name = "panelUpravKorisnicimaFooter";
            this.panelUpravKorisnicimaFooter.Size = new System.Drawing.Size(800, 100);
            this.panelUpravKorisnicimaFooter.TabIndex = 5;
            // 
            // uiActionAzuriranje
            // 
            this.uiActionAzuriranje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionAzuriranje.FlatAppearance.BorderSize = 0;
            this.uiActionAzuriranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionAzuriranje.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionAzuriranje.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionAzuriranje.Location = new System.Drawing.Point(487, 24);
            this.uiActionAzuriranje.Name = "uiActionAzuriranje";
            this.uiActionAzuriranje.Size = new System.Drawing.Size(201, 52);
            this.uiActionAzuriranje.TabIndex = 0;
            this.uiActionAzuriranje.Text = "Ažuriraj";
            this.uiActionAzuriranje.UseVisualStyleBackColor = true;
            this.uiActionAzuriranje.Click += new System.EventHandler(this.uiActionAzuriranje_Click);
            // 
            // uiActionKreiraj
            // 
            this.uiActionKreiraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionKreiraj.FlatAppearance.BorderSize = 0;
            this.uiActionKreiraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionKreiraj.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionKreiraj.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionKreiraj.Location = new System.Drawing.Point(134, 24);
            this.uiActionKreiraj.Name = "uiActionKreiraj";
            this.uiActionKreiraj.Size = new System.Drawing.Size(201, 52);
            this.uiActionKreiraj.TabIndex = 0;
            this.uiActionKreiraj.Text = "Spremi";
            this.uiActionKreiraj.UseVisualStyleBackColor = true;
            this.uiActionKreiraj.Click += new System.EventHandler(this.uiActionKreiraj_Click);
            // 
            // uiInputImeKorisnika
            // 
            this.uiInputImeKorisnika.Location = new System.Drawing.Point(172, 131);
            this.uiInputImeKorisnika.Name = "uiInputImeKorisnika";
            this.uiInputImeKorisnika.Size = new System.Drawing.Size(166, 20);
            this.uiInputImeKorisnika.TabIndex = 6;
            // 
            // uiInputPrezimeKorisnika
            // 
            this.uiInputPrezimeKorisnika.Location = new System.Drawing.Point(172, 173);
            this.uiInputPrezimeKorisnika.Name = "uiInputPrezimeKorisnika";
            this.uiInputPrezimeKorisnika.Size = new System.Drawing.Size(166, 20);
            this.uiInputPrezimeKorisnika.TabIndex = 6;
            // 
            // uiInputAdresaKorisnika
            // 
            this.uiInputAdresaKorisnika.Location = new System.Drawing.Point(172, 218);
            this.uiInputAdresaKorisnika.Name = "uiInputAdresaKorisnika";
            this.uiInputAdresaKorisnika.Size = new System.Drawing.Size(166, 20);
            this.uiInputAdresaKorisnika.TabIndex = 6;
            // 
            // uiInputIBANKorisnika
            // 
            this.uiInputIBANKorisnika.Location = new System.Drawing.Point(172, 307);
            this.uiInputIBANKorisnika.Name = "uiInputIBANKorisnika";
            this.uiInputIBANKorisnika.Size = new System.Drawing.Size(166, 20);
            this.uiInputIBANKorisnika.TabIndex = 6;
            // 
            // uiInputKorisnickoIme
            // 
            this.uiInputKorisnickoIme.Location = new System.Drawing.Point(469, 157);
            this.uiInputKorisnickoIme.Name = "uiInputKorisnickoIme";
            this.uiInputKorisnickoIme.Size = new System.Drawing.Size(166, 20);
            this.uiInputKorisnickoIme.TabIndex = 6;
            // 
            // uiInputLozinka
            // 
            this.uiInputLozinka.Location = new System.Drawing.Point(469, 202);
            this.uiInputLozinka.Name = "uiInputLozinka";
            this.uiInputLozinka.Size = new System.Drawing.Size(166, 20);
            this.uiInputLozinka.TabIndex = 6;
            // 
            // uiInputMailKorisnika
            // 
            this.uiInputMailKorisnika.Location = new System.Drawing.Point(172, 262);
            this.uiInputMailKorisnika.Name = "uiInputMailKorisnika";
            this.uiInputMailKorisnika.Size = new System.Drawing.Size(166, 20);
            this.uiInputMailKorisnika.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prezime";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "E-mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "IBAN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(466, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Korisničko ime";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Lozinka";
            // 
            // uiInputTipKorisnika
            // 
            this.uiInputTipKorisnika.FormattingEnabled = true;
            this.uiInputTipKorisnika.Location = new System.Drawing.Point(469, 246);
            this.uiInputTipKorisnika.Name = "uiInputTipKorisnika";
            this.uiInputTipKorisnika.Size = new System.Drawing.Size(166, 21);
            this.uiInputTipKorisnika.TabIndex = 8;
            // 
            // uiInputKorisnikovaPoslovnica
            // 
            this.uiInputKorisnikovaPoslovnica.FormattingEnabled = true;
            this.uiInputKorisnikovaPoslovnica.Location = new System.Drawing.Point(469, 291);
            this.uiInputKorisnikovaPoslovnica.Name = "uiInputKorisnikovaPoslovnica";
            this.uiInputKorisnikovaPoslovnica.Size = new System.Drawing.Size(166, 21);
            this.uiInputKorisnikovaPoslovnica.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(466, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Tip korisnika";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(466, 275);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Poslovnica";
            // 
            // FormKreirajKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiInputKorisnikovaPoslovnica);
            this.Controls.Add(this.uiInputTipKorisnika);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiInputMailKorisnika);
            this.Controls.Add(this.uiInputLozinka);
            this.Controls.Add(this.uiInputKorisnickoIme);
            this.Controls.Add(this.uiInputIBANKorisnika);
            this.Controls.Add(this.uiInputAdresaKorisnika);
            this.Controls.Add(this.uiInputPrezimeKorisnika);
            this.Controls.Add(this.uiInputImeKorisnika);
            this.Controls.Add(this.panelUpravKorisnicimaFooter);
            this.Controls.Add(this.panelUpravKorisnicimaHeader);
            this.Name = "FormKreirajKorisnika";
            this.Text = "FormKreirajKorisnika";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKreirajKorisnika_FormClosed);
            this.Load += new System.EventHandler(this.FormKreirajKorisnika_Load);
            this.panelUpravKorisnicimaHeader.ResumeLayout(false);
            this.panelUpravKorisnicimaHeader.PerformLayout();
            this.panelUpravKorisnicimaFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelUpravKorisnicimaHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUpravKorisnicimaFooter;
        private System.Windows.Forms.Button uiActionAzuriranje;
        private System.Windows.Forms.Button uiActionKreiraj;
        private System.Windows.Forms.TextBox uiInputImeKorisnika;
        private System.Windows.Forms.TextBox uiInputPrezimeKorisnika;
        private System.Windows.Forms.TextBox uiInputAdresaKorisnika;
        private System.Windows.Forms.TextBox uiInputIBANKorisnika;
        private System.Windows.Forms.TextBox uiInputKorisnickoIme;
        private System.Windows.Forms.TextBox uiInputLozinka;
        private System.Windows.Forms.TextBox uiInputMailKorisnika;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox uiInputTipKorisnika;
        private System.Windows.Forms.ComboBox uiInputKorisnikovaPoslovnica;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}