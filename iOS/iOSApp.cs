using System;
using GalaSoft.MvvmLight.Ioc;
using SevenKeyDecisions.Infrastructure;

namespace SevenKeyDecisions.iOS
{
	public class iOSApp : App
	{
		protected override void RegisterPlatformDependencies()
		{
			SimpleIoc.Default.Register<IEmailSender, EmailSenderIos>();
		}
	}
}
