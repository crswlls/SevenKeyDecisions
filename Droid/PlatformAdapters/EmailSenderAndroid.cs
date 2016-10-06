using System;
using Android.Content;
using SevenKeyDecisions.Infrastructure;

namespace SevenKeyDecisions.Droid.PlatformAdapters
{
	public class EmailSenderAndroid : IEmailSender
	{
		public void SendMessage(string toAddress, string subject, string body)
		{
			Intent intent = new Intent(Intent.ActionSend);
			intent.SetType("text/html");
			intent.PutExtra(Intent.ExtraEmail, toAddress);
			intent.PutExtra(Intent.ExtraSubject, subject);
			intent.PutExtra(Intent.ExtraText, body);

			Xamarin.Forms.Forms.Context.StartActivity(Intent.CreateChooser(intent, "Send Email"));
		}
	}
}
