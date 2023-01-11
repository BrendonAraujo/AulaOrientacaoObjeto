using Balta.ContentConext;

namespace Balta;

class Program
{
	static void Main(string[] args)
	{
		var articles = new List<Article>();
		articles.Add(new Article("Artigo","um teste de artigo"));
		
		
		foreach(var article in articles)
		{
			Console.WriteLine(article.Id);
			Console.WriteLine(article.Title);
			Console.WriteLine(article.Url);
		}
		
		var courses = new List<Course>();
		var course = new Course("Orientação a objetivo", "fundamentos de orientação a objeto");
		var courseC = new Course("Orientação a objetivo", "fundamentos de orientação a objeto");
		var coursePHP = new Course("Orientação a objetivo", "fundamentos de orientação a objeto");
		courses.Add(course);
		courses.Add(courseC);
		courses.Add(coursePHP);
		
		var careers = new List<Career>();
		var career = new Career("DotNET","Know more about .net");
		var careerItem = new CareerItem(1,"Start Here","",course);
		
		career?.CareerItems.Add(careerItem);
		careers.Add(career);
	}	
}