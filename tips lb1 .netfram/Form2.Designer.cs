namespace tips_lb1.netfram
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.fifaDataSet = new tips_lb1.netfram.FifaDataSet();
            this.гравецьBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.гравецьTableAdapter = new tips_lb1.netfram.FifaDataSetTableAdapters.гравецьTableAdapter();
            this.tableAdapterManager = new tips_lb1.netfram.FifaDataSetTableAdapters.TableAdapterManager();
            this.командаTableAdapter = new tips_lb1.netfram.FifaDataSetTableAdapters.командаTableAdapter();
            this.гравецьBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.гравецьBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.Exit = new System.Windows.Forms.ToolStripButton();
            this.командаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKгравецькомандаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKгравецькомандаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKгравецькомандаBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.гравецьDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.командаDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.fifaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гравецьBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гравецьBindingNavigator)).BeginInit();
            this.гравецьBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.командаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKгравецькомандаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKгравецькомандаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKгравецькомандаBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.гравецьDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.командаDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // fifaDataSet
            // 
            this.fifaDataSet.DataSetName = "FifaDataSet";
            this.fifaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // гравецьBindingSource
            // 
            this.гравецьBindingSource.DataMember = "гравець";
            this.гравецьBindingSource.DataSource = this.fifaDataSet;
            // 
            // гравецьTableAdapter
            // 
            this.гравецьTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = tips_lb1.netfram.FifaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.амплуаTableAdapter = null;
            this.tableAdapterManager.гравецьTableAdapter = this.гравецьTableAdapter;
            this.tableAdapterManager.командаTableAdapter = this.командаTableAdapter;
            // 
            // командаTableAdapter
            // 
            this.командаTableAdapter.ClearBeforeFill = true;
            // 
            // гравецьBindingNavigator
            // 
            this.гравецьBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.гравецьBindingNavigator.BindingSource = this.гравецьBindingSource;
            this.гравецьBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.гравецьBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.гравецьBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.гравецьBindingNavigatorSaveItem,
            this.Exit});
            this.гравецьBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.гравецьBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.гравецьBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.гравецьBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.гравецьBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.гравецьBindingNavigator.Name = "гравецьBindingNavigator";
            this.гравецьBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.гравецьBindingNavigator.Size = new System.Drawing.Size(884, 25);
            this.гравецьBindingNavigator.TabIndex = 0;
            this.гравецьBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // гравецьBindingNavigatorSaveItem
            // 
            this.гравецьBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.гравецьBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("гравецьBindingNavigatorSaveItem.Image")));
            this.гравецьBindingNavigatorSaveItem.Name = "гравецьBindingNavigatorSaveItem";
            this.гравецьBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.гравецьBindingNavigatorSaveItem.Text = "Save Data";
            this.гравецьBindingNavigatorSaveItem.Click += new System.EventHandler(this.гравецьBindingNavigatorSaveItem_Click);
            // 
            // Exit
            // 
            this.Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Exit.Image = global::tips_lb1.netfram.Properties.Resources.exit;
            this.Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(23, 22);
            this.Exit.Text = "toolStripButton1";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // командаBindingSource
            // 
            this.командаBindingSource.DataMember = "команда";
            this.командаBindingSource.DataSource = this.fifaDataSet;
            // 
            // гравецьDataGridView
            // 
            this.гравецьDataGridView.AutoGenerateColumns = false;
            this.гравецьDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.гравецьDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.гравецьDataGridView.DataSource = this.гравецьBindingSource;
            this.гравецьDataGridView.Location = new System.Drawing.Point(12, 28);
            this.гравецьDataGridView.Name = "гравецьDataGridView";
            this.гравецьDataGridView.Size = new System.Drawing.Size(849, 207);
            this.гравецьDataGridView.TabIndex = 1;
            this.гравецьDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.гравецьDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_гравець";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_гравець";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "П_І_П";
            this.dataGridViewTextBoxColumn2.HeaderText = "П_І_П";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата_народження";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата_народження";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_команда";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_команда";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_амплуа";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_амплуа";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Зріст";
            this.dataGridViewTextBoxColumn6.HeaderText = "Зріст";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Вага";
            this.dataGridViewTextBoxColumn7.HeaderText = "Вага";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Номер";
            this.dataGridViewTextBoxColumn8.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // командаDataGridView1
            // 
            this.командаDataGridView1.AutoGenerateColumns = false;
            this.командаDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.командаDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.командаDataGridView1.DataSource = this.командаBindingSource;
            this.командаDataGridView1.Location = new System.Drawing.Point(0, 241);
            this.командаDataGridView1.Name = "командаDataGridView1";
            this.командаDataGridView1.Size = new System.Drawing.Size(571, 251);
            this.командаDataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "id_команда";
            this.dataGridViewTextBoxColumn10.HeaderText = "id_команда";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Назва";
            this.dataGridViewTextBoxColumn11.HeaderText = "Назва";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Дата_формування_складу";
            this.dataGridViewTextBoxColumn12.HeaderText = "Дата_формування_складу";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Тренер";
            this.dataGridViewTextBoxColumn13.HeaderText = "Тренер";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn14.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 593);
            this.Controls.Add(this.командаDataGridView1);
            this.Controls.Add(this.гравецьDataGridView);
            this.Controls.Add(this.гравецьBindingNavigator);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fifaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гравецьBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гравецьBindingNavigator)).EndInit();
            this.гравецьBindingNavigator.ResumeLayout(false);
            this.гравецьBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.командаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKгравецькомандаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKгравецькомандаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKгравецькомандаBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.гравецьDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.командаDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FifaDataSet fifaDataSet;
        private System.Windows.Forms.BindingSource гравецьBindingSource;
        private FifaDataSetTableAdapters.гравецьTableAdapter гравецьTableAdapter;
        private FifaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator гравецьBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton гравецьBindingNavigatorSaveItem;
        private FifaDataSetTableAdapters.командаTableAdapter командаTableAdapter;
        private System.Windows.Forms.BindingSource командаBindingSource;
        private System.Windows.Forms.ToolStripButton Exit;
        private System.Windows.Forms.BindingSource fKгравецькомандаBindingSource;
        private System.Windows.Forms.BindingSource fKгравецькомандаBindingSource1;
        private System.Windows.Forms.BindingSource fKгравецькомандаBindingSource2;
        private System.Windows.Forms.DataGridView гравецьDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView командаDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
    }
}