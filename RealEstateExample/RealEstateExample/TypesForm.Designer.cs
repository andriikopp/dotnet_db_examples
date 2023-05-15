namespace RealEstateExample
{
    partial class TypesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TypesForm));
            this.real_estate_exampleDataSet = new RealEstateExample.real_estate_exampleDataSet();
            this.real_estate_typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.real_estate_typesTableAdapter = new RealEstateExample.real_estate_exampleDataSetTableAdapters.real_estate_typesTableAdapter();
            this.tableAdapterManager = new RealEstateExample.real_estate_exampleDataSetTableAdapters.TableAdapterManager();
            this.real_estate_typesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.real_estate_typesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.real_estate_typesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_exampleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_typesBindingNavigator)).BeginInit();
            this.real_estate_typesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_typesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // real_estate_exampleDataSet
            // 
            this.real_estate_exampleDataSet.DataSetName = "real_estate_exampleDataSet";
            this.real_estate_exampleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // real_estate_typesBindingSource
            // 
            this.real_estate_typesBindingSource.DataMember = "real_estate_types";
            this.real_estate_typesBindingSource.DataSource = this.real_estate_exampleDataSet;
            // 
            // real_estate_typesTableAdapter
            // 
            this.real_estate_typesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.real_estate_offersTableAdapter = null;
            this.tableAdapterManager.real_estate_typesTableAdapter = this.real_estate_typesTableAdapter;
            this.tableAdapterManager.UpdateOrder = RealEstateExample.real_estate_exampleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // real_estate_typesBindingNavigator
            // 
            this.real_estate_typesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.real_estate_typesBindingNavigator.BindingSource = this.real_estate_typesBindingSource;
            this.real_estate_typesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.real_estate_typesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.real_estate_typesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.real_estate_typesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.real_estate_typesBindingNavigatorSaveItem});
            this.real_estate_typesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.real_estate_typesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.real_estate_typesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.real_estate_typesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.real_estate_typesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.real_estate_typesBindingNavigator.Name = "real_estate_typesBindingNavigator";
            this.real_estate_typesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.real_estate_typesBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.real_estate_typesBindingNavigator.TabIndex = 0;
            this.real_estate_typesBindingNavigator.Text = "bindingNavigator1";
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
            // real_estate_typesBindingNavigatorSaveItem
            // 
            this.real_estate_typesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.real_estate_typesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("real_estate_typesBindingNavigatorSaveItem.Image")));
            this.real_estate_typesBindingNavigatorSaveItem.Name = "real_estate_typesBindingNavigatorSaveItem";
            this.real_estate_typesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.real_estate_typesBindingNavigatorSaveItem.Text = "Save Data";
            this.real_estate_typesBindingNavigatorSaveItem.Click += new System.EventHandler(this.real_estate_typesBindingNavigatorSaveItem_Click);
            // 
            // real_estate_typesDataGridView
            // 
            this.real_estate_typesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.real_estate_typesDataGridView.AutoGenerateColumns = false;
            this.real_estate_typesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.real_estate_typesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.real_estate_typesDataGridView.DataSource = this.real_estate_typesBindingSource;
            this.real_estate_typesDataGridView.Location = new System.Drawing.Point(12, 42);
            this.real_estate_typesDataGridView.Name = "real_estate_typesDataGridView";
            this.real_estate_typesDataGridView.RowHeadersWidth = 51;
            this.real_estate_typesDataGridView.RowTemplate.Height = 24;
            this.real_estate_typesDataGridView.Size = new System.Drawing.Size(776, 396);
            this.real_estate_typesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ret_id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ret_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // TypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.real_estate_typesDataGridView);
            this.Controls.Add(this.real_estate_typesBindingNavigator);
            this.Name = "TypesForm";
            this.Text = "Types";
            this.Load += new System.EventHandler(this.TypesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_exampleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_typesBindingNavigator)).EndInit();
            this.real_estate_typesBindingNavigator.ResumeLayout(false);
            this.real_estate_typesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.real_estate_typesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private real_estate_exampleDataSet real_estate_exampleDataSet;
        private System.Windows.Forms.BindingSource real_estate_typesBindingSource;
        private real_estate_exampleDataSetTableAdapters.real_estate_typesTableAdapter real_estate_typesTableAdapter;
        private real_estate_exampleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator real_estate_typesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton real_estate_typesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView real_estate_typesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}