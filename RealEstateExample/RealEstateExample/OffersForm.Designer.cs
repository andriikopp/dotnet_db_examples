namespace RealEstateExample
{
    partial class OffersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OffersForm));
            this.real_estate_exampleDataSet = new RealEstateExample.real_estate_exampleDataSet();
            this.real_estate_offersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.real_estate_offersTableAdapter = new RealEstateExample.real_estate_exampleDataSetTableAdapters.real_estate_offersTableAdapter();
            this.tableAdapterManager = new RealEstateExample.real_estate_exampleDataSetTableAdapters.TableAdapterManager();
            this.real_estate_typesTableAdapter = new RealEstateExample.real_estate_exampleDataSetTableAdapters.real_estate_typesTableAdapter();
            this.real_estate_offersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.real_estate_offersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.real_estate_offersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ret_id = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.realestatetypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_exampleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_offersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_offersBindingNavigator)).BeginInit();
            this.real_estate_offersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_offersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.realestatetypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // real_estate_exampleDataSet
            // 
            this.real_estate_exampleDataSet.DataSetName = "real_estate_exampleDataSet";
            this.real_estate_exampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // real_estate_offersBindingSource
            // 
            this.real_estate_offersBindingSource.DataMember = "real_estate_offers";
            this.real_estate_offersBindingSource.DataSource = this.real_estate_exampleDataSet;
            // 
            // real_estate_offersTableAdapter
            // 
            this.real_estate_offersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.real_estate_offersTableAdapter = this.real_estate_offersTableAdapter;
            this.tableAdapterManager.real_estate_typesTableAdapter = this.real_estate_typesTableAdapter;
            this.tableAdapterManager.UpdateOrder = RealEstateExample.real_estate_exampleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // real_estate_typesTableAdapter
            // 
            this.real_estate_typesTableAdapter.ClearBeforeFill = true;
            // 
            // real_estate_offersBindingNavigator
            // 
            this.real_estate_offersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.real_estate_offersBindingNavigator.BindingSource = this.real_estate_offersBindingSource;
            this.real_estate_offersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.real_estate_offersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.real_estate_offersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.real_estate_offersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.real_estate_offersBindingNavigatorSaveItem});
            this.real_estate_offersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.real_estate_offersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.real_estate_offersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.real_estate_offersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.real_estate_offersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.real_estate_offersBindingNavigator.Name = "real_estate_offersBindingNavigator";
            this.real_estate_offersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.real_estate_offersBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.real_estate_offersBindingNavigator.TabIndex = 0;
            this.real_estate_offersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // real_estate_offersBindingNavigatorSaveItem
            // 
            this.real_estate_offersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.real_estate_offersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("real_estate_offersBindingNavigatorSaveItem.Image")));
            this.real_estate_offersBindingNavigatorSaveItem.Name = "real_estate_offersBindingNavigatorSaveItem";
            this.real_estate_offersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.real_estate_offersBindingNavigatorSaveItem.Text = "Save Data";
            this.real_estate_offersBindingNavigatorSaveItem.Click += new System.EventHandler(this.real_estate_offersBindingNavigatorSaveItem_Click);
            // 
            // real_estate_offersDataGridView
            // 
            this.real_estate_offersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.real_estate_offersDataGridView.AutoGenerateColumns = false;
            this.real_estate_offersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.real_estate_offersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.ret_id,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.real_estate_offersDataGridView.DataSource = this.real_estate_offersBindingSource;
            this.real_estate_offersDataGridView.Location = new System.Drawing.Point(12, 32);
            this.real_estate_offersDataGridView.Name = "real_estate_offersDataGridView";
            this.real_estate_offersDataGridView.RowHeadersWidth = 51;
            this.real_estate_offersDataGridView.RowTemplate.Height = 24;
            this.real_estate_offersDataGridView.Size = new System.Drawing.Size(776, 406);
            this.real_estate_offersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "reo_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "reo_title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "reo_description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // ret_id
            // 
            this.ret_id.DataPropertyName = "ret_id";
            this.ret_id.DataSource = this.realestatetypesBindingSource;
            this.ret_id.DisplayMember = "ret_name";
            this.ret_id.HeaderText = "Type";
            this.ret_id.MinimumWidth = 6;
            this.ret_id.Name = "ret_id";
            this.ret_id.ValueMember = "ret_id";
            this.ret_id.Width = 125;
            // 
            // realestatetypesBindingSource
            // 
            this.realestatetypesBindingSource.DataMember = "real_estate_types";
            this.realestatetypesBindingSource.DataSource = this.real_estate_exampleDataSet;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "reo_address";
            this.dataGridViewTextBoxColumn5.HeaderText = "Address";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "reo_city";
            this.dataGridViewTextBoxColumn6.HeaderText = "City";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "reo_country";
            this.dataGridViewTextBoxColumn7.HeaderText = "Country";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "reo_price";
            this.dataGridViewTextBoxColumn8.HeaderText = "Price";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "reo_img_url";
            this.dataGridViewTextBoxColumn9.HeaderText = "Image URL";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // OffersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.real_estate_offersDataGridView);
            this.Controls.Add(this.real_estate_offersBindingNavigator);
            this.Name = "OffersForm";
            this.Text = "Offers";
            this.Load += new System.EventHandler(this.OffersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_exampleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_offersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_offersBindingNavigator)).EndInit();
            this.real_estate_offersBindingNavigator.ResumeLayout(false);
            this.real_estate_offersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_offersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.realestatetypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private real_estate_exampleDataSet real_estate_exampleDataSet;
        private System.Windows.Forms.BindingSource real_estate_offersBindingSource;
        private real_estate_exampleDataSetTableAdapters.real_estate_offersTableAdapter real_estate_offersTableAdapter;
        private real_estate_exampleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator real_estate_offersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton real_estate_offersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView real_estate_offersDataGridView;
        private real_estate_exampleDataSetTableAdapters.real_estate_typesTableAdapter real_estate_typesTableAdapter;
        private System.Windows.Forms.BindingSource realestatetypesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn ret_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
    }
}