using System;
using UIKit;
using System.Collections.Generic;

namespace GoalDemo
{
	public class TwitterHomeSource : UITableViewSource
	{
		private LinqToTwitter.Status[] mFeedList;
		private TwitterHomeCell cell;
		public TwitterHomeSource (LinqToTwitter.Status[] feedList)
		{
			this.mFeedList = feedList;
		}

		#region implemented abstract members of UITableViewSource

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{

				cell = tableView.DequeueReusableCell ("twitterHomeCell") as TwitterHomeCell;
				var item = mFeedList [indexPath.Row];
				cell.UpdateCell (item.User.Name, item.User.ProfileImageUrl, item.Text, item.User.ScreenNameResponse, item.CreatedAt);

			return cell;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return mFeedList.Length;
		}

		#endregion
	}
}

