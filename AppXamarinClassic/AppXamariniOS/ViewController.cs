using Foundation;
using System;
using System.Net;
using UIKit;

namespace AppXamariniOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        async partial void onLoadDataClick(UIButton sender)
        {
            var client = new WebClient();
            var data = await client.DownloadStringTaskAsync("https://mobiletests.getsandbox.com/ping");
            lblData.Text = data;
        }
    }
}