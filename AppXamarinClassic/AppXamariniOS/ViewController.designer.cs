// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace AppXamariniOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLoadData { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblData { get; set; }

        [Action ("onLoadDataClick:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void onLoadDataClick (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnLoadData != null) {
                btnLoadData.Dispose ();
                btnLoadData = null;
            }

            if (lblData != null) {
                lblData.Dispose ();
                lblData = null;
            }
        }
    }
}