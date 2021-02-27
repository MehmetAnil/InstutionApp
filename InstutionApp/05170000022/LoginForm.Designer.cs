
namespace _05170000022
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.slidePanel = new System.Windows.Forms.Panel();
            this.slideLabel = new System.Windows.Forms.Label();
            this.panelPersonel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPersonel = new System.Windows.Forms.Button();
            this.textPasswordPersonel = new System.Windows.Forms.TextBox();
            this.textPersonel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelYonetici = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonAdmin = new System.Windows.Forms.Button();
            this.textPasswordYonetici = new System.Windows.Forms.TextBox();
            this.textYonetici = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.slidePanel.SuspendLayout();
            this.panelPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelYonetici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // slidePanel
            // 
            this.slidePanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.slidePanel.Controls.Add(this.slideLabel);
            this.slidePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.slidePanel.Location = new System.Drawing.Point(0, 458);
            this.slidePanel.Name = "slidePanel";
            this.slidePanel.Size = new System.Drawing.Size(576, 43);
            this.slidePanel.TabIndex = 0;
            // 
            // slideLabel
            // 
            this.slideLabel.AutoSize = true;
            this.slideLabel.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.slideLabel.ForeColor = System.Drawing.Color.Sienna;
            this.slideLabel.Location = new System.Drawing.Point(434, 11);
            this.slideLabel.Name = "slideLabel";
            this.slideLabel.Size = new System.Drawing.Size(130, 23);
            this.slideLabel.TabIndex = 0;
            this.slideLabel.Text = "personel girişi";
            this.slideLabel.Click += new System.EventHandler(this.slideLabel_Click);
            // 
            // panelPersonel
            // 
            this.panelPersonel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelPersonel.Controls.Add(this.pictureBox4);
            this.panelPersonel.Controls.Add(this.pictureBox3);
            this.panelPersonel.Controls.Add(this.pictureBox1);
            this.panelPersonel.Controls.Add(this.buttonPersonel);
            this.panelPersonel.Controls.Add(this.textPasswordPersonel);
            this.panelPersonel.Controls.Add(this.textPersonel);
            this.panelPersonel.Controls.Add(this.label2);
            this.panelPersonel.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPersonel.Location = new System.Drawing.Point(0, 0);
            this.panelPersonel.Name = "panelPersonel";
            this.panelPersonel.Size = new System.Drawing.Size(576, 458);
            this.panelPersonel.TabIndex = 1;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::_05170000022.Properties.Resources.password;
            this.pictureBox4.Location = new System.Drawing.Point(142, 319);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::_05170000022.Properties.Resources.presentation;
            this.pictureBox3.Location = new System.Drawing.Point(142, 263);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_05170000022.Properties.Resources.personelgiris;
            this.pictureBox1.Location = new System.Drawing.Point(64, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPersonel
            // 
            this.buttonPersonel.BackColor = System.Drawing.Color.LightGray;
            this.buttonPersonel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPersonel.Location = new System.Drawing.Point(198, 382);
            this.buttonPersonel.Name = "buttonPersonel";
            this.buttonPersonel.Size = new System.Drawing.Size(181, 50);
            this.buttonPersonel.TabIndex = 8;
            this.buttonPersonel.Text = "Giriş Yap";
            this.buttonPersonel.UseVisualStyleBackColor = false;
            this.buttonPersonel.Click += new System.EventHandler(this.buttonPersonel_Click);
            // 
            // textPasswordPersonel
            // 
            this.textPasswordPersonel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textPasswordPersonel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPasswordPersonel.Location = new System.Drawing.Point(198, 329);
            this.textPasswordPersonel.Name = "textPasswordPersonel";
            this.textPasswordPersonel.PasswordChar = '*';
            this.textPasswordPersonel.Size = new System.Drawing.Size(227, 30);
            this.textPasswordPersonel.TabIndex = 7;
            this.textPasswordPersonel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPasswordPersonel_KeyDown);
            // 
            // textPersonel
            // 
            this.textPersonel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textPersonel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPersonel.Location = new System.Drawing.Point(198, 273);
            this.textPersonel.Name = "textPersonel";
            this.textPersonel.Size = new System.Drawing.Size(227, 30);
            this.textPersonel.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kurum Bilgi Sistemi / Personel";
            // 
            // panelYonetici
            // 
            this.panelYonetici.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelYonetici.Controls.Add(this.pictureBox6);
            this.panelYonetici.Controls.Add(this.pictureBox5);
            this.panelYonetici.Controls.Add(this.pictureBox2);
            this.panelYonetici.Controls.Add(this.buttonAdmin);
            this.panelYonetici.Controls.Add(this.textPasswordYonetici);
            this.panelYonetici.Controls.Add(this.textYonetici);
            this.panelYonetici.Controls.Add(this.label1);
            this.panelYonetici.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelYonetici.Location = new System.Drawing.Point(0, 0);
            this.panelYonetici.Name = "panelYonetici";
            this.panelYonetici.Size = new System.Drawing.Size(576, 458);
            this.panelYonetici.TabIndex = 2;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::_05170000022.Properties.Resources.password;
            this.pictureBox6.Location = new System.Drawing.Point(155, 319);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::_05170000022.Properties.Resources.admin;
            this.pictureBox5.Location = new System.Drawing.Point(155, 263);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::_05170000022.Properties.Resources.iam_administrator;
            this.pictureBox2.Location = new System.Drawing.Point(95, 97);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(430, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.BackColor = System.Drawing.Color.LightGray;
            this.buttonAdmin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdmin.Location = new System.Drawing.Point(211, 382);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(181, 50);
            this.buttonAdmin.TabIndex = 9;
            this.buttonAdmin.Text = "Giriş Yap";
            this.buttonAdmin.UseVisualStyleBackColor = false;
            this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
            // 
            // textPasswordYonetici
            // 
            this.textPasswordYonetici.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textPasswordYonetici.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textPasswordYonetici.Location = new System.Drawing.Point(211, 329);
            this.textPasswordYonetici.Name = "textPasswordYonetici";
            this.textPasswordYonetici.PasswordChar = '*';
            this.textPasswordYonetici.Size = new System.Drawing.Size(227, 30);
            this.textPasswordYonetici.TabIndex = 8;
            this.textPasswordYonetici.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textPasswordYonetici_KeyDown);
            // 
            // textYonetici
            // 
            this.textYonetici.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textYonetici.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textYonetici.Location = new System.Drawing.Point(211, 273);
            this.textYonetici.Name = "textYonetici";
            this.textYonetici.Size = new System.Drawing.Size(227, 30);
            this.textYonetici.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(377, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kurum Bilgi Sistemi / Yönetici\r\n";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(576, 501);
            this.Controls.Add(this.panelYonetici);
            this.Controls.Add(this.panelPersonel);
            this.Controls.Add(this.slidePanel);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.slidePanel.ResumeLayout(false);
            this.slidePanel.PerformLayout();
            this.panelPersonel.ResumeLayout(false);
            this.panelPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelYonetici.ResumeLayout(false);
            this.panelYonetici.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel slidePanel;
        private System.Windows.Forms.Panel panelPersonel;
        private System.Windows.Forms.Panel panelYonetici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPersonel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPersonel;
        private System.Windows.Forms.TextBox textPasswordPersonel;
        private System.Windows.Forms.Button buttonAdmin;
        private System.Windows.Forms.TextBox textPasswordYonetici;
        private System.Windows.Forms.TextBox textYonetici;
        private System.Windows.Forms.Label slideLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

