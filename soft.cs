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
    public partial class soft : Form
    {
        public soft()
        {
            InitializeComponent();
            if (!Directory.Exists(Application.StartupPath + @"\soft\Deskpins\"))
                groupBox1.Hide();
            if (!Directory.Exists(Application.StartupPath + @"\soft\MouseInc\"))
                groupBox2.Hide();
            if (!Directory.Exists(Application.StartupPath + @"\soft\Office Tool\"))
                groupBox3.Hide();
            if (!Directory.Exists(Application.StartupPath + @"\soft\Resource Hacker\"))
                groupBox4.Hide();
            if (!Directory.Exists(Application.StartupPath + @"\soft\Revo Uninstaller\"))
                groupBox5.Hide();
            if (!File.Exists(Application.StartupPath + @"\soft\Flash Player.exe"))
                groupBox6.Hide();
            if (!File.Exists(Application.StartupPath + @"\soft\HEU_KMS_Activator_v24.6.1.exe"))
                groupBox7.Hide();
        }

        private void soft_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\soft\Deskpins\Deskpins.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\soft\Deskpins\Deskpins.exe");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\soft\Deskpins\");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\soft\Deskpins\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\soft\MouseInc\MouseInc.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\soft\MouseInc\MouseInc.exe");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\soft\MouseInc\");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\soft\MouseInc\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\soft\Office Tool\Office Tool Plus.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\soft\Office Tool\Office Tool Plus.exe");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\soft\Office Tool\");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\soft\Office Tool\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\soft\Resource Hacker\ResHack.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\soft\Resource Hacker\ResHack.exe");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\soft\Resource Hacker\");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\soft\Resource Hacker\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\soft\Revo Uninstaller\RevoUPPort.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\soft\Revo Uninstaller\RevoUPPort.exe");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\soft\Revo Uninstaller\");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\soft\Revo Uninstaller\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\soft\Flash Player.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\soft\Flash Player.exe");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\soft\");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\soft\Flash Player.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\soft\HEU_KMS_Activator_v24.6.1.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\soft\HEU_KMS_Activator_v24.6.1.exe");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\soft\");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\soft\HEU_KMS_Activator_v24.6.1.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Deskpins == false)
            {
                Properties.Settings.Default.Deskpins = true;
                Properties.Settings.Default.Save();
                button22.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.Deskpins = false;
                Properties.Settings.Default.Save();
                button22.Text = "收藏";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MouseInc == false)
            {
                Properties.Settings.Default.MouseInc = true;
                Properties.Settings.Default.Save();
                button23.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.MouseInc = false;
                Properties.Settings.Default.Save();
                button23.Text = "收藏";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.OT == false)
            {
                Properties.Settings.Default.OT = true;
                Properties.Settings.Default.Save();
                button24.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.OT = false;
                Properties.Settings.Default.Save();
                button24.Text = "收藏";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RH == false)
            {
                Properties.Settings.Default.RH = true;
                Properties.Settings.Default.Save();
                button25.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.RH = false;
                Properties.Settings.Default.Save();
                button25.Text = "收藏";
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RU == false)
            {
                Properties.Settings.Default.RU = true;
                Properties.Settings.Default.Save();
                button26.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.RU = false;
                Properties.Settings.Default.Save();
                button26.Text = "收藏";
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FP == false)
            {
                Properties.Settings.Default.FP = true;
                Properties.Settings.Default.Save();
                button27.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.FP = false;
                Properties.Settings.Default.Save();
                button27.Text = "收藏";
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.HK == false)
            {
                Properties.Settings.Default.HK = true;
                Properties.Settings.Default.Save();
                button28.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.HK = false;
                Properties.Settings.Default.Save();
                button28.Text = "收藏";
            }
        }
    }
}
