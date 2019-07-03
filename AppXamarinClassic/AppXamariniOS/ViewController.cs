using AppXamarin;
using Foundation;
using System;
using UIKit;

namespace AppXamariniOS
{
    public partial class ViewController : UIViewController
    {
        private DataService _dataService;

        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            _dataService = new DataService();
        }

        async partial void onLoadDataClick(UIButton sender)
        {
            lblData.Text = await _dataService.LoadData();
        }
    }
}