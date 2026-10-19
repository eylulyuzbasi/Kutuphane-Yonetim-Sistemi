using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace KutuphaneYonetimSistemi
{
    public partial class OduncForm : Form
    {
        SqlConnection baglanti = new SqlConnection(
    "Data Source=localhost;Initial Catalog=KutuphaneDB;Integrated Security=True;TrustServerCertificate=True"
);
        void UyeleriGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Id, AdSoyad FROM Uyeler", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbUye.DataSource = dt;
            cmbUye.DisplayMember = "AdSoyad";
            cmbUye.ValueMember = "Id";

            cmbUye.SelectedIndex = -1;
        }
        void KitaplariGetir()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Id, KitapAdi FROM Kitaplar WHERE Stok > 0", baglanti);

            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbKitap.DataSource = dt;
            cmbKitap.DisplayMember = "KitapAdi";
            cmbKitap.ValueMember = "Id";

            cmbKitap.SelectedIndex = -1;
        }
        public OduncForm()
        {
            InitializeComponent();
        }

        private void cmbKitap_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OduncForm_Load(object sender, EventArgs e)
        {
            UyeleriGetir();
            KitaplariGetir();

            dtpOduncTarihi.Value = DateTime.Today;
            dtpIadeTarihi.Value = DateTime.Today.AddDays(14);

            OduncIslemleriniListele();

            dataGridViewOdunc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOdunc.MultiSelect = false;
            dataGridViewOdunc.AllowUserToAddRows = false;

            dataGridViewOdunc.ClearSelection();
            dataGridViewOdunc.CurrentCell = null;
        }

        void OduncIslemleriniListele()
        {
            string sorgu = @"
        SELECT 
            O.Id,
            U.AdSoyad AS Uye,
            K.KitapAdi AS Kitap,
            O.OduncTarihi,
            O.SonIadeTarihi,
            O.Durum
        FROM OduncIslemleri O
        INNER JOIN Uyeler U ON O.UyeId = U.Id
        INNER JOIN Kitaplar K ON O.KitapId = K.Id";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridViewOdunc.DataSource = dt;
        }
        private void btnOduncVer_Click(object sender, EventArgs e)
        {
            if (cmbUye.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir üye seçiniz!");
                return;
            }

            if (cmbKitap.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir kitap seçiniz!");
                return;
            }

            if (dtpIadeTarihi.Value.Date <= dtpOduncTarihi.Value.Date)
            {
                MessageBox.Show("Son iade tarihi ödünç tarihinden sonra olmalıdır!");
                return;
            }

            int uyeId = Convert.ToInt32(cmbUye.SelectedValue);
            int kitapId = Convert.ToInt32(cmbKitap.SelectedValue);

            baglanti.Open();

            SqlCommand komut = new SqlCommand(
                @"INSERT INTO OduncIslemleri
        (UyeId, KitapId, OduncTarihi, SonIadeTarihi, Durum)
        VALUES
        (@uyeId, @kitapId, @oduncTarihi, @sonIadeTarihi, @durum)",
                baglanti);

            komut.Parameters.AddWithValue("@uyeId", uyeId);
            komut.Parameters.AddWithValue("@kitapId", kitapId);
            komut.Parameters.AddWithValue("@oduncTarihi", dtpOduncTarihi.Value.Date);
            komut.Parameters.AddWithValue("@sonIadeTarihi", dtpIadeTarihi.Value.Date);
            komut.Parameters.AddWithValue("@durum", "Ödünçte");

            komut.ExecuteNonQuery();

            SqlCommand stokKomut = new SqlCommand(
                @"UPDATE Kitaplar
          SET Stok = Stok - 1
          WHERE Id = @kitapId AND Stok > 0",
                baglanti);

            stokKomut.Parameters.AddWithValue("@kitapId", kitapId);

            int etkilenenSatir = stokKomut.ExecuteNonQuery();

            baglanti.Close();

            if (etkilenenSatir > 0)
            {
                KitaplariGetir();

                OduncIslemleriniListele();

                MessageBox.Show("Kitap başarıyla ödünç verildi!");
            }
            else
            {
                MessageBox.Show("Kitabın stoğu azaltılamadı!");
            }
        }

        private void btnIadeAl_Click(object sender, EventArgs e)
        {

            if (dataGridViewOdunc.Rows.Count == 0)
            {
                MessageBox.Show("İade alınacak kitap bulunamadı!");
                return;
            }

            if (dataGridViewOdunc.SelectedRows.Count == 0 ||
                dataGridViewOdunc.CurrentCell == null)
            {
                MessageBox.Show("Lütfen iade alınacak kitabı seçiniz!");
                return;
            }

            DataGridViewRow seciliSatir = dataGridViewOdunc.SelectedRows[0];

            string durum = seciliSatir.Cells["Durum"].Value?.ToString() ?? "";

            if (durum == "İade Edildi")
            {
                MessageBox.Show("Bu kitap zaten iade edilmiş!");
                return;
            }

            int oduncId = Convert.ToInt32(
                seciliSatir.Cells["Id"].Value);

            DialogResult sonuc = MessageBox.Show(
                "Seçilen kitabı iade almak istediğinize emin misiniz?",
                "İade Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (sonuc != DialogResult.Yes)
            {
                return;
            }

            baglanti.Open();

            SqlCommand kitapBulKomut = new SqlCommand(
                "SELECT KitapId FROM OduncIslemleri WHERE Id=@id",
                baglanti);

            kitapBulKomut.Parameters.AddWithValue("@id", oduncId);

            object kitapIdSonuc = kitapBulKomut.ExecuteScalar();

            if (kitapIdSonuc == null)
            {
                baglanti.Close();
                MessageBox.Show("Kitap bilgisi bulunamadı!");
                return;
            }

            int kitapId = Convert.ToInt32(kitapIdSonuc);

            SqlCommand iadeKomut = new SqlCommand(
                @"UPDATE OduncIslemleri
          SET Durum = 'İade Edildi'
          WHERE Id = @id",
                baglanti);

            iadeKomut.Parameters.AddWithValue("@id", oduncId);
            iadeKomut.ExecuteNonQuery();

            SqlCommand stokKomut = new SqlCommand(
                @"UPDATE Kitaplar
          SET Stok = Stok + 1
          WHERE Id = @kitapId",
                baglanti);

            stokKomut.Parameters.AddWithValue("@kitapId", kitapId);
            stokKomut.ExecuteNonQuery();

            baglanti.Close();

            OduncIslemleriniListele();
            KitaplariGetir();

            dataGridViewOdunc.ClearSelection();
            dataGridViewOdunc.CurrentCell = null;

            MessageBox.Show("Kitap başarıyla iade alındı!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUyeYonetimi_Click(object sender, EventArgs e)
        {
            UyeForm uyeForm = new UyeForm();

            this.Hide();

            uyeForm.ShowDialog();

            this.Show();
        }

        private void btnOduncSil_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewOdunc.Rows.Count == 0)
            {
                MessageBox.Show("Silinecek ödünç kaydı bulunamadı!");
                return;
            }

            if (dataGridViewOdunc.SelectedRows.Count == 0 ||
                dataGridViewOdunc.CurrentCell == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz ödünç kaydını seçiniz!");
                return;
            }

            DataGridViewRow seciliSatir = dataGridViewOdunc.SelectedRows[0];

            int oduncId = Convert.ToInt32(
                seciliSatir.Cells["Id"].Value);

            string durum =
                seciliSatir.Cells["Durum"].Value?.ToString() ?? "";

            DialogResult sonuc = MessageBox.Show(
                "Seçilen ödünç kaydını silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (sonuc != DialogResult.Yes)
            {
                return;
            }

            baglanti.Open();

            SqlTransaction transaction = baglanti.BeginTransaction();

            try
            {
                if (durum == "Ödünçte")
                {
                    SqlCommand kitapBul = new SqlCommand(
                        "SELECT KitapId FROM OduncIslemleri WHERE Id=@id",
                        baglanti,
                        transaction);

                    kitapBul.Parameters.AddWithValue("@id", oduncId);

                    object sonucKitap = kitapBul.ExecuteScalar();

                    if (sonucKitap != null)
                    {
                        int kitapId = Convert.ToInt32(sonucKitap);

                        SqlCommand stokKomut = new SqlCommand(
                            "UPDATE Kitaplar SET Stok = Stok + 1 WHERE Id=@kitapId",
                            baglanti,
                            transaction);

                        stokKomut.Parameters.AddWithValue("@kitapId", kitapId);
                        stokKomut.ExecuteNonQuery();
                    }
                }

                SqlCommand silKomut = new SqlCommand(
                    "DELETE FROM OduncIslemleri WHERE Id=@id",
                    baglanti,
                    transaction);

                silKomut.Parameters.AddWithValue("@id", oduncId);

                silKomut.ExecuteNonQuery();

                transaction.Commit();

                baglanti.Close();

                OduncIslemleriniListele();
                KitaplariGetir();

                dataGridViewOdunc.ClearSelection();
                dataGridViewOdunc.CurrentCell = null;

                MessageBox.Show("Ödünç kaydı başarıyla silindi!");
            }
            catch (Exception)
            {
                transaction.Rollback();
                baglanti.Close();

                MessageBox.Show("Ödünç kaydı silinirken bir hata oluştu!");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            
            cmbUye.SelectedIndex = -1;
            cmbKitap.SelectedIndex = -1;

            dtpOduncTarihi.Value = DateTime.Today;
            dtpIadeTarihi.Value = DateTime.Today.AddDays(14);

            dataGridViewOdunc.ClearSelection();
            dataGridViewOdunc.CurrentCell = null;
        }
    }
}
