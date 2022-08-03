using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTK6
{
    public partial class set : Form
    {
        public set()
        {
            InitializeComponent();
        }

        private void set_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.bro == true)
            {
                radioButton7.Checked = true;
            }
            else
            {
                radioButton8.Checked = true;
            }
            if (Properties.Settings.Default.tuichu == true)
            {
                radioButton5.Checked = true;
            }
            else
            {
                radioButton6.Checked = true;
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton7.Checked==true)
            {
                Properties.Settings.Default.bro = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.bro = false;
                Properties.Settings.Default.Save();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                Properties.Settings.Default.tuichu = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.tuichu = false;
                Properties.Settings.Default.Save();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
        }
    }
}
