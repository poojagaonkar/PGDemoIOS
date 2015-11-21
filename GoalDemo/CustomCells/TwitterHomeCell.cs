using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Drawing;
using CoreAnimation;

namespace GoalDemo
{
	partial class TwitterHomeCell : UITableViewCell
	{
		public TwitterHomeCell (IntPtr handle) : base (handle)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Gray;
		}
		public void UpdateCell (string name, string image, string tweet, string handle, DateTime postDate)
		{
			labelHandle.Text = "@"+handle;
			labelTweetText.Text = tweet;
			labelUserName.Text = name;

			imgProfilePic.Image = FromUrl (image);
			CALayer profileImageCircle = imgProfilePic.Layer;
			profileImageCircle.CornerRadius = 10;
			profileImageCircle.MasksToBounds = true;

			labelTweetTime.Text = CalculateRelativeTime.RelativeTime(postDate);


				

		}
		static UIImage FromUrl (string uri)
		{
			using (var url = new NSUrl (uri))
			using (var data = NSData.FromUrl (url))
				return UIImage.LoadFromData (data);
		}
	}
}
