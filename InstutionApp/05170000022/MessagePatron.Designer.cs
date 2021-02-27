
namespace _05170000022
{
    partial class MessagePatron
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxAlici = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textGonderilecek = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonGonder = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 41);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(26, 84);
            // 
            // textSender
            // 
            this.textSender.Location = new System.Drawing.Point(146, 38);
            // 
            // textReceiver
            // 
            this.textReceiver.Location = new System.Drawing.Point(146, 84);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(24, 134);
            // 
            // textBoxMesaj
            // 
            this.textBoxMesaj.Location = new System.Drawing.Point(146, 134);
            this.textBoxMesaj.ReadOnly = true;
            // 
            // buttonOnceki
            // 
            this.buttonOnceki.Location = new System.Drawing.Point(171, 256);
            this.buttonOnceki.Click += new System.EventHandler(this.buttonOnceki_Click);
            // 
            // buttonSonraki
            // 
            this.buttonSonraki.Location = new System.Drawing.Point(271, 256);
            this.buttonSonraki.Click += new System.EventHandler(this.buttonSonraki_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(444, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alıcı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(126, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 28);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yeni Mesaj";
            // 
            // comboBoxAlici
            // 
            this.comboBoxAlici.FormattingEnabled = true;
            this.comboBoxAlici.Location = new System.Drawing.Point(541, 96);
            this.comboBoxAlici.Name = "comboBoxAlici";
            this.comboBoxAlici.Size = new System.Drawing.Size(129, 24);
            this.comboBoxAlici.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mesaj:";
            // 
            // textGonderilecek
            // 
            this.textGonderilecek.Location = new System.Drawing.Point(131, 96);
            this.textGonderilecek.Multiline = true;
            this.textGonderilecek.Name = "textGonderilecek";
            this.textGonderilecek.Size = new System.Drawing.Size(216, 100);
            this.textGonderilecek.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textGonderilecek);
            this.groupBox1.Controls.Add(this.buttonGonder);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(410, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 260);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // buttonGonder
            // 
            this.buttonGonder.Location = new System.Drawing.Point(267, 215);
            this.buttonGonder.Name = "buttonGonder";
            this.buttonGonder.Size = new System.Drawing.Size(80, 32);
            this.buttonGonder.TabIndex = 10;
            this.buttonGonder.Text = "Gönder";
            this.buttonGonder.UseVisualStyleBackColor = true;
            this.buttonGonder.Click += new System.EventHandler(this.buttonGonder_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(30, 253);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(85, 32);
            this.buttonSil.TabIndex = 14;
            this.buttonSil.Text = "Mesajı Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // MessagePatron
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 310);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.comboBoxAlici);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Name = "MessagePatron";
            this.Text = "MessagePatron";
            this.Load += new System.EventHandler(this.MessagePatron_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textSender, 0);
            this.Controls.SetChildIndex(this.textReceiver, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxMesaj, 0);
            this.Controls.SetChildIndex(this.buttonOnceki, 0);
            this.Controls.SetChildIndex(this.buttonSonraki, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.comboBoxAlici, 0);
            this.Controls.SetChildIndex(this.buttonSil, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxAlici;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textGonderilecek;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGonder;
        private System.Windows.Forms.Button buttonSil;
    }
}