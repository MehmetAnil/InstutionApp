
namespace _05170000022
{
    partial class PersonalRemoveForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.leaveButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxSil = new System.Windows.Forms.PictureBox();
            this.textBoxIDelete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.leaveButton);
            this.panel1.Controls.Add(this.pictureBoxSil);
            this.panel1.Controls.Add(this.textBoxIDelete);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1149, 397);
            this.panel1.TabIndex = 0;
            // 
            // leaveButton
            // 
            this.leaveButton.Image = global::_05170000022.Properties.Resources.exit;
            this.leaveButton.Location = new System.Drawing.Point(1032, 293);
            this.leaveButton.Name = "leaveButton";
            this.leaveButton.Size = new System.Drawing.Size(66, 69);
            this.leaveButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leaveButton.TabIndex = 26;
            this.leaveButton.TabStop = false;
            this.leaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // pictureBoxSil
            // 
            this.pictureBoxSil.Image = global::_05170000022.Properties.Resources.remove_user;
            this.pictureBoxSil.Location = new System.Drawing.Point(512, 293);
            this.pictureBoxSil.Name = "pictureBoxSil";
            this.pictureBoxSil.Size = new System.Drawing.Size(66, 69);
            this.pictureBoxSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSil.TabIndex = 25;
            this.pictureBoxSil.TabStop = false;
            this.pictureBoxSil.Click += new System.EventHandler(this.pictureBoxSil_Click);
            // 
            // textBoxIDelete
            // 
            this.textBoxIDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxIDelete.Location = new System.Drawing.Point(381, 318);
            this.textBoxIDelete.Name = "textBoxIDelete";
            this.textBoxIDelete.Size = new System.Drawing.Size(104, 22);
            this.textBoxIDelete.TabIndex = 2;
            this.textBoxIDelete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDelete_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silmek istediğiniz personel ID\'sini giriniz: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1149, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // PersonalRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 397);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "PersonalRemoveForm";
            this.Text = "Personel Silme";
            this.Load += new System.EventHandler(this.PersonalRemoveForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leaveButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxIDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox leaveButton;
        private System.Windows.Forms.PictureBox pictureBoxSil;
    }
}