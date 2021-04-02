
namespace OcarinaInscription.Forms
{
    partial class Newweek
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
            this.But_Validation = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTP_Stop = new System.Windows.Forms.DateTimePicker();
            this.DTP_Start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_NomPlaine = new System.Windows.Forms.TextBox();
            this.But_supp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // But_Validation
            // 
            this.But_Validation.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Validation.Location = new System.Drawing.Point(590, 118);
            this.But_Validation.Name = "But_Validation";
            this.But_Validation.Size = new System.Drawing.Size(172, 116);
            this.But_Validation.TabIndex = 27;
            this.But_Validation.Text = "Valider ";
            this.But_Validation.UseVisualStyleBackColor = true;
            this.But_Validation.Click += new System.EventHandler(this.But_Validation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 32);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date de fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Date du Début";
            // 
            // DTP_Stop
            // 
            this.DTP_Stop.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Stop.Location = new System.Drawing.Point(12, 195);
            this.DTP_Stop.Name = "DTP_Stop";
            this.DTP_Stop.Size = new System.Drawing.Size(572, 39);
            this.DTP_Stop.TabIndex = 24;
            // 
            // DTP_Start
            // 
            this.DTP_Start.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Start.Location = new System.Drawing.Point(12, 118);
            this.DTP_Start.Name = "DTP_Start";
            this.DTP_Start.Size = new System.Drawing.Size(572, 39);
            this.DTP_Start.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 32);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nom de la Plaine";
            // 
            // TB_NomPlaine
            // 
            this.TB_NomPlaine.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NomPlaine.Location = new System.Drawing.Point(12, 41);
            this.TB_NomPlaine.Name = "TB_NomPlaine";
            this.TB_NomPlaine.Size = new System.Drawing.Size(572, 39);
            this.TB_NomPlaine.TabIndex = 21;
            // 
            // But_supp
            // 
            this.But_supp.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_supp.Location = new System.Drawing.Point(590, 12);
            this.But_supp.Name = "But_supp";
            this.But_supp.Size = new System.Drawing.Size(172, 88);
            this.But_supp.TabIndex = 28;
            this.But_supp.Text = "Supprimer";
            this.But_supp.UseVisualStyleBackColor = true;
            this.But_supp.Click += new System.EventHandler(this.But_supp_Click);
            // 
            // Newweek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 253);
            this.Controls.Add(this.But_supp);
            this.Controls.Add(this.But_Validation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DTP_Stop);
            this.Controls.Add(this.DTP_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_NomPlaine);
            this.Name = "Newweek";
            this.Text = "Newweek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_Validation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTP_Stop;
        private System.Windows.Forms.DateTimePicker DTP_Start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_NomPlaine;
        private System.Windows.Forms.Button But_supp;
    }
}