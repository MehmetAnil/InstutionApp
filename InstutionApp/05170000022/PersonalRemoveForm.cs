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
    public partial class PersonalRemoveForm : Form
    {
        static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InstitutionDB.mdf;Integrated Security=True;Connect Timeout=30");
        public PersonalRemoveForm()
        {
            InitializeComponent();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PersonalRemoveForm_Load(object sender, EventArgs e)
        {
            connection.Open();

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PersonalTable",connection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "PersonalTable");

            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "PersonalTable";
            connection.Close();
        }

        private void textBoxIDelete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void pictureBoxSil_Click(object sender, EventArgs e)
        {
            if (!(textBoxIDelete.Text == String.Empty))
            {
                string query = "DELETE FROM PersonalTable WHERE personalID= '" + textBoxIDelete.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;
                

                try //eger öyle bir ID yoksa da silindi yazısı çıkıyor.
                {
                    connection.Open();
                    reader = command.ExecuteReader();
                    MessageBox.Show(textBoxIDelete.Text + " ID'li Personel veritabanından Silinmiştir.");
                    while (reader.Read()) { }
                    reader.Close();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PersonalTable", connection);
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet, "PersonalTable");

                    dataGridView1.DataSource = dataSet;
                    dataGridView1.DataMember = "PersonalTable";
                    connection.Close();
                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                    connection.Close();
                }
                
            }
            else
            {
                MessageBox.Show("Silinmesini istediğiniz Personel ID'sini giriniz.");
                connection.Close();
            }
        }
    }
}
