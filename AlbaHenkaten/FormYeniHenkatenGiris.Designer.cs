namespace AlbaHenkaten
{
    partial class FormYeniHenkatenGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYeniHenkatenGiris));
            this.dgHenkaten = new System.Windows.Forms.DataGridView();
            this.txProses = new System.Windows.Forms.TextBox();
            this.txHatMakine = new System.Windows.Forms.TextBox();
            this.txProje = new System.Windows.Forms.TextBox();
            this.txUrunParca = new System.Windows.Forms.TextBox();
            this.txDegisimKategorisi = new System.Windows.Forms.TextBox();
            this.txDurum = new System.Windows.Forms.TextBox();
            this.lblProses = new System.Windows.Forms.Label();
            this.lblHatMakine = new System.Windows.Forms.Label();
            this.lblProje = new System.Windows.Forms.Label();
            this.lblUrunParca = new System.Windows.Forms.Label();
            this.lblDegisimKategorisi = new System.Windows.Forms.Label();
            this.lblOncelik = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.cbOncelik = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.checkBoxOtoRefresh = new System.Windows.Forms.CheckBox();
            this.trackBarRefresh = new System.Windows.Forms.TrackBar();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgHenkaten)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgHenkaten
            // 
            this.dgHenkaten.AllowUserToAddRows = false;
            this.dgHenkaten.AllowUserToDeleteRows = false;
            this.dgHenkaten.AllowUserToOrderColumns = true;
            this.dgHenkaten.AllowUserToResizeRows = false;
            this.dgHenkaten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgHenkaten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHenkaten.Location = new System.Drawing.Point(12, 141);
            this.dgHenkaten.Name = "dgHenkaten";
            this.dgHenkaten.ReadOnly = true;
            this.dgHenkaten.RowTemplate.Height = 24;
            this.dgHenkaten.Size = new System.Drawing.Size(1172, 313);
            this.dgHenkaten.TabIndex = 0;
            this.dgHenkaten.Sorted += new System.EventHandler(this.dgHenkaten_Sorted);
            // 
            // txProses
            // 
            this.txProses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txProses.Location = new System.Drawing.Point(3, 23);
            this.txProses.MaxLength = 150;
            this.txProses.Name = "txProses";
            this.txProses.Size = new System.Drawing.Size(149, 22);
            this.txProses.TabIndex = 1;
            // 
            // txHatMakine
            // 
            this.txHatMakine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txHatMakine.Location = new System.Drawing.Point(158, 23);
            this.txHatMakine.MaxLength = 150;
            this.txHatMakine.Name = "txHatMakine";
            this.txHatMakine.Size = new System.Drawing.Size(150, 22);
            this.txHatMakine.TabIndex = 2;
            // 
            // txProje
            // 
            this.txProje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txProje.Location = new System.Drawing.Point(314, 23);
            this.txProje.MaxLength = 150;
            this.txProje.Name = "txProje";
            this.txProje.Size = new System.Drawing.Size(150, 22);
            this.txProje.TabIndex = 3;
            // 
            // txUrunParca
            // 
            this.txUrunParca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txUrunParca.Location = new System.Drawing.Point(470, 23);
            this.txUrunParca.MaxLength = 150;
            this.txUrunParca.Name = "txUrunParca";
            this.txUrunParca.Size = new System.Drawing.Size(150, 22);
            this.txUrunParca.TabIndex = 4;
            // 
            // txDegisimKategorisi
            // 
            this.txDegisimKategorisi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txDegisimKategorisi.Location = new System.Drawing.Point(626, 23);
            this.txDegisimKategorisi.MaxLength = 150;
            this.txDegisimKategorisi.Name = "txDegisimKategorisi";
            this.txDegisimKategorisi.Size = new System.Drawing.Size(150, 22);
            this.txDegisimKategorisi.TabIndex = 5;
            // 
            // txDurum
            // 
            this.txDurum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txDurum.Location = new System.Drawing.Point(782, 23);
            this.txDurum.MaxLength = 50;
            this.txDurum.Name = "txDurum";
            this.txDurum.Size = new System.Drawing.Size(149, 22);
            this.txDurum.TabIndex = 8;
            // 
            // lblProses
            // 
            this.lblProses.AutoSize = true;
            this.lblProses.Location = new System.Drawing.Point(3, 0);
            this.lblProses.Name = "lblProses";
            this.lblProses.Size = new System.Drawing.Size(52, 17);
            this.lblProses.TabIndex = 2;
            this.lblProses.Text = "Proses";
            // 
            // lblHatMakine
            // 
            this.lblHatMakine.AutoSize = true;
            this.lblHatMakine.Location = new System.Drawing.Point(158, 0);
            this.lblHatMakine.Name = "lblHatMakine";
            this.lblHatMakine.Size = new System.Drawing.Size(87, 17);
            this.lblHatMakine.TabIndex = 2;
            this.lblHatMakine.Text = "Hat / Makine";
            // 
            // lblProje
            // 
            this.lblProje.AutoSize = true;
            this.lblProje.Location = new System.Drawing.Point(314, 0);
            this.lblProje.Name = "lblProje";
            this.lblProje.Size = new System.Drawing.Size(41, 17);
            this.lblProje.TabIndex = 2;
            this.lblProje.Text = "Proje";
            // 
            // lblUrunParca
            // 
            this.lblUrunParca.AutoSize = true;
            this.lblUrunParca.Location = new System.Drawing.Point(470, 0);
            this.lblUrunParca.Name = "lblUrunParca";
            this.lblUrunParca.Size = new System.Drawing.Size(88, 17);
            this.lblUrunParca.TabIndex = 2;
            this.lblUrunParca.Text = "Ürün / Parça";
            // 
            // lblDegisimKategorisi
            // 
            this.lblDegisimKategorisi.AutoSize = true;
            this.lblDegisimKategorisi.Location = new System.Drawing.Point(626, 0);
            this.lblDegisimKategorisi.Name = "lblDegisimKategorisi";
            this.lblDegisimKategorisi.Size = new System.Drawing.Size(125, 17);
            this.lblDegisimKategorisi.TabIndex = 2;
            this.lblDegisimKategorisi.Text = "Değişim Kategorisi";
            // 
            // lblOncelik
            // 
            this.lblOncelik.AutoSize = true;
            this.lblOncelik.Location = new System.Drawing.Point(937, 0);
            this.lblOncelik.Name = "lblOncelik";
            this.lblOncelik.Size = new System.Drawing.Size(55, 17);
            this.lblOncelik.TabIndex = 2;
            this.lblOncelik.Text = "Öncelik";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(782, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(50, 17);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "Durum";
            // 
            // cbOncelik
            // 
            this.cbOncelik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbOncelik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOncelik.FormattingEnabled = true;
            this.cbOncelik.Location = new System.Drawing.Point(937, 23);
            this.cbOncelik.Name = "cbOncelik";
            this.cbOncelik.Size = new System.Drawing.Size(69, 24);
            this.cbOncelik.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lblProses, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblProje, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbOncelik, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblOncelik, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUrunParca, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txDegisimKategorisi, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDegisimKategorisi, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txUrunParca, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txProje, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHatMakine, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txHatMakine, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txProses, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnKaydet, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDurum, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txDurum, 5, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 77);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(1012, 23);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(99, 24);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(12, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1172, 40);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "YENİ HENKATEN GİRİŞ SAYFASI";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(1120, 26);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 23);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // checkBoxOtoRefresh
            // 
            this.checkBoxOtoRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOtoRefresh.AutoSize = true;
            this.checkBoxOtoRefresh.Checked = true;
            this.checkBoxOtoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOtoRefresh.Location = new System.Drawing.Point(860, 26);
            this.checkBoxOtoRefresh.Name = "checkBoxOtoRefresh";
            this.checkBoxOtoRefresh.Size = new System.Drawing.Size(141, 21);
            this.checkBoxOtoRefresh.TabIndex = 8;
            this.checkBoxOtoRefresh.Text = "Otomatik yenile ()";
            this.checkBoxOtoRefresh.UseVisualStyleBackColor = true;
            this.checkBoxOtoRefresh.CheckedChanged += new System.EventHandler(this.checkBoxOtoRefresh_CheckedChanged);
            // 
            // trackBarRefresh
            // 
            this.trackBarRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRefresh.Location = new System.Drawing.Point(1007, 22);
            this.trackBarRefresh.Minimum = 1;
            this.trackBarRefresh.Name = "trackBarRefresh";
            this.trackBarRefresh.Size = new System.Drawing.Size(104, 56);
            this.trackBarRefresh.TabIndex = 9;
            this.trackBarRefresh.Value = 5;
            this.trackBarRefresh.Scroll += new System.EventHandler(this.trackBarRefresh_Scroll);
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 5000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // FormYeniHenkatenGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 466);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.checkBoxOtoRefresh);
            this.Controls.Add(this.trackBarRefresh);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgHenkaten);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "FormYeniHenkatenGiris";
            this.Text = "Yeni Henkaten Giriş Sayfası";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormYeniHenkatenGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHenkaten)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgHenkaten;
        private System.Windows.Forms.TextBox txProses;
        private System.Windows.Forms.TextBox txHatMakine;
        private System.Windows.Forms.TextBox txProje;
        private System.Windows.Forms.TextBox txUrunParca;
        private System.Windows.Forms.TextBox txDegisimKategorisi;
        private System.Windows.Forms.TextBox txDurum;
        private System.Windows.Forms.Label lblProses;
        private System.Windows.Forms.Label lblHatMakine;
        private System.Windows.Forms.Label lblProje;
        private System.Windows.Forms.Label lblUrunParca;
        private System.Windows.Forms.Label lblDegisimKategorisi;
        private System.Windows.Forms.Label lblOncelik;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.ComboBox cbOncelik;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.CheckBox checkBoxOtoRefresh;
        private System.Windows.Forms.TrackBar trackBarRefresh;
        private System.Windows.Forms.Timer timerRefresh;
    }
}

