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
			var cell = tableView.DequeueReusableCell ("timelineCell") as TimelineCustomCel;
			cell.UpdateCell(mData [indexPath.Row].UserName, UIImage.FromFile (mData[indexPath.Row].ImageName),mData [indexPath.Row].Detail,mData [indexPath.Row].NumLikes, mData [indexPath.Row].NumComments,mData [indexPath.Row].PostDate );
		

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
		public override nfloat GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
		{
			return 182;
		}
	}

}
