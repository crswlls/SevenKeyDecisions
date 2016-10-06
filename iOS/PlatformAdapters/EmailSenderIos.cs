using System;
using MessageUI;
using SevenKeyDecisions.Infrastructure;
using UIKit;

namespace SevenKeyDecisions.iOS
{
	public class EmailSenderIos : IEmailSender
	{
		public void SendMessage(string toAddress, string subject, string body)
		{
			MFMailComposeViewController mailController;
			if (MFMailComposeViewController.CanSendMail)
			{
				mailController = new MFMailComposeViewController();
				mailController.SetToRecipients(new string[] { toAddress });
				mailController.SetSubject(subject);
				mailController.SetMessageBody(body, false);
				mailController.Finished += ( object s, MFComposeResultEventArgs args) => {
				  args.Controller.DismissViewController (true, null);
				};

				UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(mailController, true, null);
			}
		}
	}
}
