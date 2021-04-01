using OcarinaInscription.Class;
using OcarinaInscription.Forms;
using OcarinaInscription.SQLclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcarinaInscription
{
    public partial class MainForm : Form
    {
        List<ChillModel> childs = new List<ChillModel>();
        FormManager FM = new FormManager();
        SqlManager SqlManager = new SqlManager();

        public MainForm()
        {
            try 
            {
                InitializeComponent();
                LoadEnfantList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void LoadEnfantList()
        {
            
            childs = SqlManager.LoadChild();
            CleanListBox();
        }

        private void CleanListBox()
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = childs;
            
            dataGridView1.Columns["N_National"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["Remarque"].Visible = false;
            dataGridView1.Columns["Allergie"].Visible = false;
            dataGridView1.Columns["Adresse"].Visible = false;
            dataGridView1.Columns[@"Age"].Visible = false;
            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["Date_Naissance"].Visible = false;
            
        }


        private void Butt_Add_Children_Click(object sender, EventArgs e)
        {
            FM.OpenInscription();           
        }

        private void Butt_Modifier_Participant_Click(object sender, EventArgs e)
        {
            try
            {
                FM.OpenInscription(selectedChild());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selectionné un participant \n ERROR : " + ex.ToString());
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadEnfantList();
        }

        private void But_Supp_Enfant_Click(object sender, EventArgs e)
        {
            var enfatn = selectedChild();
            try
            {
                DialogResult dialogResult = MessageBox.Show($"Es-tu sûr de vouloir supprimer ce participant  ?  ", "Supprimer", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlManager.DeleteChild(enfatn);
                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Selectionné un participant \n ERROR : "+ ex.ToString());
            }
            LoadEnfantList();
        }

        private void BUT_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private ChillModel selectedChild()
        {
             return this.dataGridView1.CurrentRow.DataBoundItem  as ChillModel;
        }

        private void But_apayer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlManager.ChildHavePaid(selectedChild(),dateTimePicker1.Value.DayOfWeek);
                LoadEnfantList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selectionné un participant \n ERROR : " + ex.ToString());
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadEnfantList();
        }

        private void BUT_Refresh_Click(object sender, EventArgs e)
        {
            LoadEnfantList();
        }

        private void But_Remarque_Click(object sender, EventArgs e)
        {
            FM.OpenExcelExport('b');
        }

        private void BUT_Export_to_excel_Click(object sender, EventArgs e)
        {
            FM.OpenExcelExport('a');
        }

        private void But_NewWeek_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult = MessageBox.Show("Es-tu sûr de vouloir commencer une nouvelle semaine ? \n Si oui , la base de donées va être réinitialisez.", "Nouvelle semaine", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlManager.NewWeek();
                LoadEnfantList();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}