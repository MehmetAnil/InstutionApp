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
using System.Windows.Forms.Integration;

namespace _05170000022
{
    public partial class PersonalForm : Form
    {

        //Veritabanina baglanti icin gerekli siniflardan connection olusturuldu.
        static readonly SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InstitutionDB.mdf;Integrated Security=True;Connect Timeout=30");
        public static string userName;
        public static string isKolu;
        public PersonalForm(string username)
        {
            InitializeComponent();
            userName = username;
        }
        public static string GetUsername()
        {
            return userName;
        }
        public static string GetIsKolu()
        {
            connection.Close(); 
            connection.Open();

            string query = "SELECT iskolu FROM PersonalTable WHERE username = '" + userName + "'";
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    isKolu = reader["iskolu"].ToString();
                    
                }
            }
            connection.Close();
            return isKolu;
        }

        private void PersonalForm_Load(object sender, EventArgs e)
        {
            isKolu = GetIsKolu();
            connection.Open();
            string query = "SELECT personalID,isim,iskolu FROM PersonalTable WHERE username = '"+ userName + "'";
            SqlCommand command = new SqlCommand(query,connection);
            using(SqlDataReader reader = command.ExecuteReader())
            {
                if(reader.Read())
                {
                    labelID.Text = reader["personalID"].ToString()+", "+ reader["iskolu"].ToString()+", "+ reader["isim"].ToString();
                }
            }
            
            query = "SELECT personel_tipi FROM PersonalTable WHERE username = '" + userName + "'";
            command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read() & reader["personel_tipi"].ToString().Equals("Idari Personel"))
                {
                    bilancoToolStripMenuItem.Visible = true;
                    
                }
                else if (reader["personel_tipi"].ToString().Equals("Personel"))
                {
                    bilancoToolStripMenuItem.Visible = false;
                    
                }
            }
            connection.Close();


        }

        private void infoShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIPanel.Controls.Clear();
            PersonalUpdate updateForm = new PersonalUpdate(userName);
            updateForm.MdiParent = this;
            updateForm.FormBorderStyle = FormBorderStyle.None;
            MDIPanel.Controls.Add(updateForm);
            updateForm.Show();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();      //degistirilebilir
        }

        private void bilancoShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //WPF kullanılan Form çağılırıyor.

            SalaryWPF.MainWindow salaryForm = new SalaryWPF.MainWindow(userName);
            ElementHost.EnableModelessKeyboardInterop(salaryForm);
            salaryForm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();
            string date = DateTime.Now.ToShortDateString();
            labelTime.Text = time + ", " + date;

        }

        private void toplantılarıGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {

           ToplantiFormPersonel form = new ToplantiFormPersonel(isKolu,userName);
           form.Show();
            
           
        }

        private void mesajlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isKolu = GetIsKolu();
            connection.Open();
            MDIPanel.Controls.Clear();
            string query = "SELECT personel_tipi FROM PersonalTable WHERE username = '" + userName + "'";
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read() & reader["personel_tipi"].ToString().Equals("Idari Personel"))
                {
                    MessagePatron formPatron = new MessagePatron();
                    formPatron.MdiParent = this;
                    formPatron.FormBorderStyle = FormBorderStyle.None;
                    MDIPanel.Controls.Add(formPatron);
                    formPatron.Show();

                }
                else if (reader["personel_tipi"].ToString().Equals("Personel"))
                {
                    MessagePersonel formPersonel = new MessagePersonel();
                    formPersonel.MdiParent = this;
                    formPersonel.FormBorderStyle = FormBorderStyle.None;
                    MDIPanel.Controls.Add(formPersonel);
                    formPersonel.Show();

                }
            }
            connection.Close();
        }
    }
}
