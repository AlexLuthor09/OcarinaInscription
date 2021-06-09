
namespace OcarinaInscription
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.But_Remarque = new System.Windows.Forms.Button();
            this.BUT_Export_to_excel = new System.Windows.Forms.Button();
            this.BUT_Quitter = new System.Windows.Forms.Button();
            this.BUT_Refresh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.But_Supp_Enfant = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Butt_Modifier_Participant = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Butt_Add_Children = new System.Windows.Forms.Button();
            this.But_apayer = new System.Windows.Forms.Button();
            this.But_changeWEEK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // But_Remarque
            // 
            this.But_Remarque.AutoSize = true;
            this.But_Remarque.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Remarque.Location = new System.Drawing.Point(1060, 414);
            this.But_Remarque.Name = "But_Remarque";
            this.But_Remarque.Size = new System.Drawing.Size(180, 85);
            this.But_Remarque.TabIndex = 31;
            this.But_Remarque.Text = "Remarques / Allergies";
            this.But_Remarque.UseVisualStyleBackColor = true;
            this.But_Remarque.Click += new System.EventHandler(this.But_Remarque_Click);
            // 
            // BUT_Export_to_excel
            // 
            this.BUT_Export_to_excel.AutoSize = true;
            this.BUT_Export_to_excel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_Export_to_excel.Location = new System.Drawing.Point(1060, 505);
            this.BUT_Export_to_excel.Name = "BUT_Export_to_excel";
            this.BUT_Export_to_excel.Size = new System.Drawing.Size(180, 85);
            this.BUT_Export_to_excel.TabIndex = 30;
            this.BUT_Export_to_excel.Text = "Export to Excel";
            this.BUT_Export_to_excel.UseVisualStyleBackColor = true;
            this.BUT_Export_to_excel.Click += new System.EventHandler(this.BUT_Export_to_excel_Click);
            // 
            // BUT_Quitter
            // 
            this.BUT_Quitter.AutoSize = true;
            this.BUT_Quitter.BackColor = System.Drawing.Color.Maroon;
            this.BUT_Quitter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_Quitter.ForeColor = System.Drawing.Color.White;
            this.BUT_Quitter.Location = new System.Drawing.Point(1079, 666);
            this.BUT_Quitter.Name = "BUT_Quitter";
            this.BUT_Quitter.Size = new System.Drawing.Size(164, 67);
            this.BUT_Quitter.TabIndex = 29;
            this.BUT_Quitter.Text = "Quitter";
            this.BUT_Quitter.UseVisualStyleBackColor = false;
            this.BUT_Quitter.Click += new System.EventHandler(this.BUT_Quitter_Click);
            // 
            // BUT_Refresh
            // 
            this.BUT_Refresh.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUT_Refresh.Location = new System.Drawing.Point(724, 7);
            this.BUT_Refresh.Name = "BUT_Refresh";
            this.BUT_Refresh.Size = new System.Drawing.Size(162, 67);
            this.BUT_Refresh.TabIndex = 28;
            this.BUT_Refresh.Text = "Refresh";
            this.BUT_Refresh.UseVisualStyleBackColor = true;
            this.BUT_Refresh.Click += new System.EventHandler(this.BUT_Refresh_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(314, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 26);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // But_Supp_Enfant
            // 
            this.But_Supp_Enfant.AutoSize = true;
            this.But_Supp_Enfant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_Supp_Enfant.Location = new System.Drawing.Point(1060, 291);
            this.But_Supp_Enfant.Name = "But_Supp_Enfant";
            this.But_Supp_Enfant.Size = new System.Drawing.Size(180, 85);
            this.But_Supp_Enfant.TabIndex = 25;
            this.But_Supp_Enfant.Text = "Supprimer Participant";
            this.But_Supp_Enfant.UseVisualStyleBackColor = true;
            this.But_Supp_Enfant.Click += new System.EventHandler(this.But_Supp_Enfant_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(10, 77);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1044, 656);
            this.dataGridView1.TabIndex = 24;
            // 
            // Butt_Modifier_Participant
            // 
            this.Butt_Modifier_Participant.AutoSize = true;
            this.Butt_Modifier_Participant.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Modifier_Participant.Location = new System.Drawing.Point(1060, 200);
            this.Butt_Modifier_Participant.Name = "Butt_Modifier_Participant";
            this.Butt_Modifier_Participant.Size = new System.Drawing.Size(180, 85);
            this.Butt_Modifier_Participant.TabIndex = 23;
            this.Butt_Modifier_Participant.Text = "Modifier Participant";
            this.Butt_Modifier_Participant.UseVisualStyleBackColor = true;
            this.Butt_Modifier_Participant.Click += new System.EventHandler(this.Butt_Modifier_Participant_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Liste des particiants:";
            // 
            // Butt_Add_Children
            // 
            this.Butt_Add_Children.AutoSize = true;
            this.Butt_Add_Children.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Butt_Add_Children.Location = new System.Drawing.Point(1060, 109);
            this.Butt_Add_Children.Name = "Butt_Add_Children";
            this.Butt_Add_Children.Size = new System.Drawing.Size(180, 85);
            this.Butt_Add_Children.TabIndex = 20;
            this.Butt_Add_Children.Text = "Ajouter Participant";
            this.Butt_Add_Children.UseVisualStyleBackColor = true;
            this.Butt_Add_Children.Click += new System.EventHandler(this.Butt_Add_Children_Click);
            // 
            // But_apayer
            // 
            this.But_apayer.AutoSize = true;
            this.But_apayer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_apayer.Location = new System.Drawing.Point(556, 7);
            this.But_apayer.Name = "But_apayer";
            this.But_apayer.Size = new System.Drawing.Size(163, 67);
            this.But_apayer.TabIndex = 32;
            this.But_apayer.Text = "A payer";
            this.But_apayer.UseVisualStyleBackColor = true;
            this.But_apayer.Click += new System.EventHandler(this.But_apayer_Click);
            // 
            // But_changeWEEK
            // 
            this.But_changeWEEK.AutoSize = true;
            this.But_changeWEEK.BackColor = System.Drawing.Color.Maroon;
            this.But_changeWEEK.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_changeWEEK.ForeColor = System.Drawing.Color.White;
            this.But_changeWEEK.Location = new System.Drawing.Point(1073, 7);
            this.But_changeWEEK.Name = "But_changeWEEK";
            this.But_changeWEEK.Size = new System.Drawing.Size(167, 67);
            this.But_changeWEEK.TabIndex = 37;
            this.But_changeWEEK.Text = "Changer de Semaine";
            this.But_changeWEEK.UseVisualStyleBackColor = false;
            this.But_changeWEEK.Click += new System.EventHandler(this.But_changeWEEK_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1246, 743);
            this.Controls.Add(this.But_changeWEEK);
            this.Controls.Add(this.But_Remarque);
            this.Controls.Add(this.BUT_Export_to_excel);
            this.Controls.Add(this.BUT_Quitter);
            this.Controls.Add(this.BUT_Refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.But_Supp_Enfant);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Butt_Modifier_Participant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Butt_Add_Children);
            this.Controls.Add(this.But_apayer);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscription";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_Remarque;
        private System.Windows.Forms.Button BUT_Export_to_excel;
        private System.Windows.Forms.Button BUT_Quitter;
        private System.Windows.Forms.Button BUT_Refresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button But_Supp_Enfant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Butt_Modifier_Participant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Butt_Add_Children;
        private System.Windows.Forms.Button But_apayer;
        private System.Windows.Forms.Button But_changeWEEK;
    }
}

