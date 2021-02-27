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
    public partial class AdminForm : Form
    {
        static readonly SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InstitutionDB.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminForm(string userName)
        {
            InitializeComponent();
            userNameLabel.Text= "Hosgeldiniz, "+ userName;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //DateTime sinifindan gun ve saat'in getirilmesi
           
            string time = DateTime.Now.ToLongTimeString();
            string date = DateTime.Now.ToShortDateString();
            timeLabel.Text = time + ", " + date; 
            
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();      //degistirilebilir
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Sistem Yoneticilerinin calisan eklemesi icin gereken kisim
            PersonalAddForm prsAdd = new PersonalAddForm();
            prsAdd.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            PersonalRemoveForm prsRemove = new PersonalRemoveForm();
            prsRemove.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            connection.Open();


            connection.Close();
        }

        
    }
}
