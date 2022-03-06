namespace AlbaHenkaten
{
    partial class FormKalite
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKalite));
            this.lblBaslik = new System.Windows.Forms.Label();
            this.dgHenkatenAcik = new System.Windows.Forms.DataGridView();
            this.tabHenkaten = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlEdit = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDegisimKategorisi = new System.Windows.Forms.Label();
            this.lblProses = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblProje = new System.Windows.Forms.Label();
            this.lblUrunParca = new System.Windows.Forms.Label();
            this.lblHatMakine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOncelik = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txProses = new System.Windows.Forms.TextBox();
            this.txHatMakine = new System.Windows.Forms.TextBox();
            this.txProje = new System.Windows.Forms.TextBox();
            this.txUrunParca = new System.Windows.Forms.TextBox();
            this.txDegisimKategorisi = new System.Windows.Forms.TextBox();
            this.txAciklama = new System.Windows.Forms.TextBox();
            this.txAksiyonTedbir = new System.Windows.Forms.TextBox();
            this.txOncelik = new System.Windows.Forms.TextBox();
            this.txBaslangicTarihi = new System.Windows.Forms.TextBox();
            this.txDurum = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgHenkatenKapali = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnListeleKapali = new System.Windows.Forms.Button();
            this.cbKullanici = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBaslangic2 = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.checkBoxOtoRefresh = new System.Windows.Forms.CheckBox();
            this.trackBarRefresh = new System.Windows.Forms.TrackBar();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgHenkatenAcik)).BeginInit();
            this.tabHenkaten.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgHenkatenKapali)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(12, 11);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1513, 40);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "HENKATEN LİSTESİ";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgHenkatenAcik
            // 
            this.dgHenkatenAcik.AllowUserToAddRows = false;
            this.dgHenkatenAcik.AllowUserToDeleteRows = false;
            this.dgHenkatenAcik.AllowUserToOrderColumns = true;
            this.dgHenkatenAcik.AllowUserToResizeRows = false;
            this.dgHenkatenAcik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHenkatenAcik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHenkatenAcik.Location = new System.Drawing.Point(3, 70);
            this.dgHenkatenAcik.MultiSelect = false;
            this.dgHenkatenAcik.Name = "dgHenkatenAcik";
            this.dgHenkatenAcik.ReadOnly = true;
            this.dgHenkatenAcik.RowTemplate.Height = 24;
            this.dgHenkatenAcik.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHenkatenAcik.Size = new System.Drawing.Size(1483, 432);
            this.dgHenkatenAcik.TabIndex = 3;
            this.dgHenkatenAcik.Sorted += new System.EventHandler(this.dgHenkatenAcik_Sorted);
            this.dgHenkatenAcik.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgHenkatenAcik_MouseDoubleClick);
            // 
            // tabHenkaten
            // 
            this.tabHenkaten.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabHenkaten.Controls.Add(this.tabPage1);
            this.tabHenkaten.Controls.Add(this.tabPage2);
            this.tabHenkaten.Location = new System.Drawing.Point(15, 54);
            this.tabHenkaten.Name = "tabHenkaten";
            this.tabHenkaten.SelectedIndex = 0;
            this.tabHenkaten.Size = new System.Drawing.Size(1510, 546);
            this.tabHenkaten.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1502, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Açık Kayıtlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pnlEdit, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgHenkatenAcik, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1489, 505);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEdit.ColumnCount = 12;
            this.pnlEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.4999F));
            this.pnlEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49991F));
            this.pnlEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49991F));
            this.pnlEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49991F));
            this.pnlEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.49991F));
            this.pnlEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.4999F));
            this.pnlEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50052F));
            this.pnlEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.pnlEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.pnlEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50006F));
            this.pnlEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.pnlEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.pnlEdit.Controls.Add(this.label3, 8, 0);
            this.pnlEdit.Controls.Add(this.lblDegisimKategorisi, 4, 0);
            this.pnlEdit.Controls.Add(this.lblProses, 0, 0);
            this.pnlEdit.Controls.Add(this.lblDurum, 9, 0);
            this.pnlEdit.Controls.Add(this.lblProje, 2, 0);
            this.pnlEdit.Controls.Add(this.lblUrunParca, 3, 0);
            this.pnlEdit.Controls.Add(this.lblHatMakine, 1, 0);
            this.pnlEdit.Controls.Add(this.label1, 5, 0);
            this.pnlEdit.Controls.Add(this.label2, 6, 0);
            this.pnlEdit.Controls.Add(this.lblOncelik, 7, 0);
            this.pnlEdit.Controls.Add(this.btnSave, 10, 1);
            this.pnlEdit.Controls.Add(this.txProses, 0, 1);
            this.pnlEdit.Controls.Add(this.txHatMakine, 1, 1);
            this.pnlEdit.Controls.Add(this.txProje, 2, 1);
            this.pnlEdit.Controls.Add(this.txUrunParca, 3, 1);
            this.pnlEdit.Controls.Add(this.txDegisimKategorisi, 4, 1);
            this.pnlEdit.Controls.Add(this.txAciklama, 5, 1);
            this.pnlEdit.Controls.Add(this.txAksiyonTedbir, 6, 1);
            this.pnlEdit.Controls.Add(this.txOncelik, 7, 1);
            this.pnlEdit.Controls.Add(this.txBaslangicTarihi, 8, 1);
            this.pnlEdit.Controls.Add(this.txDurum, 9, 1);
            this.pnlEdit.Controls.Add(this.btnCancel, 11, 1);
            this.pnlEdit.Location = new System.Drawing.Point(3, 3);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.RowCount = 2;
            this.pnlEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlEdit.Size = new System.Drawing.Size(1483, 58);
            this.pnlEdit.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1017, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Başlangıç Tarihi";
            // 
            // lblDegisimKategorisi
            // 
            this.lblDegisimKategorisi.AutoSize = true;
            this.lblDegisimKategorisi.Location = new System.Drawing.Point(539, 0);
            this.lblDegisimKategorisi.Name = "lblDegisimKategorisi";
            this.lblDegisimKategorisi.Size = new System.Drawing.Size(125, 17);
            this.lblDegisimKategorisi.TabIndex = 2;
            this.lblDegisimKategorisi.Text = "Değişim Kategorisi";
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
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(1142, 0);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(50, 17);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "Durum";
            // 
            // lblProje
            // 
            this.lblProje.AutoSize = true;
            this.lblProje.Location = new System.Drawing.Point(271, 0);
            this.lblProje.Name = "lblProje";
            this.lblProje.Size = new System.Drawing.Size(41, 17);
            this.lblProje.TabIndex = 2;
            this.lblProje.Text = "Proje";
            // 
            // lblUrunParca
            // 
            this.lblUrunParca.AutoSize = true;
            this.lblUrunParca.Location = new System.Drawing.Point(405, 0);
            this.lblUrunParca.Name = "lblUrunParca";
            this.lblUrunParca.Size = new System.Drawing.Size(88, 17);
            this.lblUrunParca.TabIndex = 2;
            this.lblUrunParca.Text = "Ürün / Parça";
            // 
            // lblHatMakine
            // 
            this.lblHatMakine.AutoSize = true;
            this.lblHatMakine.Location = new System.Drawing.Point(137, 0);
            this.lblHatMakine.Name = "lblHatMakine";
            this.lblHatMakine.Size = new System.Drawing.Size(87, 17);
            this.lblHatMakine.TabIndex = 2;
            this.lblHatMakine.Text = "Hat / Makine";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Açıklama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(807, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Aksiyon / Tedbir";
            // 
            // lblOncelik
            // 
            this.lblOncelik.AutoSize = true;
            this.lblOncelik.Location = new System.Drawing.Point(942, 0);
            this.lblOncelik.Name = "lblOncelik";
            this.lblOncelik.Size = new System.Drawing.Size(55, 17);
            this.lblOncelik.TabIndex = 2;
            this.lblOncelik.Text = "Öncelik";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1277, 23);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 24);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Tamamla";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txProses
            // 
            this.txProses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txProses.Enabled = false;
            this.txProses.Location = new System.Drawing.Point(3, 23);
            this.txProses.Name = "txProses";
            this.txProses.Size = new System.Drawing.Size(128, 22);
            this.txProses.TabIndex = 12;
            // 
            // txHatMakine
            // 
            this.txHatMakine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txHatMakine.Enabled = false;
            this.txHatMakine.Location = new System.Drawing.Point(137, 23);
            this.txHatMakine.Name = "txHatMakine";
            this.txHatMakine.Size = new System.Drawing.Size(128, 22);
            this.txHatMakine.TabIndex = 12;
            // 
            // txProje
            // 
            this.txProje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txProje.Enabled = false;
            this.txProje.Location = new System.Drawing.Point(271, 23);
            this.txProje.Name = "txProje";
            this.txProje.Size = new System.Drawing.Size(128, 22);
            this.txProje.TabIndex = 12;
            // 
            // txUrunParca
            // 
            this.txUrunParca.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txUrunParca.Enabled = false;
            this.txUrunParca.Location = new System.Drawing.Point(405, 23);
            this.txUrunParca.Name = "txUrunParca";
            this.txUrunParca.Size = new System.Drawing.Size(128, 22);
            this.txUrunParca.TabIndex = 12;
            // 
            // txDegisimKategorisi
            // 
            this.txDegisimKategorisi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txDegisimKategorisi.Enabled = false;
            this.txDegisimKategorisi.Location = new System.Drawing.Point(539, 23);
            this.txDegisimKategorisi.Name = "txDegisimKategorisi";
            this.txDegisimKategorisi.Size = new System.Drawing.Size(128, 22);
            this.txDegisimKategorisi.TabIndex = 12;
            // 
            // txAciklama
            // 
            this.txAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txAciklama.Location = new System.Drawing.Point(673, 23);
            this.txAciklama.MaxLength = 250;
            this.txAciklama.Name = "txAciklama";
            this.txAciklama.Size = new System.Drawing.Size(128, 22);
            this.txAciklama.TabIndex = 12;
            // 
            // txAksiyonTedbir
            // 
            this.txAksiyonTedbir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txAksiyonTedbir.Location = new System.Drawing.Point(807, 23);
            this.txAksiyonTedbir.MaxLength = 150;
            this.txAksiyonTedbir.Name = "txAksiyonTedbir";
            this.txAksiyonTedbir.Size = new System.Drawing.Size(129, 22);
            this.txAksiyonTedbir.TabIndex = 12;
            // 
            // txOncelik
            // 
            this.txOncelik.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txOncelik.Enabled = false;
            this.txOncelik.Location = new System.Drawing.Point(942, 23);
            this.txOncelik.Name = "txOncelik";
            this.txOncelik.Size = new System.Drawing.Size(69, 22);
            this.txOncelik.TabIndex = 12;
            // 
            // txBaslangicTarihi
            // 
            this.txBaslangicTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txBaslangicTarihi.Enabled = false;
            this.txBaslangicTarihi.Location = new System.Drawing.Point(1017, 23);
            this.txBaslangicTarihi.Name = "txBaslangicTarihi";
            this.txBaslangicTarihi.Size = new System.Drawing.Size(119, 22);
            this.txBaslangicTarihi.TabIndex = 12;
            // 
            // txDurum
            // 
            this.txDurum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txDurum.Enabled = false;
            this.txDurum.Location = new System.Drawing.Point(1142, 23);
            this.txDurum.Name = "txDurum";
            this.txDurum.Size = new System.Drawing.Size(129, 22);
            this.txDurum.TabIndex = 12;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1377, 23);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1502, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Kapalı Kayıtlar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgHenkatenKapali, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1490, 505);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // dgHenkatenKapali
            // 
            this.dgHenkatenKapali.AllowUserToAddRows = false;
            this.dgHenkatenKapali.AllowUserToDeleteRows = false;
            this.dgHenkatenKapali.AllowUserToOrderColumns = true;
            this.dgHenkatenKapali.AllowUserToResizeRows = false;
            this.dgHenkatenKapali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgHenkatenKapali.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgHenkatenKapali.Location = new System.Drawing.Point(3, 78);
            this.dgHenkatenKapali.MultiSelect = false;
            this.dgHenkatenKapali.Name = "dgHenkatenKapali";
            this.dgHenkatenKapali.ReadOnly = true;
            this.dgHenkatenKapali.RowTemplate.Height = 24;
            this.dgHenkatenKapali.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgHenkatenKapali.Size = new System.Drawing.Size(1484, 424);
            this.dgHenkatenKapali.TabIndex = 4;
            this.dgHenkatenKapali.Sorted += new System.EventHandler(this.dgHenkatenKapali_Sorted);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReport);
            this.panel1.Controls.Add(this.btnListeleKapali);
            this.panel1.Controls.Add(this.cbKullanici);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpBaslangic2);
            this.panel1.Controls.Add(this.dtpBaslangic1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 69);
            this.panel1.TabIndex = 5;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(737, 21);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(100, 23);
            this.btnReport.TabIndex = 6;
            this.btnReport.Text = "Rapor Bas";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnListeleKapali
            // 
            this.btnListeleKapali.Location = new System.Drawing.Point(631, 21);
            this.btnListeleKapali.Name = "btnListeleKapali";
            this.btnListeleKapali.Size = new System.Drawing.Size(100, 23);
            this.btnListeleKapali.TabIndex = 6;
            this.btnListeleKapali.Text = "Listele";
            this.btnListeleKapali.UseVisualStyleBackColor = true;
            this.btnListeleKapali.Click += new System.EventHandler(this.btnListeleKapali_Click);
            // 
            // cbKullanici
            // 
            this.cbKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullanici.FormattingEnabled = true;
            this.cbKullanici.Location = new System.Drawing.Point(468, 21);
            this.cbKullanici.Name = "cbKullanici";
            this.cbKullanici.Size = new System.Drawing.Size(142, 24);
            this.cbKullanici.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(404, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ekleyen";
            // 
            // dtpBaslangic2
            // 
            this.dtpBaslangic2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic2.Location = new System.Drawing.Point(260, 19);
            this.dtpBaslangic2.Name = "dtpBaslangic2";
            this.dtpBaslangic2.Size = new System.Drawing.Size(109, 22);
            this.dtpBaslangic2.TabIndex = 1;
            // 
            // dtpBaslangic1
            // 
            this.dtpBaslangic1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic1.Location = new System.Drawing.Point(145, 19);
            this.dtpBaslangic1.Name = "dtpBaslangic1";
            this.dtpBaslangic1.Size = new System.Drawing.Size(109, 22);
            this.dtpBaslangic1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Başlangıç Tarihi";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Enabled = true;
            this.timerRefresh.Interval = 5000;
            this.timerRefresh.Tick += new System.EventHandler(this.timerList_Tick);
            // 
            // checkBoxOtoRefresh
            // 
            this.checkBoxOtoRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxOtoRefresh.AutoSize = true;
            this.checkBoxOtoRefresh.Checked = true;
            this.checkBoxOtoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOtoRefresh.Location = new System.Drawing.Point(1197, 27);
            this.checkBoxOtoRefresh.Name = "checkBoxOtoRefresh";
            this.checkBoxOtoRefresh.Size = new System.Drawing.Size(141, 21);
            this.checkBoxOtoRefresh.TabIndex = 5;
            this.checkBoxOtoRefresh.Text = "Otomatik yenile ()";
            this.checkBoxOtoRefresh.UseVisualStyleBackColor = true;
            this.checkBoxOtoRefresh.CheckedChanged += new System.EventHandler(this.checkBoxOtoRefresh_CheckedChanged);
            // 
            // trackBarRefresh
            // 
            this.trackBarRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRefresh.Location = new System.Drawing.Point(1344, 23);
            this.trackBarRefresh.Minimum = 1;
            this.trackBarRefresh.Name = "trackBarRefresh";
            this.trackBarRefresh.Size = new System.Drawing.Size(104, 56);
            this.trackBarRefresh.TabIndex = 6;
            this.trackBarRefresh.Value = 5;
            this.trackBarRefresh.Scroll += new System.EventHandler(this.trackBarList_Scroll);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(1457, 27);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(64, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // FormKalite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 612);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.checkBoxOtoRefresh);
            this.Controls.Add(this.trackBarRefresh);
            this.Controls.Add(this.tabHenkaten);
            this.Controls.Add(this.lblBaslik);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "FormKalite";
            this.Text = "Kalite - İşlem Listesi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormKalite_FormClosing);
            this.Load += new System.EventHandler(this.FormKalite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgHenkatenAcik)).EndInit();
            this.tabHenkaten.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgHenkatenKapali)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridView dgHenkatenAcik;
        private System.Windows.Forms.TabControl tabHenkaten;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel pnlEdit;
        private System.Windows.Forms.Label lblProses;
        private System.Windows.Forms.Label lblProje;
        private System.Windows.Forms.Label lblOncelik;
        private System.Windows.Forms.Label lblUrunParca;
        private System.Windows.Forms.Label lblDegisimKategorisi;
        private System.Windows.Forms.Label lblHatMakine;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txProses;
        private System.Windows.Forms.TextBox txHatMakine;
        private System.Windows.Forms.TextBox txProje;
        private System.Windows.Forms.TextBox txUrunParca;
        private System.Windows.Forms.TextBox txDegisimKategorisi;
        private System.Windows.Forms.TextBox txAciklama;
        private System.Windows.Forms.TextBox txAksiyonTedbir;
        private System.Windows.Forms.TextBox txOncelik;
        private System.Windows.Forms.TextBox txBaslangicTarihi;
        private System.Windows.Forms.TextBox txDurum;
        private System.Windows.Forms.DataGridView dgHenkatenKapali;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpBaslangic2;
        private System.Windows.Forms.DateTimePicker dtpBaslangic1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnListeleKapali;
        private System.Windows.Forms.ComboBox cbKullanici;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.CheckBox checkBoxOtoRefresh;
        private System.Windows.Forms.TrackBar trackBarRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancel;
    }
}