﻿
namespace OcarinaInscription.Forms
{
    partial class Inscription
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
            this.But_Quit = new System.Windows.Forms.Button();
            this.CB_BIM = new System.Windows.Forms.CheckBox();
            this.CB_Fiche_Sante = new System.Windows.Forms.CheckBox();
            this.NUD_Age = new System.Windows.Forms.NumericUpDown();
            this.CB_MC = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.DTP_Naissance = new System.Windows.Forms.DateTimePicker();
            this.TB_Adresse = new System.Windows.Forms.TextBox();
            this.TB_N_National = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Allergies = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Remarques = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Butt_Validating = new System.Windows.Forms.Button();
            this.TB_Firstname = new System.Windows.Forms.TextBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Age)).BeginInit();
            this.SuspendLayout();
            // 
            // But_Quit
            // 
            this.But_Quit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.But_Quit.BackColor = System.Drawing.Color.Red;
            this.But_Quit.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Quit.Location = new System.Drawing.Point(1134, 40);
            this.But_Quit.Margin = new System.Windows.Forms.Padding(4);
            this.But_Quit.Name = "But_Quit";
            this.But_Quit.Size = new System.Drawing.Size(178, 62);
            this.But_Quit.TabIndex = 48;
            this.But_Quit.Text = "Quitter";
            this.But_Quit.UseVisualStyleBackColor = false;
            this.But_Quit.Click += new System.EventHandler(this.But_Quit_Click);
            // 
            // CB_BIM
            // 
            this.CB_BIM.AutoSize = true;
            this.CB_BIM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_BIM.Location = new System.Drawing.Point(118, 436);
            this.CB_BIM.Margin = new System.Windows.Forms.Padding(4);
            this.CB_BIM.Name = "CB_BIM";
            this.CB_BIM.Size = new System.Drawing.Size(68, 27);
            this.CB_BIM.TabIndex = 47;
            this.CB_BIM.Text = "BIM";
            this.CB_BIM.UseVisualStyleBackColor = true;
            // 
            // CB_Fiche_Sante
            // 
            this.CB_Fiche_Sante.AutoSize = true;
            this.CB_Fiche_Sante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Fiche_Sante.Location = new System.Drawing.Point(30, 475);
            this.CB_Fiche_Sante.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Fiche_Sante.Name = "CB_Fiche_Sante";
            this.CB_Fiche_Sante.Size = new System.Drawing.Size(133, 27);
            this.CB_Fiche_Sante.TabIndex = 46;
            this.CB_Fiche_Sante.Text = "Fiche santé";
            this.CB_Fiche_Sante.UseVisualStyleBackColor = true;
            // 
            // NUD_Age
            // 
            this.NUD_Age.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Age.Location = new System.Drawing.Point(30, 211);
            this.NUD_Age.Margin = new System.Windows.Forms.Padding(4);
            this.NUD_Age.Name = "NUD_Age";
            this.NUD_Age.Size = new System.Drawing.Size(165, 30);
            this.NUD_Age.TabIndex = 45;
            // 
            // CB_MC
            // 
            this.CB_MC.AutoSize = true;
            this.CB_MC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_MC.Location = new System.Drawing.Point(30, 436);
            this.CB_MC.Margin = new System.Windows.Forms.Padding(4);
            this.CB_MC.Name = "CB_MC";
            this.CB_MC.Size = new System.Drawing.Size(63, 27);
            this.CB_MC.TabIndex = 44;
            this.CB_MC.Text = "MC";
            this.CB_MC.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(592, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 23);
            this.label9.TabIndex = 43;
            this.label9.Text = "Date de naissance";
            // 
            // DTP_Naissance
            // 
            this.DTP_Naissance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTP_Naissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_Naissance.Location = new System.Drawing.Point(596, 72);
            this.DTP_Naissance.Margin = new System.Windows.Forms.Padding(4);
            this.DTP_Naissance.Name = "DTP_Naissance";
            this.DTP_Naissance.Size = new System.Drawing.Size(274, 30);
            this.DTP_Naissance.TabIndex = 42;
            // 
            // TB_Adresse
            // 
            this.TB_Adresse.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Adresse.Location = new System.Drawing.Point(30, 395);
            this.TB_Adresse.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Adresse.Name = "TB_Adresse";
            this.TB_Adresse.Size = new System.Drawing.Size(525, 30);
            this.TB_Adresse.TabIndex = 41;
            this.TB_Adresse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Keypress);
            // 
            // TB_N_National
            // 
            this.TB_N_National.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_N_National.Location = new System.Drawing.Point(30, 335);
            this.TB_N_National.Margin = new System.Windows.Forms.Padding(4);
            this.TB_N_National.Name = "TB_N_National";
            this.TB_N_National.Size = new System.Drawing.Size(525, 30);
            this.TB_N_National.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 369);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Adresse";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 308);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 23);
            this.label8.TabIndex = 38;
            this.label8.Text = "Numéro National";
            // 
            // TB_Email
            // 
            this.TB_Email.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Email.Location = new System.Drawing.Point(30, 270);
            this.TB_Email.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(525, 30);
            this.TB_Email.TabIndex = 37;
            this.TB_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Keypress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 23);
            this.label7.TabIndex = 35;
            this.label7.Text = "Age";
            // 
            // TB_Allergies
            // 
            this.TB_Allergies.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Allergies.Location = new System.Drawing.Point(32, 542);
            this.TB_Allergies.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Allergies.Multiline = true;
            this.TB_Allergies.Name = "TB_Allergies";
            this.TB_Allergies.Size = new System.Drawing.Size(522, 407);
            this.TB_Allergies.TabIndex = 34;
            this.TB_Allergies.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Keypress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 513);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Allergies";
            // 
            // TB_Remarques
            // 
            this.TB_Remarques.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Remarques.Location = new System.Drawing.Point(596, 137);
            this.TB_Remarques.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Remarques.Multiline = true;
            this.TB_Remarques.Name = "TB_Remarques";
            this.TB_Remarques.Size = new System.Drawing.Size(642, 812);
            this.TB_Remarques.TabIndex = 32;
            this.TB_Remarques.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Keypress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Remarques";
            // 
            // Butt_Validating
            // 
            this.Butt_Validating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Butt_Validating.BackColor = System.Drawing.Color.Lime;
            this.Butt_Validating.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Validating.Location = new System.Drawing.Point(462, 968);
            this.Butt_Validating.Margin = new System.Windows.Forms.Padding(4);
            this.Butt_Validating.Name = "Butt_Validating";
            this.Butt_Validating.Size = new System.Drawing.Size(303, 88);
            this.Butt_Validating.TabIndex = 30;
            this.Butt_Validating.Text = "Valider";
            this.Butt_Validating.UseVisualStyleBackColor = false;
            this.Butt_Validating.Click += new System.EventHandler(this.Butt_Validating_Click);
            // 
            // TB_Firstname
            // 
            this.TB_Firstname.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Firstname.Location = new System.Drawing.Point(30, 137);
            this.TB_Firstname.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Firstname.Name = "TB_Firstname";
            this.TB_Firstname.Size = new System.Drawing.Size(525, 30);
            this.TB_Firstname.TabIndex = 29;
            this.TB_Firstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Keypress);
            // 
            // TB_Name
            // 
            this.TB_Name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Name.Location = new System.Drawing.Point(30, 72);
            this.TB_Name.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(525, 30);
            this.TB_Name.TabIndex = 28;
            this.TB_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_Keypress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nom";
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 1069);
            this.Controls.Add(this.But_Quit);
            this.Controls.Add(this.CB_BIM);
            this.Controls.Add(this.CB_Fiche_Sante);
            this.Controls.Add(this.NUD_Age);
            this.Controls.Add(this.CB_MC);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DTP_Naissance);
            this.Controls.Add(this.TB_Adresse);
            this.Controls.Add(this.TB_N_National);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TB_Allergies);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Remarques);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Butt_Validating);
            this.Controls.Add(this.TB_Firstname);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inscription";
            this.Text = "Inscription";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_Quit;
        private System.Windows.Forms.CheckBox CB_BIM;
        private System.Windows.Forms.CheckBox CB_Fiche_Sante;
        private System.Windows.Forms.NumericUpDown NUD_Age;
        private System.Windows.Forms.CheckBox CB_MC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker DTP_Naissance;
        private System.Windows.Forms.TextBox TB_Adresse;
        private System.Windows.Forms.TextBox TB_N_National;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TB_Allergies;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Remarques;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Butt_Validating;
        private System.Windows.Forms.TextBox TB_Firstname;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}