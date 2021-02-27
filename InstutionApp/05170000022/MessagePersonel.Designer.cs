
namespace _05170000022
{
    partial class MessagePersonel
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
            this.buttonSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(220, 45);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(220, 88);
            // 
            // textSender
            // 
            this.textSender.Location = new System.Drawing.Point(340, 42);
            // 
            // textReceiver
            // 
            this.textReceiver.Location = new System.Drawing.Point(340, 88);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(218, 138);
            // 
            // textBoxMesaj
            // 
            this.textBoxMesaj.Location = new System.Drawing.Point(340, 138);
            this.textBoxMesaj.ReadOnly = true;
            // 
            // buttonOnceki
            // 
            this.buttonOnceki.Location = new System.Drawing.Point(365, 260);
            this.buttonOnceki.Click += new System.EventHandler(this.buttonOnceki_Click);
            // 
            // buttonSonraki
            // 
            this.buttonSonraki.Location = new System.Drawing.Point(465, 260);
            this.buttonSonraki.Click += new System.EventHandler(this.buttonSonraki_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(224, 260);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(85, 32);
            this.buttonSil.TabIndex = 8;
            this.buttonSil.Text = "Mesajı Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // MessagePersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 310);
            this.Controls.Add(this.buttonSil);
            this.Name = "MessagePersonel";
            this.Text = "MessagePersonel";
            this.Load += new System.EventHandler(this.MessagePersonel_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textSender, 0);
            this.Controls.SetChildIndex(this.textReceiver, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.textBoxMesaj, 0);
            this.Controls.SetChildIndex(this.buttonOnceki, 0);
            this.Controls.SetChildIndex(this.buttonSonraki, 0);
            this.Controls.SetChildIndex(this.buttonSil, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSil;
    }
}