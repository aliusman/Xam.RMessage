using System;

using UIKit;

namespace Xam.RMessage.iOS
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
          
            RMessage.SetDefaultViewController(this);

            RMessage.ShowNotificationWithTitle("Connessione Assente","Ho bisogno di una connessione!",RMessageType.Error,string.Empty,()=>{});

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
