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
    public partial class file : Form
    {
        public file()
        {
            InitializeComponent();
            if (!Directory.Exists(Application.StartupPath + @"\files\Everything\"))
                groupBox1.Hide();
            if (!Directory.Exists(Application.StartupPath + @"\files\FormatFactory\"))
                groupBox2.Hide();
            if (!File.Exists(Application.StartupPath + @"\files\Empty Folder Nuker.exe"))
                groupBox3.Hide();
            if (!File.Exists(Application.StartupPath + @"\files\Iobit Unlocker.exe"))
                groupBox4.Hide();
            if (!File.Exists(Application.StartupPath + @"\files\SpaceSniffer.exe"))
                groupBox5.Hide();
            if (!File.Exists(Application.StartupPath + @"\files\USBCopyer.exe"))
                groupBox6.Hide();
            if (!File.Exists(Application.StartupPath + @"\files\WinLinks.exe"))
                groupBox7.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\files\Everything\Everything.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\files\Everything\Everything.exe");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\files\FormatFactory\FormatFactory.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\files\FormatFactory\FormatFactory.exe");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\files\Empty Folder Nuker.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\files\Empty Folder Nuker.exe");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\files\Iobit Unlocker.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\files\Iobit Unlocker.exe");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\files\SpaceSniffer.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\files\SpaceSniffer.exe");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\files\USBCopyer.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\files\USBCopyer.exe");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\files\WinLinks.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\files\WinLinks.exe");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\files\");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\files\");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\files\");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\files\");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\files\");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\files\Everything\");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\files\FormatFactory\");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\files\Everything\";
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
                Properties.Settings.Default.path = Application.StartupPath + @"\files\FormatFactory\";
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
                Properties.Settings.Default.path = Application.StartupPath + @"\files\Empty Folder Nuker.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\files\Iobit Unlocker.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\files\SpaceSniffer.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\files\USBCopyer.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\files\WinLinks.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void file_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
