using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms; 

namespace AlbaHenkaten
{
    public partial class FormReportHenkaten : Form
    {
        private DateTime baslangicTarihi1, baslangicTarihi2;
        private int? kullaniciId;
        public FormReportHenkaten(DateTime baslangicTarihi1, DateTime baslangicTarihi2, int? kullaniciId)
        {
            InitializeComponent();


            this.baslangicTarihi1 = baslangicTarihi1;
            this.baslangicTarihi2 = baslangicTarihi2;
            this.kullaniciId = kullaniciId;
        }

        private DataTable GetHenkatenKapali()
        {// 

            SqlHelper sqlHelper = new SqlHelper();
            List<SqlParameter> parameters = new List<SqlParameter>{ new SqlParameter("BaslangicTarihi1", baslangicTarihi1),
                                                                    new SqlParameter("BaslangicTarihi2", baslangicTarihi2)
                                                                  };

            string filterForKullanici = String.Empty;

            if (kullaniciId.HasValue)
            {
                parameters.Add(new SqlParameter("@EkleyenKullaniciId", kullaniciId));
                filterForKullanici = " AND k.Id = @EkleyenKullaniciId ";
            }


            var henkatens = sqlHelper.ExecuteQuery(@"SELECT  
                  [Proses]
                 ,[HatMakine] 
                 ,[Proje]
                 ,[UrunParca]
                 ,[DegisimKategorisi]
                 ,[Aciklama]
                 ,[AksiyonTedbir]
                 ,[OncelikSirasi]
                 ,[BaslangicTarihi] 
                 ,[BitisTarihi]
                 ,[Durum] 
                 ,[Baslik] as [Ekleyen]
            FROM[dbo].[Henkaten] h
            JOIN [Oncelik] o ON o.Id = h.OncelikId
            JOIN [Kullanici] k ON k.Id = h.EkleyenKullaniciId " + filterForKullanici +
          @"WHERE BitisTarihi IS NOT NULL AND BaslangicTarihi BETWEEN @BaslangicTarihi1 AND @BaslangicTarihi2
            ORDER BY h.Id DESC", CommandType.Text, parameters.ToArray()).Tables[0];


            return henkatens;
        }

        private void FormReportHenkaten_Load(object sender, EventArgs e)
        {
            var data = GetHenkatenKapali();
            ReportDataSource datasource = new ReportDataSource("DSHenkaten", data);
           
            this.reportViewer1.ProcessingMode = ProcessingMode.Local;

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource); 

            this.reportViewer1.LocalReport.ReportPath = @"ReportHenkaten.rdlc";

            this.reportViewer1.RefreshReport();
            this.reportViewer1.LocalReport.Refresh();
             
        }
    }
}
