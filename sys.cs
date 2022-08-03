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
    public partial class sys : Form
    {
        public sys()
        {
            InitializeComponent();
            if (!Directory.Exists(Application.StartupPath + @"\system\AIDA64\"))
                groupBox1.Hide();
            if (!Directory.Exists(Application.StartupPath + @"\system\Dism++\"))
                groupBox2.Hide();
            if (!Directory.Exists(Application.StartupPath + @"\system\PCMaster\"))
                groupBox3.Hide();
            if (!Directory.Exists(Application.StartupPath + @"\system\UltimateDefrag\"))
                groupBox4.Hide();
            if (!File.Exists(Application.StartupPath + @"\system\Blue Screen View.exe"))
                groupBox5.Hide();
            if (!File.Exists(Application.StartupPath + @"\system\ContextMenu Manager.exe"))
                groupBox6.Hide();
            if (!File.Exists(Application.StartupPath + @"\system\Rufus.exe"))
                groupBox7.Hide();
            if (!File.Exists(Application.StartupPath + @"\system\WindowSize.exe"))
                groupBox8.Hide();
            if (!File.Exists(Application.StartupPath + @"\system\WinNTSetup.exe"))
                groupBox9.Hide();
            if (Properties.Settings.Default.AIDA64 == true)
            {
                button28.Text = "取消收藏";
            }
            if (Properties.Settings.Default.Dism == true)
            {
                button29.Text = "取消收藏";
            }
            if (Properties.Settings.Default.AIDA64 == true)
            {
                button30.Text = "取消收藏";
            }
            if (Properties.Settings.Default.AIDA64 == true)
            {
                button31.Text = "取消收藏";
            }
            if (Properties.Settings.Default.AIDA64 == true)
            {
                button32.Text = "取消收藏";
            }
            if (Properties.Settings.Default.AIDA64 == true)
            {
                button33.Text = "取消收藏";
            }
            if (Properties.Settings.Default.AIDA64 == true)
            {
                button34.Text = "取消收藏";
            }
            if (Properties.Settings.Default.AIDA64 == true)
            {
                button35.Text = "取消收藏";
            }
            if (Properties.Settings.Default.AIDA64 == true)
            {
                button36.Text = "取消收藏";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\system\AIDA64\aida64.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\system\AIDA64\aida64.exe");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\system\AIDA64\");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\system\AIDA64\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\system\Dism++\Dism++x64.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\system\Dism++\Dism++x64.exe");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\system\Dism++\");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\system\Dism++\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\system\PCMaster\PCMaster.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\system\PCMaster\PCMaster.exe");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\system\PCMaster\");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\system\PCMaster\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\system\UltimateDefrag\UltimateDefrag.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\system\UltimateDefrag\UltimateDefrag.exe");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\system\UltimateDefrag\");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\system\UltimateDefrag\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\system\Blue Screen View.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\system\Blue Screen View.exe");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\system\");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\system\Blue Screen View.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\system\ContextMenu Manager.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\system\ContextMenu Manager.exe");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\system\");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\system\ContextMenu Manager.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\system\Rufus.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\system\Rufus.exe");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\system\");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\system\Rufus.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\system\WindowSize.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\system\WindowSize.exe");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\system\");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\system\WindowSize.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\system\WinNTSetup.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\system\WinNTSetup.exe");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\system\");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\system\WinNTSetup.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void sys_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.AIDA64 == false)
            {
                Properties.Settings.Default.AIDA64 = true;
                Properties.Settings.Default.Save();
                button28.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.AIDA64 = false;
                Properties.Settings.Default.Save();
                button28.Text = "收藏";
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Dism == false)
            {
                Properties.Settings.Default.Dism = true;
                Properties.Settings.Default.Save();
                button29.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.Dism = false;
                Properties.Settings.Default.Save();
                button29.Text = "收藏";
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.PCMaster == false)
            {
                Properties.Settings.Default.PCMaster = true;
                Properties.Settings.Default.Save();
                button30.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.PCMaster = false;
                Properties.Settings.Default.Save();
                button30.Text = "收藏";
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UltimateDefrag == false)
            {
                Properties.Settings.Default.UltimateDefrag = true;
                Properties.Settings.Default.Save();
                button31.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.UltimateDefrag = false;
                Properties.Settings.Default.Save();
                button31.Text = "收藏";
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.BSV == false)
            {
                Properties.Settings.Default.BSV = true;
                Properties.Settings.Default.Save();
                button32.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.BSV = false;
                Properties.Settings.Default.Save();
                button32.Text = "收藏";
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CMM == false)
            {
                Properties.Settings.Default.CMM = true;
                Properties.Settings.Default.Save();
                button33.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.CMM = false;
                Properties.Settings.Default.Save();
                button33.Text = "收藏";
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Rufus == false)
            {
                Properties.Settings.Default.Rufus = true;
                Properties.Settings.Default.Save();
                button34.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.Rufus = false;
                Properties.Settings.Default.Save();
                button34.Text = "收藏";
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.WindowSize == false)
            {
                Properties.Settings.Default.WindowSize = true;
                Properties.Settings.Default.Save();
                button35.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.WindowSize = false;
                Properties.Settings.Default.Save();
                button35.Text = "收藏";
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.WinNTSetup == false)
            {
                Properties.Settings.Default.WinNTSetup = true;
                Properties.Settings.Default.Save();
                button36.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.WinNTSetup = false;
                Properties.Settings.Default.Save();
                button36.Text = "收藏";
            }
        }
    }
}
