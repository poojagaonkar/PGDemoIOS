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
	[Register ("TimelineCustomCel")]
	partial class TimelineCustomCel
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel detailLabel { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imgProfilePic { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelUsername { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (detailLabel != null) {
				detailLabel.Dispose ();
				detailLabel = null;
			}
			if (imgProfilePic != null) {
				imgProfilePic.Dispose ();
				imgProfilePic = null;
			}
			if (labelUsername != null) {
				labelUsername.Dispose ();
				labelUsername = null;
			}
		}
	}
}
