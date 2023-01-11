using Balta.ContentConext.NotificationContent;

namespace Balta.ContentConext;

public class CareerItem : BaseContent
{
	public CareerItem(int order, string title, string description, Course course)
	{
		Order = order;
		Title = title;
		Description = description;
		if(course == null)
		{
			AddNotification(new Notification("Course", "Invalid course"));
		}else
		{
			Course = course;	
		}
	}

	public int Order { get; set; }
	public string Title { get; set; } = "";
	public string Description { get; set; } = "";
	public Course Course { get; set;} = new Course("","");
}