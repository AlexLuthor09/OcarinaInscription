
namespace OcarinaInscription.Forms
{
    partial class Childifinder
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Butt_Validating = new System.Windows.Forms.Button();
            this.But_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 70);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(353, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // Butt_Validating
            // 
            this.Butt_Validating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Butt_Validating.BackColor = System.Drawing.Color.Lime;
            this.Butt_Validating.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Validating.Location = new System.Drawing.Point(365, 87);
            this.Butt_Validating.Name = "Butt_Validating";
            this.Butt_Validating.Size = new System.Drawing.Size(128, 69);
            this.Butt_Validating.TabIndex = 31;
            this.Butt_Validating.Text = "Valider";
            this.Butt_Validating.UseVisualStyleBackColor = false;
            this.Butt_Validating.Click += new System.EventHandler(this.Butt_Validating_Click);
            // 
            // But_annuler
            // 
            this.But_annuler.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.But_annuler.BackColor = System.Drawing.Color.DarkRed;
            this.But_annuler.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_annuler.Location = new System.Drawing.Point(365, 12);
            this.But_annuler.Name = "But_annuler";
            this.But_annuler.Size = new System.Drawing.Size(128, 69);
            this.But_annuler.TabIndex = 32;
            this.But_annuler.Text = "Annuler";
            this.But_annuler.UseVisualStyleBackColor = false;
            // 
            // Childifinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 164);
            this.Controls.Add(this.But_annuler);
            this.Controls.Add(this.Butt_Validating);
            this.Controls.Add(this.comboBox1);
            this.Name = "Childifinder";
            this.Text = "Childifinder";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Butt_Validating;
        private System.Windows.Forms.Button But_annuler;
    }
}