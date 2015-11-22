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
	[Register ("TwitterMeController")]
	partial class TwitterMeController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imgMyProfile { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelMyHandle { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelMyName { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (imgMyProfile != null) {
				imgMyProfile.Dispose ();
				imgMyProfile = null;
			}
			if (labelMyHandle != null) {
				labelMyHandle.Dispose ();
				labelMyHandle = null;
			}
			if (labelMyName != null) {
				labelMyName.Dispose ();
				labelMyName = null;
			}
		}
	}
}
