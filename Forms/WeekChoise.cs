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
            SqlManager.DeletePlaine(selectedPlaine());
            
        }

        private void Butt_Validating_Click(object sender, EventArgs e)
        {
            mainForm.CurrentPlaineID = selectedPlaine().Id;
            this.Close();
        }

        private void But_NewWeek_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Es-tu sûr de vouloir commencer une nouvelle semaine ? \n Si oui , la base de donées va être réinitialisez.", "Nouvelle semaine", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FM.OpenNewWeek();
                LoadplainesToList();
            }
        }

        private void But_modifweek_Click(object sender, EventArgs e)
        {
            FM.OpenNewWeek(selectedPlaine());
        }
        private PlaineModel selectedPlaine()
        {
            if (plaines.Count > 0)
                return this.dataGridView1.CurrentRow.DataBoundItem as PlaineModel;
            else
            {
                PlaineModel plaineModel = new PlaineModel();
                return plaineModel;
            }
        }
    }
}
