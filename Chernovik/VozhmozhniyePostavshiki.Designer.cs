namespace Chernovik
{
    partial class VozhmozhniyePostavshiki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VozhmozhniyePostavshiki));
            this.chernovikDataSet = new Chernovik.ChernovikDataSet();
            this.materialSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialSupplierTableAdapter = new Chernovik.ChernovikDataSetTableAdapters.MaterialSupplierTableAdapter();
            this.tableAdapterManager = new Chernovik.ChernovikDataSetTableAdapters.TableAdapterManager();
            this.materialSupplierBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.materialSupplierDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSohr = new System.Windows.Forms.Button();
            this.buttonNazad = new System.Windows.Forms.Button();
            this.buttonYdalit = new System.Windows.Forms.Button();
            this.buttonPoslednyaya = new System.Windows.Forms.Button();
            this.buttonPervaya = new System.Windows.Forms.Button();
            this.buttonPred = new System.Windows.Forms.Button();
            this.buttonSled = new System.Windows.Forms.Button();
            this.buttonDobavit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chernovikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialSupplierBindingNavigator)).BeginInit();
            this.materialSupplierBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialSupplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chernovikDataSet
            // 
            this.chernovikDataSet.DataSetName = "ChernovikDataSet";
            this.chernovikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialSupplierBindingSource
            // 
            this.materialSupplierBindingSource.DataMember = "MaterialSupplier";
            this.materialSupplierBindingSource.DataSource = this.chernovikDataSet;
            // 
            // materialSupplierTableAdapter
            // 
            this.materialSupplierTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgentPriorityHistoryTableAdapter = null;
            this.tableAdapterManager.AgentTableAdapter = null;
            this.tableAdapterManager.AgentTypeTableAdapter = null;
            this.tableAdapterManager.AvtorizacziyaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialCountHistoryTableAdapter = null;
            this.tableAdapterManager.MaterialSupplierTableAdapter = this.materialSupplierTableAdapter;
            this.tableAdapterManager.MaterialTableAdapter = null;
            this.tableAdapterManager.MaterialTypeTableAdapter = null;
            this.tableAdapterManager.ProductCostHistoryTableAdapter = null;
            this.tableAdapterManager.ProductMaterialTableAdapter = null;
            this.tableAdapterManager.ProductSaleTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.ProductTypeTableAdapter = null;
            this.tableAdapterManager.ShopTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Chernovik.ChernovikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // materialSupplierBindingNavigator
            // 
            this.materialSupplierBindingNavigator.AddNewItem = null;
            this.materialSupplierBindingNavigator.BindingSource = this.materialSupplierBindingSource;
            this.materialSupplierBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.materialSupplierBindingNavigator.DeleteItem = null;
            this.materialSupplierBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialSupplierBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.materialSupplierBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materialSupplierBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.materialSupplierBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.materialSupplierBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.materialSupplierBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.materialSupplierBindingNavigator.Name = "materialSupplierBindingNavigator";
            this.materialSupplierBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.materialSupplierBindingNavigator.Size = new System.Drawing.Size(635, 27);
            this.materialSupplierBindingNavigator.TabIndex = 0;
            this.materialSupplierBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
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
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // materialSupplierDataGridView
            // 
            this.materialSupplierDataGridView.AutoGenerateColumns = false;
            this.materialSupplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialSupplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.materialSupplierDataGridView.DataSource = this.materialSupplierBindingSource;
            this.materialSupplierDataGridView.Location = new System.Drawing.Point(31, 47);
            this.materialSupplierDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialSupplierDataGridView.Name = "materialSupplierDataGridView";
            this.materialSupplierDataGridView.RowHeadersWidth = 51;
            this.materialSupplierDataGridView.RowTemplate.Height = 24;
            this.materialSupplierDataGridView.Size = new System.Drawing.Size(574, 179);
            this.materialSupplierDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaterialID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaterialID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn2.HeaderText = "SupplierID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "MaterialTitle";
            this.dataGridViewTextBoxColumn3.HeaderText = "MaterialTitle";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SupplierTitle";
            this.dataGridViewTextBoxColumn4.HeaderText = "SupplierTitle";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // buttonSohr
            // 
            this.buttonSohr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.buttonSohr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSohr.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSohr.Location = new System.Drawing.Point(473, 245);
            this.buttonSohr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSohr.Name = "buttonSohr";
            this.buttonSohr.Size = new System.Drawing.Size(148, 45);
            this.buttonSohr.TabIndex = 25;
            this.buttonSohr.Text = "Сохранить";
            this.buttonSohr.UseVisualStyleBackColor = false;
            this.buttonSohr.Click += new System.EventHandler(this.buttonSohr_Click);
            // 
            // buttonNazad
            // 
            this.buttonNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.buttonNazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNazad.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNazad.Location = new System.Drawing.Point(473, 295);
            this.buttonNazad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonNazad.Name = "buttonNazad";
            this.buttonNazad.Size = new System.Drawing.Size(148, 45);
            this.buttonNazad.TabIndex = 24;
            this.buttonNazad.Text = "Назад";
            this.buttonNazad.UseVisualStyleBackColor = false;
            this.buttonNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // buttonYdalit
            // 
            this.buttonYdalit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.buttonYdalit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonYdalit.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonYdalit.Location = new System.Drawing.Point(318, 295);
            this.buttonYdalit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonYdalit.Name = "buttonYdalit";
            this.buttonYdalit.Size = new System.Drawing.Size(148, 45);
            this.buttonYdalit.TabIndex = 23;
            this.buttonYdalit.Text = "Удалить";
            this.buttonYdalit.UseVisualStyleBackColor = false;
            this.buttonYdalit.Click += new System.EventHandler(this.buttonYdalit_Click);
            // 
            // buttonPoslednyaya
            // 
            this.buttonPoslednyaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.buttonPoslednyaya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPoslednyaya.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPoslednyaya.Location = new System.Drawing.Point(14, 295);
            this.buttonPoslednyaya.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPoslednyaya.Name = "buttonPoslednyaya";
            this.buttonPoslednyaya.Size = new System.Drawing.Size(148, 45);
            this.buttonPoslednyaya.TabIndex = 22;
            this.buttonPoslednyaya.Text = "Последняя";
            this.buttonPoslednyaya.UseVisualStyleBackColor = false;
            this.buttonPoslednyaya.Click += new System.EventHandler(this.buttonPoslednyaya_Click);
            // 
            // buttonPervaya
            // 
            this.buttonPervaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.buttonPervaya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPervaya.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPervaya.Location = new System.Drawing.Point(14, 245);
            this.buttonPervaya.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPervaya.Name = "buttonPervaya";
            this.buttonPervaya.Size = new System.Drawing.Size(148, 45);
            this.buttonPervaya.TabIndex = 21;
            this.buttonPervaya.Text = "Первая";
            this.buttonPervaya.UseVisualStyleBackColor = false;
            this.buttonPervaya.Click += new System.EventHandler(this.buttonPervaya_Click);
            // 
            // buttonPred
            // 
            this.buttonPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.buttonPred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPred.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPred.Location = new System.Drawing.Point(166, 295);
            this.buttonPred.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPred.Name = "buttonPred";
            this.buttonPred.Size = new System.Drawing.Size(148, 45);
            this.buttonPred.TabIndex = 20;
            this.buttonPred.Text = "Предыдущая";
            this.buttonPred.UseVisualStyleBackColor = false;
            this.buttonPred.Click += new System.EventHandler(this.buttonPred_Click);
            // 
            // buttonSled
            // 
            this.buttonSled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.buttonSled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSled.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSled.Location = new System.Drawing.Point(166, 245);
            this.buttonSled.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSled.Name = "buttonSled";
            this.buttonSled.Size = new System.Drawing.Size(148, 45);
            this.buttonSled.TabIndex = 19;
            this.buttonSled.Text = "Следующая";
            this.buttonSled.UseVisualStyleBackColor = false;
            this.buttonSled.Click += new System.EventHandler(this.buttonSled_Click);
            // 
            // buttonDobavit
            // 
            this.buttonDobavit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.buttonDobavit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDobavit.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDobavit.Location = new System.Drawing.Point(318, 245);
            this.buttonDobavit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonDobavit.Name = "buttonDobavit";
            this.buttonDobavit.Size = new System.Drawing.Size(148, 45);
            this.buttonDobavit.TabIndex = 18;
            this.buttonDobavit.Text = "Добавить";
            this.buttonDobavit.UseVisualStyleBackColor = false;
            this.buttonDobavit.Click += new System.EventHandler(this.buttonDobavit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chernovik.Properties.Resources.Черновик;
            this.pictureBox1.Location = new System.Drawing.Point(593, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // VozhmozhniyePostavshiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonSohr);
            this.Controls.Add(this.buttonNazad);
            this.Controls.Add(this.buttonYdalit);
            this.Controls.Add(this.buttonPoslednyaya);
            this.Controls.Add(this.buttonPervaya);
            this.Controls.Add(this.buttonPred);
            this.Controls.Add(this.buttonSled);
            this.Controls.Add(this.buttonDobavit);
            this.Controls.Add(this.materialSupplierDataGridView);
            this.Controls.Add(this.materialSupplierBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "VozhmozhniyePostavshiki";
            this.Text = "Возможные поставщики";
            this.Load += new System.EventHandler(this.VozhmozhniyePostavshiki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chernovikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialSupplierBindingNavigator)).EndInit();
            this.materialSupplierBindingNavigator.ResumeLayout(false);
            this.materialSupplierBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialSupplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChernovikDataSet chernovikDataSet;
        private System.Windows.Forms.BindingSource materialSupplierBindingSource;
        private ChernovikDataSetTableAdapters.MaterialSupplierTableAdapter materialSupplierTableAdapter;
        private ChernovikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator materialSupplierBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView materialSupplierDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button buttonSohr;
        private System.Windows.Forms.Button buttonNazad;
        private System.Windows.Forms.Button buttonYdalit;
        private System.Windows.Forms.Button buttonPoslednyaya;
        private System.Windows.Forms.Button buttonPervaya;
        private System.Windows.Forms.Button buttonPred;
        private System.Windows.Forms.Button buttonSled;
        private System.Windows.Forms.Button buttonDobavit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}