using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace GoalDemo
{
	partial class TwitterHomeCell : UITableViewCell
	{
		public TwitterHomeCell (IntPtr handle) : base (handle)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Gray;
		}
		public void UpdateCell (string name, string image, string tweet, string handle, string postDate)
		{
			labelHandle.Text = "@"+handle;
			labelTweetText.Text = tweet;
			labelUserName.Text = name;
			labelTweetTime.Text = postDate;
			imgProfilePic.Image = FromUrl (image);


				/*cell.ImageView.SetImage (
				url: new NSUrl ("http://db.tt/ayAqtbFy"), 
				placeholder: UIImage.FromBundle ("placeholder.png")
			);*/

		}
		static UIImage FromUrl (string uri)
		{
			using (var url = new NSUrl (uri))
			using (var data = NSData.FromUrl (url))
				return UIImage.LoadFromData (data);
		}
	}
}
