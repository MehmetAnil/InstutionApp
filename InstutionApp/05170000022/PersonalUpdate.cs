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
    public partial class PersonalUpdate : Form
    {
        //Veritabanina baglanti icin gerekli siniflardan connection olusturuldu.
        static readonly SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InstitutionDB.mdf;Integrated Security=True;Connect Timeout=30");
        String userName;
        public PersonalUpdate(String username)
        {
            InitializeComponent();
            userName = username;
        }

        private void pictureUpdate_Click(object sender, EventArgs e)
        {
            connection.Open();
            try
            {
                string query = "UPDATE PersonalTable SET username= @username, password= @password, yas= @yas,mail= @mail WHERE username = '" + userName + "'";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@yas", int.Parse(textYas.Text));
                command.Parameters.AddWithValue("@mail", textMail.Text);
                command.Parameters.AddWithValue("@username", textUsername.Text);
                command.Parameters.AddWithValue("@password", textPassword.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Update İşlemi Yapıldı.");
            }
            catch
            {
                MessageBox.Show("Update Sırasında Hata oldu.");
            }
            connection.Close();
        }

        private void PersonalUpdate_Load(object sender, EventArgs e)
        {
            connection.Open();
            string query = "SELECT * FROM PersonalTable WHERE username = '" + userName + "'";
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    textID.Text = reader["personalID"].ToString();
                    textIsim.Text = reader["isim"].ToString();
                    textYas.Text = reader["yas"].ToString();
                    textTip.Text = reader["personel_tipi"].ToString();
                    textMail.Text = reader["mail"].ToString();
                    textMaas.Text = reader["maas"].ToString();
                    textBolum.Text = reader["iskolu"].ToString();

                    textUsername.Text = reader["username"].ToString();
                    textPassword.Text = reader["password"].ToString();
                }

            }
            connection.Close();
        }
    }
}
