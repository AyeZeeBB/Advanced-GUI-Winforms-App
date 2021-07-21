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
            //Make sure settings panel is not visible
            panel1.Visible = false;

            //initilze Cefsharp settings
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

            //load checkboxes from saved settings
            guna2CheckBox1.Checked = Settings.Default.DB;
            guna2CheckBox2.Checked = Settings.Default.Autosave;

            //Add browser to form
            this.Controls.Add(browser);
            //setup download handler
            browser.DownloadHandler = new DownloadHandler();
            browser.Dock = DockStyle.Fill;

            //Fix for docking issue i was having
            browser.BringToFront();
            panel1.BringToFront();
            resizebox.BringToFront();
            notificationpanel.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Hide notification panel if the close button is pressed
            notificationpanel.Visible = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Make sure the processes closes
            Application.Exit();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            //Open or close settings panel based on if its visible or not
            if(panel1.Visible)
            {
                panel1.Visible = false;
            }
            else
            {
                panel1.Visible = true;
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            //Save Settings
            Settings.Default.DB = guna2CheckBox1.Checked;
            Settings.Default.Autosave = guna2CheckBox2.Checked;
            Settings.Default.Save();

            //Set Settings panel to not visible after apply
            panel1.Visible = false;
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Save Checkbox
            Settings.Default.DB = guna2CheckBox1.Checked;
            Settings.Default.Save();

            //Load new webeditor based settings
            if (Settings.Default.DB)
            {
                browser.Load("https://development.advancedgui.app/");
            }
            else
            {
                browser.Load("https://advancedgui.app/");
            }
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Save Checkbox
            Settings.Default.Autosave = guna2CheckBox2.Checked;
            Settings.Default.Save();
        }
    }
}
