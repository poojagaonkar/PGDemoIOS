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
	[Register ("TwitterHomeCell")]
	partial class TwitterHomeCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imgProfilePic { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelHandle { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelTweetText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelTweetTime { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelUserName { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (imgProfilePic != null) {
				imgProfilePic.Dispose ();
				imgProfilePic = null;
			}
			if (labelHandle != null) {
				labelHandle.Dispose ();
				labelHandle = null;
			}
			if (labelTweetText != null) {
				labelTweetText.Dispose ();
				labelTweetText = null;
			}
			if (labelTweetTime != null) {
				labelTweetTime.Dispose ();
				labelTweetTime = null;
			}
			if (labelUserName != null) {
				labelUserName.Dispose ();
				labelUserName = null;
			}
		}
	}
}
