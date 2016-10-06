using System;
namespace SevenKeyDecisions.Infrastructure
{
	public interface IEmailSender
	{
		void SendMessage(string toAddress, string subject, string body);
	}
}