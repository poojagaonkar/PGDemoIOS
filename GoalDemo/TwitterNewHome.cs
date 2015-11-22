using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;
using LinqToTwitter;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Auth;
using BigTed;

namespace GoalDemo
{
	partial class TwitterNewHome : UITableViewController
	{
		private Xamarin.Auth.Account loggedInAccount;

		public TwitterNewHome (IntPtr handle) : base (handle)
		{
		}
		public override  void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			this.NavigationItem.Title = "Home";
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
			BTProgressHUD.Show();
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
			BTProgressHUD.Dismiss();
			return tl;
			//Console.WriteLine("Tweets Returned: " + tl.Count.ToString());
		}


		async public void GetUserData()
		{
			//use the account object and make the desired API call
			InvokeOnMainThread(()=>{
				BTProgressHUD.Show();}
			);

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
				var myName = (string)jo ["name"];
				var myHandle= (string)jo ["screen_name"];
				var myBackgroundImg = (string)jo ["profile_background_image_url"];
				var myFollowers =(string)jo ["followers_count"]; 
				var myFriends=(string)jo ["friends_count"];
				var noOfTweets = (string)jo["statuses_count"];
				NSUserDefaults.StandardUserDefaults.SetString(imageUrl, "MyProfileImage"); 
				NSUserDefaults.StandardUserDefaults.SetString(myName, "MyName");
				NSUserDefaults.StandardUserDefaults.SetString(myHandle, "MyHandle");
				NSUserDefaults.StandardUserDefaults.SetString(myBackgroundImg, "MyBackImage");
				NSUserDefaults.StandardUserDefaults.SetString(myFollowers, "MyFollowers");
				NSUserDefaults.StandardUserDefaults.SetString(myFriends, "MFriends");
				NSUserDefaults.StandardUserDefaults.SetString(noOfTweets, "noOfTweets");
				//jo	{{   "id": 2847008436,   "id_str": "2847008436",   "name": "Pooja Gaonkar",   "screen_name": "PoojaGaonkar19",   "location": "",   "description": "",   "url": null,   "entities": {     "description": {       "urls": []     }   },   "protected": false,   "followers_count": 15,   "friends_count": 10,   "listed_count": 0,   "created_at": "Wed Oct 08 10:34:31 +0000 2014",   "favourites_count": 0,   "utc_offset": null,   "time_zone": null,   "geo_enabled": false,   "verified": false,   "statuses_count": 9,   "lang": "en-gb",   "status": {     "created_at": "Tue Nov 17 06:30:53 +0000 2015",     "id": 666503755630669824,     "id_str": "666503755630669824",     "text": "#craftsvilla #unprofessionalmuch to tie up with designers who dont respond to orders.Was highly expecting my 1st order from you to be great",     "source": "<a href=\"http://twitter.com\" rel=\"nofollow\">Twitter Web Client</a>",     "truncated": false,     "in_reply_to_status_id": null,     "in_reply_to_status_id_str": null,     "in_reply_to_user_id": null,     "in_reply_to_user_id_str": null,     "in_reply_to_screen_name": null,     "geo": null,     "coordinates": null,     "place": null,     "contributors": null,     "retweet_count": 0,     "favorite_count": 0,     "entities": {       "hashtags": [         {           "text": "craftsvilla",           "indices": [             0,             12           ]         },         {           "text": "unprofessionalmuch",           "indices": [             13,             32           ]         }       ],       "symbols": [],       "user_mentions": [],       "urls": []     },     "favorited": false,     "retweeted": false,     "lang": "en"   },   "contributors_enabled": false,   "is_translator": false,   "is_translation_enabled": false,   "profile_background_color": "C0DEED",   "profile_background_image_url": "http://abs.twimg.com/images/themes/theme1/bg.png",   "profile_background_image_url_https": "https://abs.twimg.com/images/themes/theme1/bg.png",   "profile_background_tile": false,   "profile_image_url": "http://pbs.twimg.com/profile_images/523659656174911488/rLCxTYc7_normal.jpeg",   "profile_image_url_https": "https://pbs.twimg.com/profile_images/523659656174911488/rLCxTYc7_normal.jpeg",   "profile_link_color": "0084B4",   "profile_sidebar_border_color": "C0DEED",   "profile_sidebar_fill_color": "DDEEF6",   "profile_text_color": "333333",   "profile_use_background_image": true,   "has_extended_profile": false,   "default_profile": true,   "default_profile_image": false,   "following": false,   "follow_request_sent": false,   "notifications": false }}	Newtonsoft.Json.Linq.JObject
			});
			InvokeOnMainThread(()=>{
				BTProgressHUD.Dismiss();}
			);

		}
		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
		}
	}
}
