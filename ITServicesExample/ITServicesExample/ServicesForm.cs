using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITServicesExample
{
    public partial class ServicesForm : Form
    {
        public ServicesForm()
        {
            InitializeComponent();
        }

        private void serviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.serviceBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.it_services_exampleDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!");
            }
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'it_services_exampleDataSet.service_type' table. You can move, or remove it, as needed.
            this.service_typeTableAdapter.Fill(this.it_services_exampleDataSet.service_type);
            this.serviceTableAdapter.Fill(this.it_services_exampleDataSet.service);
        }
    }
}
