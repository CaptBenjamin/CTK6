using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace CTK6
{
    public partial class deling : Form
    {
        public deling()
        {
            InitializeComponent();

            backgroundWorker1.WorkerReportsProgress = true;
        }

        private void deling_Load(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            FileAttributes attr = File.GetAttributes(Properties.Settings.Default.path);
            if (attr == FileAttributes.Directory)
            {
                Directory.Delete(Properties.Settings.Default.path, true);
            }
            else
            {
                File.Delete(Properties.Settings.Default.path);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("删除操作已被取消", "删除功能", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 0;
                label1.Text = "删除操作已取消";
            }
            else if (e.Error != null)
            {
                MessageBox.Show("删除操作错误，请重试！", "删除功能", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressBar1.Value = 0;
                label1.Text = "删除操作错误，请重试！";
            }
            else
            {
                progressBar1.Value = 100;
                label1.Text = "删除操作已成功完成！";
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }
    }
}
