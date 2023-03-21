using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProject
{
    public partial class PredmForm : Form
    {
        public PredmForm()
        {
            InitializeComponent();
        }

        private void предметыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.предметыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.studentDataSet);

        }

        private void BtnPredm_Click(object sender, EventArgs e)
        {
            PredmForm pf = new PredmForm();
            pf.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void наименование_предметаTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PredmForm_Load(object sender, EventArgs e)
        {

        }
    }
}
