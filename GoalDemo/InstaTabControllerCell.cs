using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace GoalDemo
{
	partial class InstaTabControllerCell : UITableViewCell
	{
		public InstaTabControllerCell (IntPtr handle) : base (handle)
		{
		}
		public void UpdateCell (string name, UIImage image, string detail, int likes, int comment, DateTime postDate)
		{
			instaProfileImage.Image = image;
			labelInstaUser.Text = name;
			instaLabelStatis.Text = detail;
			labelInstaUser1.Text = name;
			/*lblLikes.Text = likes.ToString ()+" "+"Likes";
			lblComments.Text = comment.ToString ()+" "+"Comments";
			lblDate.Text = postDate.ToString ("D");*/
		}
	}
}
