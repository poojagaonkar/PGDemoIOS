using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using FlyoutNavigation;
using MonoTouch.Dialog;

namespace GoalDemo
{
	partial class FBMenuController : UIViewController
	{
		public FBMenuController (IntPtr handle) : base (handle)
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();


			AppDelegate.FlyoutNavigation = new FlyoutNavigationController {//this will create a new instance of the FlyoutComponent
				NavigationRoot = new RootElement("Menu"){ //Here we create the root of the alements
					new Section("Pages"){
						new StringElement ("News Feed"),
						new StringElement ("Messages"),
						new StringElement ("Nearby"),
						new StringElement ("Events"),
						new StringElement ("Friends"),

					},
					new Section("Groups"){
						new StringElement ("Family"),
						new StringElement ("College"),
						new StringElement ("School"),
						new StringElement ("Work"),
						new StringElement ("Pune"),

					},
					new Section("Others"){
						new StringElement ("Create group"),
						new StringElement ("Help center"),
						new StringElement ("Privacy and policies"),
						new StringElement ("Report/Feedback"),
						new StringElement ("Logout"),

					}

				},
				ViewControllers =  new UIViewController[]  {//here we link Controllers
					new UINavigationController ((TimelineController)this.Storyboard.InstantiateViewController("TimelineController")),
					new UIViewController { View = new UIImageView { Image = UIImage.FromFile("User1") } },
					new UIViewController { View = new UIImageView { Image = UIImage.FromFile("User2") } },

					new UIViewController { View = new UILabel { Text = "Events"} },
					new UIViewController { View = new UILabel { Text = "Friends"} },

					new UIViewController { View = new UILabel { Text = "Family"} },
					new UIViewController { View = new UILabel { Text = "College"} },
					new UIViewController { View = new UILabel { Text = "School"} },
					new UIViewController { View = new UILabel { Text = "Work"} },
					new UIViewController { View = new UILabel { Text = "Pune"} },

					new UIViewController { View = new UILabel { Text = "Group Created"} },
					new UIViewController { View = new UILabel { Text = "Help center"} },
					new UIViewController { View = new UILabel { Text = "Privacy"} },
					new UIViewController { View = new UILabel { Text = "Report"} },
					new UIViewController { View = new UILabel { Text = "Logout"} },
				}
			};

			UIBarButtonItem menuIndicator = new UIBarButtonItem (UIImage.FromBundle ("images/slideout.png"), UIBarButtonItemStyle.Plain, (sender, e) => {
				AppDelegate.FlyoutNavigation.ToggleMenu ();
			});
			NavigationItem.SetLeftBarButtonItem (menuIndicator, true);

			this.Add(AppDelegate.FlyoutNavigation.View);
		}
	}
}
