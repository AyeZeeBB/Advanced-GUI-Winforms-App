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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form1 f = new Form1();
        private async void Form2_Load(object sender, EventArgs e)
        {
            this.Activate();

            //For Preloading the Main form so the CefSharp browser can load in before showing.
            //Not needed, just so it dosnt show a white screen before the browser page loads.
            f.Show();
            f.Hide();

            await Task.Delay(2000);

            this.Hide();
            f.Show();
        }
    }
}
