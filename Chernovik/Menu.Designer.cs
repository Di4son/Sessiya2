namespace Chernovik
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.SpisokMaterialov = new System.Windows.Forms.Button();
            this.Postavshiki = new System.Windows.Forms.Button();
            this.TipyMaterialov = new System.Windows.Forms.Button();
            this.VozmozhniyePostavshiki = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SpisokMaterialov
            // 
            this.SpisokMaterialov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.SpisokMaterialov.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SpisokMaterialov.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpisokMaterialov.Location = new System.Drawing.Point(14, 58);
            this.SpisokMaterialov.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SpisokMaterialov.Name = "SpisokMaterialov";
            this.SpisokMaterialov.Size = new System.Drawing.Size(277, 46);
            this.SpisokMaterialov.TabIndex = 3;
            this.SpisokMaterialov.Text = "Список материалов";
            this.SpisokMaterialov.UseVisualStyleBackColor = false;
            this.SpisokMaterialov.Click += new System.EventHandler(this.SpisokMaterialov_Click);
            // 
            // Postavshiki
            // 
            this.Postavshiki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.Postavshiki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Postavshiki.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Postavshiki.Location = new System.Drawing.Point(483, 58);
            this.Postavshiki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Postavshiki.Name = "Postavshiki";
            this.Postavshiki.Size = new System.Drawing.Size(277, 46);
            this.Postavshiki.TabIndex = 4;
            this.Postavshiki.Text = "Поставщики";
            this.Postavshiki.UseVisualStyleBackColor = false;
            this.Postavshiki.Click += new System.EventHandler(this.Postavshiki_Click);
            // 
            // TipyMaterialov
            // 
            this.TipyMaterialov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.TipyMaterialov.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TipyMaterialov.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TipyMaterialov.Location = new System.Drawing.Point(483, 112);
            this.TipyMaterialov.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TipyMaterialov.Name = "TipyMaterialov";
            this.TipyMaterialov.Size = new System.Drawing.Size(277, 46);
            this.TipyMaterialov.TabIndex = 5;
            this.TipyMaterialov.Text = "Типы материалов";
            this.TipyMaterialov.UseVisualStyleBackColor = false;
            this.TipyMaterialov.Click += new System.EventHandler(this.TipyMaterialov_Click);
            // 
            // VozmozhniyePostavshiki
            // 
            this.VozmozhniyePostavshiki.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.VozmozhniyePostavshiki.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VozmozhniyePostavshiki.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VozmozhniyePostavshiki.Location = new System.Drawing.Point(14, 112);
            this.VozmozhniyePostavshiki.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VozmozhniyePostavshiki.Name = "VozmozhniyePostavshiki";
            this.VozmozhniyePostavshiki.Size = new System.Drawing.Size(277, 46);
            this.VozmozhniyePostavshiki.TabIndex = 6;
            this.VozmozhniyePostavshiki.Text = "Возможные поставщики";
            this.VozmozhniyePostavshiki.UseVisualStyleBackColor = false;
            this.VozmozhniyePostavshiki.Click += new System.EventHandler(this.VozmozhniyePostavshiki_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chernovik.Properties.Resources.Черновик;
            this.pictureBox1.Location = new System.Drawing.Point(295, 24);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "material_1.jpeg");
            this.imageList1.Images.SetKeyName(1, "material_2.jpeg");
            this.imageList1.Images.SetKeyName(2, "material_3.jpeg");
            this.imageList1.Images.SetKeyName(3, "material_4.jpeg");
            this.imageList1.Images.SetKeyName(4, "material_5.jpeg");
            this.imageList1.Images.SetKeyName(5, "material_6.jpeg");
            this.imageList1.Images.SetKeyName(6, "material_7.jpeg");
            this.imageList1.Images.SetKeyName(7, "material_8.jpeg");
            this.imageList1.Images.SetKeyName(8, "material_9.jpeg");
            this.imageList1.Images.SetKeyName(9, "material_10.jpeg");
            this.imageList1.Images.SetKeyName(10, "material_11.jpeg");
            this.imageList1.Images.SetKeyName(11, "material_12.jpeg");
            this.imageList1.Images.SetKeyName(12, "material_13.jpeg");
            this.imageList1.Images.SetKeyName(13, "material_14.jpeg");
            this.imageList1.Images.SetKeyName(14, "material_15.jpeg");
            this.imageList1.Images.SetKeyName(15, "material_16.jpeg");
            this.imageList1.Images.SetKeyName(16, "material_17.jpeg");
            this.imageList1.Images.SetKeyName(17, "material_18.jpeg");
            this.imageList1.Images.SetKeyName(18, "material_19.jpeg");
            this.imageList1.Images.SetKeyName(19, "material_20.jpeg");
            this.imageList1.Images.SetKeyName(20, "material_21.jpeg");
            this.imageList1.Images.SetKeyName(21, "material_22.jpeg");
            this.imageList1.Images.SetKeyName(22, "material_23.jpeg");
            this.imageList1.Images.SetKeyName(23, "material_24.jpeg");
            this.imageList1.Images.SetKeyName(24, "material_25.jpeg");
            this.imageList1.Images.SetKeyName(25, "material_26.png");
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 213);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.VozmozhniyePostavshiki);
            this.Controls.Add(this.TipyMaterialov);
            this.Controls.Add(this.Postavshiki);
            this.Controls.Add(this.SpisokMaterialov);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Главное меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SpisokMaterialov;
        private System.Windows.Forms.Button Postavshiki;
        private System.Windows.Forms.Button TipyMaterialov;
        private System.Windows.Forms.Button VozmozhniyePostavshiki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}