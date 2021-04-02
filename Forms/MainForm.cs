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
        List<PlaineModel> plaines = new List<PlaineModel>();
        FormManager FM = new FormManager();
        SqlManager SqlManager = new SqlManager();

        public MainForm()
        {
            try 
            {
                InitializeComponent();
                LoadDBToList();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            if(plaines.Count <= 0)
            {
                ButtEnable(false); 
            }
        }

        private void LoadDBToList()
        {
            plaines = SqlManager.LoadPlaines();
            childs = SqlManager.LoadChild();
            CleanListBox();
        }

        private void CleanListBox()
        {
            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = childs;
            
            dataGridView1.Columns["N_National"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
            dataGridView1.Columns["PlaineId"].Visible = false;
            dataGridView1.Columns["Remarque"].Visible = false;
            dataGridView1.Columns["Allergie"].Visible = false;
            dataGridView1.Columns["Adresse"].Visible = false;
            dataGridView1.Columns[@"Age"].Visible = false;
            dataGridView1.Columns["Email"].Visible = false;
            dataGridView1.Columns["Date_Naissance"].Visible = false;

            Combox_plaines.DataSource = null;
            Combox_plaines.DataSource = plaines;
            Combox_plaines.DisplayMember = "Fullname";
        }


        private void Butt_Add_Children_Click(object sender, EventArgs e)
        {
            FM.OpenInscription(selectedPlaine());           
        }

        private void Butt_Modifier_Participant_Click(object sender, EventArgs e)
        {
            try
            {
                FM.OpenInscription(selectedChild(),selectedPlaine());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selectionné un participant \n ERROR : " + ex.ToString());
            }
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadDBToList();
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
            LoadDBToList();
        }

        private void BUT_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private ChillModel selectedChild()
        {
             return this.dataGridView1.CurrentRow.DataBoundItem  as ChillModel;
        }

        private PlaineModel selectedPlaine()
        {
            return this.Combox_plaines.SelectedItem as PlaineModel;
        }

        private void But_apayer_Click(object sender, EventArgs e)
        {
            try
            {
                SqlManager.ChildHavePaid(selectedChild(),dateTimePicker1.Value.DayOfWeek);
                LoadDBToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selectionné un participant \n ERROR : " + ex.ToString());
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDBToList();
        }

        private void BUT_Refresh_Click(object sender, EventArgs e)
        {
            LoadDBToList();
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
                FM.OpenNewWeek();
                LoadDBToList();
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
       private void ButtEnable(bool v)
        {

            Butt_Add_Children.Enabled = v;
            Butt_Modifier_Participant.Enabled = v;
            But_apayer.Enabled = v;
            BUT_Export_to_excel.Enabled = v;
            BUT_Refresh.Enabled = v;
            But_Remarque.Enabled = v;
            But_Supp_Enfant.Enabled = v;
        }

        private void But_modifweek_Click(object sender, EventArgs e)
        {
            FM.OpenNewWeek(selectedPlaine());
        }

        private void Combox_plaines_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}