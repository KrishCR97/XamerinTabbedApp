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
    [Register ("FirstViewController")]
    partial class FirstViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton 4hoursBTN { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton 6hoursBTN { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton 8hoursBTN { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton moreThan8HoursBTN { get; set; }

        [Action ("UIButton602_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton602_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (4hoursBTN != null) {
                4hoursBTN.Dispose ();
                4hoursBTN = null;
            }

            if (6hoursBTN != null) {
                6hoursBTN.Dispose ();
                6hoursBTN = null;
            }

            if (8hoursBTN != null) {
                8hoursBTN.Dispose ();
                8hoursBTN = null;
            }

            if (moreThan8HoursBTN != null) {
                moreThan8HoursBTN.Dispose ();
                moreThan8HoursBTN = null;
            }
        }
    }
}