using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_GUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Form1 fc = (Form1)Application.OpenForms["Form1"];

        private void Form3_Load(object sender, EventArgs e)
        {
            guna2CheckBox1.Checked = Settings.Default.DB;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.DB = guna2CheckBox1.Checked;
            Settings.Default.Save();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Settings.Default.DB = guna2CheckBox1.Checked;
            Settings.Default.Save();

            if (Settings.Default.DB)
            {
                if (fc != null)
                {
                    fc.browser.Load("https://development.advancedgui.app/");
                }
            }
            else
            {
                if (fc != null)
                {
                    fc.browser.Load("https://advancedgui.app/");
                }
            }
        }
    }
}
