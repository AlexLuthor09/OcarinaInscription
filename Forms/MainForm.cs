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
            try {
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
            ComboBox_ListOfChildren.DataSource = null;
            ComboBox_ListOfChildren.DataSource = childs;
            ComboBox_ListOfChildren.DisplayMember = "FullName";
        }


        private void Butt_Add_Children_Click(object sender, EventArgs e)
        {
            FM.OpenInscription();
        }

        private void Butt_Modifier_Participant_Click(object sender, EventArgs e)
        {
            FM.OpenInscription(selectedChild());
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            LoadEnfantList();
        }

        private void But_Supp_Enfant_Click(object sender, EventArgs e)
        {
            SqlManager.DeleteChild(selectedChild());
            LoadEnfantList();
        }

        private void BUT_Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private ChillModel selectedChild()
        {
            return dataGridView1.CurrentRow.DataBoundItem as ChillModel;
        }

        private void But_apayer_Click(object sender, EventArgs e)
        {
            SqlManager.ChildHavePaid(selectedChild(),dateTimePicker1.Value.DayOfWeek);
            LoadEnfantList();
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
    }
}