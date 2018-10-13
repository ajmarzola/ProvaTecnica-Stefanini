using System;
using System.Windows.Forms;
using ProvaTecnica.Business;

namespace ProvaTecnica.Win.UI
{
    public partial class frmMain : Form
    {
        private string selectedType = string.Empty;

        public frmMain()
        {
            InitializeComponent();
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            using (var bll = new FileBll())
            {
                if (await bll.Process(txtPath.Text, selectedType))
                    MessageBox.Show("Arquivo processado com sucesso!", "SUCESSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Algo não funcionou no processamento do arquivo", "OPS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = openFileDialog1.FileName;
            }
        }

        private void rdbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbCustomer.Checked)
                selectedType = "C";
        }

        private void rdbProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProduct.Checked)
                selectedType = "P";
        }
    }
}
