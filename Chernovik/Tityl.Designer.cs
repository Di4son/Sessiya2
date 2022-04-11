namespace Chernovik
{
    partial class Tityl
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tityl));
            this.label1 = new System.Windows.Forms.Label();
            this.voiti = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.knopkaVihod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Черновик";
            // 
            // voiti
            // 
            this.voiti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.voiti.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.voiti.Location = new System.Drawing.Point(103, 275);
            this.voiti.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.voiti.Name = "voiti";
            this.voiti.Size = new System.Drawing.Size(127, 46);
            this.voiti.TabIndex = 2;
            this.voiti.Text = "Войти";
            this.voiti.UseVisualStyleBackColor = false;
            this.voiti.Click += new System.EventHandler(this.voiti_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Chernovik.Properties.Resources.Черновик;
            this.pictureBox1.Location = new System.Drawing.Point(58, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // knopkaVihod
            // 
            this.knopkaVihod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(177)))), ((int)(((byte)(77)))));
            this.knopkaVihod.Font = new System.Drawing.Font("Segoe Print", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.knopkaVihod.Location = new System.Drawing.Point(103, 327);
            this.knopkaVihod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.knopkaVihod.Name = "knopkaVihod";
            this.knopkaVihod.Size = new System.Drawing.Size(127, 46);
            this.knopkaVihod.TabIndex = 3;
            this.knopkaVihod.Text = "Выйти";
            this.knopkaVihod.UseVisualStyleBackColor = false;
            this.knopkaVihod.Click += new System.EventHandler(this.knopkaVihod_Click);
            // 
            // Tityl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 379);
            this.Controls.Add(this.knopkaVihod);
            this.Controls.Add(this.voiti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tityl";
            this.Text = "Титульное меню";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button voiti;
        private System.Windows.Forms.Button knopkaVihod;
    }
}

