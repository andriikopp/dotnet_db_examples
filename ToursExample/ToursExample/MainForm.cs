using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToursExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToursForm toursForm = new ToursForm();
            toursForm.MdiParent = this;
            toursForm.Show();
        }

        private void typesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypesForm typesForm = new TypesForm();
            typesForm.MdiParent = this;
            typesForm.Show();
        }
    }
}
