namespace Chernovik
{
    partial class SpisokMaterialov
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpisokMaterialov));
            this.materialBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.materialDataGridView = new System.Windows.Forms.DataGridView();
            this.knopkaDobavit = new System.Windows.Forms.Button();
            this.knopkaSled = new System.Windows.Forms.Button();
            this.knopkaPred = new System.Windows.Forms.Button();
            this.knopkaPervaya = new System.Windows.Forms.Button();
            this.knopkaPoslednyaya = new System.Windows.Forms.Button();
            this.knopkaYdalit = new System.Windows.Forms.Button();
            this.knopkaNazad = new System.Windows.Forms.Button();
            this.knopkaSohr = new System.Windows.Forms.Button();
            this.knopkaGalereya = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.сортироватьToolStrip = new System.Windows.Forms.ToolStrip();
            this.сортироватьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chernovikDataSet = new Chernovik.ChernovikDataSet();
            this.materialTableAdapter = new Chernovik.ChernovikDataSetTableAdapters.MaterialTableAdapter();
            this.tableAdapterManager = new Chernovik.ChernovikDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingNavigator)).BeginInit();
            this.materialBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.сортироватьToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chernovikDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // materialBindingNavigator
            // 
            this.materialBindingNavigator.AddNewItem = null;
            this.materialBindingNavigator.BindingSource = this.materialBindingSource;
            this.materialBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.materialBindingNavigator.DeleteItem = null;
            this.materialBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.materialBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.materialBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materialBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.materialBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.materialBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.materialBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.materialBindingNavigator.Name = "materialBindingNavigator";
            this.materialBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.materialBindingNavigator.Size = new System.Drawing.Size(1360, 27);
            this.materialBindingNavigator.TabIndex = 0;
            this.materialBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 24);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // materialDataGridView
            // 
            this.materialDataGridView.AutoGenerateColumns = false;
            this.materialDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.materialDataGridView.DataSource = this.materialBindingSource;
            this.materialDataGridView.Location = new System.Drawing.Point(9, 63);
            this.materialDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.materialDataGridView.Name = "materialDataGridView";
            this.materialDataGridView.RowHeadersWidth = 51;
            this.materialDataGridView.RowTemplate.Height = 24;
            this.materialDataGridView.Size = new System.Drawing.Size(1320, 299);
            this.materialDataGridView.TabIndex = 1;
            // 
            // knopkaDobavit
            // 
            this.knopkaDobavit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.knopkaDobavit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.knopkaDobavit.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.knopkaDobavit.Location = new System.Drawing.Point(686, 372);
            this.knopkaDobavit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.knopkaDobavit.Name = "knopkaDobavit";
            this.knopkaDobavit.Size = new System.Drawing.Size(148, 45);
            this.knopkaDobavit.TabIndex = 2;
            this.knopkaDobavit.Text = "Добавить";
            this.knopkaDobavit.UseVisualStyleBackColor = false;
            this.knopkaDobavit.Click += new System.EventHandler(this.buttonDobavit_Click);
            // 
            // knopkaSled
            // 
            this.knopkaSled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.knopkaSled.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.knopkaSled.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.knopkaSled.Location = new System.Drawing.Point(534, 372);
            this.knopkaSled.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.knopkaSled.Name = "knopkaSled";
            this.knopkaSled.Size = new System.Drawing.Size(148, 45);
            this.knopkaSled.TabIndex = 3;
            this.knopkaSled.Text = "Следующая";
            this.knopkaSled.UseVisualStyleBackColor = false;
            this.knopkaSled.Click += new System.EventHandler(this.buttonSled_Click);
            // 
            // knopkaPred
            // 
            this.knopkaPred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.knopkaPred.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.knopkaPred.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.knopkaPred.Location = new System.Drawing.Point(534, 422);
            this.knopkaPred.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.knopkaPred.Name = "knopkaPred";
            this.knopkaPred.Size = new System.Drawing.Size(148, 45);
            this.knopkaPred.TabIndex = 4;
            this.knopkaPred.Text = "Предыдущая";
            this.knopkaPred.UseVisualStyleBackColor = false;
            this.knopkaPred.Click += new System.EventHandler(this.buttonPred_Click);
            // 
            // knopkaPervaya
            // 
            this.knopkaPervaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.knopkaPervaya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.knopkaPervaya.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.knopkaPervaya.Location = new System.Drawing.Point(382, 372);
            this.knopkaPervaya.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.knopkaPervaya.Name = "knopkaPervaya";
            this.knopkaPervaya.Size = new System.Drawing.Size(148, 45);
            this.knopkaPervaya.TabIndex = 5;
            this.knopkaPervaya.Text = "Первая";
            this.knopkaPervaya.UseVisualStyleBackColor = false;
            this.knopkaPervaya.Click += new System.EventHandler(this.buttonPervaya_Click);
            // 
            // knopkaPoslednyaya
            // 
            this.knopkaPoslednyaya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.knopkaPoslednyaya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.knopkaPoslednyaya.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.knopkaPoslednyaya.Location = new System.Drawing.Point(382, 422);
            this.knopkaPoslednyaya.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.knopkaPoslednyaya.Name = "knopkaPoslednyaya";
            this.knopkaPoslednyaya.Size = new System.Drawing.Size(148, 45);
            this.knopkaPoslednyaya.TabIndex = 6;
            this.knopkaPoslednyaya.Text = "Последняя";
            this.knopkaPoslednyaya.UseVisualStyleBackColor = false;
            this.knopkaPoslednyaya.Click += new System.EventHandler(this.buttonPoslednyaya_Click);
            // 
            // knopkaYdalit
            // 
            this.knopkaYdalit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.knopkaYdalit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.knopkaYdalit.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.knopkaYdalit.Location = new System.Drawing.Point(686, 422);
            this.knopkaYdalit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.knopkaYdalit.Name = "knopkaYdalit";
            this.knopkaYdalit.Size = new System.Drawing.Size(148, 45);
            this.knopkaYdalit.TabIndex = 7;
            this.knopkaYdalit.Text = "Удалить";
            this.knopkaYdalit.UseVisualStyleBackColor = false;
            this.knopkaYdalit.Click += new System.EventHandler(this.buttonYdalit_Click);
            // 
            // knopkaNazad
            // 
            this.knopkaNazad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.knopkaNazad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.knopkaNazad.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.knopkaNazad.Location = new System.Drawing.Point(841, 422);
            this.knopkaNazad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.knopkaNazad.Name = "knopkaNazad";
            this.knopkaNazad.Size = new System.Drawing.Size(148, 45);
            this.knopkaNazad.TabIndex = 8;
            this.knopkaNazad.Text = "Назад";
            this.knopkaNazad.UseVisualStyleBackColor = false;
            this.knopkaNazad.Click += new System.EventHandler(this.buttonNazad_Click);
            // 
            // knopkaSohr
            // 
            this.knopkaSohr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.knopkaSohr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.knopkaSohr.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.knopkaSohr.Location = new System.Drawing.Point(841, 372);
            this.knopkaSohr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.knopkaSohr.Name = "knopkaSohr";
            this.knopkaSohr.Size = new System.Drawing.Size(148, 45);
            this.knopkaSohr.TabIndex = 9;
            this.knopkaSohr.Text = "Сохранить";
            this.knopkaSohr.UseVisualStyleBackColor = false;
            this.knopkaSohr.Click += new System.EventHandler(this.buttonSohr_Click);
            // 
            // knopkaGalereya
            // 
            this.knopkaGalereya.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.knopkaGalereya.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.knopkaGalereya.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.knopkaGalereya.Location = new System.Drawing.Point(1025, 396);
            this.knopkaGalereya.Margin = new System.Windows.Forms.Padding(2);
            this.knopkaGalereya.Name = "knopkaGalereya";
            this.knopkaGalereya.Size = new System.Drawing.Size(258, 45);
            this.knopkaGalereya.TabIndex = 30;
            this.knopkaGalereya.Text = "Галерея изображений";
            this.knopkaGalereya.UseVisualStyleBackColor = false;
            this.knopkaGalereya.Click += new System.EventHandler(this.knopkaGalereya_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Chernovik.Properties.Resources.Черновик;
            this.pictureBox2.Location = new System.Drawing.Point(1299, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 42);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
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
            // сортироватьToolStrip
            // 
            this.сортироватьToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сортироватьToolStripButton});
            this.сортироватьToolStrip.Location = new System.Drawing.Point(0, 27);
            this.сортироватьToolStrip.Name = "сортироватьToolStrip";
            this.сортироватьToolStrip.Size = new System.Drawing.Size(1360, 25);
            this.сортироватьToolStrip.TabIndex = 31;
            this.сортироватьToolStrip.Text = "сортироватьToolStrip";
            // 
            // сортироватьToolStripButton
            // 
            this.сортироватьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.сортироватьToolStripButton.Name = "сортироватьToolStripButton";
            this.сортироватьToolStripButton.Size = new System.Drawing.Size(82, 22);
            this.сортироватьToolStripButton.Text = "Сортировать";
            this.сортироватьToolStripButton.Click += new System.EventHandler(this.сортироватьToolStripButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CountInPack";
            this.dataGridViewTextBoxColumn3.HeaderText = "CountInPack";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Unit";
            this.dataGridViewTextBoxColumn4.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CountInStock";
            this.dataGridViewTextBoxColumn5.HeaderText = "CountInStock";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "MinCount";
            this.dataGridViewTextBoxColumn6.HeaderText = "MinCount";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn7.HeaderText = "Description";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cost";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cost";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Image";
            this.dataGridViewTextBoxColumn9.HeaderText = "Image";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "MaterialTypeID";
            this.dataGridViewTextBoxColumn10.HeaderText = "MaterialTypeID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.chernovikDataSet;
            // 
            // chernovikDataSet
            // 
            this.chernovikDataSet.DataSetName = "ChernovikDataSet";
            this.chernovikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgentPriorityHistoryTableAdapter = null;
            this.tableAdapterManager.AgentTableAdapter = null;
            this.tableAdapterManager.AgentTypeTableAdapter = null;
            this.tableAdapterManager.AvtorizacziyaTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MaterialCountHistoryTableAdapter = null;
            this.tableAdapterManager.MaterialSupplierTableAdapter = null;
            this.tableAdapterManager.MaterialTableAdapter = this.materialTableAdapter;
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
            // SpisokMaterialov
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 487);
            this.Controls.Add(this.сортироватьToolStrip);
            this.Controls.Add(this.knopkaGalereya);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.knopkaSohr);
            this.Controls.Add(this.knopkaNazad);
            this.Controls.Add(this.knopkaYdalit);
            this.Controls.Add(this.knopkaPoslednyaya);
            this.Controls.Add(this.knopkaPervaya);
            this.Controls.Add(this.knopkaPred);
            this.Controls.Add(this.knopkaSled);
            this.Controls.Add(this.knopkaDobavit);
            this.Controls.Add(this.materialDataGridView);
            this.Controls.Add(this.materialBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SpisokMaterialov";
            this.Text = "Список материалов";
            this.Load += new System.EventHandler(this.SpisokMaterialov_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingNavigator)).EndInit();
            this.materialBindingNavigator.ResumeLayout(false);
            this.materialBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.сортироватьToolStrip.ResumeLayout(false);
            this.сортироватьToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chernovikDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChernovikDataSet chernovikDataSet;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private ChernovikDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private ChernovikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator materialBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView materialDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button knopkaDobavit;
        private System.Windows.Forms.Button knopkaSled;
        private System.Windows.Forms.Button knopkaPred;
        private System.Windows.Forms.Button knopkaPervaya;
        private System.Windows.Forms.Button knopkaPoslednyaya;
        private System.Windows.Forms.Button knopkaYdalit;
        private System.Windows.Forms.Button knopkaNazad;
        private System.Windows.Forms.Button knopkaSohr;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button knopkaGalereya;
        private System.Windows.Forms.ToolStrip сортироватьToolStrip;
        private System.Windows.Forms.ToolStripButton сортироватьToolStripButton;
    }
}