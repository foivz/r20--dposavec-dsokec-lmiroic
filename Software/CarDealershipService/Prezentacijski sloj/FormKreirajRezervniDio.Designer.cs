namespace Prezentacijski_sloj
{
    partial class FormKreirajRezervniDio
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
            this.panelKreirajRezervniDioHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelKreirajRezervniDioFooter = new System.Windows.Forms.Panel();
            this.uiActionAzuriraj = new System.Windows.Forms.Button();
            this.uiActionSpremi = new System.Windows.Forms.Button();
            this.uiInputGodinaProizvodnjeDijela = new System.Windows.Forms.TextBox();
            this.uiInputOpisRezervnogDijela = new System.Windows.Forms.TextBox();
            this.uiInputNazivRezervnogDijela = new System.Windows.Forms.TextBox();
            this.uiInputCijenaRezervnogDijela = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelKreirajRezervniDioHeader.SuspendLayout();
            this.panelKreirajRezervniDioFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKreirajRezervniDioHeader
            // 
            this.panelKreirajRezervniDioHeader.Controls.Add(this.label1);
            this.panelKreirajRezervniDioHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKreirajRezervniDioHeader.Location = new System.Drawing.Point(0, 0);
            this.panelKreirajRezervniDioHeader.Name = "panelKreirajRezervniDioHeader";
            this.panelKreirajRezervniDioHeader.Size = new System.Drawing.Size(800, 100);
            this.panelKreirajRezervniDioHeader.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kreiranje rezervnog dijela";
            // 
            // panelKreirajRezervniDioFooter
            // 
            this.panelKreirajRezervniDioFooter.Controls.Add(this.uiActionAzuriraj);
            this.panelKreirajRezervniDioFooter.Controls.Add(this.uiActionSpremi);
            this.panelKreirajRezervniDioFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelKreirajRezervniDioFooter.Location = new System.Drawing.Point(0, 350);
            this.panelKreirajRezervniDioFooter.Name = "panelKreirajRezervniDioFooter";
            this.panelKreirajRezervniDioFooter.Size = new System.Drawing.Size(800, 100);
            this.panelKreirajRezervniDioFooter.TabIndex = 5;
            // 
            // uiActionAzuriraj
            // 
            this.uiActionAzuriraj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionAzuriraj.FlatAppearance.BorderSize = 0;
            this.uiActionAzuriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionAzuriraj.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionAzuriraj.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionAzuriraj.Location = new System.Drawing.Point(474, 27);
            this.uiActionAzuriraj.Name = "uiActionAzuriraj";
            this.uiActionAzuriraj.Size = new System.Drawing.Size(201, 52);
            this.uiActionAzuriraj.TabIndex = 1;
            this.uiActionAzuriraj.Text = "Ažuriraj";
            this.uiActionAzuriraj.UseVisualStyleBackColor = true;
            this.uiActionAzuriraj.Click += new System.EventHandler(this.uiActionAzuriraj_Click);
            // 
            // uiActionSpremi
            // 
            this.uiActionSpremi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionSpremi.FlatAppearance.BorderSize = 0;
            this.uiActionSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionSpremi.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionSpremi.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionSpremi.Location = new System.Drawing.Point(137, 27);
            this.uiActionSpremi.Name = "uiActionSpremi";
            this.uiActionSpremi.Size = new System.Drawing.Size(201, 52);
            this.uiActionSpremi.TabIndex = 0;
            this.uiActionSpremi.Text = "Spremi";
            this.uiActionSpremi.UseVisualStyleBackColor = true;
            this.uiActionSpremi.Click += new System.EventHandler(this.uiActionSpremi_Click);
            // 
            // uiInputGodinaProizvodnjeDijela
            // 
            this.uiInputGodinaProizvodnjeDijela.Location = new System.Drawing.Point(137, 195);
            this.uiInputGodinaProizvodnjeDijela.Name = "uiInputGodinaProizvodnjeDijela";
            this.uiInputGodinaProizvodnjeDijela.Size = new System.Drawing.Size(193, 20);
            this.uiInputGodinaProizvodnjeDijela.TabIndex = 6;
            // 
            // uiInputOpisRezervnogDijela
            // 
            this.uiInputOpisRezervnogDijela.Location = new System.Drawing.Point(137, 237);
            this.uiInputOpisRezervnogDijela.Multiline = true;
            this.uiInputOpisRezervnogDijela.Name = "uiInputOpisRezervnogDijela";
            this.uiInputOpisRezervnogDijela.Size = new System.Drawing.Size(193, 83);
            this.uiInputOpisRezervnogDijela.TabIndex = 6;
            // 
            // uiInputNazivRezervnogDijela
            // 
            this.uiInputNazivRezervnogDijela.Location = new System.Drawing.Point(455, 195);
            this.uiInputNazivRezervnogDijela.Name = "uiInputNazivRezervnogDijela";
            this.uiInputNazivRezervnogDijela.Size = new System.Drawing.Size(193, 20);
            this.uiInputNazivRezervnogDijela.TabIndex = 6;
            // 
            // uiInputCijenaRezervnogDijela
            // 
            this.uiInputCijenaRezervnogDijela.Location = new System.Drawing.Point(455, 241);
            this.uiInputCijenaRezervnogDijela.Name = "uiInputCijenaRezervnogDijela";
            this.uiInputCijenaRezervnogDijela.Size = new System.Drawing.Size(193, 20);
            this.uiInputCijenaRezervnogDijela.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Godina proizvodnje";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Opis artikla";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Naziv artikla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cijena artikla";
            // 
            // FormKreirajRezervniDio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiInputCijenaRezervnogDijela);
            this.Controls.Add(this.uiInputNazivRezervnogDijela);
            this.Controls.Add(this.uiInputOpisRezervnogDijela);
            this.Controls.Add(this.uiInputGodinaProizvodnjeDijela);
            this.Controls.Add(this.panelKreirajRezervniDioFooter);
            this.Controls.Add(this.panelKreirajRezervniDioHeader);
            this.Name = "FormKreirajRezervniDio";
            this.Text = "Kreiranje rezervnih dijelova";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKreirajRezervniDio_FormClosed);
            this.Load += new System.EventHandler(this.FormKreirajRezervniDio_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormKreirajRezervniDio_HelpRequested);
            this.panelKreirajRezervniDioHeader.ResumeLayout(false);
            this.panelKreirajRezervniDioHeader.PerformLayout();
            this.panelKreirajRezervniDioFooter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelKreirajRezervniDioHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelKreirajRezervniDioFooter;
        private System.Windows.Forms.Button uiActionSpremi;
        private System.Windows.Forms.TextBox uiInputGodinaProizvodnjeDijela;
        private System.Windows.Forms.TextBox uiInputOpisRezervnogDijela;
        private System.Windows.Forms.TextBox uiInputNazivRezervnogDijela;
        private System.Windows.Forms.TextBox uiInputCijenaRezervnogDijela;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button uiActionAzuriraj;
    }
}