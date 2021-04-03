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
    public partial class Newweek : Form
    {
        private PlaineModel plaines;
        private bool modif=false;
        
        public Newweek()
        {
            
            InitializeComponent();
            
        }


        public Newweek(PlaineModel plaine)
        {
            this.modif = true;
            InitializeComponent();

            this.plaines = plaine;

            DTP_Start.Value = Convert.ToDateTime(plaines.DateDebut);
            DTP_Stop.Value = Convert.ToDateTime(plaines.DateFin);
            TB_NomPlaine.Text = plaines.Nom;
        }

        private void But_Validation_Click(object sender, EventArgs e)
        {
            savePlaine();
            this.Close();          
        }
        private void savePlaine()
        {
            try
            {
                if (modif)
                {
                    data(plaines);
                    SQLclass.SqlManager.UpdatePlaine(this.getplaine());
                }
                else
                {
                    PlaineModel chillModel = new PlaineModel();
                    data(chillModel);
                    SQLclass.SqlManager.SavePlaine(this.getplaine());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void data(PlaineModel plaineModel)
        {
            plaineModel.DateDebut = DTP_Start.Value.ToShortDateString().Trim();
            plaineModel.DateFin = DTP_Stop.Value.ToShortDateString().Trim();
            plaineModel.Nom = TB_NomPlaine.Text.Trim();

            this.plaines = plaineModel;
        }
        private PlaineModel getplaine()
        {
            return plaines;
        }

    }
}
