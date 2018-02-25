// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace BasicTabbedBarApp
{
    [Register ("SecondViewController")]
    partial class SecondViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel selected4HrsLBL { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel selected6HrsLBL { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel selected8HrsLBL { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel selectedGT8HrsLBL { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (selected4HrsLBL != null) {
                selected4HrsLBL.Dispose ();
                selected4HrsLBL = null;
            }

            if (selected6HrsLBL != null) {
                selected6HrsLBL.Dispose ();
                selected6HrsLBL = null;
            }

            if (selected8HrsLBL != null) {
                selected8HrsLBL.Dispose ();
                selected8HrsLBL = null;
            }

            if (selectedGT8HrsLBL != null) {
                selectedGT8HrsLBL.Dispose ();
                selectedGT8HrsLBL = null;
            }
        }
    }
}