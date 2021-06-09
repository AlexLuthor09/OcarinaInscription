
namespace OcarinaInscription.Forms
{
    partial class WeekChoise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeekChoise));
            this.But_modifweek = new System.Windows.Forms.Button();
            this.But_NewWeek = new System.Windows.Forms.Button();
            this.But_supp = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Butt_Validating = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // But_modifweek
            // 
            this.But_modifweek.AutoSize = true;
            this.But_modifweek.BackColor = System.Drawing.Color.Maroon;
            this.But_modifweek.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_modifweek.ForeColor = System.Drawing.Color.White;
            this.But_modifweek.Location = new System.Drawing.Point(428, 84);
            this.But_modifweek.Name = "But_modifweek";
            this.But_modifweek.Size = new System.Drawing.Size(163, 67);
            this.But_modifweek.TabIndex = 37;
            this.But_modifweek.Text = "Modifier Semaine";
            this.But_modifweek.UseVisualStyleBackColor = false;
            this.But_modifweek.Click += new System.EventHandler(this.But_modifweek_Click);
            // 
            // But_NewWeek
            // 
            this.But_NewWeek.AutoSize = true;
            this.But_NewWeek.BackColor = System.Drawing.Color.Maroon;
            this.But_NewWeek.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_NewWeek.ForeColor = System.Drawing.Color.White;
            this.But_NewWeek.Location = new System.Drawing.Point(428, 11);
            this.But_NewWeek.Name = "But_NewWeek";
            this.But_NewWeek.Size = new System.Drawing.Size(163, 67);
            this.But_NewWeek.TabIndex = 36;
            this.But_NewWeek.Text = "Nouvelle Semaine";
            this.But_NewWeek.UseVisualStyleBackColor = false;
            this.But_NewWeek.Click += new System.EventHandler(this.But_NewWeek_Click);
            // 
            // But_supp
            // 
            this.But_supp.BackColor = System.Drawing.Color.Maroon;
            this.But_supp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_supp.ForeColor = System.Drawing.Color.Transparent;
            this.But_supp.Location = new System.Drawing.Point(428, 156);
            this.But_supp.Margin = new System.Windows.Forms.Padding(2);
            this.But_supp.Name = "But_supp";
            this.But_supp.Size = new System.Drawing.Size(163, 72);
            this.But_supp.TabIndex = 38;
            this.But_supp.Text = "Supprimer Semaine";
            this.But_supp.UseVisualStyleBackColor = false;
            this.But_supp.Click += new System.EventHandler(this.But_supp_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 84);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 217);
            this.dataGridView1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Liste des semaines";
            // 
            // Butt_Validating
            // 
            this.Butt_Validating.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Butt_Validating.BackColor = System.Drawing.Color.Lime;
            this.Butt_Validating.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Validating.Location = new System.Drawing.Point(428, 233);
            this.Butt_Validating.Name = "Butt_Validating";
            this.Butt_Validating.Size = new System.Drawing.Size(162, 122);
            this.Butt_Validating.TabIndex = 41;
            this.Butt_Validating.Text = "Valider";
            this.Butt_Validating.UseVisualStyleBackColor = false;
            this.Butt_Validating.Click += new System.EventHandler(this.Butt_Validating_Click);
            // 
            // WeekChoise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Butt_Validating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.But_supp);
            this.Controls.Add(this.But_modifweek);
            this.Controls.Add(this.But_NewWeek);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeekChoise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeekChoise";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.WeekChoise_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_modifweek;
        private System.Windows.Forms.Button But_NewWeek;
        private System.Windows.Forms.Button But_supp;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Butt_Validating;
    }
}