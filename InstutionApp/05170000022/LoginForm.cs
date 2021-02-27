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
    public partial class Login : Form
    {
        int panelGenisligi;
        bool hidden;

        //Veritabanina baglanti icin gerekli siniflardan connection olusturuldu.
        static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InstitutionDB.mdf;Integrated Security=True;Connect Timeout=30");
        public Login()
        {
            InitializeComponent();
            panelGenisligi = panelYonetici.Width;
            hidden = false;
        }

        private void slideLabel_Click(object sender, EventArgs e)
        {
            //ekran kaydiktan sonra slideLabel'in yazi icerigi degismeli
            
            if (slideLabel.Text == "personel girişi")  
            {
                slideLabel.Text = "yönetici girişi";

                //kaydirma islemini saglayan timer1'in cagirilmasi
                timer1.Start();                                           
                slidePanel.BackColor = Color.FromArgb(204, 204, 255);
            }
            else if (slideLabel.Text == "yönetici girişi")
            {
                slideLabel.Text = "personel girişi";
                timer1.Start();
                slidePanel.BackColor = Color.FromArgb(179, 209, 255);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer'a gore pencerelerin birbiri uzerine kapanarak saklanmasini timer ile sagliyoruz
            if (hidden)
            {
                panelYonetici.Width += 20;                      
                if (panelYonetici.Width >= panelGenisligi)
                {
                    timer1.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }

            else
            {
                panelYonetici.Width -= 20;                      
                if (panelYonetici.Width <= 0)
                {
                    timer1.Stop();
                    hidden = true;
                    this.Refresh();
                }
            }   

        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            connection.Open();
           
            //Veritabani manipulasyonu icin sorgu
            string query = "SELECT username,password FROM AdminTable Where username = '" + textYonetici.Text.Trim() + "' and password = '" + textPasswordYonetici.Text.Trim() + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);  //query ve connection ortak calistirildi
            DataTable table = new DataTable();
            adapter.Fill(table);

            if(table.Rows.Count == 1) //belirlenen kosullari saglarsa 
            {
                this.Hide();
                AdminForm adminForm = new AdminForm(usernameAdmin);
                adminForm.Closed += (s, args) => this.Close();
                adminForm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }

            connection.Close();
        }
        public string usernameAdmin// on LoginForm to AdminForm
        {
            get { return textYonetici.Text; }
        }
        public string usernamePersonel// on LoginForm to PersonelForm
        {
            get { return textPersonel.Text; }
        }
       

        private void textPasswordYonetici_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    //sifreden sonra enter ile giris
            {
                buttonAdmin_Click(this, new EventArgs());
            }
        }

        private void textPasswordPersonel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    //sifreden sonra enter ile giris
            {
                buttonPersonel_Click(this, new EventArgs());
            }
        }

        private void buttonPersonel_Click(object sender, EventArgs e)
        {
            connection.Open();
            //Veritabani manipulasyonu icin sorgu
            string query = "SELECT username,password FROM PersonalTable Where username = '" + textPersonel.Text.Trim() + "' and password = '" + textPasswordPersonel.Text.Trim() + "'";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);  //query ve connection ortak calistirildi
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1) //belirlenen kosullari saglarsa 
            {
                this.Hide();
                PersonalForm personelForm = new PersonalForm(usernamePersonel);
                personelForm.Closed += (s, args) => this.Close();
                personelForm.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }

            connection.Close();
        }
    }
}
