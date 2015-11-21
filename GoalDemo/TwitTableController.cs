using System;
using UIKit;
using LinqToTwitter;
using System.Collections.Generic;
using Xamarin.Auth;
using System.Linq;

namespace GoalDemo
{
	public class TwitTableController : UITableViewController
	{
		private Xamarin.Auth.Account loggedInAccount;
		private List<Status> myList;
		public TwitTableController ()
		{
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

					TableView.RowHeight = UITableView.AutomaticDimension;
					TableView.EstimatedRowHeight = 160;

					TableView.Source = new TwitterHomeSource(mList.ToArray());
					//twitterHomeTableView.ReloadData();




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

