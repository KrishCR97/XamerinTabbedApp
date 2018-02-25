using System;

using UIKit;

namespace BasicTabbedBarApp
{
    public partial class SecondViewController : UIViewController
    {
        protected SecondViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }
        public override void ViewWillAppear(bool animated){
            base.ViewWillAppear(animated);
            double total = AppDelegate.fourHours + AppDelegate.sixHours 
                                      + AppDelegate.eightHours + AppDelegate.moreThanEightHours;
            selected4HrsLBL.Text = ((AppDelegate.fourHours / total)*100).ToString("0.0") + "% of people sleep 4 hours";
            selected6HrsLBL.Text = ((AppDelegate.sixHours / total)*100).ToString("0.0") + "% of people sleep 6 hours";
            selected8HrsLBL.Text = ((AppDelegate.eightHours / total)*100).ToString("0.0") + "% of people sleep 8 hours";
            selectedGT8HrsLBL.Text = ((AppDelegate.moreThanEightHours)*100 / total).ToString("0.0") + "% of people sleep more than 8 hours";

        }


        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            double total = AppDelegate.fourHours + AppDelegate.sixHours
                                     + AppDelegate.eightHours + AppDelegate.moreThanEightHours;
            selected4HrsLBL.Text = AppDelegate.fourHours / total + "% of people sleep 4 hours";
            selected6HrsLBL.Text = AppDelegate.sixHours / total + "% of people sleep 6 hours";
            selected8HrsLBL.Text = AppDelegate.eightHours / total + "% of people sleep 8 hours";
            selectedGT8HrsLBL.Text = AppDelegate.moreThanEightHours / total + "% of people sleep more than 8 hours";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
