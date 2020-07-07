namespace Prezentacijski_sloj
{
    partial class FormProdajaArtikla
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
            this.dgvProdajniArtikli = new System.Windows.Forms.DataGridView();
            this.panelProdajaArtikalaHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelProdajaArtikalaFooter = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.uiInputKlijenti = new System.Windows.Forms.ComboBox();
            this.lblSuma = new System.Windows.Forms.Label();
            this.uiActionProdaja = new System.Windows.Forms.Button();
            this.dgvOdabraniArtikli = new System.Windows.Forms.DataGridView();
            this.panelProdajaArtiklaOdabraniArtikli = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdajniArtikli)).BeginInit();
            this.panelProdajaArtikalaHeader.SuspendLayout();
            this.panelProdajaArtikalaFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniArtikli)).BeginInit();
            this.panelProdajaArtiklaOdabraniArtikli.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProdajniArtikli
            // 
            this.dgvProdajniArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdajniArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdajniArtikli.Location = new System.Drawing.Point(0, 97);
            this.dgvProdajniArtikli.Name = "dgvProdajniArtikli";
            this.dgvProdajniArtikli.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdajniArtikli.Size = new System.Drawing.Size(1101, 218);
            this.dgvProdajniArtikli.TabIndex = 0;
            this.dgvProdajniArtikli.DoubleClick += new System.EventHandler(this.dgvProdajniArtikli_DoubleClick);
            // 
            // panelProdajaArtikalaHeader
            // 
            this.panelProdajaArtikalaHeader.Controls.Add(this.label1);
            this.panelProdajaArtikalaHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProdajaArtikalaHeader.Location = new System.Drawing.Point(0, 0);
            this.panelProdajaArtikalaHeader.Name = "panelProdajaArtikalaHeader";
            this.panelProdajaArtikalaHeader.Size = new System.Drawing.Size(1101, 100);
            this.panelProdajaArtikalaHeader.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(456, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prodaja";
            // 
            // panelProdajaArtikalaFooter
            // 
            this.panelProdajaArtikalaFooter.Controls.Add(this.label3);
            this.panelProdajaArtikalaFooter.Controls.Add(this.uiInputKlijenti);
            this.panelProdajaArtikalaFooter.Controls.Add(this.lblSuma);
            this.panelProdajaArtikalaFooter.Controls.Add(this.uiActionProdaja);
            this.panelProdajaArtikalaFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelProdajaArtikalaFooter.Location = new System.Drawing.Point(0, 514);
            this.panelProdajaArtikalaFooter.Name = "panelProdajaArtikalaFooter";
            this.panelProdajaArtikalaFooter.Size = new System.Drawing.Size(1101, 100);
            this.panelProdajaArtikalaFooter.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(767, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Klijent";
            // 
            // uiInputKlijenti
            // 
            this.uiInputKlijenti.FormattingEnabled = true;
            this.uiInputKlijenti.Location = new System.Drawing.Point(836, 46);
            this.uiInputKlijenti.Name = "uiInputKlijenti";
            this.uiInputKlijenti.Size = new System.Drawing.Size(150, 21);
            this.uiInputKlijenti.TabIndex = 2;
            // 
            // lblSuma
            // 
            this.lblSuma.AutoSize = true;
            this.lblSuma.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuma.ForeColor = System.Drawing.Color.LightGray;
            this.lblSuma.Location = new System.Drawing.Point(108, 42);
            this.lblSuma.Name = "lblSuma";
            this.lblSuma.Size = new System.Drawing.Size(57, 22);
            this.lblSuma.TabIndex = 1;
            this.lblSuma.Text = "label3";
            // 
            // uiActionProdaja
            // 
            this.uiActionProdaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionProdaja.FlatAppearance.BorderSize = 0;
            this.uiActionProdaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionProdaja.Font = new System.Drawing.Font("Modern No. 20", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionProdaja.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionProdaja.Location = new System.Drawing.Point(446, 26);
            this.uiActionProdaja.Name = "uiActionProdaja";
            this.uiActionProdaja.Size = new System.Drawing.Size(201, 52);
            this.uiActionProdaja.TabIndex = 0;
            this.uiActionProdaja.Text = "Prodaj";
            this.uiActionProdaja.UseVisualStyleBackColor = true;
            this.uiActionProdaja.Click += new System.EventHandler(this.uiActionProdaja_Click);
            // 
            // dgvOdabraniArtikli
            // 
            this.dgvOdabraniArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOdabraniArtikli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdabraniArtikli.Location = new System.Drawing.Point(0, 354);
            this.dgvOdabraniArtikli.Name = "dgvOdabraniArtikli";
            this.dgvOdabraniArtikli.Size = new System.Drawing.Size(1101, 161);
            this.dgvOdabraniArtikli.TabIndex = 4;
            // 
            // panelProdajaArtiklaOdabraniArtikli
            // 
            this.panelProdajaArtiklaOdabraniArtikli.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelProdajaArtiklaOdabraniArtikli.Controls.Add(this.label2);
            this.panelProdajaArtiklaOdabraniArtikli.Location = new System.Drawing.Point(0, 311);
            this.panelProdajaArtiklaOdabraniArtikli.Name = "panelProdajaArtiklaOdabraniArtikli";
            this.panelProdajaArtiklaOdabraniArtikli.Size = new System.Drawing.Size(1101, 46);
            this.panelProdajaArtiklaOdabraniArtikli.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Odabrani artikli";
            // 
            // FormProdajaArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 614);
            this.Controls.Add(this.panelProdajaArtiklaOdabraniArtikli);
            this.Controls.Add(this.dgvOdabraniArtikli);
            this.Controls.Add(this.panelProdajaArtikalaFooter);
            this.Controls.Add(this.panelProdajaArtikalaHeader);
            this.Controls.Add(this.dgvProdajniArtikli);
            this.Name = "FormProdajaArtikla";
            this.Text = "Prodaja artikla";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProdajaArtikla_FormClosed);
            this.Load += new System.EventHandler(this.FormProdajaArtikla_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormProdajaArtikla_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdajniArtikli)).EndInit();
            this.panelProdajaArtikalaHeader.ResumeLayout(false);
            this.panelProdajaArtikalaHeader.PerformLayout();
            this.panelProdajaArtikalaFooter.ResumeLayout(false);
            this.panelProdajaArtikalaFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdabraniArtikli)).EndInit();
            this.panelProdajaArtiklaOdabraniArtikli.ResumeLayout(false);
            this.panelProdajaArtiklaOdabraniArtikli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProdajniArtikli;
        private System.Windows.Forms.Panel panelProdajaArtikalaHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelProdajaArtikalaFooter;
        private System.Windows.Forms.Button uiActionProdaja;
        private System.Windows.Forms.DataGridView dgvOdabraniArtikli;
        private System.Windows.Forms.Panel panelProdajaArtiklaOdabraniArtikli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox uiInputKlijenti;
    }
}