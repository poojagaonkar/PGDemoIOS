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
						new StringElement ("Friends"),
						new StringElement ("Photos"),
					},

				},
				ViewControllers =  new UIViewController[]  {//here we link Controllers
					new UINavigationController ((TimelineController)this.Storyboard.InstantiateViewController("TimelineController")),

				}
			};

			UIBarButtonItem menuIndicator = new UIBarButtonItem (UIImage.FromFile ("slideout.png"), UIBarButtonItemStyle.Plain, (sender, e) => {
				AppDelegate.FlyoutNavigation.ToggleMenu ();
			});
			NavigationItem.SetLeftBarButtonItem (menuIndicator, true);
			this.Add(AppDelegate.FlyoutNavigation.View);
		}
	}
}
