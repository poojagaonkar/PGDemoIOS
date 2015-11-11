using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace GoalDemo
{
	partial class FBLoginController : UIViewController
	{
		public FBLoginController (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			btnLogin.TouchDown += delegate {
				UIViewController flyoutVC = new FBMenuController();
				PresentViewController(flyoutVC, true, null);
			};
		}
	}
}
