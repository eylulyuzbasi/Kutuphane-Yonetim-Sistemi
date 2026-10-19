using Microsoft.Data.SqlClient;
using System.Data;
namespace KutuphaneYonetimSistemi
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(
        "Data Source=localhost;Initial Catalog=KutuphaneDB;Integrated" +
            " Security=True;TrustServerCertificate=True"
         );
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.AllowUserToAddRows = false;
            Listele();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Kitaplar", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKitapAdi.Text))
            {
                MessageBox.Show("Kitap adý boþ býrakýlamaz!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtYazar.Text))
            {
                MessageBox.Show("Yazar adý boþ býrakýlamaz!");
                return;
            }

            if (cmbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen kategori seçiniz!");
                return;
            }

            baglanti.Open();

            SqlCommand komut = new SqlCommand(
                "INSERT INTO Kitaplar (KitapAdi, Yazar, Kategori, Stok) VALUES (@kitapAdi, @yazar, @kategori, @stok)",
                baglanti);

            komut.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@kategori", cmbKategori.Text);
            komut.Parameters.AddWithValue("@stok", nudStok.Value);
            komut.ExecuteNonQuery();
            baglanti.Close();
            Listele();

            MessageBox.Show("Kitap baþarýyla eklendi!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow satir = dataGridView1.Rows[e.RowIndex];

            txtKitapAdi.Text = satir.Cells["KitapAdi"].Value?.ToString() ?? "";
            txtYazar.Text = satir.Cells["Yazar"].Value?.ToString() ?? "";
            cmbKategori.Text = satir.Cells["Kategori"].Value?.ToString() ?? "";

            if (satir.Cells["Stok"].Value != null)
            {
                nudStok.Value = Convert.ToDecimal(satir.Cells["Stok"].Value);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek kitabý seçiniz!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtKitapAdi.Text))
            {
                MessageBox.Show("Kitap adý boþ býrakýlamaz!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtYazar.Text))
            {
                MessageBox.Show("Yazar adý boþ býrakýlamaz!");
                return;
            }

            if (cmbKategori.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen kategori seçiniz!");
                return;
            }

            string eskiKitapAdi = dataGridView1.CurrentRow.Cells["KitapAdi"].Value.ToString();
            string eskiYazar = dataGridView1.CurrentRow.Cells["Yazar"].Value.ToString();
            string eskiKategori = dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
            decimal eskiStok = Convert.ToDecimal(
                dataGridView1.CurrentRow.Cells["Stok"].Value);

            if (txtKitapAdi.Text == eskiKitapAdi &&
                txtYazar.Text == eskiYazar &&
                cmbKategori.Text == eskiKategori &&
                nudStok.Value == eskiStok)
            {
                MessageBox.Show("Herhangi bir deðiþiklik yapmadýnýz!");
                return;
            }

            int id = Convert.ToInt32(
                dataGridView1.CurrentRow.Cells["Id"].Value);

            baglanti.Open();

            SqlCommand komut = new SqlCommand(
                "UPDATE Kitaplar SET KitapAdi=@kitapAdi, Yazar=@yazar, Kategori=@kategori, Stok=@stok WHERE Id=@id",
                baglanti);

            komut.Parameters.AddWithValue("@kitapAdi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazar", txtYazar.Text);
            komut.Parameters.AddWithValue("@kategori", cmbKategori.Text);
            komut.Parameters.AddWithValue("@stok", nudStok.Value);
            komut.Parameters.AddWithValue("@id", id);

            komut.ExecuteNonQuery();

            baglanti.Close();

            Listele();

            MessageBox.Show("Kitap baþarýyla güncellendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Silinecek kitap bulunamadý!");
                return;
            }

            
            if (dataGridView1.SelectedRows.Count == 0 ||
                dataGridView1.CurrentCell == null)
            {
                MessageBox.Show("Lütfen silmek istediðiniz kitabý seçiniz!");
                return;
            }

            DataGridViewRow seciliSatir = dataGridView1.SelectedRows[0];

            int id = Convert.ToInt32(seciliSatir.Cells["Id"].Value);

            DialogResult sonuc = MessageBox.Show(
                "Seçilen kitabý silmek istediðinize emin misiniz?",
                "Silme Onayý",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (sonuc != DialogResult.Yes)
            {
                return;
            }

            baglanti.Open();

            SqlCommand kontrolKomut = new SqlCommand(
                "SELECT COUNT(*) FROM OduncIslemleri WHERE KitapId=@id",
                baglanti);

            kontrolKomut.Parameters.AddWithValue("@id", id);

            int oduncSayisi = Convert.ToInt32(
                kontrolKomut.ExecuteScalar());

            if (oduncSayisi > 0)
            {
                baglanti.Close();

                MessageBox.Show(
                    "Bu kitap ödünç iþlemlerinde kullanýldýðý için silinemez!");

                return;
            }

            SqlCommand komut = new SqlCommand(
                "DELETE FROM Kitaplar WHERE Id=@id",
                baglanti);

            komut.Parameters.AddWithValue("@id", id);

            komut.ExecuteNonQuery();

            baglanti.Close();

            Listele();

            txtKitapAdi.Clear();
            txtYazar.Clear();
            cmbKategori.SelectedIndex = -1;
            nudStok.Value = 0;

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            MessageBox.Show("Kitap baþarýyla silindi!");
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtKitapAdi.Clear();
            txtYazar.Clear();
            cmbKategori.SelectedIndex = -1;
            nudStok.Value = 0;

            dataGridView1.ClearSelection();
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            string sorgu = @"
        SELECT * FROM Kitaplar
        WHERE KitapAdi COLLATE Latin1_General_100_CI_AI LIKE @arama
        OR Yazar COLLATE Latin1_General_100_CI_AI LIKE @arama
        OR Kategori COLLATE Latin1_General_100_CI_AI LIKE @arama";

            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);

            da.SelectCommand.Parameters.AddWithValue(
                "@arama", "%" + txtAra.Text.Trim() + "%");

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void btnUyeYonetimi_Click(object sender, EventArgs e)
        {
            UyeForm uyeForm = new UyeForm();
            uyeForm.ShowDialog();
        }

        private void btnOduncIslemleri_Click(object sender, EventArgs e)
        {
            OduncForm oduncForm = new OduncForm();
            oduncForm.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Listele();
        }
    }
}

