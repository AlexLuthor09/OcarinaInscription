using OcarinaInscription.Class;
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

namespace OcarinaInscription.Forms
{
    public partial class WeekChoise : Form
    {
        private List<PlaineModel> plaines = new List<PlaineModel>();
        private FormManager FM = new FormManager();
        private MainForm mainForm;
        private bool supp = false;
        public WeekChoise(MainForm main)
        {
            InitializeComponent();
            LoadplainesToList();
            this.mainForm = main;
        }
        private void LoadplainesToList()
        {
            plaines = SqlManager.LoadPlaines();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = plaines;
 
        }
        private void But_supp_Click(object sender, EventArgs e)
        {
            supp = true;
            DialogResult dialogResult = MessageBox.Show($"Es-tu sûr de vouloir supprimer cette semaine : {selectedPlaine().fullname} ?  ", "Supprimer", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                SqlManager.DeletePlaine(selectedPlaine());
                LoadplainesToList();
            }
        }

        private void Butt_Validating_Click(object sender, EventArgs e)
        {
            mainForm.CurrentPlaineID = selectedPlaine().Id;
            mainForm.ButtonEnable(true);
            this.Close();
        }

        private void But_NewWeek_Click(object sender, EventArgs e)
        {            
            FM.OpenNewWeek();
        }

        private void But_modifweek_Click(object sender, EventArgs e)
        {
            FM.OpenNewWeek(selectedPlaine());
            LoadplainesToList();
        }
        private PlaineModel selectedPlaine()
        {
             return dataGridView1.CurrentRow.DataBoundItem as PlaineModel;
        }

        private void WeekChoise_Activated(object sender, EventArgs e)
        {
            if(!supp)
            LoadplainesToList();
            else supp = false;
        }
    }
}
