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
            if (File.Exists(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Projects\\" + downloadItem.SuggestedFileName))
            {
                File.Delete(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Projects\\" + downloadItem.SuggestedFileName);
            }

            OnBeforeDownloadFired?.Invoke(this, downloadItem);

            if (!callback.IsDisposed)
            {

                using (callback)
                {
                    
                    callback.Continue(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Projects\\" + downloadItem.SuggestedFileName, showDialog: false);
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
                        fc.panel1.Visible = true;
                        fc.label1.Text = String.Format("Current Download Speed: {0} bytes ({1}%)", downloadItem.CurrentSpeed, downloadItem.PercentComplete);
                    }
                }

                if (downloadItem.IsComplete)
                {
                    if (fc != null)
                    {
                        fc.label1.Text = "File has been exported to " + System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Projects\\" + downloadItem.SuggestedFileName;
                        await Task.Delay(5000);
                        fc.panel1.Visible = false;
                    }
                }

                if(downloadItem.IsCancelled)
                {
                    fc.panel1.Visible = false;
                }
            }
        }
    }
}
