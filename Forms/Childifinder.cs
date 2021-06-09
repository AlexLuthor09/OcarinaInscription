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
    public partial class Childifinder : Form
    {
        Inscription Inscription;
        ChillModel chillModel = new ChillModel();
        List<ChillModel> chillModels;
        public Childifinder(Inscription inscription)
        {
            this.Inscription = inscription;
            InitializeComponent();
            this.chillModels = SqlManager.LoadChild();
       
            EnlevageDeDoublons();
            comboBox1.DataSource = null;
            comboBox1.DataSource = this.chillModels;
            comboBox1.DisplayMember = "fullname";
            
        }

        private void Butt_Validating_Click(object sender, EventArgs e)
        {
            chillModel = comboBox1.SelectedItem as ChillModel;
            this.Inscription.loadChild(this.chillModel);
            this.Close();
        }
        private void EnlevageDeDoublons()
        { 

            for (int i = 0;i < this.chillModels.Count;i++)
            {
                if(i==0)
                {
                    break;
                }
                if(this.chillModels[i-1].Nom == this.chillModels[i].Nom && this.chillModels[i - 1].Prenom == this.chillModels[i].Prenom)
                {
                    this.chillModels.RemoveAt(i-1);
                }
            }

        }
    }
}
