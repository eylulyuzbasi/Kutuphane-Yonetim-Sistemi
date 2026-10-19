namespace KutuphaneYonetimSistemi
{
    partial class UyeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtAdSoyad = new TextBox();
            label2 = new Label();
            txtTelefon = new TextBox();
            txtEmail = new TextBox();
            label3 = new Label();
            btnUyeEkle = new Button();
            btnUyeGuncelle = new Button();
            btnUyeSil = new Button();
            btnUyeTemizle = new Button();
            dataGridViewUyeler = new DataGridView();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUyeler).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(18, 57);
            label1.Name = "label1";
            label1.Size = new Size(112, 30);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(136, 56);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(150, 31);
            txtAdSoyad.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(18, 109);
            label2.Name = "label2";
            label2.Size = new Size(92, 30);
            label2.TabIndex = 2;
            label2.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(136, 108);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(150, 31);
            txtTelefon.TabIndex = 3;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 162);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(150, 31);
            txtEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(18, 162);
            label3.Name = "label3";
            label3.Size = new Size(80, 30);
            label3.TabIndex = 5;
            label3.Text = "E-mail:";
            // 
            // btnUyeEkle
            // 
            btnUyeEkle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUyeEkle.Location = new Point(13, 226);
            btnUyeEkle.Name = "btnUyeEkle";
            btnUyeEkle.Size = new Size(99, 48);
            btnUyeEkle.TabIndex = 6;
            btnUyeEkle.Text = "Ekle";
            btnUyeEkle.UseVisualStyleBackColor = true;
            btnUyeEkle.Click += btnUyeEkle_Click;
            // 
            // btnUyeGuncelle
            // 
            btnUyeGuncelle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUyeGuncelle.Location = new Point(118, 226);
            btnUyeGuncelle.Name = "btnUyeGuncelle";
            btnUyeGuncelle.Size = new Size(101, 48);
            btnUyeGuncelle.TabIndex = 7;
            btnUyeGuncelle.Text = "Güncelle";
            btnUyeGuncelle.UseVisualStyleBackColor = true;
            btnUyeGuncelle.Click += btnUyeGuncelle_Click;
            // 
            // btnUyeSil
            // 
            btnUyeSil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUyeSil.Location = new Point(225, 226);
            btnUyeSil.Name = "btnUyeSil";
            btnUyeSil.Size = new Size(101, 48);
            btnUyeSil.TabIndex = 8;
            btnUyeSil.Text = "Sil";
            btnUyeSil.UseVisualStyleBackColor = true;
            btnUyeSil.Click += btnUyeSil_Click;
            // 
            // btnUyeTemizle
            // 
            btnUyeTemizle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUyeTemizle.Location = new Point(332, 226);
            btnUyeTemizle.Name = "btnUyeTemizle";
            btnUyeTemizle.Size = new Size(101, 48);
            btnUyeTemizle.TabIndex = 9;
            btnUyeTemizle.Text = "Temizle";
            btnUyeTemizle.UseVisualStyleBackColor = true;
            btnUyeTemizle.Click += btnUyeTemizle_Click;
            // 
            // dataGridViewUyeler
            // 
            dataGridViewUyeler.AllowUserToResizeRows = false;
            dataGridViewUyeler.BackgroundColor = Color.LemonChiffon;
            dataGridViewUyeler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUyeler.Location = new Point(12, 302);
            dataGridViewUyeler.Name = "dataGridViewUyeler";
            dataGridViewUyeler.RowHeadersWidth = 62;
            dataGridViewUyeler.Size = new Size(1200, 356);
            dataGridViewUyeler.TabIndex = 10;
            dataGridViewUyeler.CellContentClick += dataGridViewUyeler_CellContentClick;
            dataGridViewUyeler.MouseDown += dataGridViewUyeler_MouseDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(477, 23);
            label4.Name = "label4";
            label4.Size = new Size(218, 26);
            label4.TabIndex = 11;
            label4.Text = "👤ÜYE YÖNETİMİ";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            button1.Location = new Point(981, 246);
            button1.Name = "button1";
            button1.Size = new Size(231, 41);
            button1.TabIndex = 12;
            button1.Text = "<-Kütüphane Yönetimi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UyeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            ClientSize = new Size(1224, 682);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(dataGridViewUyeler);
            Controls.Add(btnUyeTemizle);
            Controls.Add(btnUyeSil);
            Controls.Add(btnUyeGuncelle);
            Controls.Add(btnUyeEkle);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefon);
            Controls.Add(label2);
            Controls.Add(txtAdSoyad);
            Controls.Add(label1);
            Name = "UyeForm";
            Text = "Üye Ekleme Sayfası";
            Load += UyeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUyeler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAdSoyad;
        private Label label2;
        private TextBox txtTelefon;
        private TextBox txtEmail;
        private Label label3;
        private Button btnUyeEkle;
        private Button btnUyeGuncelle;
        private Button btnUyeSil;
        private Button btnUyeTemizle;
        private DataGridView dataGridViewUyeler;
        private Label label4;
        private Button button1;
    }
}