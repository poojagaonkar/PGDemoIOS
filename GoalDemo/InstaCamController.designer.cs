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
	[Register ("InstaCamController")]
	partial class InstaCamController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIImageView instaCamPic { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (instaCamPic != null) {
				instaCamPic.Dispose ();
				instaCamPic = null;
			}
		}
	}
}
