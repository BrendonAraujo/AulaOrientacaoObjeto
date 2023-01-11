using Balta.ContentConext.NotificationContent;

namespace Balta.ContentConext;

public class BaseContent : Notifiable
{
	public BaseContent()
	{
		Id = Guid.NewGuid();
	}
	public Guid Id { get; set; }
}
