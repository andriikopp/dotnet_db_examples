using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateExample
{
    public partial class TypesForm : Form
    {
        public TypesForm()
        {
            InitializeComponent();
        }

        private void real_estate_typesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.real_estate_typesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.real_estate_exampleDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning!");
            }
        }

        private void TypesForm_Load(object sender, EventArgs e)
        {
            this.real_estate_typesTableAdapter.Fill(this.real_estate_exampleDataSet.real_estate_types);
        }
    }
}
