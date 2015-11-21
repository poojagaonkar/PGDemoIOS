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
	[Register ("TwitterHomeController")]
	partial class TwitterHomeController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView TwitterHomeView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (TwitterHomeView != null) {
				TwitterHomeView.Dispose ();
				TwitterHomeView = null;
			}
		}
	}
}
