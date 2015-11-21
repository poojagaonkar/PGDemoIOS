﻿using System;

namespace GoalDemo
{
	public static class CalculateRelativeTime
	{

		const int SECOND = 1;
		const int MINUTE = 60 * SECOND;
		const int HOUR = 60 * MINUTE;
		const int DAY = 24 * HOUR;
		const int MONTH = 30 * DAY;

		public static string RelativeTime (DateTime userTweettime)
		{
			
			var ts = new TimeSpan(DateTime.UtcNow.Ticks - userTweettime.Ticks);
			double delta = Math.Abs(ts.TotalSeconds);

			if (delta < 1 * MINUTE)
			{
				return ts.Seconds == 1 ? "1s" : ts.Seconds + "s";
			}
			if (delta < 2 * MINUTE)
			{
				return "1m";
			}
			if (delta < 45 * MINUTE)
			{
				return ts.Minutes + "m";
			}
			if (delta < 90 * MINUTE)
			{
				return "1h";
			}
			if (delta < 24 * HOUR)
			{
				return ts.Hours + "h";
			}
			if (delta < 48 * HOUR)
			{
				return "1d";
			}
			if (delta < 30 * DAY)
			{
				return ts.Days + "d";
			}
			if (delta < 12 * MONTH)
			{
				int months = Convert.ToInt32(Math.Floor((double)ts.Days / 30));
				return months <= 1 ? "1M" : months + "M";
			}
			else
			{
				int years = Convert.ToInt32(Math.Floor((double)ts.Days / 365));
				return years <= 1 ? "1y" : years + "y";
			}
		}


	}
}

