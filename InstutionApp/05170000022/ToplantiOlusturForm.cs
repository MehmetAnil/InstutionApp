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
    public partial class ToplantiOlusturForm : Form
    {
        string isKolu;
        static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InstitutionDB.mdf;Integrated Security=True;Connect Timeout=30");
        public ToplantiOlusturForm(string iskolu)
        {
            InitializeComponent();
            isKolu = iskolu;
        }

        private void ToplantiOlusturForm_Load(object sender, EventArgs e)
        {
            textBolum.Text = isKolu;
        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "INSERT INTO [Toplantilar] (toplantiID,bolum,konu,tarih,kosul) VALUES (@toplantiID,@bolum,@konu,@tarih,@kosul)";
            string kosul;

            if (comboKosul.SelectedItem != null)
            {
                kosul = comboKosul.SelectedItem.ToString();
                try
                {
                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@toplantiID", int.Parse(textID.Text));
                        command.Parameters.AddWithValue("@bolum", isKolu);
                        command.Parameters.AddWithValue("@konu", textKonu.Text);
                        command.Parameters.AddWithValue("@tarih", SqlDbType.Date).Value = dateTimePicker1.Value.Date;
                        command.Parameters.AddWithValue("@kosul", kosul);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Toplantınız Oluşturuldu.");

                    }
                }
                catch
                {
                    MessageBox.Show("Lütfen tutarlı veriler girdiğinizden emin olun.");
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Toplantı Koşulunu Seçiniz.");
                connection.Close();
            }

        }

        
    }
}
