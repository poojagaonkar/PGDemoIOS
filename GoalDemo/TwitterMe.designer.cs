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
	[Register ("TwitterMe")]
	partial class TwitterMe
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelFollowers { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelFollowing { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelNoTweets { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelUserHandle { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelUserName { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView twitProfileImage { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (labelFollowers != null) {
				labelFollowers.Dispose ();
				labelFollowers = null;
			}
			if (labelFollowing != null) {
				labelFollowing.Dispose ();
				labelFollowing = null;
			}
			if (labelNoTweets != null) {
				labelNoTweets.Dispose ();
				labelNoTweets = null;
			}
			if (labelUserHandle != null) {
				labelUserHandle.Dispose ();
				labelUserHandle = null;
			}
			if (labelUserName != null) {
				labelUserName.Dispose ();
				labelUserName = null;
			}
			if (twitProfileImage != null) {
				twitProfileImage.Dispose ();
				twitProfileImage = null;
			}
		}
	}
}
