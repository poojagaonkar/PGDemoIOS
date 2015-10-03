using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;

namespace GoalDemo
{
	public class RootTableSource : UITableViewSource
	{
		TimelineModel[] mData;
		public RootTableSource (TimelineModel[] mData)
		{
			this.mData = mData;
		}
		#region implemented abstract members of UITableViewSource
		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			var cell = tableView.DequeueReusableCell ("timelineCell");
			cell.TextLabel.Text = mData [indexPath.Row].UserName;
			cell.ImageView.Image =  UIImage.FromFile ("Images/"+mData[indexPath.Row].ImageName);
			//cell.DetailTextLabel.Text = mData [indexPath.Row].Detail;

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
