namespace Prezentacijski_sloj
{
    partial class FormUpravljanjeRezervacijama
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
            this.dgvUpravRezervacijamaSveRezervacije = new System.Windows.Forms.DataGridView();
            this.panelUpravRezervacijamaHeader = new System.Windows.Forms.Panel();
            this.panelUpravRezervacijamaFooter = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.uiActionAzuriranjRervacije = new System.Windows.Forms.Button();
            this.uiActionObrisiRezervacije = new System.Windows.Forms.Button();
            this.uiActionKreirajRezervaciju = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpravRezervacijamaSveRezervacije)).BeginInit();
            this.panelUpravRezervacijamaHeader.SuspendLayout();
            this.panelUpravRezervacijamaFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUpravRezervacijamaSveRezervacije
            // 
            this.dgvUpravRezervacijamaSveRezervacije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUpravRezervacijamaSveRezervacije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpravRezervacijamaSveRezervacije.Location = new System.Drawing.Point(0, 95);
            this.dgvUpravRezervacijamaSveRezervacije.Name = "dgvUpravRezervacijamaSveRezervacije";
            this.dgvUpravRezervacijamaSveRezervacije.Size = new System.Drawing.Size(800, 260);
            this.dgvUpravRezervacijamaSveRezervacije.TabIndex = 0;
            // 
            // panelUpravRezervacijamaHeader
            // 
            this.panelUpravRezervacijamaHeader.Controls.Add(this.label1);
            this.panelUpravRezervacijamaHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpravRezervacijamaHeader.Location = new System.Drawing.Point(0, 0);
            this.panelUpravRezervacijamaHeader.Name = "panelUpravRezervacijamaHeader";
            this.panelUpravRezervacijamaHeader.Size = new System.Drawing.Size(800, 100);
            this.panelUpravRezervacijamaHeader.TabIndex = 1;
            // 
            // panelUpravRezervacijamaFooter
            // 
            this.panelUpravRezervacijamaFooter.Controls.Add(this.uiActionKreirajRezervaciju);
            this.panelUpravRezervacijamaFooter.Controls.Add(this.uiActionObrisiRezervacije);
            this.panelUpravRezervacijamaFooter.Controls.Add(this.uiActionAzuriranjRervacije);
            this.panelUpravRezervacijamaFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUpravRezervacijamaFooter.Location = new System.Drawing.Point(0, 350);
            this.panelUpravRezervacijamaFooter.Name = "panelUpravRezervacijamaFooter";
            this.panelUpravRezervacijamaFooter.Size = new System.Drawing.Size(800, 100);
            this.panelUpravRezervacijamaFooter.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervacije";
            // 
            // uiActionAzuriranjRervacije
            // 
            this.uiActionAzuriranjRervacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionAzuriranjRervacije.FlatAppearance.BorderSize = 0;
            this.uiActionAzuriranjRervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionAzuriranjRervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionAzuriranjRervacije.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionAzuriranjRervacije.Location = new System.Drawing.Point(51, 11);
            this.uiActionAzuriranjRervacije.Name = "uiActionAzuriranjRervacije";
            this.uiActionAzuriranjRervacije.Size = new System.Drawing.Size(162, 58);
            this.uiActionAzuriranjRervacije.TabIndex = 0;
            this.uiActionAzuriranjRervacije.Text = "Azuriraj rezervaciju";
            this.uiActionAzuriranjRervacije.UseVisualStyleBackColor = true;
            this.uiActionAzuriranjRervacije.Click += new System.EventHandler(this.uiActionAzuriranjeRezervacije_Click);
            // 
            // uiActionObrisiRezervacije
            // 
            this.uiActionObrisiRezervacije.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionObrisiRezervacije.FlatAppearance.BorderSize = 0;
            this.uiActionObrisiRezervacije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionObrisiRezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionObrisiRezervacije.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionObrisiRezervacije.Location = new System.Drawing.Point(325, 11);
            this.uiActionObrisiRezervacije.Name = "uiActionObrisiRezervacije";
            this.uiActionObrisiRezervacije.Size = new System.Drawing.Size(162, 58);
            this.uiActionObrisiRezervacije.TabIndex = 0;
            this.uiActionObrisiRezervacije.Text = "Obrisi rezervaciju";
            this.uiActionObrisiRezervacije.UseVisualStyleBackColor = true;
            this.uiActionObrisiRezervacije.Click += new System.EventHandler(this.uiActionObrisiRezervacije_Click);
            // 
            // uiActionKreirajRezervaciju
            // 
            this.uiActionKreirajRezervaciju.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionKreirajRezervaciju.FlatAppearance.BorderSize = 0;
            this.uiActionKreirajRezervaciju.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionKreirajRezervaciju.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionKreirajRezervaciju.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionKreirajRezervaciju.Location = new System.Drawing.Point(561, 11);
            this.uiActionKreirajRezervaciju.Name = "uiActionKreirajRezervaciju";
            this.uiActionKreirajRezervaciju.Size = new System.Drawing.Size(162, 58);
            this.uiActionKreirajRezervaciju.TabIndex = 0;
            this.uiActionKreirajRezervaciju.Text = "Kreiraj rezervaciju";
            this.uiActionKreirajRezervaciju.UseVisualStyleBackColor = true;
            this.uiActionKreirajRezervaciju.Click += new System.EventHandler(this.uiActionKreirajRezervaciju_Click);
            // 
            // FormUpravljanjeRezervacijama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelUpravRezervacijamaFooter);
            this.Controls.Add(this.panelUpravRezervacijamaHeader);
            this.Controls.Add(this.dgvUpravRezervacijamaSveRezervacije);
            this.Name = "FormUpravljanjeRezervacijama";
            this.Text = "FormUpravljanjeRezervacijama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUpravljanjeRezervacijama_FormClosed);
            this.Load += new System.EventHandler(this.FormUpravljanjeRezervacijama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpravRezervacijamaSveRezervacije)).EndInit();
            this.panelUpravRezervacijamaHeader.ResumeLayout(false);
            this.panelUpravRezervacijamaHeader.PerformLayout();
            this.panelUpravRezervacijamaFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUpravRezervacijamaSveRezervacije;
        private System.Windows.Forms.Panel panelUpravRezervacijamaHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUpravRezervacijamaFooter;
        private System.Windows.Forms.Button uiActionKreirajRezervaciju;
        private System.Windows.Forms.Button uiActionObrisiRezervacije;
        private System.Windows.Forms.Button uiActionAzuriranjRervacije;
    }
}