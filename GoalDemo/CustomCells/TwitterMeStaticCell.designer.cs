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
	[Register ("TwitterMeStaticCell")]
	partial class TwitterMeStaticCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imgMyProfile { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelFollowers { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelFollowing { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelMyHandle { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelMyName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelMyTweets { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelTweetText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelTweetTime { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (imgMyProfile != null) {
				imgMyProfile.Dispose ();
				imgMyProfile = null;
			}
			if (labelFollowers != null) {
				labelFollowers.Dispose ();
				labelFollowers = null;
			}
			if (labelFollowing != null) {
				labelFollowing.Dispose ();
				labelFollowing = null;
			}
			if (labelMyHandle != null) {
				labelMyHandle.Dispose ();
				labelMyHandle = null;
			}
			if (labelMyName != null) {
				labelMyName.Dispose ();
				labelMyName = null;
			}
			if (labelMyTweets != null) {
				labelMyTweets.Dispose ();
				labelMyTweets = null;
			}
			if (labelTweetText != null) {
				labelTweetText.Dispose ();
				labelTweetText = null;
			}
			if (labelTweetTime != null) {
				labelTweetTime.Dispose ();
				labelTweetTime = null;
			}
		}
	}
}
