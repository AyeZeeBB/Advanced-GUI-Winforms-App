using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Not the best fix for allowing it to edit label1 across threads but it works for now
            Form1.CheckForIllegalCrossThreadCalls = false;
        }

        public ChromiumWebBrowser browser;

        private void Form1_Load(object sender, EventArgs e)
        {
            var settings = new CefSettings();
            settings.CachePath = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/Cache";
            settings.PersistSessionCookies = true;
            Cef.Initialize(settings);

            //Create a point browser to Advanced GUIS webpage depending on setting selected
            if (Settings.Default.DB == true)
            {
                browser = new ChromiumWebBrowser("https://development.advancedgui.app/");
            }
            else
            {
                browser = new ChromiumWebBrowser("https://advancedgui.app/");
            }

            this.Controls.Add(browser);
            browser.DownloadHandler = new DownloadHandler();
            browser.Dock = DockStyle.Fill;

            //Fix docking issue i was having
            browser.BringToFront();
            resizebox.BringToFront();
            notificationpanel.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            notificationpanel.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }
    }
}
