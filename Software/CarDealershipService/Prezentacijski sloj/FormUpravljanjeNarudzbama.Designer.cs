namespace Prezentacijski_sloj
{
    partial class FormUpravljanjeNarudzbama
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvUpravljanjeNarudzbamaSveNarudzbe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiActionAzurirajNarudzbu = new System.Windows.Forms.Button();
            this.uiActionObrisiNarudzbu = new System.Windows.Forms.Button();
            this.uiActionKreirajNarudzbu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpravljanjeNarudzbamaSveNarudzbe)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uiActionKreirajNarudzbu);
            this.panel2.Controls.Add(this.uiActionObrisiNarudzbu);
            this.panel2.Controls.Add(this.uiActionAzurirajNarudzbu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 100);
            this.panel2.TabIndex = 1;
            // 
            // dgvUpravljanjeNarudzbamaSveNarudzbe
            // 
            this.dgvUpravljanjeNarudzbamaSveNarudzbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpravljanjeNarudzbamaSveNarudzbe.Location = new System.Drawing.Point(0, 100);
            this.dgvUpravljanjeNarudzbamaSveNarudzbe.Name = "dgvUpravljanjeNarudzbamaSveNarudzbe";
            this.dgvUpravljanjeNarudzbamaSveNarudzbe.Size = new System.Drawing.Size(800, 253);
            this.dgvUpravljanjeNarudzbamaSveNarudzbe.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(272, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Narudzbe";
            // 
            // uiActionAzurirajNarudzbu
            // 
            this.uiActionAzurirajNarudzbu.FlatAppearance.BorderSize = 0;
            this.uiActionAzurirajNarudzbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionAzurirajNarudzbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionAzurirajNarudzbu.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionAzurirajNarudzbu.Location = new System.Drawing.Point(59, 19);
            this.uiActionAzurirajNarudzbu.Name = "uiActionAzurirajNarudzbu";
            this.uiActionAzurirajNarudzbu.Size = new System.Drawing.Size(162, 58);
            this.uiActionAzurirajNarudzbu.TabIndex = 0;
            this.uiActionAzurirajNarudzbu.Text = "Azuriraj narudzbu";
            this.uiActionAzurirajNarudzbu.UseVisualStyleBackColor = true;
            // 
            // uiActionObrisiNarudzbu
            // 
            this.uiActionObrisiNarudzbu.FlatAppearance.BorderSize = 0;
            this.uiActionObrisiNarudzbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionObrisiNarudzbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionObrisiNarudzbu.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionObrisiNarudzbu.Location = new System.Drawing.Point(317, 19);
            this.uiActionObrisiNarudzbu.Name = "uiActionObrisiNarudzbu";
            this.uiActionObrisiNarudzbu.Size = new System.Drawing.Size(162, 58);
            this.uiActionObrisiNarudzbu.TabIndex = 0;
            this.uiActionObrisiNarudzbu.Text = "Obrisi narudzbu";
            this.uiActionObrisiNarudzbu.UseVisualStyleBackColor = true;
            // 
            // uiActionKreirajNarudzbu
            // 
            this.uiActionKreirajNarudzbu.FlatAppearance.BorderSize = 0;
            this.uiActionKreirajNarudzbu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionKreirajNarudzbu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiActionKreirajNarudzbu.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionKreirajNarudzbu.Location = new System.Drawing.Point(587, 19);
            this.uiActionKreirajNarudzbu.Name = "uiActionKreirajNarudzbu";
            this.uiActionKreirajNarudzbu.Size = new System.Drawing.Size(162, 58);
            this.uiActionKreirajNarudzbu.TabIndex = 0;
            this.uiActionKreirajNarudzbu.Text = "Kreiraj narudzbu";
            this.uiActionKreirajNarudzbu.UseVisualStyleBackColor = true;
            // 
            // FormUpravljanjeNarudzbama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvUpravljanjeNarudzbamaSveNarudzbe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormUpravljanjeNarudzbama";
            this.Text = "FormUpravljanjeNarudzbama";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUpravljanjeNarudzbama_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpravljanjeNarudzbamaSveNarudzbe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUpravljanjeNarudzbamaSveNarudzbe;
        private System.Windows.Forms.Button uiActionAzurirajNarudzbu;
        private System.Windows.Forms.Button uiActionKreirajNarudzbu;
        private System.Windows.Forms.Button uiActionObrisiNarudzbu;
    }
}