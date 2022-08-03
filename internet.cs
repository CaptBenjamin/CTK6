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
    public partial class internet : Form
    {
        public internet()
        {
            InitializeComponent();
            if (!Directory.Exists(Application.StartupPath + @"\internet\DnsJumper\"))
                groupBox1.Hide();
            if (!Directory.Exists(Application.StartupPath + @"\internet\Fiddler\"))
                groupBox2.Hide();
            if (!Directory.Exists(Application.StartupPath + @"\internet\SimpleWall\"))
                groupBox3.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\internet\DnsJumper\DnsJumper.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\internet\DnsJumper\DnsJumper.exe");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\internet\Fiddler\Fiddler.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\internet\Fiddler\Fiddler.exe");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\internet\SimpleWall\simplewall.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\internet\SimpleWall\simplewall.exe");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\internet\DnsJumper\");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\internet\Fiddler\");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\internet\SimpleWall\");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\internet\DnsJumper\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\internet\Fiddler\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\internet\SimpleWall\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void internet_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
