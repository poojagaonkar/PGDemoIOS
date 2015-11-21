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
	[Register ("TwitterNewHome")]
	partial class TwitterNewHome
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView twitHomeView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (twitHomeView != null) {
				twitHomeView.Dispose ();
				twitHomeView = null;
			}
		}
	}
}
