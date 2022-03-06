using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AlbaHenkaten
{
    public partial class FormChangeConnectionString : Form
    {
        public FormChangeConnectionString()
        {
            InitializeComponent();
        }

        private void FormChangeConnectionString_Load(object sender, EventArgs e)
        {
            txConnectionString.Text = Properties.Settings.Default.ConnectionString;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("Veri tabanı bağlantısını değiştirmek üzeresiniz\nDevam edilsin mi?", "Bağlantı değiştirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                Properties.Settings.Default.ConnectionString = txConnectionString.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Veri tabanı bağlantısını değiştirildi", "Değişiklik tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection(txConnectionString.Text);
                sqlConnection.Open();
                MessageBox.Show("Bağlantı sağlandı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Bağlantı hatalı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
