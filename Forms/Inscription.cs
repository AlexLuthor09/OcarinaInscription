using OcarinaInscription.Class;
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
    public partial class Inscription : Form
    {
        private ChillModel ChillModel;
        private bool modif = false;
        string TA_bleu = "Bleu";
        string TA_vert = "Vert";
        string TA_jaune = "Jaune";
        public Inscription()
        {
            InitializeComponent();
        }
        public Inscription(ChillModel chillModel)
        {
            modif = true;
            InitializeComponent();
            loadChild(chillModel);
        }

        private void But_Quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Butt_Validating_Click(object sender, EventArgs e)
        {
            savechild();
            this.Close();
        }

        private void loadChild(ChillModel chillModel)
        {
            try
            {
                this.ChillModel = chillModel;

                TB_Name.Text = ChillModel.Nom;
                TB_Firstname.Text = ChillModel.Prenom;
                TB_Adresse.Text = ChillModel.Adresse;
                NUD_Age.Value = ChillModel.Age;
                TB_Email.Text = ChillModel.Email;
                TB_Allergies.Text = ChillModel.Allergie;
                TB_N_National.Text = ChillModel.N_National;
                TB_Remarques.Text = ChillModel.Remarque;
                DTP_Naissance.Value = Convert.ToDateTime(ChillModel.Date_Naissance.Trim());
                CB_MC.Checked = ChillModel.MC;
                CB_BIM.Checked = ChillModel.BIM;
                CB_Fiche_Sante.Checked = ChillModel.Fiche_sante;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void savechild()
        {
            try
            {
                if (modif)
                {
                    data(ChillModel);
                    SQLclass.SqlManager.UpdateChild(this.getChillModel());
                }
                else
                {
                    ChillModel chillModel = new ChillModel();
                    data(chillModel);
                    SQLclass.SqlManager.SaveChild(this.getChillModel());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private ChillModel getChillModel()
        {
            return ChillModel;
        }
        private void data(ChillModel chillModel)
        {
            chillModel.Nom = TB_Name.Text.Trim();
            chillModel.Prenom = TB_Firstname.Text.Trim();
            chillModel.Adresse = TB_Adresse.Text.Trim();
            chillModel.Age = Convert.ToInt32(NUD_Age.Value);
            chillModel.Email = TB_Email.Text.Trim();
            chillModel.Allergie = TB_Allergies.Text.Trim();
            chillModel.N_National = TB_N_National.Text.Trim();
            chillModel.Remarque = TB_Remarques.Text.Trim();
            chillModel.Date_Naissance = DTP_Naissance.Value.ToShortDateString().ToString().Trim();
            chillModel.MC = CB_MC.Checked;
            chillModel.BIM = CB_BIM.Checked;
            chillModel.Fiche_sante = CB_Fiche_Sante.Checked;
            chillModel.Nbr_jour = 0;

            if (chillModel.MC && !chillModel.BIM)
                chillModel.Prix = "1.5";
            else if (chillModel.BIM)
                chillModel.Prix = "1";
            else if (!chillModel.MC && !chillModel.BIM)
                chillModel.Prix = "6.5";
            if (chillModel.Age >= 9)
                chillModel.Tranche_age = TA_bleu.Trim();
            if (chillModel.Age < 9 && chillModel.Age >= 6)
                chillModel.Tranche_age = TA_vert.Trim();
            if (chillModel.Age < 6)
                chillModel.Tranche_age = TA_jaune.Trim();

            this.ChillModel = chillModel;
        }

        private void Tb_Keypress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsPunctuation(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }
    }
}
