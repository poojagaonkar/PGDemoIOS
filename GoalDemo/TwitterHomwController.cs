using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using Xamarin.Auth;
using System.Linq;
using System.Collections.Generic;
using LinqToTwitter;
using System.Threading.Tasks;
using CoreGraphics;


namespace GoalDemo
{
	partial class TwitterHomwController : UIViewController
	{
		private Xamarin.Auth.Account loggedInAccount;
		private List<Status> myList;
		public TwitterHomwController (IntPtr handle) : base (handle)
		{
		}

		public override  void ViewDidLoad ()
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

					twitterHomeTableView.RowHeight = UITableView.AutomaticDimension;
					twitterHomeTableView.EstimatedRowHeight = 150;

					twitterHomeTableView.Source = new TwitterHomeSource(mList.ToArray());
					twitterHomeTableView.ReloadData();
				
					/*mList.ContinueWith((Task<List<Status>> arg) => {

						myList = arg.Result;

					});
					if(mList.IsCompleted){
						twitterHomeTableView.Source = new TwitterHomeSource(myList.ToArray());
					}*/

				


				}

			};

			var ui = auth.GetUI();
			PresentViewController(ui, true, null);



		}
		 public  List<LinqToTwitter.Status> GetTwitterData()
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
			List<LinqToTwitter.Status> tl = 
				(from tweet in TwitterCtx.Status
					where tweet.Type == LinqToTwitter.StatusType.Home
					select tweet).ToList();

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
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}
	}
}
