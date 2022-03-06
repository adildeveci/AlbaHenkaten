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
    public partial class FormYeniHenkatenGiris : Form
    {
        public FormYeniHenkatenGiris()
        {
            InitializeComponent();
        }

        private void FormYeniHenkatenGiris_Load(object sender, EventArgs e)
        {
            lblBaslik.Text = Kullanici.Baslik;
            checkBoxOtoRefresh.Text = "Otomatik yenile (" + trackBarRefresh.Value.ToString() + "sn.)";
            timerRefresh.Interval = trackBarRefresh.Value * 1000;


            FillOncelik();
            ListHenkaten();
        }

        private void ClearInput()
        {
            txProses.Clear();
            txHatMakine.Clear();
            txProje.Clear();
            txUrunParca.Clear();
            txDegisimKategorisi.Clear();
            txDurum.Clear();
            cbOncelik.SelectedValue = 0;

        }

        private void SetOncelikColor()
        {
            foreach (DataGridViewRow row in dgHenkaten.Rows)
                row.Cells["Öncelik"].Style.BackColor = ColorTranslator.FromHtml("#" + row.Cells["RGBRenkKodu"].Value.ToString());
        }

        private void FillOncelik()
        {
            cbOncelik.Items.Clear();

            SqlHelper sqlHelper = new SqlHelper();
            var dtOncelik = sqlHelper.ExecuteQuery("select *, CAST(OncelikSirasi AS varchar) as OncelikSirasiText from Oncelik order by OncelikSirasi asc", CommandType.Text).Tables[0];

            #region Insert First Record

            var row = dtOncelik.NewRow();
            row["Id"] = 0;
            row["OncelikSirasi"] = 0;
            row["OncelikSirasiText"] = "Seç";

            dtOncelik.Rows.InsertAt(row, 0);

            #endregion

            cbOncelik.DataSource = dtOncelik;
            cbOncelik.ValueMember = "Id";
            cbOncelik.DisplayMember = "OncelikSirasiText";

        }

        private void ListHenkaten()
        {
            SqlHelper sqlHelper = new SqlHelper();
            SqlParameter[] parameters = { new SqlParameter("@EkleyenKullaniciId", Kullanici.Id) };
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
            FROM[dbo].[Henkaten] h
            JOIN [Oncelik] o ON o.Id = h.OncelikId
            where EkleyenKullaniciId =@EkleyenKullaniciId order by h.Id desc", CommandType.Text, parameters).Tables[0];

            dgHenkaten.DataSource = henkatens;

            #region Grid Settings

            dgHenkaten.Columns["RGBRenkKodu"].Visible = false;
            dgHenkaten.Columns["Açıklama"].MinimumWidth = 100;
            dgHenkaten.Columns["Açıklama"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            #endregion

            SetOncelikColor();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                #region Validation

                if (
                    String.IsNullOrWhiteSpace(txProses.Text) ||
                    String.IsNullOrWhiteSpace(txHatMakine.Text) ||
                    String.IsNullOrWhiteSpace(txProje.Text) ||
                    String.IsNullOrWhiteSpace(txUrunParca.Text) ||
                    String.IsNullOrWhiteSpace(txDegisimKategorisi.Text) ||
                    (cbOncelik.SelectedValue == null || (int)cbOncelik.SelectedValue <= 0) ||
                    String.IsNullOrWhiteSpace(txDurum.Text)
                       )
                {
                    MessageBox.Show("Tüm alanları doldurunuz", "Hata", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    return;
                }

                #endregion

                #region Insert

                SqlHelper sqlHelper = new SqlHelper();
                SqlParameter[] parameters = {
                new SqlParameter("@Proses", txProses.Text),
                new SqlParameter("@HatMakine", txHatMakine.Text),
                new SqlParameter("@Proje", txProje.Text),
                new SqlParameter("@UrunParca", txUrunParca.Text),
                new SqlParameter("@DegisimKategorisi", txDegisimKategorisi.Text),
                new SqlParameter("@OncelikId", cbOncelik.SelectedValue),
                new SqlParameter("@Durum", txDurum.Text),
                new SqlParameter("@EkleyenKullaniciId", Kullanici.Id)
        };

                int result = sqlHelper.ExecuteNonQuery(@"INSERT INTO [Henkaten]
           ([Proses]
           ,[HatMakine]
           ,[Proje]
           ,[UrunParca]
           ,[DegisimKategorisi]  
           ,[OncelikId]
           ,[BaslangicTarihi] 
           ,[Durum]
           ,[EkleyenKullaniciId])
            VALUES
           (@Proses 
           ,@HatMakine 
           ,@Proje 
           ,@UrunParca 
           ,@DegisimKategorisi   
           ,@OncelikId 
           ,GetDate() 
           ,@Durum 
           ,@EkleyenKullaniciId)",
                CommandType.Text,
               parameters
               );
                #endregion

                if (result == 1)
                {
                    ListHenkaten();
                    ClearInput();
                    MessageBox.Show("Kayıt eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgHenkaten_Sorted(object sender, EventArgs e)
        {
            SetOncelikColor();
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            ListHenkaten();
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

        private void trackBarRefresh_Scroll(object sender, EventArgs e)
        {
            checkBoxOtoRefresh.Text = "Otomatik yenile (" + trackBarRefresh.Value.ToString() + "sn.)";
            timerRefresh.Interval = trackBarRefresh.Value * 1000; //5*1000  5saniye
    }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ListHenkaten();
        }
    }
}
