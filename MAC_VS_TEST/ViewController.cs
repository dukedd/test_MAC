using System;

using AppKit;
using Foundation;

namespace MAC_VS_TEST
{
    public partial class ViewController : NSViewController
    {
        private int numberofTimesClicked = 0;
        private int numberofTimesClicked1 = 0;
        private int numberofTimesClicked2 = 0;
        private int numberofTimesClicked3 = 0;
        private int numberofTimesClicked4 = 0;
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();


            // Set the initial value for the label
            ClickedLabel.StringValue = "Totally Clicked 0 time.";
            ClickedLabel1.StringValue = "Button has not been clicked yet.";
            ClickedLabel2.StringValue = "Button has not been clicked yet.";
            ClickedLabel3.StringValue = "Button has not been clicked yet.";
            ClickedLabel4.StringValue = "Button has not been clicked yet.";

        }


        partial void ClickedButton1(Foundation.NSObject sender)
        {

            // Update counter and label
            ++numberofTimesClicked;
            ++numberofTimesClicked1;
            ClickedLabel.StringValue = string.Format("Totally Clicked {0} time{1}.", numberofTimesClicked, (numberofTimesClicked < 2) ? "" : "s");
            ClickedLabel1.StringValue = string.Format("This button has been clicked {0} time{1}.", numberofTimesClicked1, (numberofTimesClicked1 < 2) ? "" : "s");
        }

        partial void ClickedButton2(Foundation.NSObject sender)
        {

            // Update counter and label
            ++numberofTimesClicked;
            ++numberofTimesClicked2;
            ClickedLabel.StringValue = string.Format("Totally Clicked {0} time{1}.", numberofTimesClicked, (numberofTimesClicked < 2) ? "" : "s");
            ClickedLabel2.StringValue = string.Format("This button has been clicked {0} time{1}.", numberofTimesClicked2, (numberofTimesClicked2 < 2) ? "" : "s");
        }

        partial void ClickedButton3(Foundation.NSObject sender)
        {

            // Update counter and label
            ++numberofTimesClicked;
            ++numberofTimesClicked3;
            ClickedLabel.StringValue = string.Format("Totally Clicked {0} time{1}.", numberofTimesClicked, (numberofTimesClicked < 2) ? "" : "s");
            ClickedLabel3.StringValue = string.Format("This button has been clicked {0} time{1}.", numberofTimesClicked3, (numberofTimesClicked3 < 2) ? "" : "s");
        }

        partial void ClickedButton4(Foundation.NSObject sender)
        {

            // Update counter and label
            ++numberofTimesClicked;
            ++numberofTimesClicked4;
            ClickedLabel.StringValue = string.Format("Totally Clicked {0} time{1}.", numberofTimesClicked, (numberofTimesClicked < 2) ? "" : "s");
            ClickedLabel4.StringValue = string.Format("This button has been clicked {0} time{1}.", numberofTimesClicked4, (numberofTimesClicked4 < 2) ? "" : "s");
        }


        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }
    }
}
