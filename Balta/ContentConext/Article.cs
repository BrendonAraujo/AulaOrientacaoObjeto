using Balta.ContentConext.NotificationContent;

namespace Balta.ContentConext;

public class Article : Content
{
	public Article(string title, string url) : base(title, url)
	{
		
	}
	
	public IList<Notification> Notifications { get; set; } = new List<Notification>();
}