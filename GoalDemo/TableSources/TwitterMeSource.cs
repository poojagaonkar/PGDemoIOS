using System;
using UIKit;
using Foundation;

namespace GoalDemo
{
	public class TwitterMeSource: UITableViewSource
	{ 
		private TwitterMeStaticCell cell;
		private LinqToTwitter.Status[] mFeedList;
		public TwitterMeSource (LinqToTwitter.Status[] feedList)
		{
			this.mFeedList = feedList;
		}

		#region implemented abstract members of UITableViewSource

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			cell = tableView.DequeueReusableCell ("twitterMeCell") as TwitterMeStaticCell;
			//var item = mFeedList [indexPath.Row];
			//cell.UpdateCell (item.User.Name, item.User.ProfileImageUrl, item.Text, item.User.ScreenNameResponse, item.CreatedAt);
			string imageUrl = NSUserDefaults.StandardUserDefaults.StringForKey("MyProfileImage"); 
			string myName = NSUserDefaults.StandardUserDefaults.StringForKey("MyName");
			string myHandle = NSUserDefaults.StandardUserDefaults.StringForKey("MyHandle");
			string myBack = NSUserDefaults.StandardUserDefaults.StringForKey("MyBackImage");
			string myFollowers = NSUserDefaults.StandardUserDefaults.StringForKey("MyFollowers");
			string myFriends = NSUserDefaults.StandardUserDefaults.StringForKey("MFriends");
			string noOfTweets = NSUserDefaults.StandardUserDefaults.StringForKey("noOfTweets");
			cell.UpdateCell (imageUrl,myName,myHandle,myBack,myFriends,myFollowers,noOfTweets,DateTime.Now);

			return cell;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			throw new NotImplementedException ();
		}

		#endregion
	}
}

