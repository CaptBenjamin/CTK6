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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(Application.StartupPath + @"\system\AIDA64\"))
            {
                panel7.Hide();
            }
            else
            {
                if (Properties.Settings.Default.AIDA64 == false)
                    panel7.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\system\Dism++\"))
            {
                panel9.Hide();
            }
            else
            {
                if (Properties.Settings.Default.Dism == false)
                    panel9.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\system\PCMaster\"))
            {
                panel10.Hide();
            }
            else
            {
                if (Properties.Settings.Default.PCMaster == false)
                    panel10.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\system\UltimateDefrag\"))
            {
                panel11.Hide();
            }
            else
            {
                if (Properties.Settings.Default.UltimateDefrag == false)
                    panel11.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\system\Blue Screen View.exe"))
            {
                panel12.Hide();
            }
            else
            {
                if (Properties.Settings.Default.BSV == false)
                    panel12.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\system\ContextMenu Manager.exe"))
            {
                panel13.Hide();
            }
            else
            {
                if (Properties.Settings.Default.CMM == false)
                    panel13.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\system\Rufus.exe"))
            {
                panel14.Hide();
            }
            else
            {
                if (Properties.Settings.Default.Rufus == false)
                    panel14.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\system\WindowSize.exe"))
            {
                panel15.Hide();
            }
            else
            {
                if (Properties.Settings.Default.WindowSize == false)
                    panel15.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\system\WinNTSetup.exe"))
            {
                panel16.Hide();
            }
            else
            {
                if (Properties.Settings.Default.WinNTSetup == false)
                    panel16.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\hardware\CPU-Z\"))
            {
                panel17.Hide();
            }
            else
            {
                if (Properties.Settings.Default.CPUZ == false)
                    panel17.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\hardware\Real Temp\"))
            {
                panel18.Hide();
            }
            else
            {
                if (Properties.Settings.Default.RT == false)
                    panel18.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\hardware\GPU-Z.exe"))
            {
                panel19.Hide();
            }
            else
            {
                if (Properties.Settings.Default.GPUZ == false)
                    panel19.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\lup\Bandicam\"))
            {
                panel20.Hide();
            }
            else
            {
                if (Properties.Settings.Default.Bandicam == false)
                    panel20.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\lup\Screen To Gif.exe"))
            {
                panel21.Hide();
            }
            else
            {
                if (Properties.Settings.Default.STG == false)
                    panel21.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\soft\Deskpins\"))
            {
                panel27.Hide();
            }
            else
            {
                if (Properties.Settings.Default.Deskpins == false)
                    panel27.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\soft\MouseInc\"))
            {
                panel22.Hide();
            }
            else
            {
                if (Properties.Settings.Default.MouseInc == false)
                    panel22.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\soft\Office Tool\"))
            {
                panel23.Hide();
            }
            else
            {
                if (Properties.Settings.Default.OT == false)
                    panel23.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\soft\Resource Hacker\"))
            {
                panel24.Hide();
            }
            else
            {
                if (Properties.Settings.Default.RH == false)
                    panel24.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\soft\Revo Uninstaller\"))
            {
                panel25.Hide();
            }
            else
            {
                if (Properties.Settings.Default.RU == false)
                    panel25.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\soft\Flash Player.exe"))
            {
                panel26.Hide();
            }
            else
            {
                if (Properties.Settings.Default.FP == false)
                    panel26.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\soft\HEU_KMS_Activator_v24.6.1.exe"))
            {
                panel29.Hide();
            }
            else
            {
                if (Properties.Settings.Default.HK == false)
                    panel29.Hide();
            }
        }

        private void a()
        {
            if (!Directory.Exists(Application.StartupPath + @"\system\AIDA64\"))
            {
                panel7.Hide();
            }
            else
            {
                if (Properties.Settings.Default.AIDA64 == false)
                    panel7.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\system\Dism++\"))
            {
                panel9.Hide();
            }
            else
            {
                if (Properties.Settings.Default.Dism == false)
                    panel9.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\system\PCMaster\"))
            {
                panel10.Hide();
            }
            else
            {
                if (Properties.Settings.Default.PCMaster == false)
                    panel10.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\system\UltimateDefrag\"))
            {
                panel11.Hide();
            }
            else
            {
                if (Properties.Settings.Default.UltimateDefrag == false)
                    panel11.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\system\Blue Screen View.exe"))
            {
                panel12.Hide();
            }
            else
            {
                if (Properties.Settings.Default.BSV == false)
                    panel12.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\system\ContextMenu Manager.exe"))
            {
                panel13.Hide();
            }
            else
            {
                if (Properties.Settings.Default.CMM == false)
                    panel13.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\system\Rufus.exe"))
            {
                panel14.Hide();
            }
            else
            {
                if (Properties.Settings.Default.Rufus == false)
                    panel14.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\system\WindowSize.exe"))
            {
                panel15.Hide();
            }
            else
            {
                if (Properties.Settings.Default.WindowSize == false)
                    panel15.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\system\WinNTSetup.exe"))
            {
                panel16.Hide();
            }
            else
            {
                if (Properties.Settings.Default.WinNTSetup == false)
                    panel16.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\hardware\CPU-Z\"))
            {
                panel17.Hide();
            }
            else
            {
                if (Properties.Settings.Default.CPUZ == false)
                    panel17.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\hardware\Real Temp\"))
            {
                panel18.Hide();
            }
            else
            {
                if (Properties.Settings.Default.RT == false)
                    panel18.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\hardware\GPU-Z.exe"))
            {
                panel19.Hide();
            }
            else
            {
                if (Properties.Settings.Default.GPUZ == false)
                    panel19.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\lup\Bandicam\"))
            {
                panel20.Hide();
            }
            else
            {
                if (Properties.Settings.Default.Bandicam == false)
                    panel20.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\lup\Screen To Gif.exe"))
            {
                panel21.Hide();
            }
            else
            {
                if (Properties.Settings.Default.STG == false)
                    panel21.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\soft\Deskpins\"))
            {
                panel27.Hide();
            }
            else
            {
                if (Properties.Settings.Default.Deskpins == false)
                    panel27.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\soft\MouseInc\"))
            {
                panel22.Hide();
            }
            else
            {
                if (Properties.Settings.Default.MouseInc == false)
                    panel22.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\soft\Office Tool\"))
            {
                panel23.Hide();
            }
            else
            {
                if (Properties.Settings.Default.OT == false)
                    panel23.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\soft\Resource Hacker\"))
            {
                panel24.Hide();
            }
            else
            {
                if (Properties.Settings.Default.RH == false)
                    panel24.Hide();
            }
            if (!Directory.Exists(Application.StartupPath + @"\soft\Revo Uninstaller\"))
            {
                panel25.Hide();
            }
            else
            {
                if (Properties.Settings.Default.RU == false)
                    panel25.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\soft\Flash Player.exe"))
            {
                panel26.Hide();
            }
            else
            {
                if (Properties.Settings.Default.FP == false)
                    panel26.Hide();
            }
            if (!File.Exists(Application.StartupPath + @"\soft\HEU_KMS_Activator_v24.6.1.exe"))
            {
                panel29.Hide();
            }
            else
            {
                if (Properties.Settings.Default.HK == false)
                    panel29.Hide();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            set set = new set();
            set.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            set set = new set();
            set.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sys sys = new sys();
            sys.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            sys sys = new sys();
            sys.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Properties.Settings.Default.tuichu == true)
            {
                DialogResult dr = MessageBox.Show("是否退出CTK6?", "退出确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dr == DialogResult.OK)   //如果单击“是”按钮
                {
                    System.Environment.Exit(0);
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true; ;                 //不执行操作
                }
            }
            if (Properties.Settings.Default.tuichu == false)
            {
                System.Environment.Exit(0);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            hard hard = new hard();
            hard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            hard hard = new hard();
            hard.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lup lup = new lup();
            lup.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            lup lup = new lup();
            lup.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            soft soft = new soft();
            soft.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            soft soft = new soft();
            soft.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            internet internet = new internet();
            internet.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            internet internet = new internet();
            internet.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.Hide();
            file file = new file();
            file.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            file file = new file();
            file.Show();
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button9_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.AIDA64 = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button11_Click(object sender, EventArgs e)
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

        private void button10_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Dism = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button13_Click(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PCMaster = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button15_Click(object sender, EventArgs e)
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

        private void button14_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UltimateDefrag = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button17_Click(object sender, EventArgs e)
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

        private void button19_Click(object sender, EventArgs e)
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

        private void button23_Click(object sender, EventArgs e)
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

        private void button25_Click(object sender, EventArgs e)
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

        private void button16_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.BSV = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CMM = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Rufus = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WindowSize = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.WinNTSetup = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button27_Click(object sender, EventArgs e)
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

        private void button29_Click(object sender, EventArgs e)
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

        private void button31_Click(object sender, EventArgs e)
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

        private void button26_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CPUZ = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RT = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.GPUZ = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button33_Click(object sender, EventArgs e)
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

        private void button35_Click(object sender, EventArgs e)
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

        private void button32_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Bandicam = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.STG = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button39_Click(object sender, EventArgs e)
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

        private void button51_Click(object sender, EventArgs e)
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

        private void button47_Click(object sender, EventArgs e)
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

        private void button37_Click(object sender, EventArgs e)
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

        private void button41_Click(object sender, EventArgs e)
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

        private void button43_Click(object sender, EventArgs e)
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

        private void button45_Click(object sender, EventArgs e)
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

        private void button50_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HK = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Deskpins = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.MouseInc = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.OT = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RH = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.RU = false;
            Properties.Settings.Default.Save();
            a();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FP = false;
            Properties.Settings.Default.Save();
            a();
        }
    }
}