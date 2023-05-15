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
    public partial class ToursForm : Form
    {
        public ToursForm()
        {
            InitializeComponent();
        }

        private void tourBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tourBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tours_exampleDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void ToursForm_Load(object sender, EventArgs e)
        {
            this.tour_typeTableAdapter.Fill(this.tours_exampleDataSet.tour_type);
            this.tourTableAdapter.Fill(this.tours_exampleDataSet.tour);
        }
    }
}
