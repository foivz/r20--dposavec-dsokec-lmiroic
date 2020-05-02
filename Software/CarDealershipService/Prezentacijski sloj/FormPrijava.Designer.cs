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
            this.SuspendLayout();
            // 
            // uiActionPrijava
            // 
            this.uiActionPrijava.Location = new System.Drawing.Point(90, 204);
            this.uiActionPrijava.Name = "uiActionPrijava";
            this.uiActionPrijava.Size = new System.Drawing.Size(75, 23);
            this.uiActionPrijava.TabIndex = 0;
            this.uiActionPrijava.Text = "Prijavi se";
            this.uiActionPrijava.UseVisualStyleBackColor = true;
            this.uiActionPrijava.Click += new System.EventHandler(this.uiActionPrijava_Click);
            // 
            // uiInputKorisnickoIme
            // 
            this.uiInputKorisnickoIme.Location = new System.Drawing.Point(78, 94);
            this.uiInputKorisnickoIme.Name = "uiInputKorisnickoIme";
            this.uiInputKorisnickoIme.Size = new System.Drawing.Size(100, 20);
            this.uiInputKorisnickoIme.TabIndex = 1;
            // 
            // uiInputLozinka
            // 
            this.uiInputLozinka.Location = new System.Drawing.Point(78, 162);
            this.uiInputLozinka.Name = "uiInputLozinka";
            this.uiInputLozinka.PasswordChar = '•';
            this.uiInputLozinka.Size = new System.Drawing.Size(100, 20);
            this.uiInputLozinka.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Korisnicko ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lozinka";
            // 
            // FormPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 297);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiInputLozinka);
            this.Controls.Add(this.uiInputKorisnickoIme);
            this.Controls.Add(this.uiActionPrijava);
            this.Name = "FormPrijava";
            this.Text = "FormPrijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiActionPrijava;
        private System.Windows.Forms.TextBox uiInputKorisnickoIme;
        private System.Windows.Forms.TextBox uiInputLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}