namespace Balta.ContentConext.NotificationContent;

public abstract class Notifiable
{
	public List<Notification> Notifications { get; set; } = new List<Notification>();
	
	public void Add(Notification notification)
	{
		Notifications.Add(notification);
	}
	public void AddRange(IEnumerable<Notification> notifications)
	{
		//!Interesting, the IList interface does not have the AddRange method
		//!Why? Well, because of this, my prop cannot be a IList, has to be a List
		this.Notifications.AddRange(notifications);
	}
}