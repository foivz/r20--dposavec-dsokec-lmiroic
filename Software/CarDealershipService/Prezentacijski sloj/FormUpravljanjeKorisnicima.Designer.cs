namespace Prezentacijski_sloj
{
    partial class FormUpravljanjeKorisnicima
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
            this.uiActionBrisanje = new System.Windows.Forms.Button();
            this.dgvUpravljanjeKorisnicima = new System.Windows.Forms.DataGridView();
            this.panelUpravKorisnicimaHeader.SuspendLayout();
            this.panelUpravKorisnicimaFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpravljanjeKorisnicima)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUpravKorisnicimaHeader
            // 
            this.panelUpravKorisnicimaHeader.Controls.Add(this.label1);
            this.panelUpravKorisnicimaHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpravKorisnicimaHeader.Location = new System.Drawing.Point(0, 0);
            this.panelUpravKorisnicimaHeader.Name = "panelUpravKorisnicimaHeader";
            this.panelUpravKorisnicimaHeader.Size = new System.Drawing.Size(860, 100);
            this.panelUpravKorisnicimaHeader.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(320, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Korisnici";
            // 
            // panelUpravKorisnicimaFooter
            // 
            this.panelUpravKorisnicimaFooter.Controls.Add(this.uiActionAzuriranje);
            this.panelUpravKorisnicimaFooter.Controls.Add(this.uiActionKreiraj);
            this.panelUpravKorisnicimaFooter.Controls.Add(this.uiActionBrisanje);
            this.panelUpravKorisnicimaFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUpravKorisnicimaFooter.Location = new System.Drawing.Point(0, 350);
            this.panelUpravKorisnicimaFooter.Name = "panelUpravKorisnicimaFooter";
            this.panelUpravKorisnicimaFooter.Size = new System.Drawing.Size(860, 100);
            this.panelUpravKorisnicimaFooter.TabIndex = 4;
            // 
            // uiActionAzuriranje
            // 
            this.uiActionAzuriranje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionAzuriranje.FlatAppearance.BorderSize = 0;
            this.uiActionAzuriranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionAzuriranje.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionAzuriranje.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionAzuriranje.Location = new System.Drawing.Point(330, 24);
            this.uiActionAzuriranje.Name = "uiActionAzuriranje";
            this.uiActionAzuriranje.Size = new System.Drawing.Size(201, 52);
            this.uiActionAzuriranje.TabIndex = 0;
            this.uiActionAzuriranje.Text = "Azuriranje korisnika";
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
            this.uiActionKreiraj.Location = new System.Drawing.Point(579, 24);
            this.uiActionKreiraj.Name = "uiActionKreiraj";
            this.uiActionKreiraj.Size = new System.Drawing.Size(201, 52);
            this.uiActionKreiraj.TabIndex = 0;
            this.uiActionKreiraj.Text = "Kreiranje korisnika";
            this.uiActionKreiraj.UseVisualStyleBackColor = true;
            this.uiActionKreiraj.Click += new System.EventHandler(this.uiActionKreiraj_Click);
            // 
            // uiActionBrisanje
            // 
            this.uiActionBrisanje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionBrisanje.FlatAppearance.BorderSize = 0;
            this.uiActionBrisanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionBrisanje.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionBrisanje.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionBrisanje.Location = new System.Drawing.Point(68, 24);
            this.uiActionBrisanje.Name = "uiActionBrisanje";
            this.uiActionBrisanje.Size = new System.Drawing.Size(201, 52);
            this.uiActionBrisanje.TabIndex = 0;
            this.uiActionBrisanje.Text = "Brisanje korisnika";
            this.uiActionBrisanje.UseVisualStyleBackColor = true;
            this.uiActionBrisanje.Click += new System.EventHandler(this.uiActionBrisanje_Click);
            // 
            // dgvUpravljanjeKorisnicima
            // 
            this.dgvUpravljanjeKorisnicima.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUpravljanjeKorisnicima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpravljanjeKorisnicima.Location = new System.Drawing.Point(0, 98);
            this.dgvUpravljanjeKorisnicima.Name = "dgvUpravljanjeKorisnicima";
            this.dgvUpravljanjeKorisnicima.Size = new System.Drawing.Size(860, 252);
            this.dgvUpravljanjeKorisnicima.TabIndex = 5;
            // 
            // FormUpravljanjeKorisnicima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 450);
            this.Controls.Add(this.dgvUpravljanjeKorisnicima);
            this.Controls.Add(this.panelUpravKorisnicimaFooter);
            this.Controls.Add(this.panelUpravKorisnicimaHeader);
            this.Name = "FormUpravljanjeKorisnicima";
            this.Text = "Upravljanje korisnicima";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUpravljanjeKorisnicima_FormClosed);
            this.Load += new System.EventHandler(this.FormUpravljanjeKorisnicima_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormUpravljanjeKorisnicima_HelpRequested);
            this.panelUpravKorisnicimaHeader.ResumeLayout(false);
            this.panelUpravKorisnicimaHeader.PerformLayout();
            this.panelUpravKorisnicimaFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpravljanjeKorisnicima)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpravKorisnicimaHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUpravKorisnicimaFooter;
        private System.Windows.Forms.Button uiActionAzuriranje;
        private System.Windows.Forms.Button uiActionKreiraj;
        private System.Windows.Forms.Button uiActionBrisanje;
        private System.Windows.Forms.DataGridView dgvUpravljanjeKorisnicima;
    }
}