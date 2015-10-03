
using System;

using Foundation;
using UIKit;

namespace GoalDemo
{
	public class TimelineControllerCell : UITableViewCell
	{
		public static readonly NSString Key = new NSString ("TimelineControllerCell");

		public TimelineControllerCell () : base (UITableViewCellStyle.Value1, Key)
		{
			// TODO: add subviews to the ContentView, set various colors, etc.
			TextLabel.Text = "TextLabel";
		}
	}
}

