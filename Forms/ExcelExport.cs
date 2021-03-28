using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OcarinaInscription.Class;
using OcarinaInscription.SQLclass;

namespace OcarinaInscription
{
    public partial class ExcelExport : Form
    {
        private char Quoi;
        public ExcelExport(char quoi)
        { 
            InitializeComponent();
            this.Quoi = quoi;
            if(quoi=='b')
            {
                DTP_Start.Visible = false;
                DTP_Stop.Visible = false;
            }
            
        }

        private void But_Validation_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                if (TB_NomPlaine.Text.Trim() != "")
                {
                    string NomPlaine = TB_NomPlaine.Text.Replace(@"\s", "").Trim();
                    string path = textBox1.Text;

                    switch(this.Quoi)
                    {
                        case ('a'):
                                string dateDebut = DTP_Start.Value.Date.ToShortDateString().Trim();
                                string dateFin = DTP_Stop.Value.Date.ToShortDateString().Trim();

                                SqlManager.ExportEnfantToExcel(path + @"\" + NomPlaine /*+ "_" + dateDebut + "_" + dateFin*/);
                                MessageBox.Show("Fichier Excel créer , tu peux le trouver ici : " + path + @"\" + NomPlaine + "_" + dateDebut + "_" + dateFin + ".xls");

                            break;
                        case ('b'):

                                SqlManager.ExportRemarquetToExcel(path + @"\" + NomPlaine /*+ "_"+ DateTime.Now.ToShortDateString()*/);
                                MessageBox.Show("Fichiers Excel créés , tu peux les trouver ici : " + path + @"\" + NomPlaine + "_" + DateTime.Now.ToShortDateString());
                            break;
                        default:
                            MessageBox.Show("Mauvaise Manipulation");
                            break;
                    }
                    
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Veuillez remplir tous les champs textes disponibles");
                }
            }
            else
            {
                MessageBox.Show("Désigné d'abord un dossier");
            }
        }

        private void OpenExistanteFile_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }
        }
    }
}
