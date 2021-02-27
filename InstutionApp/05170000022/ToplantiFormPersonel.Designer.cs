
namespace _05170000022
{
    partial class ToplantiFormPersonel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabloyuKaydetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zorunluCheck = new System.Windows.Forms.RadioButton();
            this.seminerCheck = new System.Windows.Forms.RadioButton();
            this.olusturButon = new System.Windows.Forms.Button();
            this.radioTumu = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(655, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(238, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Biriminizdeki Toplantılar";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabloyuKaydetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(716, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabloyuKaydetToolStripMenuItem
            // 
            this.tabloyuKaydetToolStripMenuItem.Name = "tabloyuKaydetToolStripMenuItem";
            this.tabloyuKaydetToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.tabloyuKaydetToolStripMenuItem.Text = "Tabloyu Kaydet...";
            this.tabloyuKaydetToolStripMenuItem.Click += new System.EventHandler(this.tabloyuKaydetToolStripMenuItem_Click);
            // 
            // zorunluCheck
            // 
            this.zorunluCheck.AutoSize = true;
            this.zorunluCheck.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.zorunluCheck.Location = new System.Drawing.Point(39, 294);
            this.zorunluCheck.Name = "zorunluCheck";
            this.zorunluCheck.Size = new System.Drawing.Size(90, 23);
            this.zorunluCheck.TabIndex = 3;
            this.zorunluCheck.TabStop = true;
            this.zorunluCheck.Text = "Zorunlu";
            this.zorunluCheck.UseVisualStyleBackColor = true;
            this.zorunluCheck.CheckedChanged += new System.EventHandler(this.zorunluCheck_CheckedChanged);
            // 
            // seminerCheck
            // 
            this.seminerCheck.AutoSize = true;
            this.seminerCheck.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.seminerCheck.Location = new System.Drawing.Point(39, 323);
            this.seminerCheck.Name = "seminerCheck";
            this.seminerCheck.Size = new System.Drawing.Size(92, 23);
            this.seminerCheck.TabIndex = 4;
            this.seminerCheck.TabStop = true;
            this.seminerCheck.Text = "Seminer";
            this.seminerCheck.UseVisualStyleBackColor = true;
            this.seminerCheck.CheckedChanged += new System.EventHandler(this.seminerCheck_CheckedChanged);
            // 
            // olusturButon
            // 
            this.olusturButon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.olusturButon.Location = new System.Drawing.Point(534, 291);
            this.olusturButon.Name = "olusturButon";
            this.olusturButon.Size = new System.Drawing.Size(154, 44);
            this.olusturButon.TabIndex = 5;
            this.olusturButon.Text = "Toplantı Oluştur";
            this.olusturButon.UseVisualStyleBackColor = true;
            this.olusturButon.Click += new System.EventHandler(this.olusturButon_Click);
            // 
            // radioTumu
            // 
            this.radioTumu.AutoSize = true;
            this.radioTumu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioTumu.Location = new System.Drawing.Point(39, 265);
            this.radioTumu.Name = "radioTumu";
            this.radioTumu.Size = new System.Drawing.Size(150, 23);
            this.radioTumu.TabIndex = 6;
            this.radioTumu.TabStop = true;
            this.radioTumu.Text = "Tüm Toplantılar";
            this.radioTumu.UseVisualStyleBackColor = true;
            this.radioTumu.CheckedChanged += new System.EventHandler(this.radioTumu_CheckedChanged);
            // 
            // ToplantiFormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 376);
            this.Controls.Add(this.radioTumu);
            this.Controls.Add(this.olusturButon);
            this.Controls.Add(this.seminerCheck);
            this.Controls.Add(this.zorunluCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ToplantiFormPersonel";
            this.Text = "ToplantiFormPersonel";
            this.Load += new System.EventHandler(this.ToplantiFormPersonel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabloyuKaydetToolStripMenuItem;
        private System.Windows.Forms.RadioButton zorunluCheck;
        private System.Windows.Forms.RadioButton seminerCheck;
        private System.Windows.Forms.Button olusturButon;
        private System.Windows.Forms.RadioButton radioTumu;
    }
}