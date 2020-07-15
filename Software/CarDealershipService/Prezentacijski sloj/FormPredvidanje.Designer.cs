namespace Prezentacijski_sloj
{
    partial class FormPredvidanje
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
            this.cbInputDobavljaci = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trckBarInterval = new System.Windows.Forms.TrackBar();
            this.uiActionPokretanjePredvidanja = new System.Windows.Forms.Button();
            this.lblInterval = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trckBarInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // cbInputDobavljaci
            // 
            this.cbInputDobavljaci.FormattingEnabled = true;
            this.cbInputDobavljaci.Location = new System.Drawing.Point(648, 40);
            this.cbInputDobavljaci.Name = "cbInputDobavljaci";
            this.cbInputDobavljaci.Size = new System.Drawing.Size(142, 21);
            this.cbInputDobavljaci.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(645, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odabir dobavljaca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(37, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Artikli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(251, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum narucivanja";
            // 
            // trckBarInterval
            // 
            this.trckBarInterval.Location = new System.Drawing.Point(503, 383);
            this.trckBarInterval.Name = "trckBarInterval";
            this.trckBarInterval.Size = new System.Drawing.Size(285, 45);
            this.trckBarInterval.TabIndex = 3;
            this.trckBarInterval.ValueChanged += new System.EventHandler(this.trckBarInterval_ValueChanged);
            // 
            // uiActionPokretanjePredvidanja
            // 
            this.uiActionPokretanjePredvidanja.FlatAppearance.BorderSize = 0;
            this.uiActionPokretanjePredvidanja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiActionPokretanjePredvidanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiActionPokretanjePredvidanja.ForeColor = System.Drawing.Color.LightGray;
            this.uiActionPokretanjePredvidanja.Location = new System.Drawing.Point(648, 84);
            this.uiActionPokretanjePredvidanja.Name = "uiActionPokretanjePredvidanja";
            this.uiActionPokretanjePredvidanja.Size = new System.Drawing.Size(142, 23);
            this.uiActionPokretanjePredvidanja.TabIndex = 4;
            this.uiActionPokretanjePredvidanja.Text = "Pokreni predvidanje";
            this.uiActionPokretanjePredvidanja.UseVisualStyleBackColor = true;
            this.uiActionPokretanjePredvidanja.Click += new System.EventHandler(this.uiActionPokretanjePredvidanja_Click);
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterval.ForeColor = System.Drawing.Color.LightGray;
            this.lblInterval.Location = new System.Drawing.Point(733, 335);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(16, 17);
            this.lblInterval.TabIndex = 5;
            this.lblInterval.Text = "0";
            // 
            // FormPredvidanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInterval);
            this.Controls.Add(this.uiActionPokretanjePredvidanja);
            this.Controls.Add(this.trckBarInterval);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbInputDobavljaci);
            this.Name = "FormPredvidanje";
            this.Text = "Predvidanje";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPredvidanje_FormClosed);
            this.Load += new System.EventHandler(this.FormPredvidanje_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FormPredvidanje_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.trckBarInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbInputDobavljaci;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trckBarInterval;
        private System.Windows.Forms.Button uiActionPokretanjePredvidanja;
        private System.Windows.Forms.Label lblInterval;
    }
}