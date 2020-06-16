namespace Prezentacijski_sloj
{
    partial class FormPrijava
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
            this.uiActionPrijava = new System.Windows.Forms.Button();
            this.uiInputKorisnickoIme = new System.Windows.Forms.TextBox();
            this.uiInputLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelFrmPrijava = new System.Windows.Forms.Panel();
            this.panelFrmPrijava.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiActionPrijava
            // 
            this.uiActionPrijava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiActionPrijava.ForeColor = System.Drawing.Color.White;
            this.uiActionPrijava.Location = new System.Drawing.Point(154, 246);
            this.uiActionPrijava.Name = "uiActionPrijava";
            this.uiActionPrijava.Size = new System.Drawing.Size(172, 23);
            this.uiActionPrijava.TabIndex = 0;
            this.uiActionPrijava.Text = "Prijavi se";
            this.uiActionPrijava.UseVisualStyleBackColor = true;
            this.uiActionPrijava.Click += new System.EventHandler(this.uiActionPrijava_Click);
            // 
            // uiInputKorisnickoIme
            // 
            this.uiInputKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiInputKorisnickoIme.Location = new System.Drawing.Point(154, 134);
            this.uiInputKorisnickoIme.Name = "uiInputKorisnickoIme";
            this.uiInputKorisnickoIme.Size = new System.Drawing.Size(172, 20);
            this.uiInputKorisnickoIme.TabIndex = 1;
            // 
            // uiInputLozinka
            // 
            this.uiInputLozinka.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uiInputLozinka.Location = new System.Drawing.Point(154, 196);
            this.uiInputLozinka.Name = "uiInputLozinka";
            this.uiInputLozinka.PasswordChar = '•';
            this.uiInputLozinka.Size = new System.Drawing.Size(172, 20);
            this.uiInputLozinka.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(151, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Korisnicko ime";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lozinka";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(187, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prijava";
            // 
            // panelFrmPrijava
            // 
            this.panelFrmPrijava.Controls.Add(this.label3);
            this.panelFrmPrijava.Controls.Add(this.uiActionPrijava);
            this.panelFrmPrijava.Controls.Add(this.label2);
            this.panelFrmPrijava.Controls.Add(this.uiInputKorisnickoIme);
            this.panelFrmPrijava.Controls.Add(this.label1);
            this.panelFrmPrijava.Controls.Add(this.uiInputLozinka);
            this.panelFrmPrijava.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFrmPrijava.Location = new System.Drawing.Point(0, 0);
            this.panelFrmPrijava.Name = "panelFrmPrijava";
            this.panelFrmPrijava.Size = new System.Drawing.Size(501, 353);
            this.panelFrmPrijava.TabIndex = 6;
            // 
            // FormPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 353);
            this.Controls.Add(this.panelFrmPrijava);
            this.Name = "FormPrijava";
            this.Text = "FormPrijava";
            this.panelFrmPrijava.ResumeLayout(false);
            this.panelFrmPrijava.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uiActionPrijava;
        private System.Windows.Forms.TextBox uiInputKorisnickoIme;
        private System.Windows.Forms.TextBox uiInputLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelFrmPrijava;
    }
}