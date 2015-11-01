using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using LinqToTwitter;
using System.Collections.Generic;
using Xamarin.Auth;
using System.Linq;
using System.Threading.Tasks;

namespace GoalDemo
{
	partial class TwiiterTimelinecontroller : UITableViewController
	{
		private Xamarin.Auth.Account loggedInAccount;
		private List<Status> myList;
		public TwiiterTimelinecontroller (IntPtr handle) : base (handle)
		{
			myList = new List<Status>();
			myList.Add(new Status());
			myList[0] = new List<LinqToTwitter.Status>().ToArray();
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var auth = new OAuth1Authenticator ("Ywun66NxYNMXgjzNRdIG12q4k",
				"XQAQ5djSlMOiXfMhn5rl4fdPahqw0wNPW6nBS5I9aRCajbxMvJ",
				new Uri("https://api.twitter.com/oauth/request_token"),
				new Uri("https://api.twitter.com/oauth/authorize"),
				new Uri("https://api.twitter.com/oauth/access_token"),
				new Uri("http://mobile.twitter.com"));

			auth.Completed += (sender, e) => {
				DismissViewController (true, null);
				if (e.IsAuthenticated) {

					loggedInAccount = e.Account;
					GetUserData ();
					var mList =   GetTwitterData();
					mList.ContinueWith(async (Task<List<Status>> arg) =>{
						myList = arg.Result;
						//twitterHomeTableView.Source = new TwitterHomeSource(arg.Result.ToArray());
					});


				}

			};

			var ui = auth.GetUI();
			PresentViewController(ui, true, null);
		}
		async public  Task<List<LinqToTwitter.Status>> GetTwitterData()
		{
			//has the user already authenticated from a previous session? see AccountStore.Create().Save() later
			IEnumerable<Xamarin.Auth.Account> accounts = AccountStore.Create().FindAccountsForService("Twitter");

			//check the account store for a valid account marked as "Twitter" and then hold on to it for future requests
			/*foreach (Xamarin.Auth.Account account in accounts)
			{
				loggedInAccount = account;
				break;
			}*/
			var cred = new LinqToTwitter.InMemoryCredentialStore();
			cred.ConsumerKey = loggedInAccount.Properties["oauth_consumer_key"];
			cred.ConsumerSecret = loggedInAccount.Properties["oauth_consumer_secret"];
			cred.OAuthToken = loggedInAccount.Properties["oauth_token"];
			cred.OAuthTokenSecret = loggedInAccount.Properties["oauth_token_secret"];
			var auth = new LinqToTwitter.PinAuthorizer()
			{
				CredentialStore = cred,
			};
			var TwitterCtx = new LinqToTwitter.TwitterContext(auth);
			Console.WriteLine(TwitterCtx.User);
			List<LinqToTwitter.Status> tl = await
				(from tweet in TwitterCtx.Status
					where tweet.Type == LinqToTwitter.StatusType.Home
					select tweet).ToListAsync();

			return tl;
			//Console.WriteLine("Tweets Returned: " + tl.Count.ToString());
		}


		async public void GetUserData()
		{
			//use the account object and make the desired API call
			var request = new OAuth1Request (
				"GET",
				new Uri ("https://api.twitter.com/1.1/account/verify_credentials.json "),
				null,
				loggedInAccount);

			await request.GetResponseAsync ().ContinueWith (t => {
				var res = t.Result;
				var resString = res.GetResponseText ();
				Console.WriteLine ("Result Text: " + resString);
				var jo = Newtonsoft.Json.Linq.JObject.Parse (resString);
				var imageUrl = (string)jo ["profile_image_url"];


			});
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell = MainTwitterTimelne.DequeueReusableCell("twitcell");
			if (cell == null)
			{
				cell = new UITableViewCell(UITableViewCellStyle.Subtitle, "twitcell");
			}
			if ((myList.Count != 0) && (myList.Count > 0))
			{
				var task = System.Threading.Tasks.Task.Factory.StartNew(() =>
					{
						InvokeOnMainThread(delegate
							{
								tableView.BeginUpdates();
								cell.ImageView.Image =
									LoadImage(myList.ToArray()[indexPath.Row].User.ProfileImageUrl);
								tableView.EndUpdates();
							});
					});
				cell.TextLabel.Text = myList.ToArray()[indexPath.Row].Text;
				cell.DetailTextLabel.Text =myList.ToArray()[indexPath.Row].User.ScreenNameResponse;
			}
			return cell;
		}

		public UIImage LoadImage(string imageUrl)
		{
			UIImage img = new UIImage();
			try
			{
				var nsu = new NSUrl(imageUrl);
				var nsd = NSData.FromUrl(nsu);
				img = UIImage.LoadFromData(nsd);
			}
			catch (System.Exception exc)
			{
				Console.WriteLine(exc.Message);
			}
			return img;
		}
		public override nint NumberOfSections (UITableView tableView)
		{
			return 1;
		}
		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return myList.Count;
		}
		/*public override int NumberOfSections(UITableView tableView)
		{
			return 1;
		}
		public override int RowsInSection(UITableView tableview, int section)
		{
			var i = 0;
			return myList.ToArray().Length;
		}*/
	}
}
