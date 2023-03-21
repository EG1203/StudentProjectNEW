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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpecForm sf = new SpecForm();
            sf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PredmForm pf = new PredmForm();
            pf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Students sf = new Students();
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OcenkiForm of = new OcenkiForm();
            of.Show();
        }
    }
}
