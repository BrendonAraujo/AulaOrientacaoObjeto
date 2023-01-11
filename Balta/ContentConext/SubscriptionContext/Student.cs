using System.Collections.Generic;
using Balta.ContentConext.NotificationContent;

namespace Balta.ContentConext.SubscriptionContext;

public class Student : BaseContent
{
	public string Name { get; set; } = "";
	public string Email { get; set; } = "";
	public User User { get; set; } = new User();
	public IList<Subscription> Subscriptions { get; set; } = new List<Subscription>();
	public bool isPremium => Subscriptions.Any(subscription => !subscription.isInative);
	
	public void CreateSubscriptio(Subscription subscription)
	{
		if(isPremium)
		{
			AddNotification(new Notification("Premium","Student has a subscription active"));
			return;
		}
		if(!subscription.isInvalid)
		{
			Subscriptions.Add(subscription);
		}
	}
}
