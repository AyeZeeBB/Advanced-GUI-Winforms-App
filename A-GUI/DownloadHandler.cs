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

        Form1 fc = (Form1)Application.OpenForms["Form1"];

        public void OnBeforeDownload(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IBeforeDownloadCallback callback)
        {
            //Check to see if autosave is enabled
            if (Settings.Default.Autosave)
            {
                //if so delete the old file if it exists
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
                    //Check to see if autosave is enabled so it can choose to auto save to the projects folder or show a save dialog
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

        public void OnDownloadUpdated(IWebBrowser chromiumWebBrowser, IBrowser browser, DownloadItem downloadItem, IDownloadItemCallback callback)
        {
            OnDownloadUpdatedFired?.Invoke(this, downloadItem);

            if (downloadItem.IsValid)
            {
                // Show progress of the download
                if (downloadItem.IsInProgress && (downloadItem.PercentComplete != 0))
                {
                    //Check to see if it can find the open form
                    if (fc != null)
                    {
                        fc.ShowNotify(String.Format("Downloading: Current Download Speed: {0} bytes ({1}%)", downloadItem.CurrentSpeed, downloadItem.PercentComplete));
                    }
                }

                if (downloadItem.IsComplete)
                {
                    //Check to see if it can find the open form
                    if (fc != null)
                    {
                        fc.ShowNotify("Success: File has been downloaded to " + System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Projects\\" + downloadItem.SuggestedFileName);
                    }
                }

                if(downloadItem.IsCancelled)
                {
                    //Check to see if it can find the open form
                    if (fc != null)
                    {
                        fc.ShowNotify("Error: Download has been canceled!");
                    }
                }
            }
        }
    }
}
