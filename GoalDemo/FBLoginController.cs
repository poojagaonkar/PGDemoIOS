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

			btnLogin.TouchDown += BtnLogin_TouchDown;
		}

		void BtnLogin_TouchDown (object sender, EventArgs e)
		{
			
			UIViewController flyoutVC = (FBMenuController)this.Storyboard.InstantiateViewController("FBMenuController");
			PresentViewController(flyoutVC, true, null);
		}
	}
}
