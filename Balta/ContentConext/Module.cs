namespace Balta.ContentConext;
public class Module : BaseContent
{
	public int Order { get; set; }	
	public string Title { get; set; } = "";
	public IList<Lecture> Lectures { get; set; } = new List<Lecture>();
}