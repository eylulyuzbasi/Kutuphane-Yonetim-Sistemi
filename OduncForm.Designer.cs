namespace KutuphaneYonetimSistemi
{
    partial class OduncForm
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
            cmbUye = new ComboBox();
            label2 = new Label();
            cmbKitap = new ComboBox();
            label3 = new Label();
            dtpOduncTarihi = new DateTimePicker();
            label4 = new Label();
            dtpIadeTarihi = new DateTimePicker();
            btnOduncVer = new Button();
            btnIadeAl = new Button();
            dataGridViewOdunc = new DataGridView();
            label5 = new Label();
            btnKutuphane = new Button();
            btnUyeYonetimi = new Button();
            btnOduncSil = new Button();
            btnTemizle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOdunc).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(20, 50);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 0;
            label1.Text = "Üye:";
            // 
            // cmbUye
            // 
            cmbUye.FormattingEnabled = true;
            cmbUye.Location = new Point(190, 47);
            cmbUye.Name = "cmbUye";
            cmbUye.Size = new Size(182, 33);
            cmbUye.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(20, 104);
            label2.Name = "label2";
            label2.Size = new Size(70, 30);
            label2.TabIndex = 2;
            label2.Text = "Kitap:";
            // 
            // cmbKitap
            // 
            cmbKitap.FormattingEnabled = true;
            cmbKitap.Location = new Point(190, 101);
            cmbKitap.Name = "cmbKitap";
            cmbKitap.Size = new Size(182, 33);
            cmbKitap.TabIndex = 3;
            cmbKitap.SelectedIndexChanged += cmbKitap_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(20, 157);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 4;
            label3.Text = "Ödünç Tarihi:";
            // 
            // dtpOduncTarihi
            // 
            dtpOduncTarihi.Location = new Point(190, 154);
            dtpOduncTarihi.Name = "dtpOduncTarihi";
            dtpOduncTarihi.Size = new Size(300, 31);
            dtpOduncTarihi.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(20, 210);
            label4.Name = "label4";
            label4.Size = new Size(164, 30);
            label4.TabIndex = 6;
            label4.Text = "Son İade Tarihi:";
            // 
            // dtpIadeTarihi
            // 
            dtpIadeTarihi.Location = new Point(190, 210);
            dtpIadeTarihi.Name = "dtpIadeTarihi";
            dtpIadeTarihi.Size = new Size(300, 31);
            dtpIadeTarihi.TabIndex = 7;
            // 
            // btnOduncVer
            // 
            btnOduncVer.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnOduncVer.Location = new Point(130, 270);
            btnOduncVer.Name = "btnOduncVer";
            btnOduncVer.Size = new Size(127, 55);
            btnOduncVer.TabIndex = 8;
            btnOduncVer.Text = "Ödünç Ver";
            btnOduncVer.UseVisualStyleBackColor = true;
            btnOduncVer.Click += btnOduncVer_Click;
            // 
            // btnIadeAl
            // 
            btnIadeAl.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnIadeAl.Location = new Point(283, 270);
            btnIadeAl.Name = "btnIadeAl";
            btnIadeAl.Size = new Size(127, 55);
            btnIadeAl.TabIndex = 9;
            btnIadeAl.Text = "İade Al";
            btnIadeAl.UseVisualStyleBackColor = true;
            btnIadeAl.Click += btnIadeAl_Click;
            // 
            // dataGridViewOdunc
            // 
            dataGridViewOdunc.AllowUserToAddRows = false;
            dataGridViewOdunc.BackgroundColor = Color.MediumAquamarine;
            dataGridViewOdunc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOdunc.Location = new Point(22, 357);
            dataGridViewOdunc.Name = "dataGridViewOdunc";
            dataGridViewOdunc.RowHeadersWidth = 62;
            dataGridViewOdunc.Size = new Size(1155, 304);
            dataGridViewOdunc.TabIndex = 10;
            dataGridViewOdunc.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label5.Location = new Point(470, 9);
            label5.Name = "label5";
            label5.Size = new Size(232, 28);
            label5.TabIndex = 11;
            label5.Text = "ÖDÜNÇ İŞLEMLERİ";
            // 
            // btnKutuphane
            // 
            btnKutuphane.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnKutuphane.Location = new Point(938, 260);
            btnKutuphane.Name = "btnKutuphane";
            btnKutuphane.Size = new Size(239, 41);
            btnKutuphane.TabIndex = 12;
            btnKutuphane.Text = "<-Kütüphane Yönetimi";
            btnKutuphane.UseVisualStyleBackColor = true;
            btnKutuphane.Click += button1_Click;
            // 
            // btnUyeYonetimi
            // 
            btnUyeYonetimi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnUyeYonetimi.Location = new Point(938, 307);
            btnUyeYonetimi.Name = "btnUyeYonetimi";
            btnUyeYonetimi.Size = new Size(239, 41);
            btnUyeYonetimi.TabIndex = 13;
            btnUyeYonetimi.Text = "<-Üye Yönetimi";
            btnUyeYonetimi.UseVisualStyleBackColor = true;
            btnUyeYonetimi.Click += btnUyeYonetimi_Click;
            // 
            // btnOduncSil
            // 
            btnOduncSil.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnOduncSil.Location = new Point(435, 270);
            btnOduncSil.Name = "btnOduncSil";
            btnOduncSil.Size = new Size(225, 55);
            btnOduncSil.TabIndex = 14;
            btnOduncSil.Text = "Ödünç Kaydını Sil";
            btnOduncSil.UseVisualStyleBackColor = true;
            btnOduncSil.Click += btnOduncSil_Click;
            // 
            // btnTemizle
            // 
            btnTemizle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            btnTemizle.Location = new Point(702, 270);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(136, 55);
            btnTemizle.TabIndex = 15;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // OduncForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGreen;
            ClientSize = new Size(1209, 673);
            Controls.Add(btnTemizle);
            Controls.Add(btnOduncSil);
            Controls.Add(btnUyeYonetimi);
            Controls.Add(btnKutuphane);
            Controls.Add(label5);
            Controls.Add(dataGridViewOdunc);
            Controls.Add(btnIadeAl);
            Controls.Add(btnOduncVer);
            Controls.Add(dtpIadeTarihi);
            Controls.Add(label4);
            Controls.Add(dtpOduncTarihi);
            Controls.Add(label3);
            Controls.Add(cmbKitap);
            Controls.Add(label2);
            Controls.Add(cmbUye);
            Controls.Add(label1);
            Name = "OduncForm";
            Text = "OduncForm";
            Load += OduncForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOdunc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbUye;
        private Label label2;
        private ComboBox cmbKitap;
        private Label label3;
        private DateTimePicker dtpOduncTarihi;
        private Label label4;
        private DateTimePicker dtpIadeTarihi;
        private Button btnOduncVer;
        private Button btnIadeAl;
        private DataGridView dataGridViewOdunc;
        private Label label5;
        private Button btnKutuphane;
        private Button btnUyeYonetimi;
        private Button btnOduncSil;
        private Button btnTemizle;
    }
}