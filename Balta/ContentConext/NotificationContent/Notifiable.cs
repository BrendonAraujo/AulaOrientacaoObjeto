namespace Balta.ContentConext.NotificationContent;

public abstract class Notifiable
{
	public List<Notification> Notifications { get; set; } = new List<Notification>();
	public bool isInvalid => Notifications.Any();
	
	public void AddNotification(Notification notification)
	{
		Notifications.Add(notification);
	}
	public void AddNotifications(IEnumerable<Notification> notifications)
	{
		//!Interesting, the IList interface does not have the AddRange method
		//!Why? Well, because of this, my prop cannot be a IList, has to be a List
		this.Notifications.AddRange(notifications);
	}
}