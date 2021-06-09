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
        private int plaine;
        public ExcelExport(char quoi, int plaines)
        { 
            InitializeComponent();
            this.Quoi = quoi;
           
            comboBox1.DataSource = null;
            comboBox1.DataSource = SqlManager.LoadPlaines();
            comboBox1.DisplayMember = "Nom";
            this.plaine = plaines;
        }

        private void But_Validation_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                if (comboBox1.Text.Trim() != "")
                {
                    string NomPlaine = comboBox1.Text + DateTime.Now.Year.ToString();/*comboBox1.SelectedText.Replace(@"\s", "").Replace(@"/","-").Trim();*/
                    string path = textBox1.Text;

                    switch(this.Quoi)
                    {
                        case ('a'):
                               

                                SqlManager.ExportEnfantToExcel(path + @"\" + NomPlaine,this.plaine);
                                MessageBox.Show("Fichier Excel créer , tu peux le trouver ici : " + path + @"\" + NomPlaine + ".xls");

                            break;
                        case ('b'):

                                SqlManager.ExportRemarquetToExcel(path + @"\" + NomPlaine, this.plaine);
                                MessageBox.Show("Fichiers Excel créés , tu peux les trouver ici : " + path + @"\" + NomPlaine + DateTime.Now.ToShortDateString().Replace(@"\s", "").Trim());
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
