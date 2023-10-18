using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IsIT.B2B.Common.Security;
using System.IO;

namespace IsIT.B2B.PublicCertDownloaderTest
{
    public partial class DownloadForm : Form
    {
        public DownloadForm()
        {
            InitializeComponent();
            btnSave.Enabled = false;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            textBoxPublicCert.Clear();
            var url = IOBUrlTextBox.Text;
            var cert = WcfSecurityHelper<DownloadForm>.GetServerCertificate(url);            
            string b64ExportCertificate = Convert.ToBase64String(cert.RawData);
            textBoxPublicCert.Text = b64ExportCertificate;
            btnSave.Enabled = true;
            this.UseWaitCursor = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {                
                using (TextWriter tw = new StreamWriter(saveFileDialog1.FileName))
                {                    
                    tw.WriteLine(textBoxPublicCert.Text);
                }
                MessageBox.Show("Saved to " + saveFileDialog1.FileName, "Saved Log File", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.UseWaitCursor = false;
        }
    }
}
