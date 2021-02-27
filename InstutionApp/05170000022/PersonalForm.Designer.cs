
namespace _05170000022
{
    partial class PersonalForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesajlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplantıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplantılarıGörüntüleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilancoShowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MDIPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.labelID);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 98);
            this.panel1.TabIndex = 0;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTime.Location = new System.Drawing.Point(626, 51);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(50, 29);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Dubai", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(14, 40);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(115, 51);
            this.labelID.TabIndex = 3;
            this.labelID.Text = "Bilgiler";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.işlemlerToolStripMenuItem,
            this.toplantıToolStripMenuItem,
            this.bilancoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoShowToolStripMenuItem,
            this.mesajlarToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // infoShowToolStripMenuItem
            // 
            this.infoShowToolStripMenuItem.Name = "infoShowToolStripMenuItem";
            this.infoShowToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.infoShowToolStripMenuItem.Text = "Bilgileri Göster";
            this.infoShowToolStripMenuItem.Click += new System.EventHandler(this.infoShowToolStripMenuItem_Click);
            // 
            // mesajlarToolStripMenuItem
            // 
            this.mesajlarToolStripMenuItem.Name = "mesajlarToolStripMenuItem";
            this.mesajlarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mesajlarToolStripMenuItem.Text = "Mesajlar";
            this.mesajlarToolStripMenuItem.Click += new System.EventHandler(this.mesajlarToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // toplantıToolStripMenuItem
            // 
            this.toplantıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplantılarıGörüntüleToolStripMenuItem});
            this.toplantıToolStripMenuItem.Name = "toplantıToolStripMenuItem";
            this.toplantıToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.toplantıToolStripMenuItem.Text = "Toplantı";
            // 
            // toplantılarıGörüntüleToolStripMenuItem
            // 
            this.toplantılarıGörüntüleToolStripMenuItem.Name = "toplantılarıGörüntüleToolStripMenuItem";
            this.toplantılarıGörüntüleToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.toplantılarıGörüntüleToolStripMenuItem.Text = "Toplantıları Görüntüle";
            this.toplantılarıGörüntüleToolStripMenuItem.Click += new System.EventHandler(this.toplantılarıGörüntüleToolStripMenuItem_Click);
            // 
            // bilancoToolStripMenuItem
            // 
            this.bilancoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bilancoShowToolStripMenuItem});
            this.bilancoToolStripMenuItem.Name = "bilancoToolStripMenuItem";
            this.bilancoToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.bilancoToolStripMenuItem.Text = "Bilanço";
            // 
            // bilancoShowToolStripMenuItem
            // 
            this.bilancoShowToolStripMenuItem.Name = "bilancoShowToolStripMenuItem";
            this.bilancoShowToolStripMenuItem.Size = new System.Drawing.Size(248, 26);
            this.bilancoShowToolStripMenuItem.Text = "Bilanço Göster/Düzenle";
            this.bilancoShowToolStripMenuItem.Click += new System.EventHandler(this.bilancoShowToolStripMenuItem_Click);
            // 
            // MDIPanel
            // 
            this.MDIPanel.Location = new System.Drawing.Point(-2, 94);
            this.MDIPanel.Name = "MDIPanel";
            this.MDIPanel.Size = new System.Drawing.Size(803, 357);
            this.MDIPanel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MDIPanel);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "PersonalForm";
            this.Text = "Personel Paneli";
            this.Load += new System.EventHandler(this.PersonalForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoShowToolStripMenuItem;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Panel MDIPanel;
        private System.Windows.Forms.ToolStripMenuItem toplantıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplantılarıGörüntüleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilancoShowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mesajlarToolStripMenuItem;
    }
}