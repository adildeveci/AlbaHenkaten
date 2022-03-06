using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbaHenkaten
{
    public partial class FormKalite : Form
    {
        private int selectedHenkatenId = 0;
        public FormKalite()
        {
            InitializeComponent();
        }
        private void FormKalite_Load(object sender, EventArgs e)
        {
            dtpBaslangic1.Value = DateTime.Today.AddMonths(-1);
            checkBoxOtoRefresh.Text = "Otomatik yenile (" + trackBarRefresh.Value.ToString() + "sn.)";
            timerRefresh.Interval = trackBarRefresh.Value * 1000;
            lblBaslik.Text = Kullanici.Baslik;

            ListHenkatenAcik();
            FillKullanici();
            ListHenkatenKapali();

        }

        private void SetOncelikColor(DataGridView dgHenkaten)
        {
            foreach (DataGridViewRow row in dgHenkaten.Rows)
                row.Cells["Öncelik"].Style.BackColor = ColorTranslator.FromHtml("#" + row.Cells["RGBRenkKodu"].Value.ToString());
        }

        private void ListHenkatenAcik()
        {
            SqlHelper sqlHelper = new SqlHelper();
            SqlParameter[] parameters = { };
            var henkatens = sqlHelper.ExecuteQuery(@"SELECT 
                  h.[Id]  
                 ,[Proses]
                 ,[HatMakine] as [Hat / Makine] 
                 ,[Proje]
                 ,[UrunParca] as [Ürün / Parça]
                 ,[DegisimKategorisi] as [Değişim Kategorisi]
                 ,[OncelikSirasi] as [Öncelik]
                 ,[RGBRenkKodu]
                 ,[BaslangicTarihi] as [Başlangıç Tarihi] 
                 ,[Durum] 
                 ,[Baslik] as [Ekleyen]
            FROM[dbo].[Henkaten] h
            JOIN [Oncelik] o ON o.Id = h.OncelikId
            JOIN [Kullanici] k ON k.Id = h.EkleyenKullaniciId
            WHERE h.BitisTarihi IS NULL
            ORDER BY h.Id DESC", CommandType.Text, parameters).Tables[0];


            dgHenkatenAcik.DataSource = henkatens;

            #region Grid Settings

            dgHenkatenAcik.Columns["Id"].Visible = false;
            dgHenkatenAcik.Columns["RGBRenkKodu"].Visible = false;
            dgHenkatenAcik.Columns["Ürün / Parça"].MinimumWidth = 100;
            dgHenkatenAcik.Columns["Ürün / Parça"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgHenkatenAcik.Columns["Değişim Kategorisi"].MinimumWidth = 100;
            dgHenkatenAcik.Columns["Değişim Kategorisi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            #endregion

            SetOncelikColor(dgHenkatenAcik);

        }
        private void ListHenkatenKapali()
        {//

            #region Validation

            if (dtpBaslangic1.Value.Date > dtpBaslangic2.Value.Date)
            {
                MessageBox.Show("Başlangıç tarih aralığı hatalı \nMin. başlangıç tarihi max. başlangıç tarihinden büyük olamaz", "Geçersiz tarih aralığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #endregion

            SqlHelper sqlHelper = new SqlHelper();
            List<SqlParameter> parameters = new List<SqlParameter>{ new SqlParameter("BaslangicTarihi1", dtpBaslangic1.Value.Date),
                                                                    new SqlParameter("BaslangicTarihi2", dtpBaslangic2.Value.Date.AddDays(1).AddMilliseconds(-1))//ikinci tarihin son saatleri de ekleniyor
                                                                  };

            string filterForKullanici = String.Empty;

            if ((int)cbKullanici.SelectedValue != 0)
            {
                parameters.Add(new SqlParameter("@EkleyenKullaniciId", (int)cbKullanici.SelectedValue));
                filterForKullanici = " AND k.Id = @EkleyenKullaniciId ";
            }


            var henkatens = sqlHelper.ExecuteQuery(@"SELECT  
                  [Proses]
                 ,[HatMakine] as [Hat / Makine] 
                 ,[Proje]
                 ,[UrunParca] as [Ürün / Parça]
                 ,[DegisimKategorisi] as [Değişim Kategorisi]
                 ,[Aciklama] as [Açıklama]
                 ,[AksiyonTedbir] as [Aksiyon / Tedbir]
                 ,[OncelikSirasi] as [Öncelik]
                 ,[RGBRenkKodu]
                 ,[BaslangicTarihi] as [Başlangıç Tarihi] 
                 ,[BitisTarihi] as [Bitiş Tarihi] 
                 ,[Durum] 
                 ,[Baslik] as [Ekleyen]
            FROM[dbo].[Henkaten] h
            JOIN [Oncelik] o ON o.Id = h.OncelikId
            JOIN [Kullanici] k ON k.Id = h.EkleyenKullaniciId " + filterForKullanici +
          @"WHERE BitisTarihi IS NOT NULL AND BaslangicTarihi BETWEEN @BaslangicTarihi1 AND @BaslangicTarihi2
            ORDER BY h.Id DESC", CommandType.Text, parameters.ToArray()).Tables[0];


            dgHenkatenKapali.DataSource = henkatens;

            #region Grid Settings

            dgHenkatenKapali.Columns["RGBRenkKodu"].Visible = false;
            dgHenkatenKapali.Columns["Açıklama"].MinimumWidth = 100;
            dgHenkatenKapali.Columns["Açıklama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgHenkatenKapali.Columns["Aksiyon / Tedbir"].MinimumWidth = 125;
            dgHenkatenKapali.Columns["Aksiyon / Tedbir"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            #endregion

            SetOncelikColor(dgHenkatenKapali);
        }

        private void FillKullanici()
        {
            cbKullanici.Items.Clear();

            SqlHelper sqlHelper = new SqlHelper();
            var dtOncelik = sqlHelper.ExecuteQuery("select Id, Baslik from Kullanici where KaliteMi=0 order by Baslik asc", CommandType.Text).Tables[0];

            #region Insert First Record

            var row = dtOncelik.NewRow();
            row["Id"] = 0;
            row["Baslik"] = "Hepsi";

            dtOncelik.Rows.InsertAt(row, 0);

            #endregion

            cbKullanici.DataSource = dtOncelik;
            cbKullanici.ValueMember = "Id";
            cbKullanici.DisplayMember = "Baslik";

        }
        private void ClearInput()
        {
            selectedHenkatenId = 0;
            txProses.Clear();
            txHatMakine.Clear();
            txUrunParca.Clear();
            txDegisimKategorisi.Clear();
            txAciklama.Clear();
            txAksiyonTedbir.Clear();
            txOncelik.Clear();
            txBaslangicTarihi.Clear();
            txDurum.Clear();
        }

        private void dgHenkatenAcik_Sorted(object sender, EventArgs e)
        {
            SetOncelikColor(dgHenkatenAcik);
        }
        private void dgHenkatenKapali_Sorted(object sender, EventArgs e)
        {
            SetOncelikColor(dgHenkatenKapali);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                #region Validation

                if (String.IsNullOrWhiteSpace(txAciklama.Text) || String.IsNullOrWhiteSpace(txAksiyonTedbir.Text))
                {
                    MessageBox.Show("Kaydı kapatmak için alanları doldurunuz", "Eksik bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                #endregion

                #region Update

                SqlHelper sqlHelper = new SqlHelper();
                SqlParameter[] parameters = {
                new SqlParameter("@Id", selectedHenkatenId),
                new SqlParameter("@Aciklama", txAciklama.Text),
                new SqlParameter("@AksiyonTedbir", txAksiyonTedbir.Text)
            };

                int result = sqlHelper.ExecuteNonQuery(@"UPDATE [dbo].[Henkaten] SET
                                              [Aciklama] = @Aciklama,
                                              [AksiyonTedbir] = @AksiyonTedbir,
                                              [BitisTarihi] = GetDate()
                                              WHERE Id = @Id", CommandType.Text, parameters);

                #endregion

                if (result > 0)
                {
                    MessageBox.Show("Kayıt kapatıldı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInput();
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    ListHenkatenAcik();
                    ListHenkatenKapali();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListeleKapali_Click(object sender, EventArgs e)
        {
            ListHenkatenKapali();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            #region Validation

            if (dtpBaslangic1.Value.Date > dtpBaslangic2.Value.Date)
            {
                MessageBox.Show("Başlangıç tarih aralığı hatalı \nMin. başlangıç tarihi max. başlangıç tarihinden büyük olamaz", "Geçersiz tarih aralığı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #endregion

            int? kullaniciId = null;
            if ((int)cbKullanici.SelectedValue != 0)
                kullaniciId = (int)cbKullanici.SelectedValue;

            FormReportHenkaten formReportHenkaten = new FormReportHenkaten(dtpBaslangic1.Value.Date, dtpBaslangic2.Value.Date.AddDays(1).AddMilliseconds(-1), kullaniciId);
            formReportHenkaten.Show();

        }

        private void checkBoxOtoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOtoRefresh.Checked)
            {
                timerRefresh.Start();
                btnRefresh.Visible = false;
                trackBarRefresh.Enabled = true;
            }
            else
            {
                timerRefresh.Stop();
                btnRefresh.Visible = true;
                trackBarRefresh.Enabled = false;
            }
        }

        private void trackBarList_Scroll(object sender, EventArgs e)
        {
            checkBoxOtoRefresh.Text = "Otomatik yenile (" + trackBarRefresh.Value.ToString() + "sn.)";
            timerRefresh.Interval = trackBarRefresh.Value * 1000; //5*1000  5saniye
        }

        private void timerList_Tick(object sender, EventArgs e)
        {
            if (tabHenkaten.SelectedIndex == 0) //acik henkaten tabi
            {
                ListHenkatenAcik();
            }
            else //kapali henkaten tabi 
            {
                ListHenkatenKapali();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListHenkatenAcik();
        }

        private void dgHenkatenAcik_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgHenkatenAcik.SelectedRows.Count == 1)
            {
                selectedHenkatenId = (int)dgHenkatenAcik.SelectedRows[0].Cells["Id"].Value;
                txProses.Text = dgHenkatenAcik.SelectedRows[0].Cells["Proses"].Value.ToString();
                txHatMakine.Text = dgHenkatenAcik.SelectedRows[0].Cells["Hat / Makine"].Value.ToString();
                txUrunParca.Text = dgHenkatenAcik.SelectedRows[0].Cells["Ürün / Parça"].Value.ToString();
                txDegisimKategorisi.Text = dgHenkatenAcik.SelectedRows[0].Cells["Değişim Kategorisi"].Value.ToString();
                txOncelik.Text = dgHenkatenAcik.SelectedRows[0].Cells["Öncelik"].Value.ToString();
                txBaslangicTarihi.Text = dgHenkatenAcik.SelectedRows[0].Cells["Başlangıç Tarihi"].Value.ToString();
                txDurum.Text = dgHenkatenAcik.SelectedRows[0].Cells["Durum"].Value.ToString();

                btnSave.Enabled = true;
                btnCancel.Enabled = true;

            }
            else
            {
                ClearInput();
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearInput();
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void FormKalite_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
