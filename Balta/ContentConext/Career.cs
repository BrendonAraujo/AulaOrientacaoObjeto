namespace Balta.ContentConext;

public class Career : Content
{
	public Career(string title, string url) : base(title, url)
	{
	}

	public int Courses { get; set; } 
	public IList<CareerItem> CareerItems { get; set; } = new List<CareerItem>();
	public int TotalCourses => CareerItems.Count;
}