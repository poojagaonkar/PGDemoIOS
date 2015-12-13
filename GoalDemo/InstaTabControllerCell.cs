using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace GoalDemo
{
	partial class InstaTabControllerCell : UITableViewCell
	{
		public InstaTabControllerCell (IntPtr handle) : base (handle)
		{
		}
		public void UpdateCell (string name, UIImage image, string detail, int likes, int comment, DateTime postDate, UIImage postImage)
		{
			instaProfileImage.Image = image;
			labelInstaUser.Text = name;
			instaLabelStatis.Text = detail;
			labelInstaUser1.Text = name;
			instaPic.Image = postImage;


			btnLike.TouchUpInside += delegate {
				new UIAlertView("Like", "You liked this post", null, "OK", null).Show();
			};
		}
	}
}
