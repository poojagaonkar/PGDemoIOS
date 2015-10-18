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
	[Register ("TwitterController")]
	partial class TwitterController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView TwitterView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (TwitterView != null) {
				TwitterView.Dispose ();
				TwitterView = null;
			}
		}
	}
}
