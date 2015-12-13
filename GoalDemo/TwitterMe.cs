using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using CoreAnimation;

namespace GoalDemo
{
	partial class TwitterMe : UIViewController
	{
		public TwitterMe (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var prefs = NSUserDefaults.StandardUserDefaults;
			this.NavigationController.Title = "Profile";
			/*NSUserDefaults.StandardUserDefaults.SetString(imageUrl, "MyProfileImage"); 
			NSUserDefaults.StandardUserDefaults.SetString(myName, "MyName");
			NSUserDefaults.StandardUserDefaults.SetString(myHandle, "MyHandle");
			NSUserDefaults.StandardUserDefaults.SetString(myBackgroundImg, "MyBackImage");
			NSUserDefaults.StandardUserDefaults.SetString(myFollowers, "MyFollowers");
			NSUserDefaults.StandardUserDefaults.SetString(myFriends, "MFriends");
			NSUserDefaults.StandardUserDefaults.SetString(noOfTweets, "noOfTweets");*/
			labelUserName.Text = prefs.StringForKey ("MyName");
			labelUserHandle.Text = prefs.StringForKey ("MyHandle");
			labelFollowers.Text = prefs.StringForKey ("MyFollowers");
			labelFollowing.Text = prefs.StringForKey ("MFriends");
			labelNoTweets.Text = prefs.StringForKey ("noOfTweets") +" "+"Tweets";
			twitProfileImage.Image = FromUrl (prefs.StringForKey ("MyProfileImage"));
			CALayer profileImageCircle = twitProfileImage.Layer;
			profileImageCircle.CornerRadius = 10;
			profileImageCircle.MasksToBounds = true;
		}
		static UIImage FromUrl (string uri)
		{
			using (var url = new NSUrl (uri))
			using (var data = NSData.FromUrl (url))
				return UIImage.LoadFromData (data);
		}
	}
}
