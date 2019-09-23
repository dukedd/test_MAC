// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MAC_VS_TEST
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        AppKit.NSTextField ClickedLabel { get; set; }   

        [Outlet]
        AppKit.NSTextField ClickedLabel1 { get; set; }

        [Outlet]
        AppKit.NSTextField ClickedLabel2 { get; set; }

        [Outlet]
        AppKit.NSTextField ClickedLabel3 { get; set; }

        [Outlet]
        AppKit.NSTextField ClickedLabel4 { get; set; }

        [Action ("ClickedButton1:")]
        partial void ClickedButton1 (Foundation.NSObject sender);

        [Action ("ClickedButton2:")]
        partial void ClickedButton2 (Foundation.NSObject sender);

        [Action ("ClickedButton3:")]
        partial void ClickedButton3 (Foundation.NSObject sender);

        [Action ("ClickedButton4:")]
        partial void ClickedButton4 (Foundation.NSObject sender);
        
        void ReleaseDesignerOutlets ()
        {
            if (ClickedLabel1 != null) {
                ClickedLabel1.Dispose ();
                ClickedLabel1 = null;
            }

            if (ClickedLabel2 != null) {
                ClickedLabel2.Dispose ();
                ClickedLabel2 = null;
            }

            if (ClickedLabel3 != null) {
                ClickedLabel3.Dispose ();
                ClickedLabel3 = null;
            }

            if (ClickedLabel4 != null) {
                ClickedLabel4.Dispose ();
                ClickedLabel4 = null;
            }

            if (ClickedLabel != null) {
                ClickedLabel.Dispose ();
                ClickedLabel = null;
            }
        }
    }
}
