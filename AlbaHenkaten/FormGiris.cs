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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txSifre.Text))
            {
                MessageBox.Show("Şifre giriniz", "Şifre giriniz", MessageBoxButtons.OK, icon: MessageBoxIcon.Warning);
                return;
            }

            SqlHelper sqlHelper = new SqlHelper();
            SqlParameter[] parameters = { new SqlParameter("@Sifre", txSifre.Text) };
            var kullanicilar = sqlHelper.ExecuteQuery("select * from Kullanici where Sifre = @Sifre", CommandType.Text, parameters).Tables[0];
            if (kullanicilar.Rows.Count < 1)
            {
                MessageBox.Show("Kullanıcı bulunamadı", "Hata", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }

            Kullanici.Id = int.Parse(kullanicilar.Rows[0]["Id"].ToString());
            Kullanici.Baslik = kullanicilar.Rows[0]["Baslik"].ToString();
            Kullanici.KaliteMi = bool.Parse(kullanicilar.Rows[0]["KaliteMi"].ToString());

            this.Hide();

            if (Kullanici.KaliteMi)
            {
                FormKalite formKalite = new FormKalite();
                formKalite.Show();
            }
            else
            {
                FormYeniHenkatenGiris formYeniHenkatenGiris = new FormYeniHenkatenGiris();
                formYeniHenkatenGiris.Show();
            }
        }

        private void txSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void btnConnection_Click(object sender, EventArgs e)
        {
            FormChangeConnectionString formChangeConnectionString = new FormChangeConnectionString();
            formChangeConnectionString.ShowDialog();
        }
    }
}
