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
        UIKit.UIButton eightHoursBTN { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton fourHoursBTN { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton moreThan8HoursBTN { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton sixHoursBTN { get; set; }

        [Action ("EightHoursBTN_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void EightHoursBTN_TouchUpInside (UIKit.UIButton sender);

        [Action ("FourHoursBTN_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FourHoursBTN_TouchUpInside (UIKit.UIButton sender);

        [Action ("MoreThan8HoursBTN_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void MoreThan8HoursBTN_TouchUpInside (UIKit.UIButton sender);

        [Action ("SixHoursBTN_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SixHoursBTN_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (eightHoursBTN != null) {
                eightHoursBTN.Dispose ();
                eightHoursBTN = null;
            }

            if (fourHoursBTN != null) {
                fourHoursBTN.Dispose ();
                fourHoursBTN = null;
            }

            if (moreThan8HoursBTN != null) {
                moreThan8HoursBTN.Dispose ();
                moreThan8HoursBTN = null;
            }

            if (sixHoursBTN != null) {
                sixHoursBTN.Dispose ();
                sixHoursBTN = null;
            }
        }
    }
}