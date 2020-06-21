namespace Prezentacijski_sloj
{
    partial class FormUpravljanjeSkladistem
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
            this.dgvSviArtikliNaSkladistu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUpravSkladistemHeader = new System.Windows.Forms.Panel();
            this.panelUpravSkladistemFooter = new System.Windows.Forms.Panel();
            this.uiActionKreiranjeRezervnogDijela = new System.Windows.Forms.Button();
            this.uiActionAzuriranje = new System.Windows.Forms.Button();
            this.uiActionKreiraj = new System.Windows.Forms.Button();
            this.uiActionBrisanje = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviArtikliNaSkladistu)).BeginInit();
            this.panelUpravSkladistemHeader.SuspendLayout();
            this.panelUpravSkladistemFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSviArtikliNaSkladistu
            // 
            this.dgvSviArtikliNaSkladistu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSviArtikliNaSkladistu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSviArtikliNaSkladistu.Location = new System.Drawing.Point(12, 99);
            this.dgvSviArtikliNaSkladistu.Name = "dgvSviArtikliNaSkladistu";
            this.dgvSviArtikliNaSkladistu.Size = new System.Drawing.Size(914, 305);
            this.dgvSviArtikliNaSkladistu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(359, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skladište";
            // 
            // panelUpravSkladistemHeader
            // 
            this.panelUpravSkladistemHeader.Controls.Add(this.label1);
            this.panelUpravSkladistemHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUpravSkladistemHeader.Location = new System.Drawing.Point(0, 0);
            this.panelUpravSkladistemHeader.Name = "panelUpravSkladistemHeader";
            this.panelUpravSkladistemHeader.Size = new System.Drawing.Size(938, 100);
            this.panelUpravSkladistemHeader.TabIndex = 2;
            // 
            // panelUpravSkladistemFooter
            // 
            this.panelUpravSkladistemFooter.Controls.Add(this.uiActionKreiranjeRezervnogDijela);
            this.panelUpravSkladistemFooter.Controls.Add(this.uiActionAzuriranje);
            this.panelUpravSkladistemFooter.Controls.Add(this.uiActionKreiraj);
            this.panelUpravSkladistemFooter.Controls.Add(this.uiActionBrisanje);
            this.panelUpravSkladistemFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUpravSkladistemFooter.Location = new System.Drawing.Point(0, 402);
            this.panelUpravSkladistemFooter.Name = "panelUpravSkladistemFooter";
            this.panelUpravSkladistemFooter.Size = new System.Drawing.Size(938, 100);
            this.panelUpravSkladistemFooter.TabIndex = 3;
            // 
            // uiActionKreiranjeRezervnogDijela
            // 
            this.uiActionKreiranjeRezervnogDijela.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionKreiranjeRezervnogDijela.FlatAppearance.BorderSize = 0;
            this.uiActionKreiranjeRezervnogDijela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionKreiranjeRezervnogDijela.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionKreiranjeRezervnogDijela.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionKreiranjeRezervnogDijela.Location = new System.Drawing.Point(703, 24);
            this.uiActionKreiranjeRezervnogDijela.Name = "uiActionKreiranjeRezervnogDijela";
            this.uiActionKreiranjeRezervnogDijela.Size = new System.Drawing.Size(201, 52);
            this.uiActionKreiranjeRezervnogDijela.TabIndex = 1;
            this.uiActionKreiranjeRezervnogDijela.Text = "Kreiranje rezervnog dijela";
            this.uiActionKreiranjeRezervnogDijela.UseVisualStyleBackColor = true;
            this.uiActionKreiranjeRezervnogDijela.Click += new System.EventHandler(this.uiActionKreiranjeRezervnogDijela_Click);
            // 
            // uiActionAzuriranje
            // 
            this.uiActionAzuriranje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionAzuriranje.FlatAppearance.BorderSize = 0;
            this.uiActionAzuriranje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionAzuriranje.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionAzuriranje.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionAzuriranje.Location = new System.Drawing.Point(263, 24);
            this.uiActionAzuriranje.Name = "uiActionAzuriranje";
            this.uiActionAzuriranje.Size = new System.Drawing.Size(201, 52);
            this.uiActionAzuriranje.TabIndex = 0;
            this.uiActionAzuriranje.Text = "Azuriranje artikla";
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
            this.uiActionKreiraj.Location = new System.Drawing.Point(470, 24);
            this.uiActionKreiraj.Name = "uiActionKreiraj";
            this.uiActionKreiraj.Size = new System.Drawing.Size(201, 52);
            this.uiActionKreiraj.TabIndex = 0;
            this.uiActionKreiraj.Text = "Kreiranje vozila";
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
            this.uiActionBrisanje.Location = new System.Drawing.Point(56, 24);
            this.uiActionBrisanje.Name = "uiActionBrisanje";
            this.uiActionBrisanje.Size = new System.Drawing.Size(201, 52);
            this.uiActionBrisanje.TabIndex = 0;
            this.uiActionBrisanje.Text = "Brisanje artikla";
            this.uiActionBrisanje.UseVisualStyleBackColor = true;
            this.uiActionBrisanje.Click += new System.EventHandler(this.uiActionBrisanje_Click);
            // 
            // FormUpravljanjeSkladistem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 502);
            this.Controls.Add(this.panelUpravSkladistemFooter);
            this.Controls.Add(this.panelUpravSkladistemHeader);
            this.Controls.Add(this.dgvSviArtikliNaSkladistu);
            this.Name = "FormUpravljanjeSkladistem";
            this.Text = "Upravljanje skladistem";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUpravljanjeSkladistem_FormClosed);
            this.Load += new System.EventHandler(this.FormUpravljanjeSkladistem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSviArtikliNaSkladistu)).EndInit();
            this.panelUpravSkladistemHeader.ResumeLayout(false);
            this.panelUpravSkladistemHeader.PerformLayout();
            this.panelUpravSkladistemFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSviArtikliNaSkladistu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUpravSkladistemHeader;
        private System.Windows.Forms.Panel panelUpravSkladistemFooter;
        private System.Windows.Forms.Button uiActionAzuriranje;
        private System.Windows.Forms.Button uiActionKreiraj;
        private System.Windows.Forms.Button uiActionBrisanje;
        private System.Windows.Forms.Button uiActionKreiranjeRezervnogDijela;
    }
}