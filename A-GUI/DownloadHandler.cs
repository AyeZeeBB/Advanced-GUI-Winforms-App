using CefSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A_GUI
{
    public class DownloadHandler : IDownloadHandler
    {
        public event EventHandler<DownloadItem> OnBeforeDownloadFired;

        public event EventHandler<DownloadItem> OnDownloadUpdatedFired;

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            if (Settings.Default.Autosave)
            {
                if (File.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Projects\\" + downloadItem.SuggestedFileName))
                {
                    File.Delete(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Projects\\" + downloadItem.SuggestedFileName);
                }
            }

            OnBeforeDownloadFired?.Invoke(this, downloadItem);

            if (!callback.IsDisposed)
            {

                using (callback)
                {
                    if (Settings.Default.Autosave)
                    {
                        callback.Continue(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Projects\\" + downloadItem.SuggestedFileName, showDialog: false);
                    }
                    else
                    {
                        callback.Continue(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Projects\\" + downloadItem.SuggestedFileName, showDialog: true);
                    }
                }
            }
        }

        Form1 fc = (Form1)Application.OpenForms["Form1"];    

    public async void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            OnDownloadUpdatedFired?.Invoke(this, downloadItem);

            if (downloadItem.IsValid)
            {
                // Show progress of the download
                if (downloadItem.IsInProgress && (downloadItem.PercentComplete != 0))
                {
                    if (fc != null)
                    {
                        fc.notificationpanel.Visible = true;
                        fc.notificationlabel.Text = String.Format("Current Download Speed: {0} bytes ({1}%)", downloadItem.CurrentSpeed, downloadItem.PercentComplete);
                    }
                }

                if (downloadItem.IsComplete)
                {
                    if (fc != null)
                    {
                        fc.notificationlabel.Text = "File has been downloaded to " + System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Projects\\" + downloadItem.SuggestedFileName;
                        await Task.Delay(5000);
                        fc.notificationpanel.Visible = false;
                    }
                }

                if(downloadItem.IsCancelled)
                {
                    fc.notificationpanel.Visible = false;
                }
            }
        }
    }
}
