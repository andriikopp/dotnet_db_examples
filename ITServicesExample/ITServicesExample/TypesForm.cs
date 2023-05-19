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
    public partial class TypesForm : Form
    {
        public TypesForm()
        {
            InitializeComponent();
        }

        private void service_typeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.service_typeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.it_services_exampleDataSet);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Warning!");
            }
        }

        private void TypesForm_Load(object sender, EventArgs e)
        {
            this.service_typeTableAdapter.Fill(this.it_services_exampleDataSet.service_type);
        }
    }
}
