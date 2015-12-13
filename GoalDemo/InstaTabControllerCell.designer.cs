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
	[Register ("InstaTabControllerCell")]
	partial class InstaTabControllerCell
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView btn { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView btnComment { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnLike { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView btnReply { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel instaLabelStatis { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView instaPic { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView instaProfileImage { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelInstaUser { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UILabel labelInstaUser1 { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (btn != null) {
				btn.Dispose ();
				btn = null;
			}
			if (btnComment != null) {
				btnComment.Dispose ();
				btnComment = null;
			}
			if (btnLike != null) {
				btnLike.Dispose ();
				btnLike = null;
			}
			if (btnReply != null) {
				btnReply.Dispose ();
				btnReply = null;
			}
			if (instaLabelStatis != null) {
				instaLabelStatis.Dispose ();
				instaLabelStatis = null;
			}
			if (instaPic != null) {
				instaPic.Dispose ();
				instaPic = null;
			}
			if (instaProfileImage != null) {
				instaProfileImage.Dispose ();
				instaProfileImage = null;
			}
			if (labelInstaUser != null) {
				labelInstaUser.Dispose ();
				labelInstaUser = null;
			}
			if (labelInstaUser1 != null) {
				labelInstaUser1.Dispose ();
				labelInstaUser1 = null;
			}
		}
	}
}
