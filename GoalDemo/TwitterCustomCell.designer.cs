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
	[Register ("TwitterCustomCell")]
	partial class TwitterCustomCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView imageProfile { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelDetail { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelHandle { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelTimeStamp { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelUserName { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (imageProfile != null) {
				imageProfile.Dispose ();
				imageProfile = null;
			}
			if (labelDetail != null) {
				labelDetail.Dispose ();
				labelDetail = null;
			}
			if (labelHandle != null) {
				labelHandle.Dispose ();
				labelHandle = null;
			}
			if (labelTimeStamp != null) {
				labelTimeStamp.Dispose ();
				labelTimeStamp = null;
			}
			if (labelUserName != null) {
				labelUserName.Dispose ();
				labelUserName = null;
			}
		}
	}
}
