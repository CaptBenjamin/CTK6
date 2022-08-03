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
    public partial class hard : Form
    {
        public hard()
        {
            InitializeComponent();
            if (!Directory.Exists(Application.StartupPath + @"\hardware\CPU-Z\"))
                groupBox1.Hide();
            if (!Directory.Exists(Application.StartupPath + @"\hardware\Real Temp\"))
                groupBox2.Hide();
            if (!File.Exists(Application.StartupPath + @"\hardware\GPU-Z.exe"))
                groupBox3.Hide();
            if (Properties.Settings.Default.CPUZ == true)
            {
                button10.Text = "取消收藏";
            }
            if (Properties.Settings.Default.RT == true)
            {
                button11.Text = "取消收藏";
            }
            if (Properties.Settings.Default.GPUZ == true)
            {
                button12.Text = "取消收藏";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\hardware\CPU-Z\cpuz_x64.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\hardware\CPU-Z\cpuz_x64.exe");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\hardware\CPU-Z\");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\hardware\CPU-Z\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\hardware\Real Temp\RealTemp.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\hardware\Real Temp\RealTemp.exe");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\hardware\Real Temp\");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\hardware\Real Temp\";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + @"\hardware\GPU-Z.exe"))
            {
                MessageBox.Show("该功能已损坏，请尝试通过CTK6安装程序重新安装该功能", "启动错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(Application.StartupPath + @"\hardware\GPU-Z.exe");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\hardware\");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除该功能?", "确认删除功能", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                Properties.Settings.Default.path = Application.StartupPath + @"\hardware\GPU-Z.exe";
                Properties.Settings.Default.Save();
                deling deling = new deling();
                deling.ShowDialog();
                this.Close();
            }
        }

        private void hard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CPUZ == false)
            {
                Properties.Settings.Default.CPUZ = true;
                Properties.Settings.Default.Save();
                button10.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.CPUZ = false;
                Properties.Settings.Default.Save();
                button10.Text = "收藏";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.RT == false)
            {
                Properties.Settings.Default.RT = true;
                Properties.Settings.Default.Save();
                button11.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.RT = false;
                Properties.Settings.Default.Save();
                button11.Text = "收藏";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.GPUZ == false)
            {
                Properties.Settings.Default.GPUZ = true;
                Properties.Settings.Default.Save();
                button12.Text = "取消收藏";
            }
            else
            {
                Properties.Settings.Default.GPUZ = false;
                Properties.Settings.Default.Save();
                button12.Text = "收藏";
            }
        }
    }
}
