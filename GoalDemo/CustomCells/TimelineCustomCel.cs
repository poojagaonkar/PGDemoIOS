using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace GoalDemo
{
	partial class TimelineCustomCel : UITableViewCell
	{
		public TimelineCustomCel (IntPtr handle) : base (handle)
		{
			SelectionStyle = UITableViewCellSelectionStyle.Gray;
		}
		public void UpdateCell (string name, UIImage image, string detail, int likes, int comment, DateTime postDate)
		{
			imgProfilePic.Image = image;
			labelUsername.Text = name;
			detailLabel.Text = detail;
			lblLikes.Text = likes.ToString ()+" "+"Likes";
			lblComments.Text = comment.ToString ()+" "+"Comments";
			lblDate.Text = postDate.ToString ("D");
		}
	}
}
