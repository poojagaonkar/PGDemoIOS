// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace GoalDemo
{
	[Register ("FBMenuController")]
	partial class FBMenuController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView FBMenuView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (FBMenuView != null) {
				FBMenuView.Dispose ();
				FBMenuView = null;
			}
		}
	}
}
