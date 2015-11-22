using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreAnimation;

namespace GoalDemo
{
	partial class TwitterMeStaticCell : UITableViewCell
	{
		public TwitterMeStaticCell (IntPtr handle) : base (handle)
		{
		}
		public void UpdateCell (string imageUrl,string myName,string myHandle, string myBack,string myFriends,string myFollowers,string noOfTweets,DateTime postDate)
		{
			labelMyHandle.Text = "@"+myHandle;
			labelTweetText.Text = "";
			labelMyName.Text = myName;

			imgMyProfile.Image = FromUrl (imageUrl);
			CALayer profileImageCircle = imgMyProfile.Layer;
			profileImageCircle.CornerRadius = 10;
			profileImageCircle.MasksToBounds = true;

			labelTweetTime.Text = CalculateRelativeTime.RelativeTime(postDate);
			labelFollowers.Text = myFollowers;

			labelFollowing.Text = myFriends;
			labelMyTweets.Text = noOfTweets;


		}
		static UIImage FromUrl (string uri)
		{
			using (var url = new NSUrl (uri))
			using (var data = NSData.FromUrl (url))
				return UIImage.LoadFromData (data);
		}
	}
}
