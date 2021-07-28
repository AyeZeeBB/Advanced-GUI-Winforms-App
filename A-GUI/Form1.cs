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
        int time = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Settings.Default.UpdateCheck)
            {
                try
                {
                    //Simple check to see if you are on the latest version of the app
                    WebClient client = new WebClient();
                    double reply = double.Parse(client.DownloadString("https://pastebin.com/raw/EUtysBEK"));

                    //if the reply dosnt equal current version then enable update notification button
                    if (reply != 1.6)
                    {
                        guna2ImageButton1.Visible = true;
                    }
                }
                catch
                {
                    guna2ImageButton1.Visible = false;
                }
            }
            

            //Make sure settings panel is not visible
            panel1.Visible = false;

            //initilze Cefsharp settings
            var settings = new CefSettings();
            settings.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AdvancedGUI\\Cache";
            settings.LocalesDirPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AdvancedGUI\\Locales";
            settings.UserDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AdvancedGUI\\UserData";
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
            guna2CheckBox3.Checked = Settings.Default.UpdateCheck;

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

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //Save Checkbox
            Settings.Default.DB = guna2CheckBox1.Checked;
            Settings.Default.Save();

            if (!AppStarting)
            {
                //Load new webeditor based on settings
                if (Settings.Default.DB)
                {
                    browser.Load("https://development.advancedgui.app/");
                }
                else
                {
                    browser.Load("https://advancedgui.app/");
                }

                //Set label text depending on checkbox state
                if (Settings.Default.DB)
                {
                    ShowNotify("Success: Editior has been updated to the development build!");
                }
                else
                {
                    ShowNotify("Success: Editior has been updated to the release build!");
                }
            }
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            //Save Checkbox
            Settings.Default.Autosave = guna2CheckBox2.Checked;
            Settings.Default.Save();

            //Notify of setting change
            if (!AppStarting)
            {
                //Set label text depending on checkbox state
                if (Settings.Default.Autosave)
                {
                    ShowNotify("Success: Auto-Save to projects folder has been enabled!");
                }
                else
                {
                    ShowNotify("Success: Auto-Save to projects folder has been disabled!");
                }
            }
        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            //Goto the apps download page when clicked
            Process.Start("https://github.com/I-Am-Zee/Advanced-GUI-Winforms-App/releases");
        }

        private void guna2CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            //Save Checkbox
            Settings.Default.UpdateCheck = guna2CheckBox3.Checked;
            Settings.Default.Save();

            //Notify of setting change
            if (!AppStarting)
            {
                //Set label text depending on checkbox state
                if (Settings.Default.UpdateCheck)
                {
                    ShowNotify("Success: You will be notified for updates!");
                }
                else
                {
                    ShowNotify("Success: You will not be notified for updates!");
                }
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            //Hide notification panel if the close button is pressed
            timer1.Enabled = false;
            guna2Transition1.Hide(notificationpanel);
        }

        public void ShowNotify(string message)
        {
            //Show notification panel
            guna2Transition1.Show(notificationpanel);

            notificationlabel.Text = message;

            //Wait before hiding panel
            time = 0;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            if (time > 200)
            {
                timer1.Enabled = false;
                guna2Transition1.Hide(notificationpanel);
            }
        }
    }
}
