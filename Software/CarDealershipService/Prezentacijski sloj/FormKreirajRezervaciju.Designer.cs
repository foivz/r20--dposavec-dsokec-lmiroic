namespace Prezentacijski_sloj
{
    partial class FormKreirajRezervaciju
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
            this.panelKreirajRezervacijuHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.uiInputTipDokumenta = new System.Windows.Forms.TextBox();
            this.uiInputUkupniSaldo = new System.Windows.Forms.TextBox();
            this.uiInputZaposlenik = new System.Windows.Forms.TextBox();
            this.uiInputOpisDokumenta = new System.Windows.Forms.TextBox();
            this.dateTimeInputDatumIzdavanja = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.paneKreirajRezervacijuFooter = new System.Windows.Forms.Panel();
            this.uiACtionSpremiRezervaciju = new System.Windows.Forms.Button();
            this.cbInputKorisnik = new System.Windows.Forms.ComboBox();
            this.panelKreirajRezervacijuHeader.SuspendLayout();
            this.paneKreirajRezervacijuFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKreirajRezervacijuHeader
            // 
            this.panelKreirajRezervacijuHeader.Controls.Add(this.label1);
            this.panelKreirajRezervacijuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKreirajRezervacijuHeader.Location = new System.Drawing.Point(0, 0);
            this.panelKreirajRezervacijuHeader.Name = "panelKreirajRezervacijuHeader";
            this.panelKreirajRezervacijuHeader.Size = new System.Drawing.Size(800, 100);
            this.panelKreirajRezervacijuHeader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kreiraj rezervaciju";
            // 
            // uiInputTipDokumenta
            // 
            this.uiInputTipDokumenta.Location = new System.Drawing.Point(518, 171);
            this.uiInputTipDokumenta.Name = "uiInputTipDokumenta";
            this.uiInputTipDokumenta.Size = new System.Drawing.Size(147, 20);
            this.uiInputTipDokumenta.TabIndex = 3;
            // 
            // uiInputUkupniSaldo
            // 
            this.uiInputUkupniSaldo.Location = new System.Drawing.Point(166, 271);
            this.uiInputUkupniSaldo.Name = "uiInputUkupniSaldo";
            this.uiInputUkupniSaldo.Size = new System.Drawing.Size(147, 20);
            this.uiInputUkupniSaldo.TabIndex = 3;
            // 
            // uiInputZaposlenik
            // 
            this.uiInputZaposlenik.Location = new System.Drawing.Point(518, 271);
            this.uiInputZaposlenik.Name = "uiInputZaposlenik";
            this.uiInputZaposlenik.Size = new System.Drawing.Size(147, 20);
            this.uiInputZaposlenik.TabIndex = 3;
            // 
            // uiInputOpisDokumenta
            // 
            this.uiInputOpisDokumenta.Location = new System.Drawing.Point(166, 222);
            this.uiInputOpisDokumenta.Name = "uiInputOpisDokumenta";
            this.uiInputOpisDokumenta.Size = new System.Drawing.Size(147, 20);
            this.uiInputOpisDokumenta.TabIndex = 3;
            // 
            // dateTimeInputDatumIzdavanja
            // 
            this.dateTimeInputDatumIzdavanja.Location = new System.Drawing.Point(166, 171);
            this.dateTimeInputDatumIzdavanja.Name = "dateTimeInputDatumIzdavanja";
            this.dateTimeInputDatumIzdavanja.Size = new System.Drawing.Size(147, 20);
            this.dateTimeInputDatumIzdavanja.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Datum izdavanja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opis dokumenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ukupni saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tip dokumenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(515, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Korisnik";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(515, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Zaposlenik";
            // 
            // paneKreirajRezervacijuFooter
            // 
            this.paneKreirajRezervacijuFooter.Controls.Add(this.uiACtionSpremiRezervaciju);
            this.paneKreirajRezervacijuFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paneKreirajRezervacijuFooter.Location = new System.Drawing.Point(0, 350);
            this.paneKreirajRezervacijuFooter.Name = "paneKreirajRezervacijuFooter";
            this.paneKreirajRezervacijuFooter.Size = new System.Drawing.Size(800, 100);
            this.paneKreirajRezervacijuFooter.TabIndex = 6;
            // 
            // uiACtionSpremiRezervaciju
            // 
            this.uiACtionSpremiRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiACtionSpremiRezervaciju.FlatAppearance.BorderSize = 0;
            this.uiACtionSpremiRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiACtionSpremiRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiACtionSpremiRezervaciju.ForeColor = System.Drawing.Color.LightGray;
            this.uiACtionSpremiRezervaciju.Location = new System.Drawing.Point(324, 19);
            this.uiACtionSpremiRezervaciju.Name = "uiACtionSpremiRezervaciju";
            this.uiACtionSpremiRezervaciju.Size = new System.Drawing.Size(162, 58);
            this.uiACtionSpremiRezervaciju.TabIndex = 0;
            this.uiACtionSpremiRezervaciju.Text = "Spremi ";
            this.uiACtionSpremiRezervaciju.UseVisualStyleBackColor = true;
            // 
            // cbInputKorisnik
            // 
            this.cbInputKorisnik.FormattingEnabled = true;
            this.cbInputKorisnik.Location = new System.Drawing.Point(518, 220);
            this.cbInputKorisnik.Name = "cbInputKorisnik";
            this.cbInputKorisnik.Size = new System.Drawing.Size(147, 21);
            this.cbInputKorisnik.TabIndex = 7;
            // 
            // FormKreirajRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbInputKorisnik);
            this.Controls.Add(this.paneKreirajRezervacijuFooter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeInputDatumIzdavanja);
            this.Controls.Add(this.uiInputOpisDokumenta);
            this.Controls.Add(this.uiInputZaposlenik);
            this.Controls.Add(this.uiInputUkupniSaldo);
            this.Controls.Add(this.uiInputTipDokumenta);
            this.Controls.Add(this.panelKreirajRezervacijuHeader);
            this.Name = "FormKreirajRezervaciju";
            this.Text = "FormKreirajRezervaciju";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKreirajRezervaciju_FormClosed);
            this.Load += new System.EventHandler(this.FormKreirajRezervaciju_Load);
            this.panelKreirajRezervacijuHeader.ResumeLayout(false);
            this.panelKreirajRezervacijuHeader.PerformLayout();
            this.paneKreirajRezervacijuFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelKreirajRezervacijuHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uiInputTipDokumenta;
        private System.Windows.Forms.TextBox uiInputUkupniSaldo;
        private System.Windows.Forms.TextBox uiInputZaposlenik;
        private System.Windows.Forms.TextBox uiInputOpisDokumenta;
        private System.Windows.Forms.DateTimePicker dateTimeInputDatumIzdavanja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel paneKreirajRezervacijuFooter;
        private System.Windows.Forms.Button uiACtionSpremiRezervaciju;
        private System.Windows.Forms.ComboBox cbInputKorisnik;
    }
}