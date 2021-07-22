using CefSharp;
using CefSharp.SchemeHandler;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
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

            //Not the best way for allowing it to edit across threads but it works for now
            Form1.CheckForIllegalCrossThreadCalls = false;
        }

        public ChromiumWebBrowser browser;
        bool AppStarting = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Simple check to see if you are on the latest version of the app
            WebClient client = new WebClient();
            double reply = double.Parse(client.DownloadString("https://zeesdesign.com/AGUI/version.txt"));
            
            //if the reply dosnt equal current version then enable update notification button
            if (reply != 1.4)
            {
                guna2ImageButton1.Visible = true;
            }

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

            //pervents the notfication panel from showing on startup due to setting checkbox values
            AppStarting = false;
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

        private async void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
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

            //Notify of setting change
            if (!AppStarting)
            {
                //Show notification panel
                notificationpanel.Visible = true;
                notificationlabel.Text = "Success";

                //Set label text depending on checkbox state
                if (Settings.Default.DB)
                {
                    label1.Text = "Editior has been updated to the development build!";
                }
                else
                {
                    label1.Text = "Editior has been updated to the release build!";
                }

                //Wait before hiding panel
                await Task.Delay(3000);

                //Hide notification panel
                notificationpanel.Visible = false;
            }
        }

        private async void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Save Checkbox
            Settings.Default.Autosave = guna2CheckBox2.Checked;
            Settings.Default.Save();

            //Notify of setting change
            if (!AppStarting)
            {
                //Show notification panel
                notificationpanel.Visible = true;
                notificationlabel.Text = "Success";

                //Set label text depending on checkbox state
                if (Settings.Default.Autosave)
                {
                    label1.Text = "Auto-Save to projects folder has been enabled!";
                }
                else
                {
                    label1.Text = "Auto-Save to projects folder has been disabled!";
                }

                //Wait before hiding panel
                await Task.Delay(3000);

                //Hide notification panel
                notificationpanel.Visible = false;
            }
        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            //Goto the apps download page when clicked
            Process.Start("https://github.com/I-Am-Zee/Advanced-GUI-Winforms-App/releases");
        }
    }
}
