namespace KutuphaneYonetimSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtKitapAdi = new TextBox();
            txtYazar = new TextBox();
            cmbKategori = new ComboBox();
            nudStok = new NumericUpDown();
            btnEkle = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnTemizle = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            txtAra = new TextBox();
            btnUyeYonetimi = new Button();
            btnOduncIslemleri = new Button();
            ((System.ComponentModel.ISupportInitialize)nudStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(27, 61);
            label1.Name = "label1";
            label1.Size = new Size(109, 30);
            label1.TabIndex = 0;
            label1.Text = "Kitap Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(27, 113);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 1;
            label2.Text = "Yazar:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(27, 163);
            label3.Name = "label3";
            label3.Size = new Size(102, 30);
            label3.TabIndex = 2;
            label3.Text = "Kategori:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(27, 214);
            label4.Name = "label4";
            label4.Size = new Size(63, 30);
            label4.TabIndex = 3;
            label4.Text = "Stok:";
            // 
            // txtKitapAdi
            // 
            txtKitapAdi.Location = new Point(142, 62);
            txtKitapAdi.Name = "txtKitapAdi";
            txtKitapAdi.Size = new Size(150, 31);
            txtKitapAdi.TabIndex = 4;
            // 
            // txtYazar
            // 
            txtYazar.Location = new Point(142, 114);
            txtYazar.Name = "txtYazar";
            txtYazar.Size = new Size(150, 31);
            txtYazar.TabIndex = 5;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Items.AddRange(new object[] { "Roman", "Bilim", "Tarih", "Çocuk", "Edebiyat", "Diğer" });
            cmbKategori.Location = new Point(142, 164);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(150, 33);
            cmbKategori.TabIndex = 6;
            // 
            // nudStok
            // 
            nudStok.Location = new Point(142, 214);
            nudStok.Name = "nudStok";
            nudStok.Size = new Size(150, 31);
            nudStok.TabIndex = 7;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnEkle.Location = new Point(27, 273);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(115, 48);
            btnEkle.TabIndex = 8;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnGuncelle.Location = new Point(148, 272);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(115, 48);
            btnGuncelle.TabIndex = 9;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnSil.Location = new Point(269, 273);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(115, 47);
            btnSil.TabIndex = 10;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnTemizle.Location = new Point(390, 272);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(115, 48);
            btnTemizle.TabIndex = 11;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.BackgroundColor = Color.LightPink;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(22, 342);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1147, 326);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(367, 9);
            label5.Name = "label5";
            label5.Size = new Size(411, 28);
            label5.TabIndex = 13;
            label5.Text = "📚 KÜTÜPHANE YÖNETİM SİSTEMİ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(405, 61);
            label6.Name = "label6";
            label6.Size = new Size(109, 30);
            label6.TabIndex = 14;
            label6.Text = "Kitap Ara:";
            // 
            // txtAra
            // 
            txtAra.Location = new Point(520, 62);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(150, 31);
            txtAra.TabIndex = 15;
            txtAra.TextChanged += txtAra_TextChanged;
            // 
            // btnUyeYonetimi
            // 
            btnUyeYonetimi.BackColor = Color.White;
            btnUyeYonetimi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUyeYonetimi.Location = new Point(972, 200);
            btnUyeYonetimi.Name = "btnUyeYonetimi";
            btnUyeYonetimi.Size = new Size(197, 55);
            btnUyeYonetimi.TabIndex = 16;
            btnUyeYonetimi.Text = "Üye Yönetimi->";
            btnUyeYonetimi.UseVisualStyleBackColor = false;
            btnUyeYonetimi.Click += btnUyeYonetimi_Click;
            // 
            // btnOduncIslemleri
            // 
            btnOduncIslemleri.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnOduncIslemleri.Location = new Point(972, 265);
            btnOduncIslemleri.Name = "btnOduncIslemleri";
            btnOduncIslemleri.Size = new Size(197, 55);
            btnOduncIslemleri.TabIndex = 17;
            btnOduncIslemleri.Text = "Ödünç İşlemleri->";
            btnOduncIslemleri.UseVisualStyleBackColor = true;
            btnOduncIslemleri.Click += btnOduncIslemleri_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            ClientSize = new Size(1197, 680);
            Controls.Add(btnOduncIslemleri);
            Controls.Add(btnUyeYonetimi);
            Controls.Add(txtAra);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(btnTemizle);
            Controls.Add(btnSil);
            Controls.Add(btnGuncelle);
            Controls.Add(btnEkle);
            Controls.Add(nudStok);
            Controls.Add(cmbKategori);
            Controls.Add(txtYazar);
            Controls.Add(txtKitapAdi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Kütüphane Yönetim Sistemi";
            Activated += Form1_Activated;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtKitapAdi;
        private TextBox txtYazar;
        private ComboBox cmbKategori;
        private NumericUpDown nudStok;
        private Button btnEkle;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnTemizle;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private TextBox txtAra;
        private Button btnUyeYonetimi;
        private Button btnOduncIslemleri;
    }
}
