using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using System.Collections.Generic;

namespace GoalDemo
{
	partial class TimelineController : UITableViewController
	{
		private UITableView _TimelineView;
		private List<TimelineModel> _timelineData;

		public TimelineController (IntPtr handle) : base (handle)
		{
			Title = "Timeline";
			_timelineData = new List<TimelineModel> ();
			_timelineData.Add (new TimelineModel{ UserName= "Pooja Gaonkar", NumComments=2, NumLikes=21, Date="21 September,2015", Detail="Trying out Xamarin IOS designer", ImageName = "user1", PostDate= DateTime.Today, PostImage = ""});
			_timelineData.Add (new TimelineModel{UserName= "John Doe", NumComments=3, NumLikes=13 ,Date="22 September,2015", Detail="TDemo 1Trying out Xamarin IOS designerTrying out Xamarin IOS designerTrying out Xamarin IOS designerTrying out Xamarin IOS designerTrying out Xamarin IOS designerTrying out Xamarin IOS designerTrying out Xamarin IOS designerTrying out Xamarin IOS designer" +
					"Trying out Xamarin IOS designerTrying out Xamarin IOS designerTrying out Xamarin IOS designerTrying out Xamarin IOS designerTrying out Xamarin IOS designer", ImageName = "user2",PostDate= DateTime.Today, PostImage = ""  });
			_timelineData.Add (new TimelineModel{UserName= "Dummy user1", NumComments=4, NumLikes=15, Date="23 September,2015", Detail="Demo 2", ImageName = "user3",PostDate= new DateTime(2015,10,16), PostImage = "" });
			_timelineData.Add (new TimelineModel{UserName= "Dummy user2", NumComments=5, NumLikes=21, Date="24 September,2015", Detail="Demo 3", ImageName = "user4",PostDate= new DateTime(2015,10,15) ,PostImage = ""});
			_timelineData.Add (new TimelineModel{UserName= "Dummy user3", NumComments=6, NumLikes=34, Date="25 September,2015", Detail="La lalalalal la", ImageName = "user1" ,PostDate= new DateTime(2015,10,14), PostImage = ""});
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			TableView.RowHeight = UITableView.AutomaticDimension;
			TableView.EstimatedRowHeight = 182;
			TableView.Source = new RootTableSource(_timelineData.ToArray());

		}
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

		}
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);


		}
	}
}
