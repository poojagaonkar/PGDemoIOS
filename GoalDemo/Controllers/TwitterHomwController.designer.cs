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
	[Register ("TwitterHomwController")]
	partial class TwitterHomwController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView twitterHomeTableView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (twitterHomeTableView != null) {
				twitterHomeTableView.Dispose ();
				twitterHomeTableView = null;
			}
		}
	}
}
