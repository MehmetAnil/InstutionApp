using System;
using System.Collections;
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
    public partial class MessagePatron : MessageInheritance.MessageBaseForm
    {
        static readonly SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InstitutionDB.mdf;Integrated Security=True;Connect Timeout=30");
        static int mesajPointer = 0;
        int personalID;
        ArrayList gondericiler;
        ArrayList gondericilerIsim;
        ArrayList mesajlar;
        public MessagePatron()
        {
            InitializeComponent();
        }

        private void MessagePatron_Load(object sender, EventArgs e)
        {
            mesajPointer = 0;
            //Mesaj okuma kısmı için gerekli kodlar
            string isKolu = PersonalForm.GetIsKolu();
            string userName = PersonalForm.GetUsername();
            SqlDataReader reader;
            connection.Open();
            string query = "SELECT personalID FROM PersonalTable WHERE username = '" + userName + "'";
            SqlCommand command = new SqlCommand(query, connection);

            using (reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    textReceiver.Text = reader["personalID"].ToString();
                    personalID = int.Parse(textReceiver.Text);
                }
            }


            query = "SELECT * FROM Mesajlar WHERE Alici = '" + int.Parse(textReceiver.Text) + "'"; //bu yoksa?
            command = new SqlCommand(query, connection);
            SqlDataReader reader1 = command.ExecuteReader();

            if (reader1.Read())
            {
                query = "SELECT Gonderici,Mesaj FROM Mesajlar WHERE Alici = '" + int.Parse(textReceiver.Text) + "'";

                using (command = new SqlCommand(query, connection))
                {
                    gondericiler = new ArrayList();
                    mesajlar = new ArrayList();
                    using (reader = command.ExecuteReader())
                    {
                        if (reader != null)
                        {
                            while (reader.Read())
                            {
                                gondericiler.Add(int.Parse(reader["Gonderici"].ToString()));
                                mesajlar.Add(reader["Mesaj"].ToString());
                            }
                        }
                    }
                }
                gondericilerIsim = new ArrayList();

                for (int i = 0; i < gondericiler.Count; i++) //Idleri isme çevirme kısmı
                {

                    query = "SELECT isim FROM PersonalTable WHERE PersonalID = '" + int.Parse(gondericiler[i].ToString()) + "'";
                    using (command = new SqlCommand(query, connection))
                    {

                        using (reader = command.ExecuteReader())
                        {
                            if (reader != null)
                            {
                                while (reader.Read())
                                {
                                    gondericilerIsim.Add(reader["isim"].ToString());
                                }
                            }
                        }
                    }
                }

                textSender.Text = gondericilerIsim[mesajPointer].ToString();
                textBoxMesaj.Text = mesajlar[mesajPointer].ToString();

                buttonOnceki.Enabled = false;

            }
            else
            {
                MessageBox.Show("Mesaj Bulunamadı.");
                buttonOnceki.Enabled = false;
                buttonSonraki.Enabled = false;
            }
            reader.Close();
            reader1.Close();
            
            query = "SELECT PersonalID,isim FROM PersonalTable ";
            using (SqlCommand command1 = new SqlCommand(query, connection))
            {
                //Yeni mesaj için comboBox kısmında gerekli kodlar
                using (SqlDataReader reader2 = command1.ExecuteReader())
                {
                    if (reader2 != null)
                    {
                        while (reader2.Read())
                        {
                            comboBoxAlici.Items.Add(reader2["PersonalID"].ToString() + "- " + reader2["isim"].ToString());
                        }
                    }
                }
            }
            connection.Close();
        }

        private void buttonOnceki_Click(object sender, EventArgs e)
        {
            if (mesajPointer != 0)
            {
                mesajPointer -= 1;
                textSender.Text = gondericilerIsim[mesajPointer].ToString();
                textBoxMesaj.Text = mesajlar[mesajPointer].ToString();
                buttonSonraki.Enabled = true;

            }
            else
            {

                buttonOnceki.Enabled = false;
            }
        }

        private void buttonSonraki_Click(object sender, EventArgs e)
        {
            if (mesajPointer < gondericiler.Count - 1)
            {
                mesajPointer += 1;
                textSender.Text = gondericilerIsim[mesajPointer].ToString();
                textBoxMesaj.Text = mesajlar[mesajPointer].ToString();
                buttonOnceki.Enabled = true;
            }
            else
            {

                buttonSonraki.Enabled = false;
                
            }
        }

        private void buttonGonder_Click(object sender, EventArgs e)
        {
            int alici =0;
            connection.Open();
            string query = "INSERT INTO [Mesajlar](Gonderici,Alici,Mesaj) VALUES (@gonderici,@alici,@mesaj) ";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);

                if (comboBoxAlici.SelectedItem != null)
                {
                    alici = int.Parse(comboBoxAlici.SelectedItem.ToString().Split('-')[0]);
                }

                command.Parameters.AddWithValue("@gonderici", personalID);
                command.Parameters.AddWithValue("@alici", alici);
                command.Parameters.AddWithValue("@mesaj", textGonderilecek.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Mesaj Gonderildi!");
            } catch
            {
                MessageBox.Show("Mesaj iletiminde sorun olustu.");
            }
            
           
            connection.Close();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query;
            SqlCommand command;
            int senderID = 0;

            query = "SELECT personalID FROM PersonalTable WHERE isim = '"+ textSender.Text + "'";
            command = new SqlCommand(query, connection);
            SqlDataReader reader;

            using(reader = command.ExecuteReader())
            {
                if(reader.Read())
                    senderID = int.Parse(reader["personalID"].ToString());
            }



            query = "DELETE FROM Mesajlar WHERE Gonderici = @gonderici AND Alici = @alici AND Mesaj = @mesaj";
            command = new SqlCommand(query, connection);
            
            try
            {
                command.Parameters.AddWithValue("@gonderici", senderID);
                command.Parameters.AddWithValue("@alici", int.Parse(textReceiver.Text));
                command.Parameters.AddWithValue("@mesaj", textBoxMesaj.Text.Trim());
                command.ExecuteNonQuery();


                MessageBox.Show("Mesaj Silindi, sayfa yenilendiğinde gözükmeyecek.");
            }
            catch
            {
                MessageBox.Show("Bir sorun oluştu.");
            }
            connection.Close();
        }
    }
}
