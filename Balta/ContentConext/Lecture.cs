using Balta.ContentConext.Enums;

namespace Balta.ContentConext;

public class Lecture : BaseContent
{
	public int Order { get; set; }
	public string Title { get; set; } = "";
	public int DurationMinutes { get; set; }
	public EContentLevel Level { get; set; }
	
}