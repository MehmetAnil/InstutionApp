using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05170000022
{
    public partial class PersonalAddForm : Form
    {
        static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InstitutionDB.mdf;Integrated Security=True;Connect Timeout=30");
        public PersonalAddForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void pictureEkle_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO [PersonalTable](personalID,username,password,isim,yas,personel_tipi,iskolu,maas,gorev,mail) VALUES (@ID, @uname,@psword, @name,@yas, @type, @iskolu,@maas,@gorev,@mail)";
            string personelTipi;

            if(comboBoxSecim.SelectedItem != null)
            {
                personelTipi = comboBoxSecim.SelectedItem.ToString();
            }
            else
            {
                personelTipi = "Bilinmiyor";
            }
            try
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = query;

                    command.Parameters.AddWithValue("@ID", int.Parse(textID.Text));
                    command.Parameters.AddWithValue("@uname", textUsername.Text);
                    command.Parameters.AddWithValue("@psword", textPassword.Text);
                    command.Parameters.AddWithValue("@name", textIsim.Text);
                    command.Parameters.AddWithValue("@yas", textYas.Text);
                    command.Parameters.AddWithValue("@iskolu", textIs.Text);
                    command.Parameters.AddWithValue("@maas", textMaas.Text);
                    command.Parameters.AddWithValue("@type", personelTipi);
                    command.Parameters.AddWithValue("@gorev", "Atanmadı");
                    command.Parameters.AddWithValue("@mail", textBoxMail.Text);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                MessageBox.Show(textUsername.Text + " Başarıyla Eklendi!");
            }
            catch
            {
                MessageBox.Show("Kullanıcı ekleme işlemi sırasında Hata oldu. Lütfen yeniden deneyin.");
            }
            connection.Close();
        }
        private void textIsim_KeyPress(object sender, KeyPressEventArgs e) //sadece alfabetik değer girmek için
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || char.IsWhiteSpace(e.KeyChar));
        }

        
    }
}

