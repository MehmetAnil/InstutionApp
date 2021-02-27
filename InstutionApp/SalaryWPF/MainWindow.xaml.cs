using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SalaryWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InstitutionDB.mdf;Integrated Security=True;Connect Timeout=30");
        String userName;
        public MainWindow(String username)
        {
            InitializeComponent();
            userName = username;
        }

        private void SalaryWindow_Loaded(object sender, RoutedEventArgs e)
        {
            connection.Open();              //Ayni iskoluna mensup Personeller secildi. Butceye gore maas degistirme kısmı eklendi.
            String iskolu = null;


            String query = "SELECT iskolu FROM PersonalTable WHERE username = '" + userName + "'";
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    iskolu = reader["iskolu"].ToString();
                }
            }
            
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT personalID,isim,iskolu,maas FROM PersonalTable WHERE iskolu = '"+ iskolu + "'", connection);
            DataTable dataTable = new DataTable("PersonalTable");
            adapter.Fill(dataTable);

            gridPersonel.ItemsSource = dataTable.DefaultView;
            
            

            double butce = 0;
            query = "SELECT Butce FROM Bolumler WHERE Bolum_ismi = '" + iskolu + "'"; //Butce tablosundan iskolunun bütcesi çekildi
            command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    butce = Convert.ToDouble(reader["Butce"].ToString());
                    textBoxButce.Text = butce.ToString();
                }
            }
            double toplamMaas = 0;
            query = "SELECT SUM(maas) FROM PersonalTable WHERE iskolu = '" + iskolu + "'"; //Butce tablosundan iskolunun bütcesi çekildi
            

            using (command = new SqlCommand(query, connection))
            {
                toplamMaas = Convert.ToDouble(command.ExecuteScalar().ToString());
                   
            }

            double durum = butce - toplamMaas;
            if(durum < 0)
            {
                DurumLabel.Content = durum.ToString() + " sıkı tutunun batıyoruz.";
                DurumLabel.Foreground = Brushes.Red;
            }
            else
            {
                DurumLabel.Content = "+"+durum.ToString() + " kullanılabilir bütce var.";
                DurumLabel.Foreground = Brushes.Green;
            }


            connection.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            connection.Open();
            SqlCommand command;
            try
            {
                int personalID = int.Parse(textID.Text);
                
                string query = "UPDATE PersonalTable SET maas = @maas WHERE personalID = '" +personalID + "'";
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@maas", Decimal.Parse(textYeniMaas.Text));
                command.ExecuteNonQuery();

                MessageBox.Show("Maaş bilgisi başarıyla değiştirildi.");
            }
            catch
            {
                MessageBox.Show("Lütfen girdiğiniz verileri kontrol edin.");
            }
            connection.Close();
            this.SalaryWindow_Loaded(sender,e);
        } 
       

        private bool isNumber (string text)
        {
            int textControl;
            return int.TryParse(text,out textControl);

           
        }

        private void textID_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (isNumber(e.Text) == false && e.Text != ",")
            {
                e.Handled = true;
            }

        }

        private void textYeniMaas_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (isNumber(e.Text) == false && e.Text != ",")
            {
                e.Handled = true;
            }
        }

       
    }
}
