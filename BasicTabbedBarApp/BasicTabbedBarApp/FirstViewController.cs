using System;

using UIKit;

namespace BasicTabbedBarApp
{
    public partial class FirstViewController : UIViewController
    {
        
        protected FirstViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void FourHoursBTN_TouchUpInside(UIButton sender)
        {
            AppDelegate.fourHours++;
        }

        partial void SixHoursBTN_TouchUpInside(UIButton sender)
        {
            AppDelegate.sixHours++;
        }

        partial void EightHoursBTN_TouchUpInside(UIButton sender)
        {
            AppDelegate.eightHours++;
        }

        partial void MoreThan8HoursBTN_TouchUpInside(UIButton sender)
        {
            AppDelegate.moreThanEightHours++;
        }
    }
}
