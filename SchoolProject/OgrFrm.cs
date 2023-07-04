using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolProject
{
    public partial class OgrFrm : Form
    {
        public OgrFrm()
        {
            InitializeComponent();
        }
        public string numara;
        public string ogrenciad;

        SqlConnection baglanti = new SqlConnection(@"Data Source=OSMAN\SQLEXPRESS;Initial Catalog=BonusOkul;Integrated Security=True");
        private void OgrFrm_Load(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("SELECT DERSAD as 'Ders Adı',SINAV1, SINAV2, SINAV3,PROJE,ORTALAMA,DURUM FROM TBL_Notlar INNER JOIN TBL_Dersler ON TBL_Notlar.DersId = TBL_Dersler.DersId where OgrenciId = @p1", baglanti);
                komut.Parameters.AddWithValue("@p1", numara);
                SqlDataAdapter da = new SqlDataAdapter(komut);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                SqlCommand adKomut = new SqlCommand("SELECT OgrenciAd FROM TBL_Ogrenciler WHERE OgrenciId = @p2", baglanti);
                adKomut.Parameters.AddWithValue("@p2", numara);
                baglanti.Open();
                object adResult = adKomut.ExecuteScalar();
                baglanti.Close();

                if (adResult != null)
                {
                    ogrenciad = adResult.ToString();
                    this.Text = ogrenciad + " - Öğrenci Not Ekranı";
                }
                else
                {
                    MessageBox.Show("Öğrenci bulunamadı","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Lütfen numaranızı giriniz");
            }
        }
    }
}


