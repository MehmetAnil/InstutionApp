
namespace MessageInheritance
{
    partial class MessageBaseForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textSender = new System.Windows.Forms.TextBox();
            this.textReceiver = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMesaj = new System.Windows.Forms.TextBox();
            this.buttonOnceki = new System.Windows.Forms.Button();
            this.buttonSonraki = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(208, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gönderici:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(208, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alıcı:";
            // 
            // textSender
            // 
            this.textSender.Location = new System.Drawing.Point(328, 33);
            this.textSender.Name = "textSender";
            this.textSender.ReadOnly = true;
            this.textSender.Size = new System.Drawing.Size(223, 22);
            this.textSender.TabIndex = 2;
            // 
            // textReceiver
            // 
            this.textReceiver.Location = new System.Drawing.Point(328, 79);
            this.textReceiver.Name = "textReceiver";
            this.textReceiver.ReadOnly = true;
            this.textReceiver.Size = new System.Drawing.Size(223, 22);
            this.textReceiver.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(206, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mesaj:";
            // 
            // textBoxMesaj
            // 
            this.textBoxMesaj.Location = new System.Drawing.Point(328, 129);
            this.textBoxMesaj.Multiline = true;
            this.textBoxMesaj.Name = "textBoxMesaj";
            this.textBoxMesaj.Size = new System.Drawing.Size(235, 100);
            this.textBoxMesaj.TabIndex = 5;
            // 
            // buttonOnceki
            // 
            this.buttonOnceki.Location = new System.Drawing.Point(353, 251);
            this.buttonOnceki.Name = "buttonOnceki";
            this.buttonOnceki.Size = new System.Drawing.Size(82, 32);
            this.buttonOnceki.TabIndex = 6;
            this.buttonOnceki.Text = "Önceki";
            this.buttonOnceki.UseVisualStyleBackColor = true;
            // 
            // buttonSonraki
            // 
            this.buttonSonraki.Location = new System.Drawing.Point(453, 251);
            this.buttonSonraki.Name = "buttonSonraki";
            this.buttonSonraki.Size = new System.Drawing.Size(80, 32);
            this.buttonSonraki.TabIndex = 7;
            this.buttonSonraki.Text = "Sonraki";
            this.buttonSonraki.UseVisualStyleBackColor = true;
            // 
            // MessageBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 310);
            this.Controls.Add(this.buttonSonraki);
            this.Controls.Add(this.buttonOnceki);
            this.Controls.Add(this.textBoxMesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textReceiver);
            this.Controls.Add(this.textSender);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MessageBaseForm";
            this.Text = "Message Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.TextBox textSender;
        protected System.Windows.Forms.TextBox textReceiver;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.TextBox textBoxMesaj;
        protected System.Windows.Forms.Button buttonOnceki;
        protected System.Windows.Forms.Button buttonSonraki;
    }
}

