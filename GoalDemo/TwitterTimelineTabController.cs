using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace GoalDemo
{
	partial class TwitterTimelineTabController : UITabBarController
	{
		public TwitterTimelineTabController (IntPtr handle) : base (handle)
		{
		}
		public TwitterTimelineTabController(string mList)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			new UIAlertView ("REcieved", "List", null, "OK", null).Show ();
		}
	}
}
