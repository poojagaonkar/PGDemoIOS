using System;
using UIKit;

namespace GoalDemo
{
	public class InstaTableSource : UITableViewSource
	{
		TimelineModel[] mData;
		InstaTabControllerCell cell;
		public InstaTableSource (TimelineModel[] mData)
		{
			this.mData = mData;
		}

		#region implemented abstract members of UITableViewSource

		public override UITableViewCell GetCell (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			cell = tableView.DequeueReusableCell ("instaReuseCell") as InstaTabControllerCell;
			cell.UpdateCell(mData [indexPath.Row].UserName, UIImage.FromFile (mData[indexPath.Row].ImageName),mData [indexPath.Row].Detail,mData [indexPath.Row].NumLikes, mData [indexPath.Row].NumComments,mData [indexPath.Row].PostDate,UIImage.FromFile (mData[indexPath.Row].PostImage) );


			return cell;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return mData.Length;
		}

		#endregion
		public TimelineModel GetItem(nint id){
			return mData [id];
		}
	}
}

