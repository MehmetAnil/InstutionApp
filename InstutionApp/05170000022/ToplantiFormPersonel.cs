using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05170000022
{
    public partial class ToplantiFormPersonel : Form
    {
        static string isKolu;
        static string userName;
        static readonly SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|InstitutionDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void TabloDoldur(DataGridView dataGrid, int seminer, int zorunlu)
        {
            //verilerin radio butonlara gore dagitilmasi icin olusturulmus metod, datagrid'i doldurur.
            connection.Open();
            SqlDataAdapter adapter;
            DataSet dataSet;
            string zorunluStr = "Zorunlu";
            string seminerStr = "Seminer";
            if (seminer == 0 && zorunlu == 0)
            {
                adapter = new SqlDataAdapter("SELECT * FROM Toplantilar WHERE bolum = '" + isKolu + "'", connection);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "Toplantilar");

                dataGrid.DataSource = dataSet;
                dataGrid.DataMember = "Toplantilar";
                connection.Close();
            }
            else if (seminer == 1 && zorunlu == 0)
            {
                adapter = new SqlDataAdapter("SELECT * FROM Toplantilar WHERE kosul =  '" + seminerStr + "' AND bolum = '" + isKolu + "'", connection);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "Toplantilar");

                dataGrid.DataSource = dataSet;
                dataGrid.DataMember = "Toplantilar";
                connection.Close();
            }
            else if (seminer == 0 && zorunlu == 1)
            {
                adapter = new SqlDataAdapter("SELECT * FROM Toplantilar WHERE kosul = '" + zorunluStr + "' AND bolum = '" + isKolu + "'", connection);
                dataSet = new DataSet();
                adapter.Fill(dataSet, "Toplantilar");

                dataGrid.DataSource = dataSet;
                dataGrid.DataMember = "Toplantilar";
                connection.Close();
            }
            else
            {
                MessageBox.Show("Veritabanına Ulaşılamadı.");
            }
            dataGridView1.AutoResizeColumns();

        }
        private void KaydetCSV(DataGridView DGV)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Output.csv";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Yükleme İşlemi Başarısız Oldu." + ex.Message);
                    }
                }
                int sutunSay = DGV.ColumnCount; //sutun ve satir sayilarini aliyoruz, dongu olusturabilmek icin
                string sutunIsim = "";
                string[] output = new string[DGV.RowCount + 1];
                for (int i = 0; i < sutunSay; i++)
                {
                    sutunIsim += DGV.Columns[i].Name.ToString() + ",";
                }
                output[0] += sutunIsim; //CSV dosyasina sutun isimlerini de aliyoruz.
                for (int i = 1; (i - 1) < DGV.RowCount; i++)
                {
                    for (int j = 0; j < sutunSay; j++)
                    {
                        //Tablodaki NULL degerleri atlamak icin,
                        if (DGV.Rows[i - 1].Cells[j].Value != null)
                            output[i] += DGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                    }
                }
                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Dosyanız Kaydedilmiştir.");
            }
        }
        
        public ToplantiFormPersonel(string iskolu,string username)
        {
            InitializeComponent();
            isKolu = iskolu;
            userName = username;
        }
        


        private void ToplantiFormPersonel_Load(object sender, EventArgs e)
        {
            this.TabloDoldur(dataGridView1, 0, 0);
            connection.Open();
            string query = "SELECT personel_tipi FROM PersonalTable WHERE username = '" + userName + "'";
            SqlCommand command = new SqlCommand(query, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read() & reader["personel_tipi"].ToString().Equals("Idari Personel"))
                {
                    olusturButon.Visible = true;

                }
                else if (reader["personel_tipi"].ToString().Equals("Personel"))
                {

                    olusturButon.Visible = false;
                }
                connection.Close();
            }
        }

        private void zorunluCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.TabloDoldur(dataGridView1, 0, 1);
        }

        private void seminerCheck_CheckedChanged(object sender, EventArgs e)
        {
            this.TabloDoldur(dataGridView1, 1, 0);
        }

        private void tabloyuKaydetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KaydetCSV(dataGridView1);
        }

        private void olusturButon_Click(object sender, EventArgs e)
        {
            ToplantiOlusturForm toplantiForm = new ToplantiOlusturForm(isKolu);
            toplantiForm.Show();
        }

        private void radioTumu_CheckedChanged(object sender, EventArgs e)
        {
            this.TabloDoldur(dataGridView1, 0, 0);
        }
    }
}

