using KutuphaneYonetimSistemi;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KutuphaneYonetimSistemi
{
    public partial class UyeForm : Form
    {
        SqlConnection baglanti = new SqlConnection(
    "Data Source=localhost;Initial Catalog=KutuphaneDB;Integrated Security=True;TrustServerCertificate=True"
);
        public UyeForm()
        {
            InitializeComponent();
        }
        void UyeleriListele()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Uyeler", baglanti);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridViewUyeler.DataSource = dt;
        }

        private void UyeForm_Load(object sender, EventArgs e)
        {
            dataGridViewUyeler.AllowUserToAddRows = false;
            dataGridViewUyeler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUyeler.MultiSelect = false;

            UyeleriListele();

            dataGridViewUyeler.ClearSelection();
            dataGridViewUyeler.CurrentCell = null;
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                MessageBox.Show("Ad soyad boş bırakılamaz!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Telefon boş bırakılamaz!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("E-posta boş bırakılamaz!");
                return;
            }

            baglanti.Open();

            SqlCommand komut = new SqlCommand(
                "INSERT INTO Uyeler (AdSoyad, Telefon, Email) VALUES (@adSoyad, @telefon, @email)",
                baglanti);

            komut.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            UyeleriListele();
            MessageBox.Show("Üye başarıyla eklendi!");




        }

        private void dataGridViewUyeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow satir = dataGridViewUyeler.Rows[e.RowIndex];

            txtAdSoyad.Text = satir.Cells["AdSoyad"].Value?.ToString() ?? "";
            txtTelefon.Text = satir.Cells["Telefon"].Value?.ToString() ?? "";
            txtEmail.Text = satir.Cells["Email"].Value?.ToString() ?? "";
        }

        private void btnUyeGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridViewUyeler.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellenecek üyeyi seçiniz!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAdSoyad.Text))
            {
                MessageBox.Show("Ad soyad boş bırakılamaz!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                MessageBox.Show("Telefon boş bırakılamaz!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("E-posta boş bırakılamaz!");
                return;
            }


            string eskiAdSoyad =
                dataGridViewUyeler.CurrentRow.Cells["AdSoyad"].Value?.ToString() ?? "";

            string eskiTelefon =
                dataGridViewUyeler.CurrentRow.Cells["Telefon"].Value?.ToString() ?? "";

            string eskiEmail =
                dataGridViewUyeler.CurrentRow.Cells["Email"].Value?.ToString() ?? "";


            if (txtAdSoyad.Text == eskiAdSoyad &&
                txtTelefon.Text == eskiTelefon &&
                txtEmail.Text == eskiEmail)
            {
                MessageBox.Show("Herhangi bir değişiklik yapmadınız!");
                return;
            }

            int id = Convert.ToInt32(
                dataGridViewUyeler.CurrentRow.Cells["Id"].Value);

            baglanti.Open();

            SqlCommand komut = new SqlCommand(
                @"UPDATE Uyeler
          SET AdSoyad=@adSoyad,
              Telefon=@telefon,
              Email=@email
          WHERE Id=@id",
                baglanti);

            komut.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@id", id);

            komut.ExecuteNonQuery();

            baglanti.Close();

            UyeleriListele();

            MessageBox.Show("Üye başarıyla güncellendi!");
        }

        private void btnUyeSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewUyeler.Rows.Count == 0)
            {
                MessageBox.Show("Silinecek üye bulunamadı!");
                return;
            }

            if (dataGridViewUyeler.CurrentCell == null ||
                dataGridViewUyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz üyeyi seçiniz!");
                return;
            }

            DataGridViewRow seciliSatir = dataGridViewUyeler.SelectedRows[0];

            int id = Convert.ToInt32(seciliSatir.Cells["Id"].Value);

            DialogResult sonuc = MessageBox.Show(
                "Seçilen üyeyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (sonuc != DialogResult.Yes)
            {
                return;
            }

            baglanti.Open();

            SqlCommand komut = new SqlCommand(
                "DELETE FROM Uyeler WHERE Id=@id",
                baglanti);

            komut.Parameters.AddWithValue("@id", id);

            int silinenKayit = komut.ExecuteNonQuery();

            baglanti.Close();

            if (silinenKayit > 0)
            {
                UyeleriListele();

                txtAdSoyad.Clear();
                txtTelefon.Clear();
                txtEmail.Clear();

                dataGridViewUyeler.ClearSelection();
                dataGridViewUyeler.CurrentCell = null;

                MessageBox.Show("Üye başarıyla silindi!");
            }
        }

        private void dataGridViewUyeler_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dataGridViewUyeler.HitTest(e.X, e.Y);

            if (hit.RowIndex == -1)
            {
                dataGridViewUyeler.ClearSelection();
                dataGridViewUyeler.CurrentCell = null;
            }
        }

        private void btnUyeTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();

            dataGridViewUyeler.ClearSelection();
            dataGridViewUyeler.CurrentCell = null;

            txtAdSoyad.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();

        }
    }
}

