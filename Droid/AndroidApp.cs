using System;
using GalaSoft.MvvmLight.Ioc;
using SevenKeyDecisions.Droid.PlatformAdapters;
using SevenKeyDecisions.Infrastructure;

namespace SevenKeyDecisions.Droid
{
	public class AndroidApp : App
	{
		protected override void RegisterPlatformDependencies()
		{
			SimpleIoc.Default.Register<IEmailSender, EmailSenderAndroid>();
		}
	}
}
