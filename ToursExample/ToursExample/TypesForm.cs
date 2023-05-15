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
    public partial class TypesForm : Form
    {
        public TypesForm()
        {
            InitializeComponent();
        }

        private void tour_typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tour_typeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.tours_exampleDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        private void TypesForm_Load(object sender, EventArgs e)
        {
            this.tour_typeTableAdapter.Fill(this.tours_exampleDataSet.tour_type);
        }
    }
}
