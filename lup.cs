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
    public partial class lup : Form
    {
        public lup()
        {
            InitializeComponent();
            if (!Directory.Exists(Application.StartupPath + @"\lup\Bandicam\"))
                groupBox1.Hide();
            if (!File.Exists(Application.StartupPath + @"\lup\Screen To Gif.exe"))
                groupBox2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\lup\Bandicam\Bandicam_Portable.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\lup\Bandicam\Bandicam_Portable.exe");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\lup\Bandicam\");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\lup\Bandicam\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\lup\Screen To Gif.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\lup\Screen To Gif.exe");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\lup\");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\lup\Screen To Gif.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void lup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Bandicam == false)
            {
                Properties.Settings.Default.Bandicam = true;
                Properties.Settings.Default.Save();
                button7.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.Bandicam = false;
                Properties.Settings.Default.Save();
                button7.Text = "收藏";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.STG == false)
            {
                Properties.Settings.Default.STG = true;
                Properties.Settings.Default.Save();
                button8.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.STG = false;
                Properties.Settings.Default.Save();
                button8.Text = "收藏";
            }
        }
    }
}
