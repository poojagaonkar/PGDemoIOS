using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace GoalDemo
{
	partial class TwitterCustomCell : UITableViewCell
	{
		public TwitterCustomCell (IntPtr handle) : base (handle)
		{
		}
		public void UpdateCell (string name, string image, string tweet, string handle, string postDate)
		{

			labelHandle.Text = handle;
			labelDetail.Text = tweet;
			labelUserName.Text = name;
			labelTimeStamp.Text = postDate;
			imageProfile.Image = FromUrl (image);


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
