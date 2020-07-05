namespace Prezentacijski_sloj
{
    partial class FormKreirajSkladiste
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
            this.panelKreirajSkladistePoslovniceHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelKreirajSkladistePoslovniceFooter = new System.Windows.Forms.Panel();
            this.uiActionBrisiSkladiste = new System.Windows.Forms.Button();
            this.uiActionKreirajSkladiste = new System.Windows.Forms.Button();
            this.dgvSkladistaPoslovnice = new System.Windows.Forms.DataGridView();
            this.uiInputNazivSkladista = new System.Windows.Forms.TextBox();
            this.uiInputAdresaSkladista = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelKreirajSkladistePoslovniceHeader.SuspendLayout();
            this.panelKreirajSkladistePoslovniceFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladistaPoslovnice)).BeginInit();
            this.SuspendLayout();
            // 
            // panelKreirajSkladistePoslovniceHeader
            // 
            this.panelKreirajSkladistePoslovniceHeader.Controls.Add(this.label1);
            this.panelKreirajSkladistePoslovniceHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKreirajSkladistePoslovniceHeader.Location = new System.Drawing.Point(0, 0);
            this.panelKreirajSkladistePoslovniceHeader.Name = "panelKreirajSkladistePoslovniceHeader";
            this.panelKreirajSkladistePoslovniceHeader.Size = new System.Drawing.Size(883, 100);
            this.panelKreirajSkladistePoslovniceHeader.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(116, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(715, 55);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kreiranje skladišta poslovnice";
            // 
            // panelKreirajSkladistePoslovniceFooter
            // 
            this.panelKreirajSkladistePoslovniceFooter.Controls.Add(this.uiActionBrisiSkladiste);
            this.panelKreirajSkladistePoslovniceFooter.Controls.Add(this.uiActionKreirajSkladiste);
            this.panelKreirajSkladistePoslovniceFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelKreirajSkladistePoslovniceFooter.Location = new System.Drawing.Point(0, 505);
            this.panelKreirajSkladistePoslovniceFooter.Name = "panelKreirajSkladistePoslovniceFooter";
            this.panelKreirajSkladistePoslovniceFooter.Size = new System.Drawing.Size(883, 100);
            this.panelKreirajSkladistePoslovniceFooter.TabIndex = 6;
            // 
            // uiActionBrisiSkladiste
            // 
            this.uiActionBrisiSkladiste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionBrisiSkladiste.FlatAppearance.BorderSize = 0;
            this.uiActionBrisiSkladiste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionBrisiSkladiste.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionBrisiSkladiste.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionBrisiSkladiste.Location = new System.Drawing.Point(515, 27);
            this.uiActionBrisiSkladiste.Name = "uiActionBrisiSkladiste";
            this.uiActionBrisiSkladiste.Size = new System.Drawing.Size(201, 52);
            this.uiActionBrisiSkladiste.TabIndex = 1;
            this.uiActionBrisiSkladiste.Text = "Brisanje";
            this.uiActionBrisiSkladiste.UseVisualStyleBackColor = true;
            this.uiActionBrisiSkladiste.Click += new System.EventHandler(this.uiActionBrisiSkladiste_Click);
            // 
            // uiActionKreirajSkladiste
            // 
            this.uiActionKreirajSkladiste.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionKreirajSkladiste.FlatAppearance.BorderSize = 0;
            this.uiActionKreirajSkladiste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionKreirajSkladiste.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionKreirajSkladiste.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionKreirajSkladiste.Location = new System.Drawing.Point(178, 27);
            this.uiActionKreirajSkladiste.Name = "uiActionKreirajSkladiste";
            this.uiActionKreirajSkladiste.Size = new System.Drawing.Size(201, 52);
            this.uiActionKreirajSkladiste.TabIndex = 0;
            this.uiActionKreirajSkladiste.Text = "Kreiranje";
            this.uiActionKreirajSkladiste.UseVisualStyleBackColor = true;
            this.uiActionKreirajSkladiste.Click += new System.EventHandler(this.uiActionKreirajSkladiste_Click);
            // 
            // dgvSkladistaPoslovnice
            // 
            this.dgvSkladistaPoslovnice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSkladistaPoslovnice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladistaPoslovnice.Location = new System.Drawing.Point(0, 97);
            this.dgvSkladistaPoslovnice.Name = "dgvSkladistaPoslovnice";
            this.dgvSkladistaPoslovnice.Size = new System.Drawing.Size(883, 240);
            this.dgvSkladistaPoslovnice.TabIndex = 7;
            // 
            // uiInputNazivSkladista
            // 
            this.uiInputNazivSkladista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiInputNazivSkladista.Location = new System.Drawing.Point(184, 417);
            this.uiInputNazivSkladista.Name = "uiInputNazivSkladista";
            this.uiInputNazivSkladista.Size = new System.Drawing.Size(180, 20);
            this.uiInputNazivSkladista.TabIndex = 8;
            // 
            // uiInputAdresaSkladista
            // 
            this.uiInputAdresaSkladista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiInputAdresaSkladista.Location = new System.Drawing.Point(512, 417);
            this.uiInputAdresaSkladista.Name = "uiInputAdresaSkladista";
            this.uiInputAdresaSkladista.Size = new System.Drawing.Size(180, 20);
            this.uiInputAdresaSkladista.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Naziv skladišta";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 401);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adresa skladišta";
            // 
            // FormKreirajSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 605);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiInputAdresaSkladista);
            this.Controls.Add(this.uiInputNazivSkladista);
            this.Controls.Add(this.dgvSkladistaPoslovnice);
            this.Controls.Add(this.panelKreirajSkladistePoslovniceFooter);
            this.Controls.Add(this.panelKreirajSkladistePoslovniceHeader);
            this.Name = "FormKreirajSkladiste";
            this.Text = "FormKreirajSkladiste";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKreirajSkladiste_FormClosed);
            this.Load += new System.EventHandler(this.FormKreirajSkladiste_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormKreirajSkladiste_HelpRequested);
            this.panelKreirajSkladistePoslovniceHeader.ResumeLayout(false);
            this.panelKreirajSkladistePoslovniceHeader.PerformLayout();
            this.panelKreirajSkladistePoslovniceFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladistaPoslovnice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelKreirajSkladistePoslovniceHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelKreirajSkladistePoslovniceFooter;
        private System.Windows.Forms.Button uiActionBrisiSkladiste;
        private System.Windows.Forms.Button uiActionKreirajSkladiste;
        private System.Windows.Forms.DataGridView dgvSkladistaPoslovnice;
        private System.Windows.Forms.TextBox uiInputNazivSkladista;
        private System.Windows.Forms.TextBox uiInputAdresaSkladista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}